using System;
using System.Data;
using System.Data.SqlClient;

namespace detectVideoApp
{
    public class ConfigurationModificationHistoryDbService
    {
        #region Members
        private SqlConnection _sqlConnection;
        private FileService _xmlFilesService;
        #endregion
        #region Constructors
        public ConfigurationModificationHistoryDbService()
        {
            _xmlFilesService = new FileService();
            DatabaseConfig db = _xmlFilesService.ReadFromXmlFile();
            _sqlConnection = new SqlConnection($"server={db.ServerName}; initial catalog={db.DatabaseName}; user id=sa; password=mikrosam");

        }
        #endregion
        #region Services
        /// <summary>
        ///  Closes the connection to the database if it is open
        /// </summary>
        /// <param name="conn"></param>
        public void ValidateCloseConnection(SqlConnection conn)
        {
            ConnectionState state = _sqlConnection.State;
            if (state == ConnectionState.Open)
            {
                _sqlConnection.Close();

            }
        }
        /// <summary>
        /// Adds modified configuration to the database
        /// </summary>
        /// <param name="cameraName"></param>
        /// <param name="folderPath"></param>
        /// <param name="videoExtension"></param>
        /// <param name="photoExtension"></param>
        public void WriteToDb_Configuration_Modification(string cameraName, string folderPath = "", string videoExtension = "", string photoExtension = "")
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO configuration_modificationHistory (camera_name,folder_path,video_extension,photo_extension,timestamp) VALUES (@camera_name,@folder_path,@video_extension,@photo_extension,@timestamp);", _sqlConnection);
                cmd.Parameters.AddWithValue("camera_name", cameraName);
                cmd.Parameters.AddWithValue("folder_path", folderPath);
                cmd.Parameters.AddWithValue("video_extension", videoExtension);
                cmd.Parameters.AddWithValue("photo_extension", photoExtension);
                DateTime date = DateTime.Now;
                date = date.Date.AddHours(date.Hour).AddMinutes(date.Minute).AddSeconds(date.Second);
                cmd.Parameters.AddWithValue("timestamp", date);


                var i = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ValidateCloseConnection(_sqlConnection);

            }
        }
        /// <summary>
        /// Retrieves modified configurations that occurred between the specified start and end dates
        /// </summary>
        /// <param name="fromTimestamp"></param>
        /// <param name="toTimestamp"></param>
        /// <returns></returns>
        public DataTable ReadFromDb_Configuration_Modification_BetweenDates(DateTime fromTimestamp, DateTime toTimestamp)
        {
            _sqlConnection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT camera_name,folder_path,video_extension,photo_extension,action,timestamp FROM configuration_modificationHistory WHERE timestamp >= @from AND timestamp <= @to;;", _sqlConnection);
                cmd.Parameters.AddWithValue("from", fromTimestamp);
                cmd.Parameters.AddWithValue("to", toTimestamp);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ValidateCloseConnection(_sqlConnection);

            }
        }
        #endregion
    }
}
