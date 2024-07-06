using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using RoomManageData;
using RoomManageModel;

namespace RoomManage
{
    public class RoomGetServices
    {
        public List<Room> GetAllRooms()
        {
            RoomUserData userData = new RoomUserData();

            return userData.GetRooms();

        }

        public List<Room> GetName(string Name)
        {
            List<Room> rooms = new List<Room>();

            foreach (var room in GetAllRooms())
            {
                if (room.Name == Name)
                {
                    rooms.Add(room);
                }
            }
            return rooms;

        }

        public Room GetRooms(string Roomnum, string Name)
        {
            Room foundRoom = new Room();

            foreach (var room in GetAllRooms())
            {
                if (room.Roomnum == Roomnum && room.Name == Name)
                {
                    foundRoom = room;
                }
            }

            return foundRoom;
        }

    }
}
