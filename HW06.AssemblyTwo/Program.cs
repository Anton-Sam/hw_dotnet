using HW06.AssemblyOne;
using System;

namespace HW06.AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var moto = new Motorcycle();
            //var sportBike = new SportBike();  //Internal class
            moto.OdometrePublic = 1;            //Other props can use only in native class,the native assembly or in derived classes
        }
    }
}
