using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace detectVideoApp
{
    public partial class HistoryForm : Form
    {
        #region members
        private FileMonitoringDbService _fileMonitorDbService;
        private CameraConfigurationDbService _cameraConfigDbService;
        private ConfigurationModificationHistoryDbService _configurationModificationDbService;
        #endregion
        #region constructor
        public HistoryForm()
        {
            InitializeComponent();
            _fileMonitorDbService = new FileMonitoringDbService();
            _cameraConfigDbService = new CameraConfigurationDbService();
            _configurationModificationDbService = new ConfigurationModificationHistoryDbService();
            chooseHistoryComboBox.SelectedIndex = 0;

        }
        #endregion

        #region Members
        private void GetHistoryBtn_Click(object sender, EventArgs e)
        {
            if (displayHistoryDataGridView.Rows.Count > 0)
            {
                displayHistoryDataGridView.DataSource = null;
                displayHistoryDataGridView.Rows.Clear();

            }
            if (displayHistoryDataGridView.Columns.Contains("openFile"))
            {
                displayHistoryDataGridView.Columns.Remove("openFile");
            }
            displayHistoryDataGridView.ReadOnly = true;

            if (chooseHistoryComboBox.Text == "")
            {
                MessageBox.Show("Select History");
            }
            else
            {

                if (!string.IsNullOrEmpty(chooseHistoryComboBox.GetItemText(chooseHistoryComboBox.SelectedItem)) && (String)chooseHistoryComboBox.SelectedItem == "Monitoring Report")
                {
                    try
                    {

                        var monitoringReportBetweenTwoDates = _fileMonitorDbService.ReadFromDb_MonitoringDetails_BetweenDates(DateTime.Parse(fromDateTimePicker.Text), DateTime.Parse(toDateTimePicker.Text));
                        var closestMonitoringDetailBasedOnGivenFromDate = _fileMonitorDbService.ReadFromDb_ClosestMonitoringDetail(DateTime.Parse(fromDateTimePicker.Text));



                        if (closestMonitoringDetailBasedOnGivenFromDate.Rows.Count > 0)
                        {

                            if (!DataTableService.CheckIfValueExist(monitoringReportBetweenTwoDates, closestMonitoringDetailBasedOnGivenFromDate.Rows[0]["end_timestamp"].ToString())
                                && DateCalculator.IsBetweenTwoDates(date: (DateTime)closestMonitoringDetailBasedOnGivenFromDate.Rows[0]["end_timestamp"], fromDate: DateTime.Parse(fromDateTimePicker.Text), toDate: DateTime.Parse(toDateTimePicker.Text))
                                && DateTime.Parse(fromDateTimePicker.Text) > (DateTime)closestMonitoringDetailBasedOnGivenFromDate.Rows[0]["start_timestamp"] &&
                                DateTime.Parse(fromDateTimePicker.Text) < (DateTime)closestMonitoringDetailBasedOnGivenFromDate.Rows[0]["end_timestamp"])
                            {

                                monitoringReportBetweenTwoDates.Merge(closestMonitoringDetailBasedOnGivenFromDate);

                            }
                        }

                        displayHistoryDataGridView.DataSource = monitoringReportBetweenTwoDates;

                        if (!displayHistoryDataGridView.Columns.Contains("openFile"))
                        {
                            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                            btn.HeaderText = "media_files";
                            btn.Name = "openFile";
                            btn.Text = "open";
                            btn.UseColumnTextForButtonValue = true;
                            displayHistoryDataGridView.Columns.Add(btn);
                        }
                        displayHistoryDataGridView.Columns[0].Width = 100;

                        displayHistoryDataGridView.Columns[1].Width = 324;
                        displayHistoryDataGridView.Columns[2].Width = 180;
                        displayHistoryDataGridView.Columns[3].Width = 120;
                        displayHistoryDataGridView.Columns[4].Width = 120;
                        displayHistoryDataGridView.Columns[5].Width = 120;

                        displayHistoryDataGridView.Columns[3].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss";
                        displayHistoryDataGridView.Columns[4].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }

                }

                if (!string.IsNullOrEmpty(chooseHistoryComboBox.GetItemText(chooseHistoryComboBox.SelectedItem)) && (String)chooseHistoryComboBox.SelectedItem == "Camera Configuration")
                {

                    if (displayHistoryDataGridView.Columns.Contains("openFile"))
                    {
                        displayHistoryDataGridView.Columns.Remove("openFile");
                    }
                    var configurations = _cameraConfigDbService.ReadFromDb_Configurations_BetweenDates(DateTime.Parse(fromDateTimePicker.Text), DateTime.Parse(toDateTimePicker.Text));
                    var modifiedConfigurations = _configurationModificationDbService.ReadFromDb_Configuration_Modification_BetweenDates(DateTime.Parse(fromDateTimePicker.Text), DateTime.Parse(toDateTimePicker.Text));
                    configurations.Merge(modifiedConfigurations);
                    displayHistoryDataGridView.DataSource = configurations;
                    displayHistoryDataGridView.Columns[0].Width = 130;

                    displayHistoryDataGridView.Columns[1].Width = 324;
                    displayHistoryDataGridView.Columns[2].Width = 120;
                    displayHistoryDataGridView.Columns[3].Width = 120;
                    displayHistoryDataGridView.Columns[4].Width = 120;
                    displayHistoryDataGridView.Columns[5].Width = 120;




                }
            }
        }

        private void DisplayHistoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {

                try
                {
                    //getting a specific file path from the table
                    var filePath = this.displayHistoryDataGridView[1, e.RowIndex].Value.ToString();

                    if (FileService.IsImage(FileService.GetFileExtension(filePath)))
                    {
                        Process.Start(filePath);
                    }
                    else
                    {
                        Process test = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();

                        var existStartDateTime = _fileMonitorDbService.ReadFromDb_StartTimestamp_ForFile(filePath);
                        var existeEndTime = _fileMonitorDbService.ReadFromDb_EndTimestamp_ForFile(filePath);
                        startInfo.FileName = "C:\\Program Files\\VideoLAN\\VLC\\vlc.exe";

                        string start = "0";
                        string stop = "0";

                        if (DateCalculator.IsBetweenTwoDates(DateTime.Parse(fromDateTimePicker.Text), existStartDateTime, existeEndTime) || DateCalculator.IsBetweenTwoDates(DateTime.Parse(toDateTimePicker.Text), existStartDateTime, existeEndTime))
                        {
                            var substrResultOFStartTime = DateCalculator.SubstactTwoDates(existStartDateTime, DateTime.Parse(fromDateTimePicker.Text));
                            var substrResultOfEndTime = DateCalculator.SubstactTwoDates(existStartDateTime, DateTime.Parse(toDateTimePicker.Text));
                            var videoDuration = FileService.VideoTotalDuration(_fileMonitorDbService.ReadFromDb_StartTimestamp_ForFile(filePath), _fileMonitorDbService.ReadFromDb_EndTimestamp_ForFile(filePath));
                            if (substrResultOFStartTime > -0 && substrResultOFStartTime < videoDuration && DateCalculator.isEqual(DateTime.Parse(fromDateTimePicker.Text).Date, existStartDateTime.Date))
                            {
                                start = substrResultOFStartTime.ToString();

                            }
                            if (substrResultOfEndTime > 0 && substrResultOfEndTime < videoDuration && DateCalculator.isEqual(DateTime.Parse(toDateTimePicker.Text).Date, existeEndTime.Date))
                            {
                                stop = substrResultOfEndTime.ToString();
                            }
                        }


                        startInfo.Arguments = $"\"" + filePath + "\"" + " --start-time" + " " + start + " --stop-time " + stop;


                        Process.Start(startInfo);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }

            }
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void ServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServerConfigurationForm serverConfigurationForm = new ServerConfigurationForm();
            this.Hide();
            serverConfigurationForm.ShowDialog();
        }
        private void ChooseHistoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (displayHistoryDataGridView.Columns.Contains("openFile"))
                {
                    displayHistoryDataGridView.Columns.Remove("openFile");
                }
                if (displayHistoryDataGridView.Rows.Count > 0)
                {
                    displayHistoryDataGridView.DataSource = null;
                    displayHistoryDataGridView.Rows.Clear();
                }


            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                // Console.WriteLine(ex.Message);
            }

        }


        private void AddCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurationForm configurationForm = new ConfigurationForm();
            this.Hide();
            configurationForm.ShowDialog();
        }
        private void ModifyCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewConfigurationForm newConfigurationForm = new NewConfigurationForm();
            this.Hide();
            newConfigurationForm.ShowDialog();
        }

        #endregion

    }
}


