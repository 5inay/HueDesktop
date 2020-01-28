namespace HueDesktop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnConnect = new System.Windows.Forms.Button();
            this.gbConnect = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLights = new System.Windows.Forms.DataGridView();
            this.lightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.gbLights = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefreshLights = new System.Windows.Forms.Button();
            this.btnAllOn = new System.Windows.Forms.Button();
            this.btnAllOff = new System.Windows.Forms.Button();
            this.gbAllOnOff = new System.Windows.Forms.GroupBox();
            this.pbFindingHueBridge = new System.Windows.Forms.ProgressBar();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.gbSelectedLightDetails = new System.Windows.Forms.GroupBox();
            this.pnlLightCtrl = new System.Windows.Forms.Panel();
            this.btnColorChange = new System.Windows.Forms.Button();
            this.lblBrightnessValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBrightness = new System.Windows.Forms.TrackBar();
            this.lblLD_Name = new System.Windows.Forms.Label();
            this.lblLD_Model = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblLD_Type = new System.Windows.Forms.Label();
            this.lblLD_Manufacturer = new System.Windows.Forms.Label();
            this.gbBridgeDetails = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBridgeDetails = new System.Windows.Forms.Button();
            this.lblBridgeID = new System.Windows.Forms.Label();
            this.lblBridgeName = new System.Windows.Forms.Label();
            this.lblBridgeCnx = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBridge = new System.Windows.Forms.Label();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.lblCurrentColor = new System.Windows.Forms.Label();
            this.pnlCurrentColor = new System.Windows.Forms.Panel();
            this.gbConnect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightBindingSource)).BeginInit();
            this.gbLights.SuspendLayout();
            this.gbAllOnOff.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.gbSelectedLightDetails.SuspendLayout();
            this.pnlLightCtrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).BeginInit();
            this.gbBridgeDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Black;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Location = new System.Drawing.Point(164, 77);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(88, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // gbConnect
            // 
            this.gbConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbConnect.BackgroundImage = global::HueDesktop.Properties.Resources.helper_icon;
            this.gbConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbConnect.Controls.Add(this.label1);
            this.gbConnect.Controls.Add(this.btnConnect);
            this.gbConnect.Location = new System.Drawing.Point(204, 6);
            this.gbConnect.Name = "gbConnect";
            this.gbConnect.Size = new System.Drawing.Size(258, 110);
            this.gbConnect.TabIndex = 1;
            this.gbConnect.TabStop = false;
            this.gbConnect.Text = "CONNECT (Required only once)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Press the button on your Philips Hue Bridge\r\nand Click on \"Connect\" button below." +
    "";
            // 
            // dgvLights
            // 
            this.dgvLights.AllowUserToAddRows = false;
            this.dgvLights.AllowUserToDeleteRows = false;
            this.dgvLights.AllowUserToResizeColumns = false;
            this.dgvLights.AllowUserToResizeRows = false;
            this.dgvLights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLights.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.dgvLights.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvLights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLights.ColumnHeadersVisible = false;
            this.dgvLights.Location = new System.Drawing.Point(11, 25);
            this.dgvLights.MultiSelect = false;
            this.dgvLights.Name = "dgvLights";
            this.dgvLights.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "1";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLights.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLights.RowHeadersVisible = false;
            this.dgvLights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLights.ShowEditingIcon = false;
            this.dgvLights.Size = new System.Drawing.Size(171, 149);
            this.dgvLights.TabIndex = 2;
            this.dgvLights.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.onLightSelectionChanged);
            this.dgvLights.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.onCellText_Changed);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 66);
            this.label3.TabIndex = 1;
            this.label3.Text = "Click Refresh button to see all lights paired with this bridge.\r\nSelect a light t" +
    "o modify its settings.";
            // 
            // gbLights
            // 
            this.gbLights.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbLights.Controls.Add(this.button1);
            this.gbLights.Controls.Add(this.label4);
            this.gbLights.Controls.Add(this.btnRefreshLights);
            this.gbLights.Controls.Add(this.label3);
            this.gbLights.Controls.Add(this.dgvLights);
            this.gbLights.Location = new System.Drawing.Point(10, 118);
            this.gbLights.Name = "gbLights";
            this.gbLights.Size = new System.Drawing.Size(188, 343);
            this.gbLights.TabIndex = 1;
            this.gbLights.TabStop = false;
            this.gbLights.Text = "Connected Hue Lights";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "RESET APP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Click in case of bridge reset";
            // 
            // btnRefreshLights
            // 
            this.btnRefreshLights.BackColor = System.Drawing.Color.Black;
            this.btnRefreshLights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshLights.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshLights.Location = new System.Drawing.Point(83, 180);
            this.btnRefreshLights.Name = "btnRefreshLights";
            this.btnRefreshLights.Size = new System.Drawing.Size(95, 37);
            this.btnRefreshLights.TabIndex = 3;
            this.btnRefreshLights.Text = "Refresh";
            this.btnRefreshLights.UseVisualStyleBackColor = false;
            this.btnRefreshLights.Click += new System.EventHandler(this.btnRefreshLights_Click);
            // 
            // btnAllOn
            // 
            this.btnAllOn.BackColor = System.Drawing.Color.Black;
            this.btnAllOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllOn.Location = new System.Drawing.Point(13, 21);
            this.btnAllOn.Name = "btnAllOn";
            this.btnAllOn.Size = new System.Drawing.Size(140, 30);
            this.btnAllOn.TabIndex = 0;
            this.btnAllOn.Text = "ALL ON";
            this.btnAllOn.UseVisualStyleBackColor = false;
            this.btnAllOn.Click += new System.EventHandler(this.btnAllOn_Click);
            // 
            // btnAllOff
            // 
            this.btnAllOff.BackColor = System.Drawing.Color.Black;
            this.btnAllOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllOff.Location = new System.Drawing.Point(13, 70);
            this.btnAllOff.Name = "btnAllOff";
            this.btnAllOff.Size = new System.Drawing.Size(140, 30);
            this.btnAllOff.TabIndex = 0;
            this.btnAllOff.Text = "ALL OFF";
            this.btnAllOff.UseVisualStyleBackColor = false;
            this.btnAllOff.Click += new System.EventHandler(this.btnAllOff_Click);
            // 
            // gbAllOnOff
            // 
            this.gbAllOnOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAllOnOff.Controls.Add(this.btnAllOn);
            this.gbAllOnOff.Controls.Add(this.btnAllOff);
            this.gbAllOnOff.Location = new System.Drawing.Point(468, 6);
            this.gbAllOnOff.Name = "gbAllOnOff";
            this.gbAllOnOff.Size = new System.Drawing.Size(161, 110);
            this.gbAllOnOff.TabIndex = 1;
            this.gbAllOnOff.TabStop = false;
            this.gbAllOnOff.Text = "Group On Off Control";
            // 
            // pbFindingHueBridge
            // 
            this.pbFindingHueBridge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFindingHueBridge.Location = new System.Drawing.Point(17, 501);
            this.pbFindingHueBridge.MarqueeAnimationSpeed = 50;
            this.pbFindingHueBridge.Name = "pbFindingHueBridge";
            this.pbFindingHueBridge.Size = new System.Drawing.Size(639, 12);
            this.pbFindingHueBridge.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbFindingHueBridge.TabIndex = 2;
            this.pbFindingHueBridge.Visible = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.gbConnect);
            this.pnlMain.Controls.Add(this.gbSelectedLightDetails);
            this.pnlMain.Controls.Add(this.gbLights);
            this.pnlMain.Controls.Add(this.gbBridgeDetails);
            this.pnlMain.Controls.Add(this.lblBridgeCnx);
            this.pnlMain.Controls.Add(this.gbAllOnOff);
            this.pnlMain.Controls.Add(this.pictureBox1);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(639, 470);
            this.pnlMain.TabIndex = 3;
            // 
            // gbSelectedLightDetails
            // 
            this.gbSelectedLightDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSelectedLightDetails.Controls.Add(this.pnlLightCtrl);
            this.gbSelectedLightDetails.Location = new System.Drawing.Point(204, 118);
            this.gbSelectedLightDetails.Name = "gbSelectedLightDetails";
            this.gbSelectedLightDetails.Size = new System.Drawing.Size(425, 343);
            this.gbSelectedLightDetails.TabIndex = 1;
            this.gbSelectedLightDetails.TabStop = false;
            this.gbSelectedLightDetails.Text = "Selected Hue Light Details and Control";
            // 
            // pnlLightCtrl
            // 
            this.pnlLightCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLightCtrl.Controls.Add(this.pnlCurrentColor);
            this.pnlLightCtrl.Controls.Add(this.btnColorChange);
            this.pnlLightCtrl.Controls.Add(this.lblBrightnessValue);
            this.pnlLightCtrl.Controls.Add(this.label2);
            this.pnlLightCtrl.Controls.Add(this.tbBrightness);
            this.pnlLightCtrl.Controls.Add(this.lblLD_Name);
            this.pnlLightCtrl.Controls.Add(this.lblLD_Model);
            this.pnlLightCtrl.Controls.Add(this.lblMin);
            this.pnlLightCtrl.Controls.Add(this.lblCurrentColor);
            this.pnlLightCtrl.Controls.Add(this.lblLD_Type);
            this.pnlLightCtrl.Controls.Add(this.lblLD_Manufacturer);
            this.pnlLightCtrl.Location = new System.Drawing.Point(10, 14);
            this.pnlLightCtrl.Name = "pnlLightCtrl";
            this.pnlLightCtrl.Size = new System.Drawing.Size(407, 312);
            this.pnlLightCtrl.TabIndex = 4;
            this.pnlLightCtrl.Visible = false;
            // 
            // btnColorChange
            // 
            this.btnColorChange.BackColor = System.Drawing.Color.Black;
            this.btnColorChange.BackgroundImage = global::HueDesktop.Properties.Resources.bulb;
            this.btnColorChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnColorChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorChange.Location = new System.Drawing.Point(254, 21);
            this.btnColorChange.Name = "btnColorChange";
            this.btnColorChange.Size = new System.Drawing.Size(70, 70);
            this.btnColorChange.TabIndex = 4;
            this.btnColorChange.UseVisualStyleBackColor = false;
            this.btnColorChange.Click += new System.EventHandler(this.btnColorChange_Click);
            // 
            // lblBrightnessValue
            // 
            this.lblBrightnessValue.AutoSize = true;
            this.lblBrightnessValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrightnessValue.Location = new System.Drawing.Point(358, 6);
            this.lblBrightnessValue.MaximumSize = new System.Drawing.Size(380, 100);
            this.lblBrightnessValue.Name = "lblBrightnessValue";
            this.lblBrightnessValue.Size = new System.Drawing.Size(32, 15);
            this.lblBrightnessValue.TabIndex = 1;
            this.lblBrightnessValue.Text = "MAX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.MaximumSize = new System.Drawing.Size(380, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Click  on  icon  to  change  color\r\nUse slider to change brightness";
            // 
            // tbBrightness
            // 
            this.tbBrightness.LargeChange = 50;
            this.tbBrightness.Location = new System.Drawing.Point(356, 33);
            this.tbBrightness.Maximum = 254;
            this.tbBrightness.Minimum = 1;
            this.tbBrightness.Name = "tbBrightness";
            this.tbBrightness.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbBrightness.Size = new System.Drawing.Size(34, 213);
            this.tbBrightness.SmallChange = 10;
            this.tbBrightness.TabIndex = 3;
            this.tbBrightness.TickFrequency = 12;
            this.tbBrightness.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbBrightness.Value = 1;
            this.tbBrightness.Scroll += new System.EventHandler(this.ontbBrightness_Scroll);
            this.tbBrightness.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onBrightness_ValueChanged);
            // 
            // lblLD_Name
            // 
            this.lblLD_Name.AutoSize = true;
            this.lblLD_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLD_Name.Location = new System.Drawing.Point(71, 101);
            this.lblLD_Name.MaximumSize = new System.Drawing.Size(380, 100);
            this.lblLD_Name.Name = "lblLD_Name";
            this.lblLD_Name.Size = new System.Drawing.Size(57, 21);
            this.lblLD_Name.TabIndex = 1;
            this.lblLD_Name.Text = "Name:";
            // 
            // lblLD_Model
            // 
            this.lblLD_Model.AutoSize = true;
            this.lblLD_Model.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLD_Model.Location = new System.Drawing.Point(66, 147);
            this.lblLD_Model.MaximumSize = new System.Drawing.Size(380, 100);
            this.lblLD_Model.Name = "lblLD_Model";
            this.lblLD_Model.Size = new System.Drawing.Size(59, 21);
            this.lblLD_Model.TabIndex = 1;
            this.lblLD_Model.Text = "Model:";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(358, 255);
            this.lblMin.MaximumSize = new System.Drawing.Size(380, 100);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(28, 15);
            this.lblMin.TabIndex = 1;
            this.lblMin.Text = "OFF";
            // 
            // lblLD_Type
            // 
            this.lblLD_Type.AutoSize = true;
            this.lblLD_Type.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLD_Type.Location = new System.Drawing.Point(75, 239);
            this.lblLD_Type.MaximumSize = new System.Drawing.Size(380, 100);
            this.lblLD_Type.Name = "lblLD_Type";
            this.lblLD_Type.Size = new System.Drawing.Size(52, 21);
            this.lblLD_Type.TabIndex = 1;
            this.lblLD_Type.Text = "Type: ";
            // 
            // lblLD_Manufacturer
            // 
            this.lblLD_Manufacturer.AutoSize = true;
            this.lblLD_Manufacturer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLD_Manufacturer.Location = new System.Drawing.Point(14, 193);
            this.lblLD_Manufacturer.MaximumSize = new System.Drawing.Size(380, 100);
            this.lblLD_Manufacturer.Name = "lblLD_Manufacturer";
            this.lblLD_Manufacturer.Size = new System.Drawing.Size(111, 21);
            this.lblLD_Manufacturer.TabIndex = 1;
            this.lblLD_Manufacturer.Text = "Manufacturer:";
            // 
            // gbBridgeDetails
            // 
            this.gbBridgeDetails.Controls.Add(this.btnSearch);
            this.gbBridgeDetails.Controls.Add(this.btnBridgeDetails);
            this.gbBridgeDetails.Controls.Add(this.lblBridgeID);
            this.gbBridgeDetails.Controls.Add(this.lblBridgeName);
            this.gbBridgeDetails.Location = new System.Drawing.Point(11, 6);
            this.gbBridgeDetails.Name = "gbBridgeDetails";
            this.gbBridgeDetails.Size = new System.Drawing.Size(187, 110);
            this.gbBridgeDetails.TabIndex = 1;
            this.gbBridgeDetails.TabStop = false;
            this.gbBridgeDetails.Text = "Bridge Details";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(9, 77);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBridgeDetails
            // 
            this.btnBridgeDetails.BackColor = System.Drawing.Color.Black;
            this.btnBridgeDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBridgeDetails.Location = new System.Drawing.Point(105, 77);
            this.btnBridgeDetails.Name = "btnBridgeDetails";
            this.btnBridgeDetails.Size = new System.Drawing.Size(75, 23);
            this.btnBridgeDetails.TabIndex = 2;
            this.btnBridgeDetails.Text = "Details";
            this.btnBridgeDetails.UseVisualStyleBackColor = false;
            this.btnBridgeDetails.Click += new System.EventHandler(this.btnBridgeDetails_Click);
            // 
            // lblBridgeID
            // 
            this.lblBridgeID.AutoSize = true;
            this.lblBridgeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.92F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBridgeID.Location = new System.Drawing.Point(6, 54);
            this.lblBridgeID.Name = "lblBridgeID";
            this.lblBridgeID.Size = new System.Drawing.Size(24, 13);
            this.lblBridgeID.TabIndex = 1;
            this.lblBridgeID.Text = "ID: ";
            // 
            // lblBridgeName
            // 
            this.lblBridgeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.92F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBridgeName.Location = new System.Drawing.Point(6, 20);
            this.lblBridgeName.Name = "lblBridgeName";
            this.lblBridgeName.Size = new System.Drawing.Size(171, 34);
            this.lblBridgeName.TabIndex = 1;
            this.lblBridgeName.Text = "Name:";
            // 
            // lblBridgeCnx
            // 
            this.lblBridgeCnx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBridgeCnx.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBridgeCnx.Location = new System.Drawing.Point(248, 85);
            this.lblBridgeCnx.Name = "lblBridgeCnx";
            this.lblBridgeCnx.Size = new System.Drawing.Size(173, 26);
            this.lblBridgeCnx.TabIndex = 1;
            this.lblBridgeCnx.Text = "Bridge Connected. \r\nClick Refresh to see paired lights";
            this.lblBridgeCnx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(301, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblBridge
            // 
            this.lblBridge.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblBridge.AutoSize = true;
            this.lblBridge.Location = new System.Drawing.Point(275, 485);
            this.lblBridge.Name = "lblBridge";
            this.lblBridge.Size = new System.Drawing.Size(106, 13);
            this.lblBridge.TabIndex = 1;
            this.lblBridge.Text = "Finding Hue Bridge...\r\n";
            // 
            // colorPicker
            // 
            this.colorPicker.AnyColor = true;
            this.colorPicker.FullOpen = true;
            // 
            // lblCurrentColor
            // 
            this.lblCurrentColor.AutoSize = true;
            this.lblCurrentColor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentColor.Location = new System.Drawing.Point(71, 285);
            this.lblCurrentColor.MaximumSize = new System.Drawing.Size(380, 100);
            this.lblCurrentColor.Name = "lblCurrentColor";
            this.lblCurrentColor.Size = new System.Drawing.Size(53, 21);
            this.lblCurrentColor.TabIndex = 1;
            this.lblCurrentColor.Text = "Color:";
            // 
            // pnlCurrentColor
            // 
            this.pnlCurrentColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCurrentColor.Location = new System.Drawing.Point(141, 285);
            this.pnlCurrentColor.Name = "pnlCurrentColor";
            this.pnlCurrentColor.Size = new System.Drawing.Size(26, 20);
            this.pnlCurrentColor.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(670, 521);
            this.Controls.Add(this.lblBridge);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pbFindingHueBridge);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(680, 550);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Philips Hue Desktop Application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbConnect.ResumeLayout(false);
            this.gbConnect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightBindingSource)).EndInit();
            this.gbLights.ResumeLayout(false);
            this.gbLights.PerformLayout();
            this.gbAllOnOff.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.gbSelectedLightDetails.ResumeLayout(false);
            this.pnlLightCtrl.ResumeLayout(false);
            this.pnlLightCtrl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).EndInit();
            this.gbBridgeDetails.ResumeLayout(false);
            this.gbBridgeDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox gbConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLights;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbLights;
        private System.Windows.Forms.Button btnAllOn;
        private System.Windows.Forms.Button btnAllOff;
        private System.Windows.Forms.GroupBox gbAllOnOff;
        private System.Windows.Forms.ProgressBar pbFindingHueBridge;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblBridge;
        private System.Windows.Forms.GroupBox gbBridgeDetails;
        private System.Windows.Forms.Label lblBridgeID;
        private System.Windows.Forms.Label lblBridgeName;
        private System.Windows.Forms.BindingSource lightBindingSource;
        private System.Windows.Forms.Button btnRefreshLights;
        private System.Windows.Forms.GroupBox gbSelectedLightDetails;
        private System.Windows.Forms.Button btnBridgeDetails;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLD_Manufacturer;
        private System.Windows.Forms.Label lblLD_Model;
        private System.Windows.Forms.Label lblLD_Name;
        private System.Windows.Forms.Label lblLD_Type;
        private System.Windows.Forms.TrackBar tbBrightness;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Panel pnlLightCtrl;
        private System.Windows.Forms.Button btnColorChange;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBridgeCnx;
        private System.Windows.Forms.Label lblBrightnessValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlCurrentColor;
        private System.Windows.Forms.Label lblCurrentColor;
    }
}

