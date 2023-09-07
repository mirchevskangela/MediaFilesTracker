using System;
using System.Data;
using System.Data.SqlClient;

namespace detectVideoApp
{
    public class FileMonitoringDbService
    {
        #region Members
        private SqlConnection _sqlConnection;
        private FileService _xmlFilesService;
        #endregion
        #region Constructors
        public FileMonitoringDbService()
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
        public void validateAndCloseConnections(SqlConnection conn)
        {
            ConnectionState state = _sqlConnection.State;
            if (state == ConnectionState.Open)
            {
                _sqlConnection.Close();

            }
        }

        /// <summary>
        /// Adds a new monitoring detail to the monitoring_details table
        /// </summary>
        /// <param name="action"></param>
        /// <param name="configurationId"></param>
        /// <param name="path"></param>
        /// <param name="fileName"></param>
        /// <param name="start_timestamp"></param>
        public void WriteInDb_NewMonitoringDetail(string action, int configurationId, String path, String fileName, DateTime start_timestamp)
        {

            try
            {
                _sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO monitoring_details (action,id_configuration_details,path,name,start_timestamp) VALUES (@action,@id_configuration_details,@path,@name,@start_timestamp);", _sqlConnection);
                cmd.Parameters.AddWithValue("action", action);
                cmd.Parameters.AddWithValue("id_configuration_details", configurationId);
                cmd.Parameters.AddWithValue("path", path);
                cmd.Parameters.AddWithValue("name", fileName);
                DateTime d = DateTime.Now;
                d = d.Date.AddHours(d.Hour).AddMinutes(d.Minute).AddSeconds(d.Second);
                cmd.Parameters.AddWithValue("start_timestamp", d);


                var i = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                validateAndCloseConnections(_sqlConnection);

            }

        }

        /// <summary>
        ///Modifies the end timestamp and action values for a particular monitoring detail from the monitoring_details table based on the given camera name.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="timeNow"></param>
        public void WriteInDb_Update_EndTimestampAndAction_MonitoringDetail(String fileName, DateTime timeNow)
        {

            try
            {
                _sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE monitoring_details SET end_timestamp = @end_timestamp,action=@action WHERE name = @name;", _sqlConnection);

                cmd.Parameters.AddWithValue("name", fileName);
                cmd.Parameters.AddWithValue("action", "changed");

                timeNow = timeNow.Date.AddHours(timeNow.Hour).AddMinutes(timeNow.Minute).AddSeconds(timeNow.Second);
                cmd.Parameters.AddWithValue("end_timestamp", timeNow);
                var i = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                validateAndCloseConnections(_sqlConnection);

            }

        }

        /// <summary>
        /// Retrieves monitoring detail records from monitoring_details table,that are between the given from and to timestamp values
        /// </summary>
        /// <param name="from">from timestamp </param>
        /// <param name="to">to timestamp</param>
        /// <returns>a datatable containing retrieved records</returns>
        /// 
        public DataTable ReadFromDb_MonitoringDetails_BetweenDates(DateTime from, DateTime to)
        {
            _sqlConnection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT c.camera_name, m.path,m.name,m.start_timestamp,m.end_timestamp FROM monitoring_details AS m JOIN configuration_details AS c ON c.id = m.id_configuration_details WHERE m.start_timestamp >= @from AND m.end_timestamp <= @to;", _sqlConnection);

                cmd.Parameters.AddWithValue("from", from);
                cmd.Parameters.AddWithValue("to", to);
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
                validateAndCloseConnections(_sqlConnection);

            }
        }

        /// <summary>
        /// Retrieves camera name, file path, file name, start and end timestamp values of a monitoring detail from monitoring_details table
        /// based on the given start timestamp value
        /// </summary>
        /// <param name="start_timestamp"></param>
        /// <returns>the closest monitoring detail to the given start timestmap</returns>
        public DataTable ReadFromDb_ClosestMonitoringDetail(DateTime start_timestamp)
        {

            _sqlConnection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT  top 1 c.camera_name, m.path,m.name,m.start_timestamp,m.end_timestamp FROM monitoring_details AS m JOIN configuration_details AS c ON c.id = m.id_configuration_details WHERE m.start_timestamp  <= @start ORDER BY m.start_timestamp DESC", _sqlConnection);

                cmd.Parameters.AddWithValue("start", start_timestamp);
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
                validateAndCloseConnections(_sqlConnection);

            }
        }

        /// <summary>
        /// Retrieves specific start_timestamp value for a file based on the given path 
        /// </summary>
        /// <param name="path"></param>
        /// <returns>a datatable with one row and one column  </returns>
        public DateTime ReadFromDb_StartTimestamp_ForFile(string path)
        {
            _sqlConnection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select start_timestamp from monitoring_details where path=@path;", _sqlConnection);
                cmd.Parameters.AddWithValue("path", path);
                object result = cmd.ExecuteScalar();
                DateTime start_timestamp = DateTime.Now;
                if (result != null)
                {
                    start_timestamp = (DateTime)result;
                }
                return start_timestamp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                validateAndCloseConnections(_sqlConnection);

            }

        }

        /// <summary>
        /// Retrieves specific end_timeStamp value from the monitoring_details table for a file based on the given path 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public DateTime ReadFromDb_EndTimestamp_ForFile(string path)
        {
            _sqlConnection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select end_timeStamp from monitoring_details where path=@path;", _sqlConnection);
                cmd.Parameters.AddWithValue("path", path);
                object result = cmd.ExecuteScalar();
                DateTime end_timestamp = DateTime.Now;
                if (result != null)
                {
                    end_timestamp = (DateTime)result;
                }
                return end_timestamp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                validateAndCloseConnections(_sqlConnection);

            }

        }

        #endregion

    }
}
