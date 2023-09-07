using System;
using System.Windows.Forms;

namespace detectVideoApp
{
    public partial class ServerConfigurationForm : Form
    {
        #region Members
        private FileService _xmlService;
        #endregion
        #region Constructors
        public ServerConfigurationForm()
        {
            _xmlService = new FileService();
            InitializeComponent();
        }
        #endregion
        #region Events
        private void DbSaveBtn_Click(object sender, EventArgs e)
        {
            _xmlService.WriteXmlFile(serverTxtBox.Text, dbTxtBox.Text);
        }
        private void DatabaseConfiguration_Load(object sender, EventArgs e)
        {
            DatabaseConfig db = _xmlService.ReadFromXmlFile();

            serverTxtBox.Text = db.ServerName;
            dbTxtBox.Text = db.DatabaseName;
        }
        private void newConfigurationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewConfigurationForm newConfigurationForm = new NewConfigurationForm();
            this.Hide();
            newConfigurationForm.ShowDialog();
        }
        private void ModifyCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurationForm configurationForm = new ConfigurationForm();
            this.Hide();
            configurationForm.ShowDialog();
        }
        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
        private void HistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            this.Hide();
            historyForm.ShowDialog(this);
        }
        #endregion

    }
}
