using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace detectVideoApp
{
    public partial class MainForm : Form
    {
        #region Members
        private CameraConfigurationDbService _configDbService;
        private FileMonitoringService _fileMonitoringService;
        List<FileMonitoringService> activeCameras = new List<FileMonitoringService>();
        private NewConfigurationForm _newConfigurationForm;

        #endregion

        #region Constructors
        public MainForm()
        {

            InitializeComponent();
            _configDbService = new CameraConfigurationDbService();
            _newConfigurationForm = new NewConfigurationForm();

        }

        #endregion

        #region Events
        public void CreatedFile(object sender, FileMonitoringDetails e)
        {

            MonitoringDetailsDataGridView.Invoke(new Action(delegate ()
            {
                int rowId = MonitoringDetailsDataGridView.Rows.Add();

                DataGridViewRow row = MonitoringDetailsDataGridView.Rows[rowId];

                row.Cells[0].Value = e.Camera;
                row.Cells[1].Value = e.Action;
                row.Cells[2].Value = e.Path;
                row.Cells[3].Value = e.Name;
                row.Cells[4].Value = e.TimeStamp.ToString();

            }));
        }
        private void SetActiveCamera_Load(object sender, EventArgs e)
        {
            _newConfigurationForm.NewConfigurationCreatedNotify += UpdateAvailablesCamera_NewConfigurationAdded;

            PopulateCheckListBoxWithCameraNames();
            availableCamerasCheckListBox.Visible = false;
            MonitoringDetailsDataGridView.Visible = false;
            statusRunning.Visible = false;
            statusStopped.Visible = true;
            MonitoringDetailsDataGridView.ColumnCount = 5;
            MonitoringDetailsDataGridView.Columns[0].HeaderText = "Camera";
            MonitoringDetailsDataGridView.Columns[1].HeaderText = "Action";
            MonitoringDetailsDataGridView.Columns[2].HeaderText = "Folder Path";
            MonitoringDetailsDataGridView.Columns[3].HeaderText = "File Name";
            MonitoringDetailsDataGridView.Columns[4].HeaderText = "Timestamp";

            MonitoringDetailsDataGridView.Columns[0].Width = 150;
            MonitoringDetailsDataGridView.Columns[1].Width = 150;
            MonitoringDetailsDataGridView.Columns[2].Width = 220;
            MonitoringDetailsDataGridView.Columns[3].Width = 150;
            MonitoringDetailsDataGridView.Columns[4].Width = 150;

        }
        private void StartMonitoring_Click(object sender, EventArgs e)
        {
            MonitoringDetailsDataGridView.Visible = true;

            if (availableCamerasCheckListBox.CheckedItems.Count <= 0)
            {
                MonitoringDetailsDataGridView.Visible = false;

                MessageBox.Show("please choose at least one camera to start monitoring");
            }
            availableCamerasCheckListBox.CheckOnClick = true;

            foreach (var item in availableCamerasCheckListBox.CheckedItems)
            {
                var configuration = _configDbService.ReadFromDb_Configuration_InSingleDetail(item.ToString());

                String[] paths = configuration.folderPath.Split(',');
                for (int i = 0; i < paths.Length; i++)
                {
                    _fileMonitoringService = new FileMonitoringService(item.ToString(), configuration.id, paths[i], configuration.videoExtensions + "" + configuration.photoExtensions);
                    activeCameras.Add(_fileMonitoringService);
                    _fileMonitoringService.MonitoringDetailNotify += CreatedFile;
                    _configDbService.UpdateDb_SetActiveCamera_Configuration(item.ToString());
                }
                statusRunning.Visible = true;
                statusStopped.Visible = false;
            }
        }
        private void EndMonitoring_Click(object sender, EventArgs e)
        {
            MonitoringDetailsDataGridView.Visible = false;

            statusRunning.Visible = false;
            statusStopped.Visible = true;
            FileMonitoringService fileMonitoringService = new FileMonitoringService(stopMonitoring: true);
            for (int i = 0; i < availableCamerasCheckListBox.Items.Count; i++)
            {
                availableCamerasCheckListBox.SetItemChecked(i, false);
            }
            if (MonitoringDetailsDataGridView.Rows.Count > 0)
            {
                MonitoringDetailsDataGridView.DataSource = null;
                MonitoringDetailsDataGridView.Rows.Clear();

            }
        }
        private void AvailableCamerasBtn_Click(object sender, EventArgs e)
        {
            if (availableCamerasCheckListBox.Visible)
            {
                availableCamerasCheckListBox.Visible = false;
                availableCamerasBtn.BackColor = SystemColors.Control;

            }
            else
            {
                availableCamerasCheckListBox.Visible = true;
                availableCamerasBtn.BackColor = Color.White;
            }
        }
        private void AddNewConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _newConfigurationForm.ShowDialog();
        }
        private void ModifyConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurationForm configurationForm = new ConfigurationForm();
            configurationForm.ShowDialog();
        }
        private void HistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.ShowDialog();
        }
        private void ServerStripMenuItem_Click(object sender, EventArgs e)
        {
            ServerConfigurationForm serverConfigurationForm = new ServerConfigurationForm();
            serverConfigurationForm.ShowDialog();
        }
        #endregion

        private void UpdateAvailablesCamera_NewConfigurationAdded(object sender, NewConfiguration e)
        {
            if (e.IsCreated)
            {
                PopulateCheckListBoxWithCameraNames();

            }
        }

        /// <summary>
        /// Sets active cameras in checkboxlist as checked by default
        /// </summary>
        public void SetDefalutValuesForCheckBoxList()
        {
            var activeCameras = _configDbService.ReadFromDb_ActiveCameras();
            if (activeCameras != null)
            {
                for (int i = 0; i < activeCameras.Count; i++)
                {
                    for (int j = 0; j < availableCamerasCheckListBox.Items.Count; j++)
                    {
                        if (activeCameras[i] == availableCamerasCheckListBox.Items[j].ToString())
                        {
                            availableCamerasCheckListBox.SetItemChecked(j, true);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Adds camera names to checkboxlist from database
        /// </summary>
        private void PopulateCheckListBoxWithCameraNames()
        {
            availableCamerasCheckListBox.Items.Clear();
            availableCamerasCheckListBox.CheckOnClick = true;
            DataTable cameras = _configDbService.ReadFromDb_AllCameraNames();

            int i = 0;
            foreach (DataRow row in cameras.Rows)
            {

                availableCamerasCheckListBox.Items.Insert(i, cameras.Rows[i]["camera_name"].ToString());
                i++;
            }
            SetDefalutValuesForCheckBoxList();
        }

    }
}
