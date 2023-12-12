using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techService
{
    public enum TableName { 
        Clients,
        EquipmentsToRepair,
        Requests,
        Roles,
        Status,
        typesOfFault,
        Users,
        Workers
    }
    internal class AppData
    {
        public static techServiceEntities db = new techServiceEntities();

        public static int UsersID;
    }
}
