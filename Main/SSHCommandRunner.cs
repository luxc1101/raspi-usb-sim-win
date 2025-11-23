using Renci.SshNet;
using Renci.SshNet.Common;
using RpiUsbSim.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RpiUsbSim.Main
{
    internal class SSHCommandRunner
    {
        private readonly USBToolSshClient _sshClient;
        private string _command = string.Empty;
        private readonly Action<string> _commandExecutionCallback;
        private bool _isExecuting = false;
        public bool IsRunning => _isExecuting;

        public SSHCommandRunner(USBToolSshClient sshClient, Action<string> commandExecutionCallback)
        {
            _sshClient = sshClient;
            _commandExecutionCallback = commandExecutionCallback;
        }

        public void SetCommand(string command)
        {
            _command = command; 
        }

        public void Start()
        {
            if (!_isExecuting)
            {
                _isExecuting = true;
                Task.Run(() => ExecuteCommand());
            }
        }

        private void Stop()
        {
            _isExecuting = false;
        }

        private async Task ExecuteCommand()
        {
            while (_isExecuting)
            {
                try
                {
                    if (_sshClient.GetSshConnectionStatus() && !string.IsNullOrEmpty(_command))
                    {
                        string assignedSize = _command.Split("fssize:", StringSplitOptions.RemoveEmptyEntries).Last();
                        _command = _command.Split("fssize:", StringSplitOptions.RemoveEmptyEntries).First();
                        Debug.WriteLine($"[DEBUG]: Parsed command is: {_command}, size input is: {assignedSize}");
                        
                        using (var cmd = _sshClient.sshClient?.CreateCommand(_command))
                        {
                            var asyncResult = cmd.BeginExecute();
                            WriteUserInputFilesystemSize(assignedSize, cmd); // it has to write to cmd.CreateInputStream before finishing execution
                            ReportStdout(cmd.OutputStream, Encoding.UTF8, asyncResult);
                            ReportStderr(cmd.ExtendedOutputStream, Encoding.UTF8, asyncResult);
                            cmd.EndExecute(asyncResult);
                        }
                    }
                    else
                    {
                        _commandExecutionCallback("[ERROR]: SSH Connection failed or Command is empty");
                    }
                }
                catch (Exception ex)
                {
                    _commandExecutionCallback("[ERROR]: " + ex.Message);
                    throw new InvalidOperationException("[ERROR]: " + ex.Message);
                }
                finally 
                {
                    _command = string.Empty; // Clear command after execution
                    _isExecuting = false; // Stop after one execution
                    Debug.WriteLine($"[DEBUG]: Command execution finished, stopping runner.");
                }
                // await Task.Delay(50);
            }  
        }

        private void ReportStdout(Stream stream, Encoding encoding, IAsyncResult result)
        {
            using (var reader = new StreamReader(stream, encoding, true, 1024, true))
            {
                while (!result.IsCompleted || !reader.EndOfStream)
                {
                    string? line = reader.ReadLine();
                    if (line != null)
                    {   
                        line = line.Trim();
                        _commandExecutionCallback(line);
                    }

                }
            }
        }

        private void ReportStderr(Stream stream, Encoding encoding, IAsyncResult result)
        {
            using (var reader = new StreamReader(stream, encoding, true, 1024, true))
            {
                while (!result.IsCompleted || !reader.EndOfStream)
                {
                    string? line = reader.ReadLine();
                    if (line != null)
                    {
                        line = line.Trim();
                        _commandExecutionCallback($"[ERROR]: {line}");
                    }
                }
            }
        }

        private void WriteUserInputFilesystemSize(string sizeStr, SshCommand cmd)
        {
            if (int.TryParse(sizeStr, out int sizeInt))
            {
                using (var writer = new StreamWriter(cmd.CreateInputStream()))
                {
                    writer.WriteLine($"{sizeInt}");
                }
            }
        }
    }
}
