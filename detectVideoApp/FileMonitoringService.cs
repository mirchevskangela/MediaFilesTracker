using System;
using System.IO;

namespace detectVideoApp
{
    public class FileMonitoringService
    {
        #region Members
        private FileMonitoringDbService _dbService;
        private FileSystemWatcher _folderWatchers = new FileSystemWatcher();
        private string _Extensions;
        private int _ConfigurationId;
        private string _Camera;
        public event EventHandler<FileMonitoringDetails> MonitoringDetailNotify;
        #endregion

        #region Constructors
        public FileMonitoringService(string camera, int id, String folderPath, String extensions)
        {
            _folderWatchers.IncludeSubdirectories = true;
            _folderWatchers.NotifyFilter = NotifyFilters.FileName | NotifyFilters.Size | NotifyFilters.CreationTime;
            _folderWatchers.Path = folderPath;
            _dbService = new FileMonitoringDbService();
            _folderWatchers.Created += new FileSystemEventHandler(FileCreate);
            _folderWatchers.Changed += new FileSystemEventHandler(FileChange);
            _folderWatchers.EnableRaisingEvents = true;
            _folderWatchers.Filter = "";

            _Extensions = extensions;
            _ConfigurationId = id;
            _Camera = camera;
        }
        public FileMonitoringService(Boolean stopMonitoring)
        {
            if (_folderWatchers.IncludeSubdirectories)
            {
                _folderWatchers.IncludeSubdirectories = false;
            }
        }
        #endregion
        #region Events
        private void FileCreate(object sender, FileSystemEventArgs e)
        {
            FileInfo fileInfo = new FileInfo(e.Name);
            string strFileExt = fileInfo.Extension;
            String action = "File created ";
            DateTime timestamp = DateTime.Now;

            if (_Extensions.Contains(strFileExt))
            {
                _dbService.WriteInDb_NewMonitoringDetail(action: action, _ConfigurationId, path: e.FullPath.ToString(), fileName: e.Name.ToString(), start_timestamp: timestamp);

                OnCreatedOrChangedFile(new FileMonitoringDetails(action, _Camera, e.FullPath.ToString(), e.Name.ToString(), timestamp));
            }
        }
        /// <summary>
        /// Calls the event handler method registered with the MonitoringDetails event.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnCreatedOrChangedFile(FileMonitoringDetails e)
        {
            MonitoringDetailNotify?.Invoke(this, e);

        }
        private void FileChange(object sender, FileSystemEventArgs e)
        {
            String action = "File changed ";
            DateTime timeNow = DateTime.Now;

            FileInfo fileInfo = new FileInfo(e.Name);

            string strFileExt = fileInfo.Extension;

            if (_Extensions.Contains(strFileExt))
            {
                _dbService.WriteInDb_Update_EndTimestampAndAction_MonitoringDetail(fileName: e.Name.ToString(), timeNow);
                OnCreatedOrChangedFile(new FileMonitoringDetails(action, _Camera, e.FullPath.ToString(), e.Name.ToString(), timeNow));

            }


        }
        #endregion

    }
}
