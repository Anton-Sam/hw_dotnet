using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW06.AssemblyOne
{
    class SportBike : Motorcycle
    {
        void TestProps()
        {
            OdometrePublic = 1;
            OdometreInternal = 1;
            OdometrePrivateProtected = 1;
            OdometreProtected = 1;
            OdometreProtectedInternal = 1;
            //OdometrePrivate = 1;  Private only for native classes in current assembly
        }
    }
}
