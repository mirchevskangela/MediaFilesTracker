namespace detectVideoApp
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frfreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getHistoryBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.chooseHistoryComboBox = new System.Windows.Forms.ComboBox();
            this.displayHistoryDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayHistoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(2, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.getHistoryBtn);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.toDateTimePicker);
            this.splitContainer1.Panel1.Controls.Add(this.fromDateTimePicker);
            this.splitContainer1.Panel1.Controls.Add(this.chooseHistoryComboBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.displayHistoryDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1426, 605);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.frfreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1426, 28);
            this.menuStrip1.TabIndex = 20;
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
            this.historyToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.historyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.historyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("historyToolStripMenuItem.Image")));
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // frfreToolStripMenuItem
            // 
            this.frfreToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
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
            this.addCameraToolStripMenuItem,
            this.modifyCameraToolStripMenuItem});
            this.cameraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cameraToolStripMenuItem.Image")));
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.cameraToolStripMenuItem.Text = "Camera";
            // 
            // addCameraToolStripMenuItem
            // 
            this.addCameraToolStripMenuItem.Image = global::detectVideoApp.Properties.Resources.icons8_add_24;
            this.addCameraToolStripMenuItem.Name = "addCameraToolStripMenuItem";
            this.addCameraToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.addCameraToolStripMenuItem.Text = "Add Configuration";
            this.addCameraToolStripMenuItem.Click += new System.EventHandler(this.AddCameraToolStripMenuItem_Click);
            // 
            // modifyCameraToolStripMenuItem
            // 
            this.modifyCameraToolStripMenuItem.Image = global::detectVideoApp.Properties.Resources.icons8_edit_50;
            this.modifyCameraToolStripMenuItem.Name = "modifyCameraToolStripMenuItem";
            this.modifyCameraToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.modifyCameraToolStripMenuItem.Text = "Modify Configuration";
            this.modifyCameraToolStripMenuItem.Click += new System.EventHandler(this.ModifyCameraToolStripMenuItem_Click);
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("serverToolStripMenuItem.Image")));
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.serverToolStripMenuItem.Text = "Server";
            this.serverToolStripMenuItem.Click += new System.EventHandler(this.ServerToolStripMenuItem_Click);
            // 
            // getHistoryBtn
            // 
            this.getHistoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getHistoryBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.getHistoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.getHistoryBtn.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getHistoryBtn.Location = new System.Drawing.Point(1289, 205);
            this.getHistoryBtn.Name = "getHistoryBtn";
            this.getHistoryBtn.Size = new System.Drawing.Size(84, 26);
            this.getHistoryBtn.TabIndex = 19;
            this.getHistoryBtn.Text = "view";
            this.getHistoryBtn.UseVisualStyleBackColor = false;
            this.getHistoryBtn.Click += new System.EventHandler(this.GetHistoryBtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label3.Location = new System.Drawing.Point(27, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "TO:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "FROM:";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm:ss tt";
            this.toDateTimePicker.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDateTimePicker.Location = new System.Drawing.Point(30, 149);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(304, 24);
            this.toDateTimePicker.TabIndex = 13;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fromDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm:ss tt";
            this.fromDateTimePicker.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDateTimePicker.Location = new System.Drawing.Point(30, 105);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(304, 24);
            this.fromDateTimePicker.TabIndex = 12;
            // 
            // chooseHistoryComboBox
            // 
            this.chooseHistoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseHistoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseHistoryComboBox.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.chooseHistoryComboBox.FormattingEnabled = true;
            this.chooseHistoryComboBox.Items.AddRange(new object[] {
            "Camera Configuration",
            "Monitoring Report"});
            this.chooseHistoryComboBox.Location = new System.Drawing.Point(30, 54);
            this.chooseHistoryComboBox.Name = "chooseHistoryComboBox";
            this.chooseHistoryComboBox.Size = new System.Drawing.Size(304, 25);
            this.chooseHistoryComboBox.TabIndex = 0;
            this.chooseHistoryComboBox.SelectedIndexChanged += new System.EventHandler(this.ChooseHistoryComboBox_SelectedIndexChanged);
            // 
            // displayHistoryDataGridView
            // 
            this.displayHistoryDataGridView.AllowUserToAddRows = false;
            this.displayHistoryDataGridView.AllowUserToDeleteRows = false;
            this.displayHistoryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayHistoryDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.displayHistoryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayHistoryDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.displayHistoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.displayHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.displayHistoryDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.displayHistoryDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.displayHistoryDataGridView.Location = new System.Drawing.Point(10, 3);
            this.displayHistoryDataGridView.Name = "displayHistoryDataGridView";
            this.displayHistoryDataGridView.RowHeadersWidth = 51;
            this.displayHistoryDataGridView.RowTemplate.Height = 24;
            this.displayHistoryDataGridView.Size = new System.Drawing.Size(1404, 337);
            this.displayHistoryDataGridView.TabIndex = 0;
            this.displayHistoryDataGridView.VirtualMode = true;
            this.displayHistoryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DisplayHistoryDataGridView_CellContentClick);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 602);
            this.Controls.Add(this.splitContainer1);
            this.Name = "HistoryForm";
            this.Text = "History";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayHistoryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView displayHistoryDataGridView;
        private System.Windows.Forms.ComboBox chooseHistoryComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Button getHistoryBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frfreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyCameraToolStripMenuItem;
    }
}