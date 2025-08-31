namespace Satellaview server
{
    partial class EventPlazaEditor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveQuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxTileset = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxBuilding = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonDoorMode = new System.Windows.Forms.RadioButton();
            this.radioButtonBuildingMode = new System.Windows.Forms.RadioButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonTilesetEditor = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonAnimationEditor = new System.Windows.Forms.Button();
            this.buttonCollisionEditor = new System.Windows.Forms.Button();
            this.buttonSuperFamiconv = new System.Windows.Forms.Button();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetTileDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetTilesetDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetCollisionDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAnimationDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetBuildingMapDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllBuildingDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonQuitNoSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAnimations = new System.Windows.Forms.TabPage();
            this.tabPageTags = new System.Windows.Forms.TabPage();
            this.animationListBox = new System.Windows.Forms.ListBox();
            this.addAnimationButton = new System.Windows.Forms.Button();
            this.removeAnimationButton = new System.Windows.Forms.Button();
            this.animationPreviewPanel = new System.Windows.Forms.Panel();
            this.tagListBox = new System.Windows.Forms.ListBox();
            this.addTagButton = new System.Windows.Forms.Button();
            this.removeTagButton = new System.Windows.Forms.Button();
            this.tagColorPicker = new System.Windows.Forms.ColorDialog();
            this.frameDurationNumeric = new System.Windows.Forms.NumericUpDown();
            this.frameXPosNumeric = new System.Windows.Forms.NumericUpDown();
            this.frameYPosNumeric = new System.Windows.Forms.NumericUpDown();
            this.frameWidthNumeric = new System.Windows.Forms.NumericUpDown();
            this.frameHeightNumeric = new System.Windows.Forms.NumericUpDown();
            this.addFrameButton = new System.Windows.Forms.Button();
            this.removeFrameButton = new System.Windows.Forms.Button();
            this.networkStartButton = new System.Windows.Forms.Button();
            this.networkStopButton = new System.Windows.Forms.Button();
            this.networkStatusLabel = new System.Windows.Forms.Label();
            this.networkPortNumeric = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTileset)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuilding)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageAnimations.SuspendLayout();
            this.tabPageTags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frameDurationNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameXPosNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameYPosNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameWidthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameHeightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.networkPortNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(456, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveQuitToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.importToolStripMenuItem.Text = "Import Building...";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.exportToolStripMenuItem.Text = "Export Building...";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(176, 6);
            // 
            // saveQuitToolStripMenuItem
            // 
            this.saveQuitToolStripMenuItem.Name = "saveQuitToolStripMenuItem";
            this.saveQuitToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.saveQuitToolStripMenuItem.Text = "Save && Quit";
            this.saveQuitToolStripMenuItem.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.quitToolStripMenuItem.Text = "Quit without Saving";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBoxTileset);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 311);
            this.panel1.TabIndex = 1;
            // 
            // pictureBoxTileset
            // 
            this.pictureBoxTileset.BackColor = System.Drawing.Color.DimGray;
            this.pictureBoxTileset.Image = global::Satellaview server.Properties.Resources.Tileset;
            this.pictureBoxTileset.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTileset.Name = "pictureBoxTileset";
            this.pictureBoxTileset.Size = new System.Drawing.Size(128, 2048);
            this.pictureBoxTileset.TabIndex = 0;
            this.pictureBoxTileset.TabStop = false;
            this.pictureBoxTileset.Click += new System.EventHandler(this.pictureBoxTileset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxBuilding);
            this.groupBox1.Location = new System.Drawing.Point(152, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 254);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Building Editor";
            // 
            // pictureBoxBuilding
            // 
            this.pictureBoxBuilding.BackColor = System.Drawing.Color.DimGray;
            this.pictureBoxBuilding.Location = new System.Drawing.Point(5, 19);
            this.pictureBoxBuilding.Name = "pictureBoxBuilding";
            this.pictureBoxBuilding.Size = new System.Drawing.Size(128, 224);
            this.pictureBoxBuilding.TabIndex = 0;
            this.pictureBoxBuilding.TabStop = false;
            this.pictureBoxBuilding.Click += new System.EventHandler(this.pictureBoxBuilding_Click);
            this.pictureBoxBuilding.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxBuilding_MouseEdit);
            this.pictureBoxBuilding.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxBuilding_MouseEdit);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.radioButtonDoorMode);
            this.groupBox2.Controls.Add(this.radioButtonBuildingMode);
            this.groupBox2.Location = new System.Drawing.Point(152, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 41);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editor Mode";
            // 
            // radioButtonDoorMode
            // 
            this.radioButtonDoorMode.AutoSize = true;
            this.radioButtonDoorMode.Location = new System.Drawing.Point(82, 16);
            this.radioButtonDoorMode.Name = "radioButtonDoorMode";
            this.radioButtonDoorMode.Size = new System.Drawing.Size(48, 17);
            this.radioButtonDoorMode.TabIndex = 2;
            this.radioButtonDoorMode.TabStop = true;
            this.radioButtonDoorMode.Text = "Door";
            this.radioButtonDoorMode.UseVisualStyleBackColor = true;
            this.radioButtonDoorMode.CheckedChanged += new System.EventHandler(this.radioButtonDoorMode_CheckedChanged);
            // 
            // radioButtonBuildingMode
            // 
            this.radioButtonBuildingMode.AutoSize = true;
            this.radioButtonBuildingMode.Checked = true;
            this.radioButtonBuildingMode.Location = new System.Drawing.Point(6, 16);
            this.radioButtonBuildingMode.Name = "radioButtonBuildingMode";
            this.radioButtonBuildingMode.Size = new System.Drawing.Size(62, 17);
            this.radioButtonBuildingMode.TabIndex = 0;
            this.radioButtonBuildingMode.TabStop = true;
            this.radioButtonBuildingMode.Text = "Building";
            this.radioButtonBuildingMode.UseVisualStyleBackColor = true;
            this.radioButtonBuildingMode.CheckedChanged += new System.EventHandler(this.radioButtonBuildingMode_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(6, 238);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(122, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save & Quit";
            this.buttonSave.UseMnemonic = false;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonTilesetEditor
            // 
            this.buttonTilesetEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTilesetEditor.Location = new System.Drawing.Point(6, 164);
            this.buttonTilesetEditor.Name = "buttonTilesetEditor";
            this.buttonTilesetEditor.Size = new System.Drawing.Size(122, 23);
            this.buttonTilesetEditor.TabIndex = 5;
            this.buttonTilesetEditor.Text = "Tileset Editor";
            this.buttonTilesetEditor.UseVisualStyleBackColor = true;
            this.buttonTilesetEditor.Click += new System.EventHandler(this.buttonTilesetEditor_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonImport.Location = new System.Drawing.Point(6, 19);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(122, 23);
            this.buttonImport.TabIndex = 6;
            this.buttonImport.Text = "Import Building...";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExport.Location = new System.Drawing.Point(6, 48);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(122, 23);
            this.buttonExport.TabIndex = 7;
            this.buttonExport.Text = "Export Building...";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.buttonQuitNoSave);
            this.groupBox3.Controls.Add(this.buttonAnimationEditor);
            this.groupBox3.Controls.Add(this.buttonCollisionEditor);
            this.groupBox3.Controls.Add(this.buttonSuperFamiconv);
            this.groupBox3.Controls.Add(this.buttonImport);
            this.groupBox3.Controls.Add(this.buttonExport);
            this.groupBox3.Controls.Add(this.buttonSave);
            this.groupBox3.Controls.Add(this.buttonTilesetEditor);
            this.groupBox3.Location = new System.Drawing.Point(310, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(134, 300);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Menu";
            // 
            // buttonAnimationEditor
            // 
            this.buttonAnimationEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnimationEditor.Location = new System.Drawing.Point(6, 193);
            this.buttonAnimationEditor.Name = "buttonAnimationEditor";
            this.buttonAnimationEditor.Size = new System.Drawing.Size(122, 23);
            this.buttonAnimationEditor.TabIndex = 10;
            this.buttonAnimationEditor.Text = "Animation Editor";
            this.buttonAnimationEditor.UseVisualStyleBackColor = true;
            this.buttonAnimationEditor.Click += new System.EventHandler(this.buttonAnimationEditor_Click);
            // 
            // buttonCollisionEditor
            // 
            this.buttonCollisionEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCollisionEditor.Location = new System.Drawing.Point(6, 135);
            this.buttonCollisionEditor.Name = "buttonCollisionEditor";
            this.buttonCollisionEditor.Size = new System.Drawing.Size(122, 23);
            this.buttonCollisionEditor.TabIndex = 9;
            this.buttonCollisionEditor.Text = "Collision Editor";
            this.buttonCollisionEditor.UseVisualStyleBackColor = true;
            this.buttonCollisionEditor.Click += new System.EventHandler(this.buttonCollisionEditor_Click);
            // 
            // buttonSuperFamiconv
            // 
            this.buttonSuperFamiconv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSuperFamiconv.Location = new System.Drawing.Point(6, 92);
            this.buttonSuperFamiconv.Name = "buttonSuperFamiconv";
            this.buttonSuperFamiconv.Size = new System.Drawing.Size(122, 37);
            this.buttonSuperFamiconv.TabIndex = 8;
            this.buttonSuperFamiconv.Text = "Import SuperFamiconv\r\n/ Native Graphics...";
            this.buttonSuperFamiconv.UseVisualStyleBackColor = true;
            this.buttonSuperFamiconv.Click += new System.EventHandler(this.buttonSuperFamiconv_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetBuildingMapDataToolStripMenuItem,
            this.resetTileDataToolStripMenuItem,
            this.resetTilesetDataToolStripMenuItem,
            this.resetCollisionDataToolStripMenuItem,
            this.resetAnimationDataToolStripMenuItem,
            this.resetAllBuildingDataMenuItem});
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // resetTileDataToolStripMenuItem
            // 
            this.resetTileDataToolStripMenuItem.Name = "resetTileDataToolStripMenuItem";
            this.resetTileDataToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.resetTileDataToolStripMenuItem.Text = "Reset Tile Data";
            this.resetTileDataToolStripMenuItem.Click += new System.EventHandler(this.resetTileDataToolStripMenuItem_Click);
            // 
            // resetTilesetDataToolStripMenuItem
            // 
            this.resetTilesetDataToolStripMenuItem.Name = "resetTilesetDataToolStripMenuItem";
            this.resetTilesetDataToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.resetTilesetDataToolStripMenuItem.Text = "Reset Tileset Data";
            this.resetTilesetDataToolStripMenuItem.Click += new System.EventHandler(this.resetTilesetDataToolStripMenuItem_Click);
            // 
            // resetCollisionDataToolStripMenuItem
            // 
            this.resetCollisionDataToolStripMenuItem.Name = "resetCollisionDataToolStripMenuItem";
            this.resetCollisionDataToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.resetCollisionDataToolStripMenuItem.Text = "Reset Collision Data";
            this.resetCollisionDataToolStripMenuItem.Click += new System.EventHandler(this.resetCollisionDataToolStripMenuItem_Click);
            // 
            // resetAnimationDataToolStripMenuItem
            // 
            this.resetAnimationDataToolStripMenuItem.Name = "resetAnimationDataToolStripMenuItem";
            this.resetAnimationDataToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.resetAnimationDataToolStripMenuItem.Text = "Reset Animation Data";
            this.resetAnimationDataToolStripMenuItem.Click += new System.EventHandler(this.resetAnimationDataToolStripMenuItem_Click);
            // 
            // resetBuildingMapDataToolStripMenuItem
            // 
            this.resetBuildingMapDataToolStripMenuItem.Name = "resetBuildingMapDataToolStripMenuItem";
            this.resetBuildingMapDataToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.resetBuildingMapDataToolStripMenuItem.Text = "Reset Building Map Data";
            this.resetBuildingMapDataToolStripMenuItem.Click += new System.EventHandler(this.resetBuildingMapDataToolStripMenuItem_Click);
            //
            // resetAllBuildingDataMenuItem
            //
            this.resetAllBuildingDataMenuItem.Name = "resetAllBuildingDataMenuItem";
            this.resetAllBuildingDataMenuItem.Size = new System.Drawing.Size(203, 22);
            this.resetAllBuildingDataMenuItem.Text = "Reset All Data";
            this.resetAllBuildingDataMenuItem.Click += new System.EventHandler(this.resetAllBuildingDataMenuItem_Click);
            // 
            // buttonQuitNoSave
            // 
            this.buttonQuitNoSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonQuitNoSave.Location = new System.Drawing.Point(6, 267);
            this.buttonQuitNoSave.Name = "buttonQuitNoSave";
            this.buttonQuitNoSave.Size = new System.Drawing.Size(122, 23);
            this.buttonQuitNoSave.TabIndex = 11;
            this.buttonQuitNoSave.Text = "Quit without Saving";
            this.buttonQuitNoSave.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAnimations);
            this.tabControl1.Controls.Add(this.tabPageTags);
            this.tabControl1.Location = new System.Drawing.Point(152, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(139, 254);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPageAnimations
            // 
            this.tabPageAnimations.Controls.Add(this.removeFrameButton);
            this.tabPageAnimations.Controls.Add(this.addFrameButton);
            this.tabPageAnimations.Controls.Add(this.frameHeightNumeric);
            this.tabPageAnimations.Controls.Add(this.frameWidthNumeric);
            this.tabPageAnimations.Controls.Add(this.frameYPosNumeric);
            this.tabPageAnimations.Controls.Add(this.frameXPosNumeric);
            this.tabPageAnimations.Controls.Add(this.frameDurationNumeric);
            this.tabPageAnimations.Controls.Add(this.animationListBox);
            this.tabPageAnimations.Controls.Add(this.addAnimationButton);
            this.tabPageAnimations.Controls.Add(this.removeAnimationButton);
            this.tabPageAnimations.Controls.Add(this.animationPreviewPanel);
            this.tabPageAnimations.Location = new System.Drawing.Point(4, 22);
            this.tabPageAnimations.Name = "tabPageAnimations";
            this.tabPageAnimations.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAnimations.Size = new System.Drawing.Size(131, 228);
            this.tabPageAnimations.TabIndex = 0;
            this.tabPageAnimations.Text = "Town Animations";
            this.tabPageAnimations.UseVisualStyleBackColor = true;
            // 
            // tabPageTags
            // 
            this.tabPageTags.Controls.Add(this.tagListBox);
            this.tabPageTags.Controls.Add(this.addTagButton);
            this.tabPageTags.Controls.Add(this.removeTagButton);
            this.tabPageTags.Location = new System.Drawing.Point(4, 22);
            this.tabPageTags.Name = "tabPageTags";
            this.tabPageTags.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTags.Size = new System.Drawing.Size(131, 228);
            this.tabPageTags.TabIndex = 1;
            this.tabPageTags.Text = "Tags";
            this.tabPageTags.UseVisualStyleBackColor = true;
            // 
            // animationListBox
            // 
            this.animationListBox.Location = new System.Drawing.Point(6, 6);
            this.animationListBox.Name = "animationListBox";
            this.animationListBox.Size = new System.Drawing.Size(120, 95);
            this.animationListBox.TabIndex = 0;
            // 
            // addAnimationButton
            // 
            this.addAnimationButton.Location = new System.Drawing.Point(6, 107);
            this.addAnimationButton.Name = "addAnimationButton";
            this.addAnimationButton.Size = new System.Drawing.Size(120, 23);
            this.addAnimationButton.TabIndex = 1;
            this.addAnimationButton.Text = "Add Animation";
            this.addAnimationButton.UseVisualStyleBackColor = true;
            this.addAnimationButton.Click += new System.EventHandler(this.addAnimationButton_Click);
            // 
            // removeAnimationButton
            // 
            this.removeAnimationButton.Location = new System.Drawing.Point(6, 136);
            this.removeAnimationButton.Name = "removeAnimationButton";
            this.removeAnimationButton.Size = new System.Drawing.Size(120, 23);
            this.removeAnimationButton.TabIndex = 2;
            this.removeAnimationButton.Text = "Remove Animation";
            this.removeAnimationButton.UseVisualStyleBackColor = true;
            this.removeAnimationButton.Click += new System.EventHandler(this.removeAnimationButton_Click);
            // 
            // animationPreviewPanel
            // 
            this.animationPreviewPanel.Location = new System.Drawing.Point(6, 165);
            this.animationPreviewPanel.Name = "animationPreviewPanel";
            this.animationPreviewPanel.Size = new System.Drawing.Size(120, 57);
            this.animationPreviewPanel.TabIndex = 3;
            // 
            // tagListBox
            // 
            this.tagListBox.Location = new System.Drawing.Point(6, 6);
            this.tagListBox.Name = "tagListBox";
            this.tagListBox.Size = new System.Drawing.Size(120, 95);
            this.tagListBox.TabIndex = 0;
            // 
            // addTagButton
            // 
            this.addTagButton.Location = new System.Drawing.Point(6, 107);
            this.addTagButton.Name = "addTagButton";
            this.addTagButton.Size = new System.Drawing.Size(120, 23);
            this.addTagButton.TabIndex = 1;
            this.addTagButton.Text = "Add Tag";
            this.addTagButton.UseVisualStyleBackColor = true;
            this.addTagButton.Click += new System.EventHandler(this.addTagButton_Click);
            // 
            // removeTagButton
            // 
            this.removeTagButton.Location = new System.Drawing.Point(6, 136);
            this.removeTagButton.Name = "removeTagButton";
            this.removeTagButton.Size = new System.Drawing.Size(120, 23);
            this.removeTagButton.TabIndex = 2;
            this.removeTagButton.Text = "Remove Tag";
            this.removeTagButton.UseVisualStyleBackColor = true;
            this.removeTagButton.Click += new System.EventHandler(this.removeTagButton_Click);
            // 
            // tagColorPicker
            // 
            this.tagColorPicker.AnyColor = true;
            // 
            // frameDurationNumeric
            // 
            this.frameDurationNumeric.Location = new System.Drawing.Point(6, 6);
            this.frameDurationNumeric.Name = "frameDurationNumeric";
            this.frameDurationNumeric.Size = new System.Drawing.Size(120, 20);
            this.frameDurationNumeric.TabIndex = 4;
            // 
            // frameXPosNumeric
            // 
            this.frameXPosNumeric.Location = new System.Drawing.Point(6, 32);
            this.frameXPosNumeric.Name = "frameXPosNumeric";
            this.frameXPosNumeric.Size = new System.Drawing.Size(120, 20);
            this.frameXPosNumeric.TabIndex = 5;
            // 
            // frameYPosNumeric
            // 
            this.frameYPosNumeric.Location = new System.Drawing.Point(6, 58);
            this.frameYPosNumeric.Name = "frameYPosNumeric";
            this.frameYPosNumeric.Size = new System.Drawing.Size(120, 20);
            this.frameYPosNumeric.TabIndex = 6;
            // 
            // frameWidthNumeric
            // 
            this.frameWidthNumeric.Location = new System.Drawing.Point(6, 84);
            this.frameWidthNumeric.Name = "frameWidthNumeric";
            this.frameWidthNumeric.Size = new System.Drawing.Size(120, 20);
            this.frameWidthNumeric.TabIndex = 7;
            // 
            // frameHeightNumeric
            // 
            this.frameHeightNumeric.Location = new System.Drawing.Point(6, 110);
            this.frameHeightNumeric.Name = "frameHeightNumeric";
            this.frameHeightNumeric.Size = new System.Drawing.Size(120, 20);
            this.frameHeightNumeric.TabIndex = 8;
            // 
            // addFrameButton
            // 
            this.addFrameButton.Location = new System.Drawing.Point(6, 136);
            this.addFrameButton.Name = "addFrameButton";
            this.addFrameButton.Size = new System.Drawing.Size(120, 23);
            this.addFrameButton.TabIndex = 9;
            this.addFrameButton.Text = "Add Frame";
            this.addFrameButton.UseVisualStyleBackColor = true;
            this.addFrameButton.Click += new System.EventHandler(this.addFrameButton_Click);
            // 
            // removeFrameButton
            // 
            this.removeFrameButton.Location = new System.Drawing.Point(6, 165);
            this.removeFrameButton.Name = "removeFrameButton";
            this.removeFrameButton.Size = new System.Drawing.Size(120, 23);
            this.removeFrameButton.TabIndex = 10;
            this.removeFrameButton.Text = "Remove Frame";
            this.removeFrameButton.UseVisualStyleBackColor = true;
            this.removeFrameButton.Click += new System.EventHandler(this.removeFrameButton_Click);
            // 
            // networkStartButton
            // 
            this.networkStartButton.Location = new System.Drawing.Point(6, 19);
            this.networkStartButton.Name = "networkStartButton";
            this.networkStartButton.Size = new System.Drawing.Size(75, 23);
            this.networkStartButton.TabIndex = 12;
            this.networkStartButton.Text = "Start";
            this.networkStartButton.UseVisualStyleBackColor = true;
            // 
            // networkStopButton
            // 
            this.networkStopButton.Location = new System.Drawing.Point(87, 19);
            this.networkStopButton.Name = "networkStopButton";
            this.networkStopButton.Size = new System.Drawing.Size(75, 23);
            this.networkStopButton.TabIndex = 13;
            this.networkStopButton.Text = "Stop";
            this.networkStopButton.UseVisualStyleBackColor = true;
            // 
            // networkStatusLabel
            // 
            this.networkStatusLabel.AutoSize = true;
            this.networkStatusLabel.Location = new System.Drawing.Point(6, 45);
            this.networkStatusLabel.Name = "networkStatusLabel";
            this.networkStatusLabel.Size = new System.Drawing.Size(35, 13);
            this.networkStatusLabel.TabIndex = 14;
            this.networkStatusLabel.Text = "Status";
            // 
            // networkPortNumeric
            // 
            this.networkPortNumeric.Location = new System.Drawing.Point(6, 61);
            this.networkPortNumeric.Name = "networkPortNumeric";
            this.networkPortNumeric.Size = new System.Drawing.Size(120, 20);
            this.networkPortNumeric.TabIndex = 15;
            // 
            // EventPlazaEditor
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonQuitNoSave;
            this.ClientSize = new System.Drawing.Size(456, 340);
            this.Controls.Add(this.networkPortNumeric);
            this.Controls.Add(this.networkStatusLabel);
            this.Controls.Add(this.networkStopButton);
            this.Controls.Add(this.networkStartButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EventPlazaEditor";
            this.ShowIcon = false;
            this.Text = "Event Plaza Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTileset)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuilding)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAnimations.ResumeLayout(false);
            this.tabPageTags.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frameDurationNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameXPosNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameYPosNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameWidthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameHeightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.networkPortNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxTileset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxBuilding;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonDoorMode;
        private System.Windows.Forms.RadioButton radioButtonBuildingMode;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveQuitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Button buttonTilesetEditor;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSuperFamiconv;
        private System.Windows.Forms.Button buttonCollisionEditor;
        private System.Windows.Forms.Button buttonAnimationEditor;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetBuildingMapDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetTileDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetTilesetDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetCollisionDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAnimationDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAllBuildingDataMenuItem;
        private System.Windows.Forms.Button buttonQuitNoSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAnimations;
        private System.Windows.Forms.TabPage tabPageTags;
        private System.Windows.Forms.ListBox animationListBox;
        private System.Windows.Forms.Button addAnimationButton;
        private System.Windows.Forms.Button removeAnimationButton;
        private System.Windows.Forms.Panel animationPreviewPanel;
        private System.Windows.Forms.ListBox tagListBox;
        private System.Windows.Forms.Button addTagButton;
        private System.Windows.Forms.Button removeTagButton;
        private System.Windows.Forms.ColorDialog tagColorPicker;
        private System.Windows.Forms.NumericUpDown frameDurationNumeric;
        private System.Windows.Forms.NumericUpDown frameXPosNumeric;
        private System.Windows.Forms.NumericUpDown frameYPosNumeric;
        private System.Windows.Forms.NumericUpDown frameWidthNumeric;
        private System.Windows.Forms.NumericUpDown frameHeightNumeric;
        private System.Windows.Forms.Button addFrameButton;
        private System.Windows.Forms.Button removeFrameButton;
        private System.Windows.Forms.Button networkStartButton;
        private System.Windows.Forms.Button networkStopButton;
        private System.Windows.Forms.Label networkStatusLabel;
        private System.Windows.Forms.NumericUpDown networkPortNumeric;
    }
}