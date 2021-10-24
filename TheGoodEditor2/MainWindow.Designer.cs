namespace TheGoodEditor2
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadHoParcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveHoParcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveHoParcelAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTheGoodEditor2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportLayerListToTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAssetsListToTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTheSaveFileEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTheRandomizerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheGoodEditor2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolTipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAssetID = new System.Windows.Forms.Label();
            this.lblNames = new System.Windows.Forms.Label();
            this.lblLayer = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblFineScrollLayers = new System.Windows.Forms.Label();
            this.lblFineScroll = new System.Windows.Forms.Label();
            this.btnAssetDown = new System.Windows.Forms.Button();
            this.btnAssetUp = new System.Windows.Forms.Button();
            this.btnLayerDown = new System.Windows.Forms.Button();
            this.btnLayerUp = new System.Windows.Forms.Button();
            this.listBoxLayers = new System.Windows.Forms.ListBox();
            this.listBoxAssets = new System.Windows.Forms.ListBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.gHelpToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.grupAssetOtherTools = new System.Windows.Forms.GroupBox();
            this.buttonExtractAll = new System.Windows.Forms.Button();
            this.buttonExtract = new System.Windows.Forms.Button();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.btnOpenByteViewer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpByteViewerButtonContainer = new System.Windows.Forms.GroupBox();
            this.grpTextureControls = new System.Windows.Forms.GroupBox();
            this.grpPreviewContainer = new System.Windows.Forms.GroupBox();
            this.texturePreviewBox = new System.Windows.Forms.PictureBox();
            this.btnOpenTextureViewer = new System.Windows.Forms.Button();
            this.grpOptionsViewer = new System.Windows.Forms.GroupBox();
            this.btnExtraOptionsTexture = new System.Windows.Forms.Button();
            this.btnDumpTextures = new System.Windows.Forms.Button();
            this.chkTurnOffPreviewButton = new System.Windows.Forms.CheckBox();
            this.chkTurnPreviewOff = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grupAssetOtherTools.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpByteViewerButtonContainer.SuspendLayout();
            this.grpTextureControls.SuspendLayout();
            this.grpPreviewContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.texturePreviewBox)).BeginInit();
            this.grpOptionsViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.propertiesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1337, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadHoParcelToolStripMenuItem,
            this.saveHoParcelToolStripMenuItem,
            this.saveHoParcelAsToolStripMenuItem,
            this.exitTheGoodEditor2ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadHoParcelToolStripMenuItem
            // 
            this.loadHoParcelToolStripMenuItem.Name = "loadHoParcelToolStripMenuItem";
            this.loadHoParcelToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.loadHoParcelToolStripMenuItem.Text = "Load Ho Parcel";
            this.loadHoParcelToolStripMenuItem.Click += new System.EventHandler(this.loadHoParcelToolStripMenuItem_Click);
            // 
            // saveHoParcelToolStripMenuItem
            // 
            this.saveHoParcelToolStripMenuItem.Name = "saveHoParcelToolStripMenuItem";
            this.saveHoParcelToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.saveHoParcelToolStripMenuItem.Text = "Save Ho Parcel";
            this.saveHoParcelToolStripMenuItem.Click += new System.EventHandler(this.saveHoParcelToolStripMenuItem_Click);
            // 
            // saveHoParcelAsToolStripMenuItem
            // 
            this.saveHoParcelAsToolStripMenuItem.Name = "saveHoParcelAsToolStripMenuItem";
            this.saveHoParcelAsToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.saveHoParcelAsToolStripMenuItem.Text = "Save Ho Parcel As";
            this.saveHoParcelAsToolStripMenuItem.Click += new System.EventHandler(this.saveHoParcelAsToolStripMenuItem_Click);
            // 
            // exitTheGoodEditor2ToolStripMenuItem
            // 
            this.exitTheGoodEditor2ToolStripMenuItem.Name = "exitTheGoodEditor2ToolStripMenuItem";
            this.exitTheGoodEditor2ToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.exitTheGoodEditor2ToolStripMenuItem.Text = "Exit The GoodEditor 2";
            this.exitTheGoodEditor2ToolStripMenuItem.Click += new System.EventHandler(this.exitTheGoodEditor2ToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportLayerListToTextFileToolStripMenuItem,
            this.exportAssetsListToTextFileToolStripMenuItem,
            this.openTheSaveFileEditorToolStripMenuItem,
            this.randomizerToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // exportLayerListToTextFileToolStripMenuItem
            // 
            this.exportLayerListToTextFileToolStripMenuItem.Name = "exportLayerListToTextFileToolStripMenuItem";
            this.exportLayerListToTextFileToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.exportLayerListToTextFileToolStripMenuItem.Text = "Export Layer List To Text File";
            this.exportLayerListToTextFileToolStripMenuItem.Click += new System.EventHandler(this.exportLayerListToTextFileToolStripMenuItem_Click);
            // 
            // exportAssetsListToTextFileToolStripMenuItem
            // 
            this.exportAssetsListToTextFileToolStripMenuItem.Name = "exportAssetsListToTextFileToolStripMenuItem";
            this.exportAssetsListToTextFileToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.exportAssetsListToTextFileToolStripMenuItem.Text = "Export Asset List To Text File";
            this.exportAssetsListToTextFileToolStripMenuItem.Click += new System.EventHandler(this.exportAssetsListToTextFileToolStripMenuItem_Click);
            // 
            // openTheSaveFileEditorToolStripMenuItem
            // 
            this.openTheSaveFileEditorToolStripMenuItem.Name = "openTheSaveFileEditorToolStripMenuItem";
            this.openTheSaveFileEditorToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.openTheSaveFileEditorToolStripMenuItem.Text = "Open the Save File Editor...";
            this.openTheSaveFileEditorToolStripMenuItem.Visible = false;
            this.openTheSaveFileEditorToolStripMenuItem.Click += new System.EventHandler(this.openTheSaveFileEditorToolStripMenuItem_Click);
            // 
            // randomizerToolStripMenuItem
            // 
            this.randomizerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTheRandomizerToolStripMenuItem});
            this.randomizerToolStripMenuItem.Name = "randomizerToolStripMenuItem";
            this.randomizerToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.randomizerToolStripMenuItem.Text = "Randomizer";
            this.randomizerToolStripMenuItem.Visible = false;
            // 
            // openTheRandomizerToolStripMenuItem
            // 
            this.openTheRandomizerToolStripMenuItem.Name = "openTheRandomizerToolStripMenuItem";
            this.openTheRandomizerToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.openTheRandomizerToolStripMenuItem.Text = "Open The Randomizer";
            this.openTheRandomizerToolStripMenuItem.Click += new System.EventHandler(this.openTheRandomizerToolStripMenuItem_Click);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTheGoodEditor2ToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.disableToolTipsToolStripMenuItem});
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.propertiesToolStripMenuItem.Text = "Properties";
            // 
            // aboutTheGoodEditor2ToolStripMenuItem
            // 
            this.aboutTheGoodEditor2ToolStripMenuItem.Name = "aboutTheGoodEditor2ToolStripMenuItem";
            this.aboutTheGoodEditor2ToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.aboutTheGoodEditor2ToolStripMenuItem.Text = "About the GoodEditor 2";
            this.aboutTheGoodEditor2ToolStripMenuItem.Click += new System.EventHandler(this.aboutTheGoodEditor2ToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.helpToolStripMenuItem.Text = "Enable ToolTips";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // disableToolTipsToolStripMenuItem
            // 
            this.disableToolTipsToolStripMenuItem.Name = "disableToolTipsToolStripMenuItem";
            this.disableToolTipsToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.disableToolTipsToolStripMenuItem.Text = "Disable ToolTips";
            this.disableToolTipsToolStripMenuItem.Click += new System.EventHandler(this.disableToolTipsToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAssetID);
            this.groupBox1.Controls.Add(this.lblNames);
            this.groupBox1.Controls.Add(this.lblLayer);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lblFineScrollLayers);
            this.groupBox1.Controls.Add(this.lblFineScroll);
            this.groupBox1.Controls.Add(this.btnAssetDown);
            this.groupBox1.Controls.Add(this.btnAssetUp);
            this.groupBox1.Controls.Add(this.btnLayerDown);
            this.groupBox1.Controls.Add(this.btnLayerUp);
            this.groupBox1.Controls.Add(this.listBoxLayers);
            this.groupBox1.Controls.Add(this.listBoxAssets);
            this.groupBox1.Location = new System.Drawing.Point(16, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(648, 608);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Layers and Assets";
            // 
            // lblAssetID
            // 
            this.lblAssetID.AutoSize = true;
            this.lblAssetID.Location = new System.Drawing.Point(528, 175);
            this.lblAssetID.Name = "lblAssetID";
            this.lblAssetID.Size = new System.Drawing.Size(56, 17);
            this.lblAssetID.TabIndex = 55;
            this.lblAssetID.Text = "AssetID";
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Location = new System.Drawing.Point(357, 175);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(45, 17);
            this.lblNames.TabIndex = 54;
            this.lblNames.Text = "Name";
            // 
            // lblLayer
            // 
            this.lblLayer.AutoSize = true;
            this.lblLayer.Location = new System.Drawing.Point(110, 175);
            this.lblLayer.Name = "lblLayer";
            this.lblLayer.Size = new System.Drawing.Size(51, 17);
            this.lblLayer.TabIndex = 53;
            this.lblLayer.Text = "Layers";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(5, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(430, 80);
            this.groupBox4.TabIndex = 52;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Open Ho Parcel Details and Asset Size Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Size:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "File: None";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Location = new System.Drawing.Point(441, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 80);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misc. Options";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(21, 45);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(158, 21);
            this.checkBox2.TabIndex = 48;
            this.checkBox2.Text = "Enable Discord RPC";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(21, 24);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(156, 21);
            this.checkBox1.TabIndex = 36;
            this.checkBox1.Text = "Little Endian Ho File";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.MouseHover += new System.EventHandler(this.checkBox1_MouseHover);
            // 
            // lblFineScrollLayers
            // 
            this.lblFineScrollLayers.AutoSize = true;
            this.lblFineScrollLayers.Location = new System.Drawing.Point(64, 114);
            this.lblFineScrollLayers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFineScrollLayers.Name = "lblFineScrollLayers";
            this.lblFineScrollLayers.Size = new System.Drawing.Size(179, 17);
            this.lblFineScrollLayers.TabIndex = 50;
            this.lblFineScrollLayers.Text = "Fine Scroll Through Layers";
            // 
            // lblFineScroll
            // 
            this.lblFineScroll.AutoSize = true;
            this.lblFineScroll.Location = new System.Drawing.Point(390, 114);
            this.lblFineScroll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFineScroll.Name = "lblFineScroll";
            this.lblFineScroll.Size = new System.Drawing.Size(178, 17);
            this.lblFineScroll.TabIndex = 49;
            this.lblFineScroll.Text = "Fine Scroll Through Assets";
            // 
            // btnAssetDown
            // 
            this.btnAssetDown.Location = new System.Drawing.Point(483, 135);
            this.btnAssetDown.Margin = new System.Windows.Forms.Padding(4);
            this.btnAssetDown.Name = "btnAssetDown";
            this.btnAssetDown.Size = new System.Drawing.Size(144, 28);
            this.btnAssetDown.TabIndex = 47;
            this.btnAssetDown.Text = "↓";
            this.btnAssetDown.UseVisualStyleBackColor = true;
            this.btnAssetDown.Click += new System.EventHandler(this.btnAssetDown_Click);
            // 
            // btnAssetUp
            // 
            this.btnAssetUp.Location = new System.Drawing.Point(315, 135);
            this.btnAssetUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnAssetUp.Name = "btnAssetUp";
            this.btnAssetUp.Size = new System.Drawing.Size(145, 28);
            this.btnAssetUp.TabIndex = 46;
            this.btnAssetUp.Text = "↑";
            this.btnAssetUp.UseVisualStyleBackColor = true;
            this.btnAssetUp.Click += new System.EventHandler(this.btnAssetUp_Click);
            // 
            // btnLayerDown
            // 
            this.btnLayerDown.Location = new System.Drawing.Point(164, 135);
            this.btnLayerDown.Margin = new System.Windows.Forms.Padding(4);
            this.btnLayerDown.Name = "btnLayerDown";
            this.btnLayerDown.Size = new System.Drawing.Size(129, 28);
            this.btnLayerDown.TabIndex = 45;
            this.btnLayerDown.Text = "↓";
            this.btnLayerDown.UseVisualStyleBackColor = true;
            this.btnLayerDown.Click += new System.EventHandler(this.btnLayerDown_Click);
            this.btnLayerDown.MouseHover += new System.EventHandler(this.btnLayerDown_MouseHover);
            // 
            // btnLayerUp
            // 
            this.btnLayerUp.Location = new System.Drawing.Point(11, 135);
            this.btnLayerUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnLayerUp.Name = "btnLayerUp";
            this.btnLayerUp.Size = new System.Drawing.Size(130, 28);
            this.btnLayerUp.TabIndex = 44;
            this.btnLayerUp.Text = "↑";
            this.btnLayerUp.UseVisualStyleBackColor = true;
            this.btnLayerUp.Click += new System.EventHandler(this.btnLayerUp_Click);
            this.btnLayerUp.MouseHover += new System.EventHandler(this.btnLayerUp_MouseHover);
            // 
            // listBoxLayers
            // 
            this.listBoxLayers.FormattingEnabled = true;
            this.listBoxLayers.ItemHeight = 16;
            this.listBoxLayers.Location = new System.Drawing.Point(8, 196);
            this.listBoxLayers.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxLayers.Name = "listBoxLayers";
            this.listBoxLayers.Size = new System.Drawing.Size(297, 404);
            this.listBoxLayers.TabIndex = 2;
            this.listBoxLayers.SelectedIndexChanged += new System.EventHandler(this.listBoxLayers_SelectedIndexChanged);
            this.listBoxLayers.MouseHover += new System.EventHandler(this.listBoxLayers_MouseHover);
            // 
            // listBoxAssets
            // 
            this.listBoxAssets.FormattingEnabled = true;
            this.listBoxAssets.ItemHeight = 16;
            this.listBoxAssets.Location = new System.Drawing.Point(313, 196);
            this.listBoxAssets.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxAssets.Name = "listBoxAssets";
            this.listBoxAssets.Size = new System.Drawing.Size(312, 404);
            this.listBoxAssets.TabIndex = 1;
            this.listBoxAssets.SelectedIndexChanged += new System.EventHandler(this.listBoxAssets_SelectedIndexChanged_1);
            this.listBoxAssets.MouseHover += new System.EventHandler(this.listBoxAssets_MouseHover);
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(8, 187);
            this.btnSendData.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(640, 28);
            this.btnSendData.TabIndex = 37;
            this.btnSendData.Text = "Edit Selected Asset";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.button2_Click);
            // 
            // grupAssetOtherTools
            // 
            this.grupAssetOtherTools.Controls.Add(this.buttonExtractAll);
            this.grupAssetOtherTools.Controls.Add(this.buttonExtract);
            this.grupAssetOtherTools.Controls.Add(this.buttonReplace);
            this.grupAssetOtherTools.Controls.Add(this.btnSendData);
            this.grupAssetOtherTools.Location = new System.Drawing.Point(672, 32);
            this.grupAssetOtherTools.Margin = new System.Windows.Forms.Padding(4);
            this.grupAssetOtherTools.Name = "grupAssetOtherTools";
            this.grupAssetOtherTools.Padding = new System.Windows.Forms.Padding(4);
            this.grupAssetOtherTools.Size = new System.Drawing.Size(656, 233);
            this.grupAssetOtherTools.TabIndex = 6;
            this.grupAssetOtherTools.TabStop = false;
            this.grupAssetOtherTools.Text = "Basic Asset Tools";
            this.grupAssetOtherTools.Enter += new System.EventHandler(this.grupAssetOtherTools_Enter);
            // 
            // buttonExtractAll
            // 
            this.buttonExtractAll.Location = new System.Drawing.Point(8, 101);
            this.buttonExtractAll.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExtractAll.Name = "buttonExtractAll";
            this.buttonExtractAll.Size = new System.Drawing.Size(640, 28);
            this.buttonExtractAll.TabIndex = 7;
            this.buttonExtractAll.Text = "Extract All Assets";
            this.buttonExtractAll.UseVisualStyleBackColor = true;
            this.buttonExtractAll.Click += new System.EventHandler(this.buttonExtractAll_Click_2);
            // 
            // buttonExtract
            // 
            this.buttonExtract.Location = new System.Drawing.Point(8, 30);
            this.buttonExtract.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExtract.Name = "buttonExtract";
            this.buttonExtract.Size = new System.Drawing.Size(640, 28);
            this.buttonExtract.TabIndex = 5;
            this.buttonExtract.Text = "Extract Selected Asset";
            this.buttonExtract.UseVisualStyleBackColor = true;
            this.buttonExtract.Click += new System.EventHandler(this.buttonExtract_Click_2);
            // 
            // buttonReplace
            // 
            this.buttonReplace.Location = new System.Drawing.Point(8, 65);
            this.buttonReplace.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(640, 28);
            this.buttonReplace.TabIndex = 6;
            this.buttonReplace.Text = "Replace Selected Asset";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click_2);
            // 
            // btnOpenByteViewer
            // 
            this.btnOpenByteViewer.Location = new System.Drawing.Point(8, 21);
            this.btnOpenByteViewer.Name = "btnOpenByteViewer";
            this.btnOpenByteViewer.Size = new System.Drawing.Size(641, 39);
            this.btnOpenByteViewer.TabIndex = 38;
            this.btnOpenByteViewer.Text = "Open the Byte Viewer";
            this.btnOpenByteViewer.UseVisualStyleBackColor = true;
            this.btnOpenByteViewer.Click += new System.EventHandler(this.btnOpenByteViewer_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(640, 35);
            this.button1.TabIndex = 38;
            this.button1.Text = "What\'s this asset type?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(672, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 68);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asset Help";
            // 
            // grpByteViewerButtonContainer
            // 
            this.grpByteViewerButtonContainer.Controls.Add(this.btnOpenByteViewer);
            this.grpByteViewerButtonContainer.Location = new System.Drawing.Point(672, 348);
            this.grpByteViewerButtonContainer.Name = "grpByteViewerButtonContainer";
            this.grpByteViewerButtonContainer.Size = new System.Drawing.Size(656, 71);
            this.grpByteViewerButtonContainer.TabIndex = 8;
            this.grpByteViewerButtonContainer.TabStop = false;
            this.grpByteViewerButtonContainer.Text = "Byte Viewer Controls";
            // 
            // grpTextureControls
            // 
            this.grpTextureControls.Controls.Add(this.grpPreviewContainer);
            this.grpTextureControls.Controls.Add(this.btnOpenTextureViewer);
            this.grpTextureControls.Controls.Add(this.grpOptionsViewer);
            this.grpTextureControls.Location = new System.Drawing.Point(672, 425);
            this.grpTextureControls.Name = "grpTextureControls";
            this.grpTextureControls.Size = new System.Drawing.Size(656, 216);
            this.grpTextureControls.TabIndex = 9;
            this.grpTextureControls.TabStop = false;
            this.grpTextureControls.Text = "Texture Previewer and Viewer Controls";
            // 
            // grpPreviewContainer
            // 
            this.grpPreviewContainer.Controls.Add(this.texturePreviewBox);
            this.grpPreviewContainer.Location = new System.Drawing.Point(8, 21);
            this.grpPreviewContainer.Name = "grpPreviewContainer";
            this.grpPreviewContainer.Size = new System.Drawing.Size(200, 173);
            this.grpPreviewContainer.TabIndex = 40;
            this.grpPreviewContainer.TabStop = false;
            this.grpPreviewContainer.Text = "Preview Selected Texture";
            // 
            // texturePreviewBox
            // 
            this.texturePreviewBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.texturePreviewBox.Location = new System.Drawing.Point(3, 18);
            this.texturePreviewBox.Name = "texturePreviewBox";
            this.texturePreviewBox.Size = new System.Drawing.Size(194, 152);
            this.texturePreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.texturePreviewBox.TabIndex = 0;
            this.texturePreviewBox.TabStop = false;
            this.texturePreviewBox.Click += new System.EventHandler(this.texturePreviewBox_Click);
            // 
            // btnOpenTextureViewer
            // 
            this.btnOpenTextureViewer.Location = new System.Drawing.Point(214, 155);
            this.btnOpenTextureViewer.Name = "btnOpenTextureViewer";
            this.btnOpenTextureViewer.Size = new System.Drawing.Size(436, 39);
            this.btnOpenTextureViewer.TabIndex = 39;
            this.btnOpenTextureViewer.Text = "Open Previewed Texture";
            this.btnOpenTextureViewer.UseVisualStyleBackColor = true;
            this.btnOpenTextureViewer.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // grpOptionsViewer
            // 
            this.grpOptionsViewer.Controls.Add(this.btnExtraOptionsTexture);
            this.grpOptionsViewer.Controls.Add(this.btnDumpTextures);
            this.grpOptionsViewer.Controls.Add(this.chkTurnOffPreviewButton);
            this.grpOptionsViewer.Controls.Add(this.chkTurnPreviewOff);
            this.grpOptionsViewer.Location = new System.Drawing.Point(214, 21);
            this.grpOptionsViewer.Name = "grpOptionsViewer";
            this.grpOptionsViewer.Size = new System.Drawing.Size(436, 128);
            this.grpOptionsViewer.TabIndex = 42;
            this.grpOptionsViewer.TabStop = false;
            this.grpOptionsViewer.Text = "Options";
            // 
            // btnExtraOptionsTexture
            // 
            this.btnExtraOptionsTexture.Location = new System.Drawing.Point(270, 21);
            this.btnExtraOptionsTexture.Name = "btnExtraOptionsTexture";
            this.btnExtraOptionsTexture.Size = new System.Drawing.Size(160, 47);
            this.btnExtraOptionsTexture.TabIndex = 43;
            this.btnExtraOptionsTexture.Text = "Extra Texture Options";
            this.btnExtraOptionsTexture.UseVisualStyleBackColor = true;
            this.btnExtraOptionsTexture.Visible = false;
            this.btnExtraOptionsTexture.Click += new System.EventHandler(this.button2_Click_3);
            // 
            // btnDumpTextures
            // 
            this.btnDumpTextures.Location = new System.Drawing.Point(6, 21);
            this.btnDumpTextures.Name = "btnDumpTextures";
            this.btnDumpTextures.Size = new System.Drawing.Size(258, 47);
            this.btnDumpTextures.TabIndex = 42;
            this.btnDumpTextures.Text = "Dump All Textures (Experimental)";
            this.btnDumpTextures.UseVisualStyleBackColor = true;
            this.btnDumpTextures.Click += new System.EventHandler(this.btnDumpTextures_Click);
            // 
            // chkTurnOffPreviewButton
            // 
            this.chkTurnOffPreviewButton.AutoSize = true;
            this.chkTurnOffPreviewButton.Location = new System.Drawing.Point(6, 74);
            this.chkTurnOffPreviewButton.Name = "chkTurnOffPreviewButton";
            this.chkTurnOffPreviewButton.Size = new System.Drawing.Size(139, 21);
            this.chkTurnOffPreviewButton.TabIndex = 41;
            this.chkTurnOffPreviewButton.Text = "Hide Open Buton";
            this.chkTurnOffPreviewButton.UseVisualStyleBackColor = true;
            this.chkTurnOffPreviewButton.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chkTurnPreviewOff
            // 
            this.chkTurnPreviewOff.AutoSize = true;
            this.chkTurnPreviewOff.Location = new System.Drawing.Point(6, 101);
            this.chkTurnPreviewOff.Name = "chkTurnPreviewOff";
            this.chkTurnPreviewOff.Size = new System.Drawing.Size(207, 21);
            this.chkTurnPreviewOff.TabIndex = 41;
            this.chkTurnPreviewOff.Text = "Turn Off Texture Previewing";
            this.chkTurnPreviewOff.UseVisualStyleBackColor = true;
            this.chkTurnPreviewOff.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 645);
            this.Controls.Add(this.grpTextureControls);
            this.Controls.Add(this.grpByteViewerButtonContainer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grupAssetOtherTools);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "The GoodEditor 2";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grupAssetOtherTools.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.grpByteViewerButtonContainer.ResumeLayout(false);
            this.grpTextureControls.ResumeLayout(false);
            this.grpPreviewContainer.ResumeLayout(false);
            this.grpPreviewContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.texturePreviewBox)).EndInit();
            this.grpOptionsViewer.ResumeLayout(false);
            this.grpOptionsViewer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadHoParcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveHoParcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitTheGoodEditor2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportLayerListToTextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAssetsListToTextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTheGoodEditor2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.ToolStripMenuItem saveHoParcelAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableToolTipsToolStripMenuItem;
        private System.Windows.Forms.ToolTip gHelpToolTips;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grupAssetOtherTools;
        private System.Windows.Forms.Button buttonExtractAll;
        private System.Windows.Forms.Button buttonExtract;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOpenByteViewer;
        private System.Windows.Forms.GroupBox grpByteViewerButtonContainer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem openTheSaveFileEditorToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpTextureControls;
        private System.Windows.Forms.Button btnOpenTextureViewer;
        private System.Windows.Forms.GroupBox grpPreviewContainer;
        private System.Windows.Forms.PictureBox texturePreviewBox;
        private System.Windows.Forms.CheckBox chkTurnPreviewOff;
        private System.Windows.Forms.GroupBox grpOptionsViewer;
        private System.Windows.Forms.CheckBox chkTurnOffPreviewButton;
        private System.Windows.Forms.ToolStripMenuItem randomizerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTheRandomizerToolStripMenuItem;
        private System.Windows.Forms.Label lblAssetID;
        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.Label lblLayer;
        private System.Windows.Forms.Label lblFineScrollLayers;
        private System.Windows.Forms.Label lblFineScroll;
        private System.Windows.Forms.Button btnAssetDown;
        private System.Windows.Forms.Button btnAssetUp;
        private System.Windows.Forms.Button btnLayerDown;
        private System.Windows.Forms.Button btnLayerUp;
        private System.Windows.Forms.ListBox listBoxLayers;
        private System.Windows.Forms.ListBox listBoxAssets;
        private System.Windows.Forms.Button btnDumpTextures;
        private System.Windows.Forms.Button btnExtraOptionsTexture;
    }
}

