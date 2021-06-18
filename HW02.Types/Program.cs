using System;

namespace HW02.Types
{
    class Program
    {
        static void Main(string[] args)
        {
            byte byte1 = 1;
            System.Byte byte2 = 1;
            ComprassionTypes<byte, System.Byte>(byte1, byte2);

            sbyte sbyte1 = 1;
            System.SByte sbyte2 = 1;
            ComprassionTypes<sbyte, System.SByte>(sbyte1, sbyte2);

            short short1 = 1;
            System.Int16 short2 = 1;
            ComprassionTypes<short, System.Int16>(short1, short2);

            ushort ushort1 = 1;
            System.UInt16 ushort2 = 1;
            ComprassionTypes<ushort, System.UInt16>(ushort1, ushort2);

            int integer1 = 1;
            System.Int32 integer2 = 1;
            ComprassionTypes<int, System.Int32>(integer1, integer2);

            uint uinteger1 = 1;
            System.UInt32 uinteger2 = 1;
            ComprassionTypes<uint, System.UInt32>(uinteger1, uinteger2);

            long long1 = 1;
            System.Int64 long2 = 1;
            ComprassionTypes<long, System.Int64>(long1, long2);

            ulong ulong1 = 1;
            System.UInt64 ulong2 = 1;
            ComprassionTypes<ulong, System.UInt64>(ulong1, ulong2);

            char ch1 = '1';
            System.Char ch2 = '1';
            ComprassionTypes<char, System.Char>(ch1, ch2);

            float fl1 = 1;
            System.Single fl2 = 1;
            ComprassionTypes<float, System.Single>(fl1, fl2);

            double db1 = 1;
            System.Double db2 = 1;
            ComprassionTypes<double, System.Double>(db1, db2);

            decimal dec1 = 1;
            System.Decimal dec2 = 2;
            ComprassionTypes<decimal, System.Decimal>(dec1, dec2);

            object obj1=new object();
            System.Object obj2=new System.Object();
            ComprassionTypes<object, System.Object>(obj1, obj2);

            string str1 = "";
            System.String str2 = "";
            ComprassionTypes<string, System.String>(str1, str2);

            Console.ReadLine();
        }

        private static void ComprassionTypes<T,V>(T param1,V param2)
        {
            Console.WriteLine($"{param1.GetType()}\n{param2.GetType()}\n");
        }    
    }
}
