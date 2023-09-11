namespace detectVideoApp
{
    partial class NewConfigurationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewConfigurationForm));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveConfiguration = new System.Windows.Forms.Button();
            this.addPhotoExteTxtBox = new System.Windows.Forms.TextBox();
            this.enterVideoExtenLabel = new System.Windows.Forms.Label();
            this.addVideoExteTxtBox = new System.Windows.Forms.TextBox();
            this.browseFolderBtn = new System.Windows.Forms.Button();
            this.enterPhotoExtenLabel = new System.Windows.Forms.Label();
            this.enterCameraNameLabel = new System.Windows.Forms.Label();
            this.cameraNameTxtBox = new System.Windows.Forms.TextBox();
            this.browseFolderLabel = new System.Windows.Forms.Label();
            this.folderPathTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cameraNameWarningLabel = new System.Windows.Forms.Label();
            this.addFolderPathBtn = new System.Windows.Forms.Button();
            this.addPhotoExtenBtn = new System.Windows.Forms.Button();
            this.addVideoExtenBtn = new System.Windows.Forms.Button();
            this.photoExtListView = new System.Windows.Forms.ListView();
            this.photoExtensions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.videoExtListView = new System.Windows.Forms.ListView();
            this.videoExtensions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pathListView = new System.Windows.Forms.ListView();
            this.FolderPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frfreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewConfigurationFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyConfigurationFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveConfiguration
            // 
            this.saveConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveConfiguration.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveConfiguration.Location = new System.Drawing.Point(544, 203);
            this.saveConfiguration.Name = "saveConfiguration";
            this.saveConfiguration.Size = new System.Drawing.Size(91, 25);
            this.saveConfiguration.TabIndex = 43;
            this.saveConfiguration.Text = "Save";
            this.saveConfiguration.UseVisualStyleBackColor = true;
            this.saveConfiguration.Click += new System.EventHandler(this.SaveConfiguration_Click);
            // 
            // addPhotoExteTxtBox
            // 
            this.addPhotoExteTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPhotoExteTxtBox.Location = new System.Drawing.Point(194, 162);
            this.addPhotoExteTxtBox.Name = "addPhotoExteTxtBox";
            this.addPhotoExteTxtBox.Size = new System.Drawing.Size(308, 24);
            this.addPhotoExteTxtBox.TabIndex = 50;
            this.addPhotoExteTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddPhotoExteTxtBox_KeyDown);
            // 
            // enterVideoExtenLabel
            // 
            this.enterVideoExtenLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enterVideoExtenLabel.AutoSize = true;
            this.enterVideoExtenLabel.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.enterVideoExtenLabel.Location = new System.Drawing.Point(15, 118);
            this.enterVideoExtenLabel.Name = "enterVideoExtenLabel";
            this.enterVideoExtenLabel.Size = new System.Drawing.Size(170, 17);
            this.enterVideoExtenLabel.TabIndex = 47;
            this.enterVideoExtenLabel.Text = "Enter video extensions";
            // 
            // addVideoExteTxtBox
            // 
            this.addVideoExteTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addVideoExteTxtBox.Location = new System.Drawing.Point(194, 118);
            this.addVideoExteTxtBox.Name = "addVideoExteTxtBox";
            this.addVideoExteTxtBox.Size = new System.Drawing.Size(308, 24);
            this.addVideoExteTxtBox.TabIndex = 49;
            this.addVideoExteTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddVideoExteTxtBox_KeyDown);
            // 
            // browseFolderBtn
            // 
            this.browseFolderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browseFolderBtn.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.browseFolderBtn.Location = new System.Drawing.Point(465, 74);
            this.browseFolderBtn.Name = "browseFolderBtn";
            this.browseFolderBtn.Size = new System.Drawing.Size(33, 26);
            this.browseFolderBtn.TabIndex = 46;
            this.browseFolderBtn.Text = "...";
            this.browseFolderBtn.UseVisualStyleBackColor = true;
            this.browseFolderBtn.Click += new System.EventHandler(this.BrowseFolderBtn_Click);
            // 
            // enterPhotoExtenLabel
            // 
            this.enterPhotoExtenLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enterPhotoExtenLabel.AutoSize = true;
            this.enterPhotoExtenLabel.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.enterPhotoExtenLabel.Location = new System.Drawing.Point(15, 167);
            this.enterPhotoExtenLabel.Name = "enterPhotoExtenLabel";
            this.enterPhotoExtenLabel.Size = new System.Drawing.Size(175, 17);
            this.enterPhotoExtenLabel.TabIndex = 48;
            this.enterPhotoExtenLabel.Text = "Enter photo extensions";
            // 
            // enterCameraNameLabel
            // 
            this.enterCameraNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enterCameraNameLabel.AutoSize = true;
            this.enterCameraNameLabel.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.enterCameraNameLabel.Location = new System.Drawing.Point(15, 43);
            this.enterCameraNameLabel.Name = "enterCameraNameLabel";
            this.enterCameraNameLabel.Size = new System.Drawing.Size(144, 17);
            this.enterCameraNameLabel.TabIndex = 41;
            this.enterCameraNameLabel.Text = "Enter New Camera:";
            // 
            // cameraNameTxtBox
            // 
            this.cameraNameTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cameraNameTxtBox.Location = new System.Drawing.Point(194, 38);
            this.cameraNameTxtBox.Name = "cameraNameTxtBox";
            this.cameraNameTxtBox.Size = new System.Drawing.Size(371, 24);
            this.cameraNameTxtBox.TabIndex = 42;
            this.cameraNameTxtBox.TextChanged += new System.EventHandler(this.CameraNameTxtBox_TextChanged);
            // 
            // browseFolderLabel
            // 
            this.browseFolderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browseFolderLabel.AutoSize = true;
            this.browseFolderLabel.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.browseFolderLabel.Location = new System.Drawing.Point(15, 81);
            this.browseFolderLabel.Name = "browseFolderLabel";
            this.browseFolderLabel.Size = new System.Drawing.Size(108, 17);
            this.browseFolderLabel.TabIndex = 44;
            this.browseFolderLabel.Text = "Browse Folder";
            // 
            // folderPathTxtBox
            // 
            this.folderPathTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderPathTxtBox.Location = new System.Drawing.Point(194, 75);
            this.folderPathTxtBox.Name = "folderPathTxtBox";
            this.folderPathTxtBox.Size = new System.Drawing.Size(265, 24);
            this.folderPathTxtBox.TabIndex = 45;
            this.folderPathTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FolderPathTxtBox_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox2.Controls.Add(this.saveConfiguration);
            this.groupBox2.Controls.Add(this.cameraNameWarningLabel);
            this.groupBox2.Controls.Add(this.addFolderPathBtn);
            this.groupBox2.Controls.Add(this.addPhotoExtenBtn);
            this.groupBox2.Controls.Add(this.addVideoExtenBtn);
            this.groupBox2.Controls.Add(this.photoExtListView);
            this.groupBox2.Controls.Add(this.videoExtListView);
            this.groupBox2.Controls.Add(this.pathListView);
            this.groupBox2.Controls.Add(this.cameraNameTxtBox);
            this.groupBox2.Controls.Add(this.addPhotoExteTxtBox);
            this.groupBox2.Controls.Add(this.browseFolderBtn);
            this.groupBox2.Controls.Add(this.enterPhotoExtenLabel);
            this.groupBox2.Controls.Add(this.enterCameraNameLabel);
            this.groupBox2.Controls.Add(this.addVideoExteTxtBox);
            this.groupBox2.Controls.Add(this.enterVideoExtenLabel);
            this.groupBox2.Controls.Add(this.browseFolderLabel);
            this.groupBox2.Controls.Add(this.folderPathTxtBox);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.groupBox2.Location = new System.Drawing.Point(12, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 495);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insert Camera";
            // 
            // cameraNameWarningLabel
            // 
            this.cameraNameWarningLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cameraNameWarningLabel.AutoSize = true;
            this.cameraNameWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.cameraNameWarningLabel.Location = new System.Drawing.Point(193, 18);
            this.cameraNameWarningLabel.Name = "cameraNameWarningLabel";
            this.cameraNameWarningLabel.Size = new System.Drawing.Size(224, 17);
            this.cameraNameWarningLabel.TabIndex = 60;
            this.cameraNameWarningLabel.Text = "The camera name alredy exist!";
            // 
            // addFolderPathBtn
            // 
            this.addFolderPathBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addFolderPathBtn.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.addFolderPathBtn.Location = new System.Drawing.Point(506, 75);
            this.addFolderPathBtn.Name = "addFolderPathBtn";
            this.addFolderPathBtn.Size = new System.Drawing.Size(59, 24);
            this.addFolderPathBtn.TabIndex = 59;
            this.addFolderPathBtn.Text = "Add";
            this.addFolderPathBtn.UseVisualStyleBackColor = true;
            this.addFolderPathBtn.Click += new System.EventHandler(this.AddFolderPathBtn_Click);
            // 
            // addPhotoExtenBtn
            // 
            this.addPhotoExtenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPhotoExtenBtn.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.addPhotoExtenBtn.Location = new System.Drawing.Point(506, 162);
            this.addPhotoExtenBtn.Name = "addPhotoExtenBtn";
            this.addPhotoExtenBtn.Size = new System.Drawing.Size(59, 24);
            this.addPhotoExtenBtn.TabIndex = 57;
            this.addPhotoExtenBtn.Text = "Add";
            this.addPhotoExtenBtn.UseVisualStyleBackColor = true;
            this.addPhotoExtenBtn.Click += new System.EventHandler(this.AddPhotoExtenBtn_Click);
            // 
            // addVideoExtenBtn
            // 
            this.addVideoExtenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addVideoExtenBtn.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.addVideoExtenBtn.Location = new System.Drawing.Point(506, 118);
            this.addVideoExtenBtn.Name = "addVideoExtenBtn";
            this.addVideoExtenBtn.Size = new System.Drawing.Size(59, 24);
            this.addVideoExtenBtn.TabIndex = 56;
            this.addVideoExtenBtn.Text = "Add";
            this.addVideoExtenBtn.UseVisualStyleBackColor = true;
            this.addVideoExtenBtn.Click += new System.EventHandler(this.AddVideoExtenBtn_Click);
            // 
            // photoExtListView
            // 
            this.photoExtListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.photoExtListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.photoExtensions});
            this.photoExtListView.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.photoExtListView.HideSelection = false;
            this.photoExtListView.Location = new System.Drawing.Point(242, 234);
            this.photoExtListView.Name = "photoExtListView";
            this.photoExtListView.Size = new System.Drawing.Size(393, 129);
            this.photoExtListView.TabIndex = 55;
            this.photoExtListView.UseCompatibleStateImageBehavior = false;
            this.photoExtListView.View = System.Windows.Forms.View.Details;
            // 
            // photoExtensions
            // 
            this.photoExtensions.Text = "Photo Extensions";
            this.photoExtensions.Width = 400;
            // 
            // videoExtListView
            // 
            this.videoExtListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoExtListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.videoExtensions});
            this.videoExtListView.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.videoExtListView.HideSelection = false;
            this.videoExtListView.Location = new System.Drawing.Point(35, 234);
            this.videoExtListView.Name = "videoExtListView";
            this.videoExtListView.Size = new System.Drawing.Size(266, 129);
            this.videoExtListView.TabIndex = 54;
            this.videoExtListView.UseCompatibleStateImageBehavior = false;
            this.videoExtListView.View = System.Windows.Forms.View.Details;
            // 
            // videoExtensions
            // 
            this.videoExtensions.Text = "Video Extensions";
            this.videoExtensions.Width = 210;
            // 
            // pathListView
            // 
            this.pathListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FolderPath});
            this.pathListView.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.pathListView.HideSelection = false;
            this.pathListView.Location = new System.Drawing.Point(35, 362);
            this.pathListView.Name = "pathListView";
            this.pathListView.Size = new System.Drawing.Size(600, 115);
            this.pathListView.TabIndex = 53;
            this.pathListView.UseCompatibleStateImageBehavior = false;
            this.pathListView.View = System.Windows.Forms.View.Details;
            // 
            // FolderPath
            // 
            this.FolderPath.Text = "Folder Path";
            this.FolderPath.Width = 600;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.historyFormToolStripMenuItem,
            this.frfreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 28);
            this.menuStrip1.TabIndex = 52;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("homeToolStripMenuItem.Image")));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.HomeToolStripMenuItem_Click);
            // 
            // historyFormToolStripMenuItem
            // 
            this.historyFormToolStripMenuItem.Checked = true;
            this.historyFormToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.historyFormToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("historyFormToolStripMenuItem.Image")));
            this.historyFormToolStripMenuItem.Name = "historyFormToolStripMenuItem";
            this.historyFormToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.historyFormToolStripMenuItem.Text = "History";
            this.historyFormToolStripMenuItem.Click += new System.EventHandler(this.HistoryFormToolStripMenuItem_Click);
            // 
            // frfreToolStripMenuItem
            // 
            this.frfreToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.frfreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraToolStripMenuItem,
            this.serverFormToolStripMenuItem});
            this.frfreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("frfreToolStripMenuItem.Image")));
            this.frfreToolStripMenuItem.Name = "frfreToolStripMenuItem";
            this.frfreToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.frfreToolStripMenuItem.Text = "Configuration";
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cameraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewConfigurationFormToolStripMenuItem,
            this.modifyConfigurationFormToolStripMenuItem});
            this.cameraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cameraToolStripMenuItem.Image")));
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cameraToolStripMenuItem.Text = "Camera";
            this.cameraToolStripMenuItem.Click += new System.EventHandler(this.CameraToolStripMenuItem_Click);
            // 
            // addNewConfigurationFormToolStripMenuItem
            // 
            this.addNewConfigurationFormToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addNewConfigurationFormToolStripMenuItem.Image = global::detectVideoApp.Properties.Resources.icons8_add_24;
            this.addNewConfigurationFormToolStripMenuItem.Name = "addNewConfigurationFormToolStripMenuItem";
            this.addNewConfigurationFormToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.addNewConfigurationFormToolStripMenuItem.Text = "Add Configuration";
            // 
            // modifyConfigurationFormToolStripMenuItem
            // 
            this.modifyConfigurationFormToolStripMenuItem.Image = global::detectVideoApp.Properties.Resources.icons8_edit_50;
            this.modifyConfigurationFormToolStripMenuItem.Name = "modifyConfigurationFormToolStripMenuItem";
            this.modifyConfigurationFormToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.modifyConfigurationFormToolStripMenuItem.Text = "Modify Configuration";
            this.modifyConfigurationFormToolStripMenuItem.Click += new System.EventHandler(this.ModifyConfigurationFormToolStripMenuItem_Click);
            // 
            // serverFormToolStripMenuItem
            // 
            this.serverFormToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("serverFormToolStripMenuItem.Image")));
            this.serverFormToolStripMenuItem.Name = "serverFormToolStripMenuItem";
            this.serverFormToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.serverFormToolStripMenuItem.Text = "Server";
            this.serverFormToolStripMenuItem.Click += new System.EventHandler(this.ServerToolStripMenuItem_Click);
            // 
            // NewConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(688, 582);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Name = "NewConfigurationForm";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.NewConfigurationForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button saveConfiguration;
        private System.Windows.Forms.TextBox addPhotoExteTxtBox;
        private System.Windows.Forms.Label enterVideoExtenLabel;
        private System.Windows.Forms.TextBox addVideoExteTxtBox;
        private System.Windows.Forms.Button browseFolderBtn;
        private System.Windows.Forms.Label enterPhotoExtenLabel;
        private System.Windows.Forms.Label enterCameraNameLabel;
        private System.Windows.Forms.TextBox cameraNameTxtBox;
        private System.Windows.Forms.Label browseFolderLabel;
        private System.Windows.Forms.TextBox folderPathTxtBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frfreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverFormToolStripMenuItem;
        private System.Windows.Forms.ListView pathListView;
        private System.Windows.Forms.ColumnHeader FolderPath;
        private System.Windows.Forms.ListView photoExtListView;
        private System.Windows.Forms.ColumnHeader photoExtensions;
        private System.Windows.Forms.ListView videoExtListView;
        private System.Windows.Forms.ColumnHeader videoExtensions;
        private System.Windows.Forms.Button addPhotoExtenBtn;
        private System.Windows.Forms.Button addVideoExtenBtn;
        private System.Windows.Forms.Button addFolderPathBtn;
        private System.Windows.Forms.Label cameraNameWarningLabel;
        private System.Windows.Forms.ToolStripMenuItem addNewConfigurationFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyConfigurationFormToolStripMenuItem;
    }
}