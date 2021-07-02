using HW06.AssemblyOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW06.AssemblyTwo
{
    class ClassicBike : Motorcycle
    {
        void TestProps()
        {
            OdometreProtected = 1;
            OdometreProtectedInternal = 1;
            OdometrePublic = 1;
            //OdometrePrivate = 1;          //Only for native class
            //OdometrePrivateProtected = 1; //Only for native class and derived classes of native assembly
            //OdometreInternal = 1;         //Only for native assembly
        }
    }
}
