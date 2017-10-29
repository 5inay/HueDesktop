namespace HueDesktop
{
    class JSONBridge
    {
        public string id { get; set; }
        public string internalipaddress { get; set; }
    }

    public class BridgeConnectionSuccess 
    {
        public Success success { get; set; }
    }

    public class Success
    {
        public string username { get; set; }
    }
}
