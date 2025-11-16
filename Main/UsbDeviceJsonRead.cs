using RpiUsbSim.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace RpiUsbSim.Main
{
    internal class UsbDeviceJsonRead: IUsbDeviceJsonReader
    {
        public string DeviceFile { get; set; } = Path.GetFullPath(
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\", "Configuration", "UsbDevice.json")
            );
        private static JsonObject? usbdevice_root;

        public bool IsFileExisting(string devicefile) { return File.Exists(devicefile); }
        public bool IsJsonNodeNull(JsonNode node) { return node == null; }
        public JsonNode GetRootJsonNode()
        {
            var json = File.ReadAllText(DeviceFile, Encoding.UTF8);
            usbdevice_root = (JsonObject?)JsonNode.Parse(json);
            return usbdevice_root ?? new JsonObject();
        }
        public JsonNode GetMSCDeviceJsonNodeFromRoot()
        {
            return usbdevice_root?["MSC"] ?? new JsonObject(null);
        }
        public JsonNode GetECMDeviceJsonNodeFromRoot()
        {
            return usbdevice_root?["ECM"] ?? new JsonObject(null);
        }
        public JsonNode GetHIDDeviceJsonNodeFromRoot()
        {
            return usbdevice_root?["HID"] ?? new JsonObject(null);
        }
        public JsonNode GetCDCDeviceJsonNodeFromRoot()
        {
            return usbdevice_root?["CDC"] ?? new JsonObject(null);
        }
    }
}
