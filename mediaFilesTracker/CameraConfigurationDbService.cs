using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace detectVideoApp
{
    public class CameraConfigurationDbService
    {
        #region Members
        private SqlConnection _sqlConnection;
        private FileService _xmlFilesService;
        #endregion
        #region Constructors
        public CameraConfigurationDbService()
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
        /// Adds a new configuration to the configuration_details table
        /// </summary>
        /// <param name="camera"></param>
        /// <param name="originalCamera"></param>
        /// <param name="folderPath"></param>
        /// <param name="videoExtensions"></param>
        /// <param name="photoExtensions"></param>
        public void WriteToDb_NewConfiguration(string camera, string folderPath, string videoExtensions = "", string photoExtensions = "")
        {

            try
            {
                _sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO configuration_details (camera_name,folder_path,video_extension,photo_extension,timestamp) VALUES (@camera,@folderpath,@videoExtensions,@photoExtensions,@createdOn);", _sqlConnection);
                cmd.Parameters.AddWithValue("camera", camera);
                cmd.Parameters.AddWithValue("folderPath", folderPath);
                cmd.Parameters.AddWithValue("videoExtensions", videoExtensions);
                cmd.Parameters.AddWithValue("photoExtensions", photoExtensions);
                cmd.Parameters.AddWithValue("createdOn", DateTime.Now);


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
        /// Retrieves all camera name values from the configuration_details table
        /// </summary>
        /// <returns></returns>
        public DataTable ReadFromDb_AllCameraNames()
        {
            _sqlConnection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT camera_name FROM configuration_details;", _sqlConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;

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
        /// Retrieves multiple configurations from configuration_details table based on given from and to timestamp 
        /// </summary>
        /// <param name="fromTimestamp"></param>
        /// <param name="toTimestamp"></param>
        /// <returns></returns>
        public DataTable ReadFromDb_Configurations_BetweenDates(DateTime fromTimestamp, DateTime toTimestamp)
        {
            _sqlConnection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT camera_name,folder_path,video_extension,photo_extension,action,timestamp FROM configuration_details WHERE timestamp >= @from AND timestamp <= @to;", _sqlConnection);
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

        /// <summary>
        /// Sets the active default value from 0 to 1 to a record in the configuration_details table based on given camera name
        /// </summary>
        /// <param name="cameraName"></param>
        public void UpdateDb_SetActiveCamera_Configuration(string cameraName)
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE configuration_details SET active = 1 WHERE camera_name=@camera;", _sqlConnection);
                cmd.Parameters.AddWithValue("camera", cameraName);
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
        /// Retrieves all camera name values from the configuration_details table based on the active filed which is true
        /// </summary>
        /// <returns>list of string type containing active configurations</returns>
        public List<string> ReadFromDb_ActiveCameras()
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT camera_name FROM configuration_details WHERE active=1;", _sqlConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<string> activeCameras = new List<string>();


                while (reader.Read())
                {

                    activeCameras.Add((string)reader["camera_name"]);


                }
                return activeCameras;

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
        /// Returns a camera name or id or folder path or video extension or photo extension value of a particular record from the configuration_details table based on given camera name
        /// </summary>
        /// <param name="cameraName"></param>
        /// <returns>string value</returns>
        public (string videoExtensions, string photoExtensions, string folderPath, string name, int id) ReadFromDb_Configuration_InSingleDetail(string cameraName) // tuple return type
        {
            try
            {
                _sqlConnection.Open();
                //  SqlCommand cmd = new SqlCommand("SELECT videoExtensions,photoExtensions FROM configuration_details WHERE camera Like @camera", _sqlConnection);
                // cmd.Parameters.AddWithValue("@camera", originalCameraName + "%");
                SqlCommand cmd = new SqlCommand("SELECT video_extension,photo_extension,folder_path,id,camera_name FROM configuration_details WHERE camera_name = @camera", _sqlConnection);
                cmd.Parameters.AddWithValue("@camera", cameraName);
                SqlDataReader reader = cmd.ExecuteReader();
                List<string> videoExtensions = new List<string>();
                List<string> photoExtensions = new List<string>();
                List<string> folderPaths = new List<string>();
                string name = "";
                int id = 0;
                while (reader.Read())
                {

                    videoExtensions.Add((string)reader["video_extension"]);
                    photoExtensions.Add((string)reader["photo_extension"]);
                    folderPaths.Add((string)reader["folder_path"]);
                    name = (string)reader["camera_name"];
                    id = (int)reader["id"];

                }
              
                return (videoExtensions: string.Join(" ", videoExtensions), photoExtensions: string.Join(" ", photoExtensions), folderPath: string.Join(" ", folderPaths), name: name, id: id);

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
        /// Changes a field in a particular record of the configuration_details table based on the given camera name
        /// </summary>
        /// <param name="cameraName"></param>
        /// <param name="folderPath"></param>
        /// <param name="videoExtension"></param>
        /// <param name="photoExtension"></param>
        public void UpdateDb_Configuration(string cameraName, string folderPath = "", string videoExtension = "", string photoExtension = "")
        {
            try
            {
                if (folderPath != "")
                {
                    _sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE configuration_details SET folder_path = @folderPath WHERE camera_name=@camera;", _sqlConnection);

                    cmd.Parameters.AddWithValue("camera", cameraName);
                    cmd.Parameters.AddWithValue("folderPath", folderPath);

                    var i = cmd.ExecuteNonQuery();
                }
                if (videoExtension != "")
                {
                    _sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE configuration_details SET video_extension = @videoExtensions WHERE camera_name=@camera;", _sqlConnection);

                    cmd.Parameters.AddWithValue("camera", cameraName);
                    cmd.Parameters.AddWithValue("videoExtensions", videoExtension);

                    var i = cmd.ExecuteNonQuery();
                }
                if (photoExtension != "")
                {
                    _sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE configuration_details SET photo_extension = @photoExtensions WHERE camera_name=@camera;", _sqlConnection);

                    cmd.Parameters.AddWithValue("camera", cameraName);
                    cmd.Parameters.AddWithValue("photoExtensions", photoExtension);

                    var i = cmd.ExecuteNonQuery();
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ValidateCloseConnection(_sqlConnection);

            }
            #endregion

        }
    }
}
