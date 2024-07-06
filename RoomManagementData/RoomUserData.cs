using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoomManageModel;

namespace RoomManageData
{
    public class RoomUserData
    {
        List<Room> rooms;
        SqlDbData sqlData;
        public RoomUserData()
        {
            rooms = new List<Room>();
            sqlData = new SqlDbData();
        }

        public List<Room> GetRooms()
        {
            rooms = sqlData.GetRooms();
            return rooms;
        }

        public int AddRoom(Room room)
        {
            return sqlData.AddRoom(room.Roomnum, room.Name);
        }

        public int UpdateRoom(Room room)
        {
            return sqlData.UpdateRoom(room.Roomnum, room.Name);
        }

        public int DeleteRoom(Room room)
        {
            return sqlData.DeleteRoom(room.Roomnum);
        }


    }
}
