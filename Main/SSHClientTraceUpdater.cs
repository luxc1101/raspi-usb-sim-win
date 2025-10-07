using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpiUsbSim.Main
{
    internal class SSHClientTraceUpdater
    {
        private readonly Action<string> _singleTraceCallback;
        private Queue<string> _traces = new Queue<string>();
        private bool _isUpdating = false;
        public bool IsRunning => _isUpdating;
        public SSHClientTraceUpdater(Action<string> singleTraceCallback)
        {
            _singleTraceCallback = singleTraceCallback;
        }
        public void Start()
        {
            if (!_isUpdating)
            {
                _isUpdating = true;
                Task.Run(() => DequeueTraces());
            }
        }

        public void Stop()
        {
            _isUpdating = false;
            while (_traces.Count > 0) // Flush Remaining Traces
            {
                _singleTraceCallback(_traces.Dequeue());
            }
        }
        public void SetTraces(string message)
        {
            _traces.Enqueue(message);
        }

        private async Task DequeueTraces()
        {
            while (_isUpdating)
            {
                Debug.WriteLine($"[DEBUG]: Trace Queue Length: {_traces.Count}");
                if (_traces.Count > 0)
                {
                    _singleTraceCallback(_traces.Dequeue());
                }
                else
                {
                    await Task.Delay(50);
                }
            }
        }
    }
}
