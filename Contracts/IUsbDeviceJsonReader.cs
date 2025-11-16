using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace RpiUsbSim.Contracts
{
    internal interface IUsbDeviceJsonReader
    {
        bool IsFileExisting(string devicefile);
        bool IsJsonNodeNull(JsonNode node);
        JsonNode GetRootJsonNode();
        JsonNode GetMSCDeviceJsonNodeFromRoot();
        JsonNode GetECMDeviceJsonNodeFromRoot();
        JsonNode GetHIDDeviceJsonNodeFromRoot();
        JsonNode GetCDCDeviceJsonNodeFromRoot();

    }
}
