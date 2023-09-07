namespace detectVideoApp
{
    partial class ServerConfigurationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerConfigurationForm));
            this.serverTxtBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dbTxtBox = new System.Windows.Forms.TextBox();
            this.dbSaveBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frfreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newConfigurationFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyConfigurationFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverTxtBox
            // 
            this.serverTxtBox.Location = new System.Drawing.Point(34, 90);
            this.serverTxtBox.Name = "serverTxtBox";
            this.serverTxtBox.Size = new System.Drawing.Size(287, 22);
            this.serverTxtBox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dbTxtBox
            // 
            this.dbTxtBox.Location = new System.Drawing.Point(34, 153);
            this.dbTxtBox.Name = "dbTxtBox";
            this.dbTxtBox.Size = new System.Drawing.Size(287, 22);
            this.dbTxtBox.TabIndex = 2;
            // 
            // dbSaveBtn
            // 
            this.dbSaveBtn.Location = new System.Drawing.Point(396, 166);
            this.dbSaveBtn.Name = "dbSaveBtn";
            this.dbSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.dbSaveBtn.TabIndex = 5;
            this.dbSaveBtn.Text = "save";
            this.dbSaveBtn.UseVisualStyleBackColor = true;
            this.dbSaveBtn.Click += new System.EventHandler(this.DbSaveBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.frfreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(528, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HomeToolStripMenuItem
            // 
            this.HomeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("HomeToolStripMenuItem.Image")));
            this.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem";
            this.HomeToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.HomeToolStripMenuItem.Text = "Home";
            this.HomeToolStripMenuItem.Click += new System.EventHandler(this.HomeToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("historyToolStripMenuItem.Image")));
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.HistoryToolStripMenuItem_Click);
            // 
            // frfreToolStripMenuItem
            // 
            this.frfreToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.frfreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraToolStripMenuItem,
            this.serverToolStripMenuItem});
            this.frfreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("frfreToolStripMenuItem.Image")));
            this.frfreToolStripMenuItem.Name = "frfreToolStripMenuItem";
            this.frfreToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.frfreToolStripMenuItem.Text = "Configuration";
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newConfigurationFormToolStripMenuItem,
            this.modifyConfigurationFormToolStripMenuItem});
            this.cameraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cameraToolStripMenuItem.Image")));
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cameraToolStripMenuItem.Text = "Camera";
            // 
            // newConfigurationFormToolStripMenuItem
            // 
            this.newConfigurationFormToolStripMenuItem.Image = global::detectVideoApp.Properties.Resources.icons8_add_24;
            this.newConfigurationFormToolStripMenuItem.Name = "newConfigurationFormToolStripMenuItem";
            this.newConfigurationFormToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.newConfigurationFormToolStripMenuItem.Text = "Add Configuration";
            this.newConfigurationFormToolStripMenuItem.Click += new System.EventHandler(this.newConfigurationFormToolStripMenuItem_Click);
            // 
            // modifyConfigurationFormToolStripMenuItem
            // 
            this.modifyConfigurationFormToolStripMenuItem.Image = global::detectVideoApp.Properties.Resources.icons8_edit_50;
            this.modifyConfigurationFormToolStripMenuItem.Name = "modifyConfigurationFormToolStripMenuItem";
            this.modifyConfigurationFormToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.modifyConfigurationFormToolStripMenuItem.Text = "Modify Configuration";
            this.modifyConfigurationFormToolStripMenuItem.Click += new System.EventHandler(this.ModifyCameraToolStripMenuItem_Click);
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.serverToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("serverToolStripMenuItem.Image")));
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(23, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 55);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(23, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 55);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database";
            // 
            // ServerConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 216);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dbSaveBtn);
            this.Controls.Add(this.dbTxtBox);
            this.Controls.Add(this.serverTxtBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ServerConfigurationForm";
            this.Text = "Server Configuration";
            this.Load += new System.EventHandler(this.DatabaseConfiguration_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverTxtBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox dbTxtBox;
        private System.Windows.Forms.Button dbSaveBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frfreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem newConfigurationFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyConfigurationFormToolStripMenuItem;
    }
}