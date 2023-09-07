using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace detectVideoApp
{
    public partial class NewConfigurationForm : Form
    {
        #region Members
        private CameraConfigurationDbService _configDbService;
        public event EventHandler<NewConfiguration> NewConfigurationCreatedNotify;

        List<string> VideoExtenList = new List<string>();
        List<string> PhotoExtenList = new List<string>();
        List<string> folderPathList = new List<string>();
        public bool _HomeClicked = false;
        #endregion

        #region Cosntructors
        public NewConfigurationForm()
        {
            InitializeComponent();
            _configDbService = new CameraConfigurationDbService();

        }
        #endregion

        #region Events

        // browse folder button
        private void BrowseFolderBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPathTxtBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        /// <summary>
        /// Adds new configuration to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveConfiguration_Click(object sender, EventArgs e)
        {


            if (cameraNameTxtBox.Text == "")
            {
                MessageBox.Show("insert camera");
            }
            else if (folderPathList.Count == 0)
            {
                MessageBox.Show("select folder");
            }
            else if (_configDbService.ReadFromDb_Configuration_InSingleDetail(cameraNameTxtBox.Text.ToString()).name.ToLower() == cameraNameTxtBox.Text.ToString().ToLower())
            {
                MessageBox.Show(cameraNameTxtBox.Text + " is alredy entered, please insert another camera name");

            }
            else
            {
                _configDbService.WriteToDb_NewConfiguration(camera: cameraNameTxtBox.Text, folderPath: string.Join(",", folderPathList), videoExtensions: string.Join(" ", VideoExtenList), photoExtensions: string.Join(" ", PhotoExtenList));

                //call event
                OnNewConfigurationCreated(new NewConfiguration(true));
                SuccesDialog succesDialog = new SuccesDialog();
                succesDialog.ShowDialog();
                VideoExtenList.Clear();
                PhotoExtenList.Clear();
                folderPathList.Clear();
                photoExtListView.Clear();
                videoExtListView.Clear();
                pathListView.Clear();
                cameraNameTxtBox.Text = "";
            }
        }
        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _HomeClicked = true;
            this.Hide();

        }
        private void HistoryFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryForm history = new HistoryForm();
            this.Hide();
            history.ShowDialog();
        }
        private void FolderPathTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            AddFolderPath();
        }
        private void AddVideoExteTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddVideoExtension();
            }
        }
        private void AddPhotoExteTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddPhotoExtension();
            }
        }
        private void ServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServerConfigurationForm configurationForm = new ServerConfigurationForm();
            this.Hide();
            configurationForm.ShowDialog();
        }
        private void CameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
        private void AddVideoExtenBtn_Click(object sender, EventArgs e)
        {
            AddVideoExtension();
        }
        private void AddPhotoExtenBtn_Click(object sender, EventArgs e)
        {
            AddPhotoExtension();
        }
        private void AddFolderPathBtn_Click(object sender, EventArgs e)
        {
            AddFolderPath();
        }
        protected virtual void OnNewConfigurationCreated(NewConfiguration e)
        {
            NewConfigurationCreatedNotify?.Invoke(this, e);

        }
        private void NewConfigurationForm_Load(object sender, EventArgs e)
        {
            cameraNameWarningLabel.Visible = false;

        }
        private void CameraNameTxtBox_TextChanged(object sender, EventArgs e)
        {

            if (cameraNameTxtBox.Text.ToString() != "" && _configDbService.ReadFromDb_Configuration_InSingleDetail(cameraNameTxtBox.Text.ToString()).name.ToLower() == cameraNameTxtBox.Text.ToString().ToLower())
            {
                cameraNameWarningLabel.Visible = true;

            }
            else if (cameraNameTxtBox.Text.ToString() == " ")
            {
                cameraNameWarningLabel.Visible = false;

            }
            else
            {
                cameraNameWarningLabel.Visible = false;

            }
        }
        #endregion

        /// <summary>
        /// Adds the folder path value provided by user to the list only if the path is valid and doesn't already exist in the list.
        /// </summary>
        public void AddFolderPath()
        {
            if (Directory.Exists(folderPathTxtBox.Text))
            {
                if (!folderPathList.Contains(folderPathTxtBox.Text.ToLower()))
                {
                    ListViewItem lvi = new ListViewItem(folderPathTxtBox.Text);
                    pathListView.Items.Add(lvi);
                    folderPathList.Add(folderPathTxtBox.Text.Trim());
                    folderPathTxtBox.Text = "";
                }
                else
                {
                    MessageBox.Show(folderPathTxtBox.Text + " was alredy entered");
                    folderPathTxtBox.Text = "";

                }

            }
            else
            {
                MessageBox.Show(folderPathTxtBox.Text + " doesn't exist");

            }
        }

        /// <summary>
        ///  Adds the video extension provided by the user to a list only if the extension is valid and doesn't already exist in the list
        /// </summary>
        public void AddVideoExtension()
        {
            if (addVideoExteTxtBox.Text != "")
            {
                if (FileService.IsVideo(addVideoExteTxtBox.Text.ToLower()))
                {

                    if (!VideoExtenList.Contains(addVideoExteTxtBox.Text.ToLower()))
                    {
                        ListViewItem lvi = new ListViewItem(addVideoExteTxtBox.Text);
                        videoExtListView.Items.Add(lvi);
                        VideoExtenList.Add(addVideoExteTxtBox.Text.ToLower());
                        addVideoExteTxtBox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(addVideoExteTxtBox.Text + " was alredy entered");
                        addVideoExteTxtBox.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show("insert valid video extension");
                    // WarningDialog warningDialog = new WarningDialog("insert valid video extension");
                    MessageBox.Show("Insert valid extension");
                    // warningDialog.ShowDialog();
                }
            }

        }
        /// <summary>
        ///  Adds the photo extension provided by the user to a list only if the extension is valid and doesn't already exist in the list
        /// </summary>
        public void AddPhotoExtension()
        {
            if (addPhotoExteTxtBox.Text != "")
            {

                if (FileService.IsImage(addPhotoExteTxtBox.Text.ToLower()))
                {
                    if (!PhotoExtenList.Contains(addPhotoExteTxtBox.Text.ToLower()))
                    {
                        ListViewItem lvi = new ListViewItem(addPhotoExteTxtBox.Text.ToLower());
                        photoExtListView.Items.Add(lvi);
                        PhotoExtenList.Add(addPhotoExteTxtBox.Text);
                        addPhotoExteTxtBox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(addPhotoExteTxtBox.Text + " was alredy entered");
                        addPhotoExteTxtBox.Text = "";


                    }

                }
                else
                {
                    MessageBox.Show("insert valid photo extension");
                }
            }

        }

        private void ModifyConfigurationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurationForm configurationForm = new ConfigurationForm();
            this.Hide();
            configurationForm.ShowDialog();
        }
    }
}


