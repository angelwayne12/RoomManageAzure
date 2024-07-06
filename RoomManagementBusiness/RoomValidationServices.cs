using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoomManageData;
using RoomManageModel;

namespace RoomManage
{
    public class RoomValidationServices
    {
        RoomGetServices getservices = new RoomGetServices();

        public bool CheckIfNameExists(string Name)
        {
            bool result = getservices.GetName(Name) != null;
            return result;
        }


    }
}
