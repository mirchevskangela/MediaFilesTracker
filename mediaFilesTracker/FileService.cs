using System;
using System.IO;
using System.Xml.Serialization;



namespace detectVideoApp
{
    public class FileService
    {
        #region Members
        private System.Xml.Serialization.XmlSerializer _serializer;
        #endregion
        #region Constructors
        public FileService()
        {
            _serializer = new XmlSerializer(typeof(DatabaseConfig));

        }
        #endregion
        #region xml file services
        /// <summary>
        /// Writes data in xml file
        /// </summary>
        /// <param name="serverName"></param>
        /// <param name="databaseName"></param>
        public void WriteXmlFile(string serverName, string databaseName)
        {
            FileStream fs = new FileStream("C:\\Users\\Angelam\\Desktop\\database\\database.xml", FileMode.Create, FileAccess.Write);
            DatabaseConfig database = new DatabaseConfig();
            database.ServerName = serverName;
            database.DatabaseName = databaseName;
            _serializer.Serialize(fs, database);
            fs.Close();
        }
        /// <summary>
        /// Reads data from xml file
        /// </summary>
        /// <returns></returns>
        public DatabaseConfig ReadFromXmlFile()
        {
            System.IO.TextReader textReader = new System.IO.StreamReader("C:\\Users\\Angelam\\source\\repos\\detectVideoApp\\detectVideoApp\\bin\\Debug\\database.xml");
            var db = (DatabaseConfig)_serializer.Deserialize(textReader);
            textReader.Close();
            return db;
        }
        #endregion
        #region Services
        public static string GetFileExtension(string filePath)
        {
            FileInfo fi = new FileInfo(filePath);
            return fi.Extension;
        }
        /// <summary>
        /// Checks if the given extension provided by user is image
        /// </summary>
        /// <param name="extension"></param>
        /// <returns></returns>
        public static bool IsImage(String extension)
        {
            string pictureExtensions = ".jpg .jpeg .jfi .jpe .jif .jfif .png .svg .svgz .pdf .webp .tiff .tif .psd .raw .arw .cr .rw2 .nrw .k25";
            if (pictureExtensions.Contains(extension.ToLower()))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Checks if the given extension provided by user is image
        /// </summary>
        /// <param name="extension"></param>
        /// <returns></returns>
        public static bool IsVideo(String extension)
        {
            string videoExtensions = ".MPG .MP2 .MPEG .MPE .MPV .WEBM .MPG .MP2 .MPEG .MPE .MPV .OGG .AVI .WMV .AVCHD .AVC .MP4 .M4P";
            if (videoExtensions.ToLower().Contains(extension.ToLower()))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Calculates total duration of video based on the given start and end time
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <returns>seconds</returns>
        public static int VideoTotalDuration(DateTime startTime, DateTime endTime)
        {
            return DateCalculator.SubstactTwoDates(startTime, endTime);
        }
        #endregion
    }
}