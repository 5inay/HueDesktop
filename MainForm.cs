﻿using NLog;
using System.Collections.Generic;
using System.Net;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using HueDesktop.Properties;
using System;
using System.Text;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Drawing;

namespace HueDesktop
{
    public partial class MainForm : Form
    {
        #region MEMBER VARS
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private const string url = "https://www.meethue.com/api/nupnp";
        private JavaScriptSerializer jss = new JavaScriptSerializer();

        private HueBridge theHueBridge;
        public HueBridge getHueBridge() { return theHueBridge; }
        private List<JSONBridge> bridges;

        private volatile string APIKey;
        private volatile bool APIKeyExists;

        private HueLight[] allLights;
        private int lightIDX = 0;
        #endregion //MEMBER_VARS


        #region CONSTRUCTOR
        /// <summary>
        /// Main Form constructor. Checks if the connect operation (one-time)
        /// has been performed by the user by checking if the API key exists
        /// If yes, the Connect operation UI is disabled.
        /// If not, the Connect UI is enabled
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            setupUI();
            
            checkForExistingKey();
            theHueBridge = new HueBridge();
            if (APIKeyExists)
            {
                btnConnect.Enabled = false;
                initBridge();
            }
            else
            {
                gbConnect.Visible = true;
                btnConnect.Enabled = true;
                findBridges();
            }
        }
        #endregion //CONSTRUCTOR


        #region UI_INITIALIZATION
        /// <summary>
        /// Initial Setup of the UI based on very first use or
        /// subsequent uses based on succes or failure of the 
        /// Connect operation.
        /// </summary>
        private void setupUI()
        {
            pbFindingHueBridge.Visible = false;
            lblBridge.Visible = false;

            btnSearch.Enabled = false;
            btnBridgeDetails.Enabled = false;

            btnConnect.Enabled = false;
            btnRefreshLights.Enabled = false;

            btnAllOn.Enabled = false;
            btnAllOff.Enabled = false;

            gbConnect.Visible = false;
        }
        #endregion  //UI_INITIALIZATION


        #region FIND_BRIDGES
        /// <summary>
        /// Finds bridges based on uPnP method mentioned in 
        /// Philips Hue Developer Guide. This method is asynchronous 
        /// and uses Client_DownloadStringCompleted method as it's 
        /// handler when complete.
        /// </summary>
        private void findBridges()
        {
            lblBridge.Visible = true;
            pbFindingHueBridge.Visible = true;
            pbFindingHueBridge.MarqueeAnimationSpeed = 50;


            //Query for available bridges
            WebClient client = new WebClient();
            client.DownloadStringCompleted += Client_DownloadStringCompleted;
            client.DownloadStringAsync(new System.Uri(url), null);
            
        }

        /// <summary>
        /// Handler for findBridges() method. 
        /// Downloads bridge identity from the Hue Bridge in JSON format
        /// and maps it onto JSONBridge data structure. Also initiates
        /// a download of the xml file containing bridge details.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if(e.Error!= null)
            {
                MessageBox.Show(Resources.ERROR01, "Scan Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbFindingHueBridge.Visible = false;
                lblBridge.Visible = false;
                btnSearch.Enabled = true;
                return;
            }

            bridges = jss.Deserialize<List<JSONBridge>>(e.Result);

            if (bridges != null)
            {
                logger.Info("Yeah Baby!!!");
                WebClient client = new WebClient();
                client.DownloadProgressChanged += Client_DownloadProgressChanged;
                client.DownloadFileCompleted += Client_DownloadFileCompleted;

                string descriptionURL = "http://" + bridges[0].internalipaddress + "/description.xml";
                client.DownloadFileAsync(new System.Uri(descriptionURL), Resources.BRIDGE_XML);
            }
            else
            {
                logger.Error("Scan failed to find any Philips Hue Bridges.");
                MessageBox.Show(Resources.ERROR00, "Scan Failed", MessageBoxButtons.OK);
            }

        }

        
        /// <summary>
        /// Handler to indicate progress of the bridge xml file download
        /// (Only helpful in cases of slow connections) and logs it to the 
        /// default log file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            logger.Info("Downloading file --> Description.xml------ " + e.ProgressPercentage.ToString() + "% DONE");
            updateVerifyPercentageUI(e.ProgressPercentage.ToString());
        }

        /// <summary>
        /// Handler for bridge details xml file download completion
        /// Calls initBridge() method that has been refactored for
        /// multiple use
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            initBridge();
        }

        
        /// <summary>
        /// Populates the main bridge object with bridge details
        /// Also calls the Bridge details UI updater
        /// </summary>
        private void initBridge()
        {
            XmlSerializer bridgeGetter = new XmlSerializer(typeof(HueBridge));
            TextReader bridgeXmlReader = new StreamReader(Resources.BRIDGE_XML);
            theHueBridge = (HueBridge)bridgeGetter.Deserialize(bridgeXmlReader);

            bridgeXmlReader.Close();

            if(theHueBridge == null)
            {
                MessageBox.Show(Resources.ERROR00, "Scan Failed", MessageBoxButtons.OK);
                btnSearch.Enabled = true;
                btnBridgeDetails.Enabled = false;
                return;
            }

            updateBridgeDetailsUI();

            populateBridgeLights();
        }
        #endregion //FIND_BRIDGES


        #region VERIFY_BRIDGE_DETAILS
        private delegate void bridgeDetailsUpdaterDelegate();
        /// <summary>
        /// Updates bridge details UI 
        /// </summary>
        private void updateBridgeDetailsUI()
        {
            if(lblBridgeID.InvokeRequired)
            {
                this.Invoke(new bridgeDetailsUpdaterDelegate(updateBridgeDetailsUI), new object[] { });
                return;
            }

            lblBridgeID.Text = "ID: " + theHueBridge.bridgeDeviceSpec.bridgeSerialNumber;
            lblBridgeName.Text = "Name: " + theHueBridge.bridgeDeviceSpec.bridgeModelName;
            btnSearch.Enabled = false;
            btnBridgeDetails.Enabled = true;
            lblBridge.Visible = false;
            pbFindingHueBridge.Visible = false;
            btnRefreshLights.Enabled = true;
        }



        private delegate void percentageIndicatiorDelegate(string percentage);
        private void updateVerifyPercentageUI(string percentage)
        {
            if (lblBridge.InvokeRequired)
            {
                this.Invoke(new percentageIndicatiorDelegate(updateVerifyPercentageUI), new object[] { percentage });
                return;
            }

            lblBridge.Text = "Verifying Bridge... " + percentage + "% Completed";
        }
        #endregion //UPDATE_BRIDGE_DETAILS


        #region UI-HANDLERS
        /// <summary>
        /// One time operation. Pings a bridge to acquire the API Key
        /// Once found, the API Key is stored locally for future use.
        /// </summary>
        /// <param name="sender">UI element that this event originates from</param>
        /// <param name="e">Event paramaeters</param>
        private async void btnConnect_Click(object sender, EventArgs e)
        {
            RESTRequests r = new RESTRequests(theHueBridge.bridgeURLBase.Replace("http://", "").Replace(@":80/", ""));
            string result = await r.POST("/api", HueConstants.BODY_POST_CONNECT, Encoding.UTF8, Resources.BODY_TYPE_JSON);
            if (result == null || result.Contains("error") || result == "")
            {
                MessageBox.Show(Resources.ERROR02, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<BridgeConnectionSuccess> s = jss.Deserialize<List<BridgeConnectionSuccess>>(result);
            if(s == null || s[0].success == null || String.IsNullOrEmpty(s[0].success.username))
            {
                MessageBox.Show(Resources.ERROR02, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            APIKey = s[0].success.username;
            storeKey();

            logger.Info("API KEY DONE");

            btnConnect.Enabled = false;

            gbConnect.Visible = false;
        }

        private void btnRefreshLights_Click(object sender, EventArgs e)
        {
            populateBridgeLights();
        }

        private async void btnAllOn_Click(object sender, EventArgs e)
        {
            RESTRequests r = new RESTRequests(theHueBridge.bridgeURLBase.Replace("http://", "").Replace(@":80/", ""));
            int i = 1;
            foreach (HueLight hl in allLights)
            {
                string result = await r.PUT("/api/" + APIKey + "/lights/"+ i + "/state", "{\"on\":true}", Encoding.UTF8, Resources.BODY_TYPE_JSON);
                i++;
            }
        }

        private async void btnAllOff_Click(object sender, EventArgs e)
        {
            RESTRequests r = new RESTRequests(theHueBridge.bridgeURLBase.Replace("http://", "").Replace(@":80/", ""));
            int i = 1;
            foreach (HueLight hl in allLights)
            {
                string result = await r.PUT("/api/" + APIKey + "/lights/" + i + "/state", "{\"on\":false}", Encoding.UTF8, Resources.BODY_TYPE_JSON);
                i++;
            }
        }

        private void btnBridgeDetails_Click(object sender, EventArgs e)
        {
            BridgeDetails bd = new BridgeDetails(getHueBridge());
            bd.ShowDialog(this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            findBridges();
        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog(this) == DialogResult.OK)
            {
                Color c = colorPicker.Color;
            }
        }
        
        private async void onLightSelectionChanged(object sender, EventArgs e)
        {
            if (allLights == null || allLights[0].modelid == null || dgvLights.CurrentCell == null) return;

            lightIDX = dgvLights.CurrentCell.RowIndex;
            if (lightIDX >= 0)
            {
                logger.Info("Hue Light index = " + lightIDX);
            }
            else
            {
                return;
            }

            //Get current status of light
            RESTRequests r = new RESTRequests(theHueBridge.bridgeURLBase.Replace("http://", "").Replace(@":80/", ""));
            string singleLight = await r.GET("/api/" + APIKey + "/lights/" + (lightIDX + 1));

            JObject singleLightObj = JObject.Parse(singleLight);
            //IList<JToken> pairedLight = singleLightObj.Children().ToList(); //MAGIC!! :)
            HueLight selectedLight = JsonConvert.DeserializeObject<HueLight>(singleLightObj.ToString());

            String ld = String.Format(Resources.LIGHT_DETAILS, selectedLight.name, (selectedLight.modelid != null &&
                selectedLight.modelid.Contains("LCT")) ? "Hue Lamp" : "Hue Lightstrip", (selectedLight.state.on) ? "ON" : "OFF");
            
            if (allLights[lightIDX].modelid.Contains("LCT"))
            {
                btnColorChange.BackgroundImage = Resources.bulb;
            }
            else
            {
                btnColorChange.BackgroundImage = Resources.lightstrip;
            }

            btnColorChange.Visible = true;

            //Populate details
            lblLD_Name.Text = "Name:  " + selectedLight.name;
            lblLD_Type.Text = "Type:  " + selectedLight.type;
            lblLD_Manufacturer.Text = "Manufacturer:  " + selectedLight.manufacturername;
            lblLD_Model.Text = "Model:  " + selectedLight.modelid;
            tbBrightness.Value = (selectedLight.state.on)?selectedLight.state.bri:tbBrightness.Minimum;
            
            pnlLightCtrl.Visible = true;
        }

        private async void btnColorChange_Click(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                Color c = colorPicker.Color;
                double r = c.R;
                double g = c.G;
                double b = c.B;

                double X, Y;
                ColorConverter.colorToXY(r, g, b, out X, out Y);
                logger.Info("Setting color ==> " + X + "," + Y);

                RESTRequests rest = new RESTRequests(theHueBridge.bridgeURLBase.Replace("http://", "").Replace(@":80/", ""));
                string singleLight = await rest.GET("/api/" + APIKey + "/lights/" + (lightIDX + 1));

                JObject singleLightObj = JObject.Parse(singleLight);
                HueLight selectedLight = JsonConvert.DeserializeObject<HueLight>(singleLightObj.ToString());

                rest = new RESTRequests(theHueBridge.bridgeURLBase.Replace("http://", "").Replace(@":80/", ""));

                if (!selectedLight.state.on)
                {
                    await rest.PUT("/api/" + APIKey + "/lights/" + (lightIDX + 1) + "/state", "{\"on\":true, \"xy\":[" + X + "," + Y + "]}", Encoding.UTF8, Resources.BODY_TYPE_JSON);
                }
                else
                {
                    await rest.PUT("/api/" + APIKey + "/lights/" + (lightIDX + 1) + "/state", "{\"xy\":[" + X + "," + Y + "]}", Encoding.UTF8, Resources.BODY_TYPE_JSON);
                }

                tbBrightness.Value = selectedLight.state.bri;
            }
        }

        private async void onBrightness_ValueChanged(object sender, MouseEventArgs e)
        {
            RESTRequests r = new RESTRequests(theHueBridge.bridgeURLBase.Replace("http://", "").Replace(@":80/", ""));
            string singleLight = await r.GET("/api/" + APIKey + "/lights/" + (lightIDX + 1));

            JObject singleLightObj = JObject.Parse(singleLight);
            HueLight selectedLight = JsonConvert.DeserializeObject<HueLight>(singleLightObj.ToString());

            if (tbBrightness.Value == tbBrightness.Minimum)
            {
                await r.PUT("/api/" + APIKey + "/lights/" + (lightIDX + 1) + "/state", "{\"on\":false}", Encoding.UTF8, Resources.BODY_TYPE_JSON);
                return;
            }

            if (!selectedLight.state.on)
            {
                await r.PUT("/api/" + APIKey + "/lights/" + (lightIDX + 1) + "/state", "{\"on\":true, \"bri\":" + tbBrightness.Value + "}", Encoding.UTF8, Resources.BODY_TYPE_JSON);
            }
            else
            {
                await r.PUT("/api/" + APIKey + "/lights/" + (lightIDX + 1) + "/state", "{\"bri\":" + tbBrightness.Value + "}", Encoding.UTF8, Resources.BODY_TYPE_JSON);
            }
        }
        #endregion //UI-Handlers


        #region API_KEY_HANDLERS
        /// <summary>
        /// Stores the API key locally
        /// </summary>
        private async void storeKey()
        {
            FileStream fs = File.Open(Resources.KEY_FILE, FileMode.OpenOrCreate);
            await fs.WriteAsync(Encoding.ASCII.GetBytes(APIKey), 0, APIKey.Length);
            fs.Close();
        }

        /// <summary>
        /// Checks if the connect operation has been performed at least once
        /// </summary>
        private void checkForExistingKey()
        {
            APIKeyExists = false;
            byte[] buffer = new byte[256];
            FileStream fs = File.Open(Resources.KEY_FILE, FileMode.OpenOrCreate);
            int x = fs.Read(buffer, 0, 256);
            fs.Close();

            if (x > 1)
            {
                APIKeyExists = true;
                APIKey = Encoding.UTF8.GetString(buffer).Trim(new char[] { '\0' });
                
                return;
            }

            logger.Warn("No API KEY present!");
            
            return;
        }
        #endregion //API_KEY_HANDLERS


        #region CAMERA...LIGHTS...
        /// <summary>
        /// Finds all lights paired with the bridge and 
        /// populates the UI list
        /// </summary>
        private async void populateBridgeLights()
        {
            string endpoint = theHueBridge.bridgeURLBase.Replace("http://", "").Replace(@":80/", "");
            RESTRequests r = new RESTRequests(endpoint);
            string result = await r.GET("/api/" + APIKey + "/lights");

            if (result == null || result.Contains("error") || result == "")
            {
                MessageBox.Show(Resources.ERROR03, "Lights not paired", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Parsing this result proved to be trickier than expected 
            // Looked it up here (https://stackoverflow.com/questions/41092239/json-deserialization-not-deserializing) 
            // and followed the directions by Mohammed Abulssa and Mark Schultheiss to get the right mapping between 
            // JSON and C# data structure
            JObject lightObj = JObject.Parse(result);
            IList<JToken> allPaired = lightObj.Children().Children().ToList(); //MAGIC!! :)
            allLights = new HueLight[allPaired.Count];

            int i = 0;
            foreach (JToken jt in allPaired)
            {
                allLights[i] = JsonConvert.DeserializeObject<HueLight>(jt.ToString());
                i++;
            }

            while (allLights == null) ;
            if (allLights.Length > 1)
            {
                dgvLights.DataSource = allLights;
                btnAllOn.Enabled = true;
                btnAllOff.Enabled = true;
                dgvLights.Columns["state"].Visible = 
                dgvLights.Columns["type"].Visible = 
                dgvLights.Columns["modelid"].Visible = 
                dgvLights.Columns["manufacturername"].Visible = 
                dgvLights.Columns["uniqueid"].Visible = 
                dgvLights.Columns["swversion"].Visible = false;

                dgvLights.ClearSelection();
            }
            else
            {
                MessageBox.Show(Resources.ERROR03, "Lights not paired", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion //CAMERA...LIGHTS...
    }
}