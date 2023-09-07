namespace detectVideoApp
{
    partial class ConfigurationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.configurationDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkToAddNewConfigurationFormBtn = new System.Windows.Forms.Button();
            this.displayExistingCamerasComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configurationDetailDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.configurationDetailDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(14, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 326);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Configuration";
            // 
            // configurationDetailDataGridView
            // 
            this.configurationDetailDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configurationDetailDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.configurationDetailDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.configurationDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.configurationDetailDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.configurationDetailDataGridView.Location = new System.Drawing.Point(18, 36);
            this.configurationDetailDataGridView.Name = "configurationDetailDataGridView";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.configurationDetailDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.configurationDetailDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.configurationDetailDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.configurationDetailDataGridView.RowTemplate.Height = 24;
            this.configurationDetailDataGridView.Size = new System.Drawing.Size(666, 268);
            this.configurationDetailDataGridView.TabIndex = 24;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.linkToAddNewConfigurationFormBtn);
            this.groupBox3.Controls.Add(this.displayExistingCamerasComboBox);
            this.groupBox3.Location = new System.Drawing.Point(14, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(708, 81);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Available Cameras";
            // 
            // linkToAddNewConfigurationFormBtn
            // 
            this.linkToAddNewConfigurationFormBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkToAddNewConfigurationFormBtn.AutoSize = true;
            this.linkToAddNewConfigurationFormBtn.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.linkToAddNewConfigurationFormBtn.Location = new System.Drawing.Point(386, 37);
            this.linkToAddNewConfigurationFormBtn.Name = "linkToAddNewConfigurationFormBtn";
            this.linkToAddNewConfigurationFormBtn.Size = new System.Drawing.Size(147, 27);
            this.linkToAddNewConfigurationFormBtn.TabIndex = 38;
            this.linkToAddNewConfigurationFormBtn.Text = "New Configuration";
            this.linkToAddNewConfigurationFormBtn.UseVisualStyleBackColor = true;
            this.linkToAddNewConfigurationFormBtn.Click += new System.EventHandler(this.LinkToAddNewConfigurationFormBtn_Click);
            // 
            // displayExistingCamerasComboBox
            // 
            this.displayExistingCamerasComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayExistingCamerasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.displayExistingCamerasComboBox.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.displayExistingCamerasComboBox.FormattingEnabled = true;
            this.displayExistingCamerasComboBox.Location = new System.Drawing.Point(74, 37);
            this.displayExistingCamerasComboBox.Name = "displayExistingCamerasComboBox";
            this.displayExistingCamerasComboBox.Size = new System.Drawing.Size(306, 25);
            this.displayExistingCamerasComboBox.TabIndex = 37;
            this.displayExistingCamerasComboBox.SelectionChangeCommitted += new System.EventHandler(this.DisplayExistingCamerasComboBox_SelectionChangeCommitted);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.configurationStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(477, 28);
            this.menuStrip1.TabIndex = 53;
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
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Checked = true;
            this.historyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.historyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("historyToolStripMenuItem.Image")));
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.HistoryToolStripMenuItem_Click);
            // 
            // configurationStripMenuItem
            // 
            this.configurationStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.configurationStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraToolStripMenuItem,
            this.serverToolStripMenuItem});
            this.configurationStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("configurationStripMenuItem.Image")));
            this.configurationStripMenuItem.Name = "configurationStripMenuItem";
            this.configurationStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.configurationStripMenuItem.Text = "Configuration";
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cameraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addConfigurationToolStripMenuItem,
            this.modifyConfigurationToolStripMenuItem});
            this.cameraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cameraToolStripMenuItem.Image")));
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cameraToolStripMenuItem.Text = "Camera";
            // 
            // addConfigurationToolStripMenuItem
            // 
            this.addConfigurationToolStripMenuItem.Image = global::detectVideoApp.Properties.Resources.icons8_add_24;
            this.addConfigurationToolStripMenuItem.Name = "addConfigurationToolStripMenuItem";
            this.addConfigurationToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.addConfigurationToolStripMenuItem.Text = "Add Configuration";
            this.addConfigurationToolStripMenuItem.Click += new System.EventHandler(this.AddConfigurationToolStripMenuItem_Click);
            // 
            // modifyConfigurationToolStripMenuItem
            // 
            this.modifyConfigurationToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.modifyConfigurationToolStripMenuItem.Image = global::detectVideoApp.Properties.Resources.icons8_edit_50;
            this.modifyConfigurationToolStripMenuItem.Name = "modifyConfigurationToolStripMenuItem";
            this.modifyConfigurationToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.modifyConfigurationToolStripMenuItem.Text = "Modify Configuration";
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("serverToolStripMenuItem.Image")));
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.serverToolStripMenuItem.Text = "Server";
            this.serverToolStripMenuItem.Click += new System.EventHandler(this.ServerToolStripMenuItem_Click);
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(744, 478);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Name = "ConfigurationForm";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.configurationDetailDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView configurationDetailDataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox displayExistingCamerasComboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.Button linkToAddNewConfigurationFormBtn;
        private System.Windows.Forms.ToolStripMenuItem addConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyConfigurationToolStripMenuItem;
    }
}