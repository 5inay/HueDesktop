using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace HueDesktop
{
    public class MyRoot
    {
        private HueBridge hb { get; set; }
    }

    [Serializable]
    [XmlRoot("root", Namespace = "urn:schemas-upnp-org:device-1-0")]
    public class HueBridge
    {
        [XmlElement("specVersion")]
        private SpecVersion bridgeSpecVersion { get; set; }
        [XmlElement("URLBase")]
        public string bridgeURLBase { get; set; }
        [XmlElement("device")]
        public Device bridgeDeviceSpec { get; set; }
    }

    public class SpecVersion
    {
        [XmlElement("major")]
        private int majorVersion { get; set; }
        [XmlElement("minor")]
        private int minorVersion { get; set; }
    }

   
    public class Device
    {
        [XmlElement("deviceType")]
        public string bridgeType { get; set; }
        [XmlElement("friendlyName")]
        public string bridgeFriendlyName { get; set; }
        [XmlElement("manufacturer")]
        public string bridgeManufacturer { get; set; }
        [XmlElement("manufacturerURL")]
        public string bridgeManURL { get; set; }
        [XmlElement("modelDescription")]
        public string bridgeDescription { get; set; }
        [XmlElement("modelName")]
        public string bridgeModelName { get; set; }
        [XmlElement("modelNumber")]
        public string bridgeModelNumber { get; set; }
        [XmlElement("modelURL")]
        public string bridgeModelURL { get; set; }
        [XmlElement("serialNumber")]
        public string bridgeSerialNumber { get; set; }
        [XmlElement("UDN")]
        public string bridgeUDN { get; set; }
        [XmlElement("presentationURL")]
        public string bridgePresentationURL { get; set; }
        [XmlElement("iconList")]
        public IconList hueIconList { get; set; }
    }

    public class IconList
    {
        private List<Icon> hueIcons { get; set; }
    }

    public class Icon
    {
        [XmlElement("mimetype")]
        private string iconMimeType { get; set; }
        [XmlElement("height")]
        private int iconHeight { get; set; }
        [XmlElement("width")]
        private int iconWidth { get; set; }
        [XmlElement("depth")]
        private int iconColorDepth { get; set; }
        [XmlElement("url")]
        private string iconUrl { get; set; }
    }
}
