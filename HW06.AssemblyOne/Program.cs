using System;

namespace HW06.AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var moto = new Motorcycle();

            var maxSpeed = moto.MaxSpeed;           //Can get value of public property
            //moto.MaxSpeed = 1;                    //Can set value only in costructor or with initialization
            moto.OdometreInternal = 1;              //Can set value to property everywhere in this assembly    
            moto.OdometreProtectedInternal = 1;     //Can set value to prop, because in current assembly it's the same as internal prop
            moto.OdometrePublic = 1;                //Can set value to property everywhere in any assembly
            //moto.OdometrePrivate = 1;             Can set value only in the native class in this assembly
            //moto.OdometrePrivateProtected = 1;    Can set value only in the nattive class and in the derived class in this assembly
            //moto.OdometreProtected = 1;           Can set value only in the nattive class and in the derived class in any assembly

            moto.StartEnginePublic();               //Can use public method anywhere
            //moto.StartEnginePrivate();            Can use private method only in native class in current assembly
        }
    }
}
