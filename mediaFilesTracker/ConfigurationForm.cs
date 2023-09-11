using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace detectVideoApp
{
    public partial class ConfigurationForm : Form
    {

        #region Cosntructors
        public ConfigurationForm()
        {
            InitializeComponent();
            _configDbService = new CameraConfigurationDbService();
            _newConfigurationForm = new NewConfigurationForm();
            _configurationModificationDbService = new ConfigurationModificationHistoryDbService();
        }
        #region Members
        private CameraConfigurationDbService _configDbService;
        NewConfigurationForm _newConfigurationForm;
        private ConfigurationModificationHistoryDbService _configurationModificationDbService;


        #endregion
        #endregion
        #region Events
        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            _newConfigurationForm.NewConfigurationCreatedNotify += AddNewCameraInComboBox;

            FillComboboxWtihCameraNames();
            if (displayExistingCamerasComboBox.Items.Count > 0)
            {
                displayExistingCamerasComboBox.SelectedIndex = 0;
                var selectedCameraConfiguration = _configDbService.ReadFromDb_Configuration_InSingleDetail(displayExistingCamerasComboBox.GetItemText(displayExistingCamerasComboBox.SelectedItem));
                string selectedCameraNameExistingFolderPaths = selectedCameraConfiguration.folderPath;
                string selectedCameraNameExistingVideoExtensions = selectedCameraConfiguration.videoExtensions;
                string selectedCameraNameExistingPhotoExtensions = selectedCameraConfiguration.photoExtensions;
                CreateCustomDatagridViewForConfigurationDetails(selectedCameraNameExistingFolderPaths, selectedCameraNameExistingVideoExtensions, selectedCameraNameExistingPhotoExtensions);
            }
        }
        private void ConfigurationDetailsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (configurationDetailDataGridView.Rows.Count > 1)
            {
                var cameraName = displayExistingCamerasComboBox.SelectedItem.ToString();

                var insertedValue = configurationDetailDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString();

                if (e.ColumnIndex == 1)
                {
                    //video validation and addding new video extension 

                    string existingVideoExtensions = _configDbService.ReadFromDb_Configuration_InSingleDetail(cameraName).videoExtensions;

                    if (FileService.IsVideo(insertedValue))
                    {
                        if (existingVideoExtensions.Contains(insertedValue.ToLower()))
                        {
                            MessageBox.Show(insertedValue + " is alredy entered");
                        }
                        else
                        {
                            _configurationModificationDbService.WriteToDb_Configuration_Modification(cameraName: cameraName, videoExtension: insertedValue.ToLower());
                            _configDbService.UpdateDb_Configuration(cameraName: cameraName, videoExtension: existingVideoExtensions + " " + insertedValue.ToLower());
                        }
                    }
                    else
                    {
                        MessageBox.Show("insert a valid extension");
                    }

                }
                else if (e.ColumnIndex == 2)
                {
                    //photo validation and addding new extension 

                    string existingPhotoExtensions = _configDbService.ReadFromDb_Configuration_InSingleDetail(cameraName).photoExtensions;
                    if (FileService.IsImage(insertedValue))
                    {
                        if (existingPhotoExtensions.Contains(insertedValue))
                        {
                            MessageBox.Show(insertedValue + " is alredy entered");
                        }
                        else
                        {

                            _configurationModificationDbService.WriteToDb_Configuration_Modification(cameraName: cameraName, photoExtension: insertedValue);
                            _configDbService.UpdateDb_Configuration(cameraName: cameraName, photoExtension: existingPhotoExtensions + " " + insertedValue.ToLower());
                        }
                    }
                    else
                    {
                        MessageBox.Show("insert a valid extension");
                    }
                }
                else
                {
                    //folder validation and addding new folder  
                    if (System.IO.Directory.Exists(insertedValue))
                    {
                        String existingFolderPaths = _configDbService.ReadFromDb_Configuration_InSingleDetail(cameraName).folderPath;
                        if (existingFolderPaths.ToLower().Contains(insertedValue.ToLower()))
                        {
                            MessageBox.Show(insertedValue + " is alredy entered");

                        }
                        else
                        {
                            _configurationModificationDbService.WriteToDb_Configuration_Modification(cameraName: cameraName, folderPath: insertedValue);
                            _configDbService.UpdateDb_Configuration(cameraName: cameraName, folderPath: existingFolderPaths + "," + insertedValue);

                        }
                    }
                    else
                    {
                        MessageBox.Show("insert a valid path");
                    }
                }
            }

        }
        private void LinkToAddNewConfigurationFormBtn_Click(object sender, EventArgs e)
        {
            _newConfigurationForm.ShowDialog();

            if (_newConfigurationForm._HomeClicked)
            {
                this.Hide();
            }
        }
        private void DisplayExistingCamerasComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            configurationDetailDataGridView.Rows.Clear();

            if (!string.IsNullOrEmpty(displayExistingCamerasComboBox.GetItemText(displayExistingCamerasComboBox.SelectedItem)))
            {

                var selectedCameraName = _configDbService.ReadFromDb_Configuration_InSingleDetail(displayExistingCamerasComboBox.SelectedItem.ToString());
                string selectedCameraNameExistingFolderPaths = selectedCameraName.folderPath;
                string selectedCameraNameExistingVideoExtensions = selectedCameraName.videoExtensions;
                string selectedCameraNameExistingPhotoExtensions = selectedCameraName.photoExtensions;
                CreateCustomDatagridViewForConfigurationDetails(selectedCameraNameExistingFolderPaths, selectedCameraNameExistingVideoExtensions, selectedCameraNameExistingPhotoExtensions);


            }
        }
        public void FillComboboxWtihCameraNames()
        {
            displayExistingCamerasComboBox.Items.Clear();
            DataTable cameras = _configDbService.ReadFromDb_AllCameraNames();

            foreach (DataRow row in cameras.Rows)
            {
                displayExistingCamerasComboBox.Items.Add(row["camera_name"]);

            }
        }
        public void CreateCustomDatagridViewForConfigurationDetails(string folderPath, string videoExtension, string photoExtension)
        {
            var folderPathList = folderPath.Split(',').ToList();
            var videoExtensionsList = videoExtension.Split(' ').ToList();
            var photoExtensionsList = photoExtension.ToString().Split(' ').ToList();


            configurationDetailDataGridView.ColumnCount = 3;

            configurationDetailDataGridView.Columns[0].Name = "Folder Paths";
            configurationDetailDataGridView.Columns[1].Name = "Video Extensions";
            configurationDetailDataGridView.Columns[2].Name = "Photo Extensions";
            configurationDetailDataGridView.Columns[0].Width = 420;
            configurationDetailDataGridView.Columns[1].Width = 100;
            configurationDetailDataGridView.Columns[2].Width = 100;


            configurationDetailDataGridView.RowCount = Math.Max(folderPathList.Count, Math.Max(videoExtensionsList.Count, photoExtensionsList.Count)) + 1;

            this.configurationDetailDataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.ConfigurationDetailsDataGridView_CellValueChanged);
            for (int i = 0; i < folderPathList.Count; i++)
            {
                configurationDetailDataGridView.Rows[i].Cells["Folder Paths"].Value = folderPathList.ElementAt(i);

            }
            for (int i = 0; i < videoExtensionsList.Count; i++)
            {
                configurationDetailDataGridView.Rows[i].Cells["Video Extensions"].Value = videoExtensionsList.ElementAt(i);

            }
            for (int i = 0; i < photoExtensionsList.Count; i++)
            {
                configurationDetailDataGridView.Rows[i].Cells["Photo Extensions"].Value = photoExtensionsList.ElementAt(i);

            }
            this.configurationDetailDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ConfigurationDetailsDataGridView_CellValueChanged);
        }
        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void AddNewCameraInComboBox(object sender, NewConfiguration e)
        {
            if (e.IsCreated)
            {
                FillComboboxWtihCameraNames();

            }
        }

        private void AddConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _newConfigurationForm.ShowDialog();
        }

        private void ServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServerConfigurationForm serverConfigurationForm = new ServerConfigurationForm();
            this.Hide();
            serverConfigurationForm.ShowDialog();
        }

        private void HistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            this.Hide();
            historyForm.ShowDialog();

        }
    }
    #endregion

}
