using RoomManageModel;
using System.Data.SqlClient;
namespace RoomManageData
{
    public class SqlDbData
    {
        string connectionString
            //= "Data Source =ELIJAH\\MSSQLSERVER01; Initial Catalog = Room ; Integrated Security = True;";
            = "Server = tcp:52.184.82.37,1433; Database = Room; User Id = sa; Password = integ2!";

        SqlConnection sqlConnection;

        public SqlDbData()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public List<Room> GetRooms()
        {
            string selectStatement = "SELECT Roomnum, Name FROM tblRooms";

            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            sqlConnection.Open();
            List<Room> rooms = new List<Room>();

            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                string Roomnum = reader["Roomnum"].ToString();
                string Name = reader["Name"].ToString();

                Room readRoom = new Room();
                readRoom.Roomnum = Roomnum;
                readRoom.Name = Name;

                rooms.Add(readRoom);
            }

            sqlConnection.Close();

            return rooms;

        }

        public int AddRoom(string Roomnum, string Name)
        {
            int success;

            string insertStatement = "INSERT INTO tblRooms Values (@Roomnum, @Name)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@Roomnum", Roomnum);
            insertCommand.Parameters.AddWithValue("@Name", Name);
            sqlConnection.Open();

            success = insertCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }

        public int UpdateRoom(string Roomnum, string Name)
        {
            int success;

            string updateStatement = $"UPDATE tblRooms SET Name = @Name WHERE Roomnum = @Roomnum";
            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);
            sqlConnection.Open();

            updateCommand.Parameters.AddWithValue("@Name", Name);
            updateCommand.Parameters.AddWithValue("@Roomnum", Roomnum);

            success = updateCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }

        public int DeleteRoom(string Roomnum)
        {
            int success;

            string deleteStatement = $"DELETE FROM tblRooms WHERE Roomnum = @Roomnum";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlConnection);
            sqlConnection.Open();

            deleteCommand.Parameters.AddWithValue("@Roomnum", Roomnum);

            success = deleteCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }



    }
}
