using RoomManage;
using RoomManageData;
using RoomManageModel;


namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RoomGetServices getServices = new RoomGetServices();

            var rooms = getServices.GetAllRooms();

            foreach (var item in rooms)
            {
                Console.WriteLine(item.Roomnum);
                Console.WriteLine(item.Name);
                Console.WriteLine();
            }

            //SqlDbData.Connect();
        }
    }
}
