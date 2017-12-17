using HueDesktop.Properties;
using NLog;
using System;
using System.Windows.Forms;


namespace HueDesktop
{
    public partial class BridgeDetails : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        private HueBridge ourHueBridge;
        public BridgeDetails(HueBridge hb)
        {
            InitializeComponent();

            ourHueBridge = hb;

            populateDetails();
        }

        private void populateDetails()
        {
           
            rtbBridgeDetails.AppendText(Resources.BRIDGE_NAME + ourHueBridge.bridgeDeviceSpec.bridgeModelName + Environment.NewLine);
            rtbBridgeDetails.AppendText(Resources.BRIDGE_DESC + ourHueBridge.bridgeDeviceSpec.bridgeDescription + Environment.NewLine);
            rtbBridgeDetails.AppendText(Resources.BRIDGE_MANUF + ourHueBridge.bridgeDeviceSpec.bridgeManufacturer + Environment.NewLine);
            rtbBridgeDetails.AppendText(Resources.BRIDGE_MANUF__URL + ourHueBridge.bridgeDeviceSpec.bridgeManURL + Environment.NewLine);
            rtbBridgeDetails.AppendText(Resources.BRIDGE_MNUM + ourHueBridge.bridgeDeviceSpec.bridgeModelNumber + Environment.NewLine);
            rtbBridgeDetails.AppendText(Resources.BRIDGE_SNUM + ourHueBridge.bridgeDeviceSpec.bridgeSerialNumber + Environment.NewLine);
            rtbBridgeDetails.AppendText(Resources.BRIDGE_URL + ourHueBridge.bridgeURLBase.Replace(@"http://", "").Replace(@":80/", "") + Environment.NewLine);
            rtbBridgeDetails.AppendText(Resources.BRIDGE_VERSION + ourHueBridge.bridgeSpecVersion.majorVersion + "." + ourHueBridge.bridgeSpecVersion.minorVersion + Environment.NewLine);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
