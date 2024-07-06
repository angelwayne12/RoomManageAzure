using RoomManageData;
using RoomManageModel;

namespace RoomManage
{
    public class RoomTransactionService
    {
        RoomValidationServices validationServices = new RoomValidationServices();
        RoomUserData userData = new RoomUserData();

        public bool CreateRoom(Room room)
        {
            bool result = false;

            if (validationServices.CheckIfNameExists(room.Name))
            {
                result = userData.AddRoom(room) > 0;
            }

            return result;
        }

        public bool CreateRoom(string Roomnum, string Name)
        {
            Room room = new Room { Roomnum = Roomnum, Name = Name };

            return CreateRoom(room);
        }

        public bool UpdateRoom(Room room)
        {
            bool result = false;

            if (validationServices.CheckIfNameExists(room.Name))
            {
                result = userData.UpdateRoom(room) > 0;
            }

            return result;
        }

        public bool UpdateRoom(string Roomnum, string Name)
        {
            Room room = new Room { Roomnum = Roomnum, Name = Name };

            return UpdateRoom(room);
        }

        public bool DeleteRoom(Room room)
        {
            bool result = false;

            if (validationServices.CheckIfNameExists(room.Name))
            {
                result = userData.DeleteRoom(room) > 0;
            }

            return result;
        }


    }
}
