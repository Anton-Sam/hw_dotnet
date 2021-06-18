using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HW._03.Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Переменные для преобразования типов (чтобы не плодить лишнее переменные)
            byte byteVal = 1;
            int intVal = 2000000;
            double doubleVal = 0.001;
            DateTime dateTimeVal = new DateTime();
            string stringVal = "it-academy";
            bool boolVal = true;
            decimal decimalVal;
            ushort ushortVal = 500;
            object objectVal;

            //Неявное преобразование типов
            //1
            intVal = byteVal;
            //2
            doubleVal = intVal + 0.1;
            //3
            objectVal = dateTimeVal;
            //4
            IEnumerable<char> charColl = stringVal;
            //5
            decimalVal = ushortVal;

            //Явное преобразование типов
            //1
            intVal = (int)doubleVal;
            //2
            intVal = int.Parse(stringVal);
            //3
            boolVal = Convert.ToBoolean(intVal);
            //4
            stringVal = doubleVal.ToString();
            //5
            intVal =Convert.ToInt32(boolVal);

            //Boxing
            //1
            object objInt = 10;
            //2
            string strBool = true.ToString();
            //3
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            //4
            object objDate = dateTimeVal;
            //5
            string strChar = 'a'.ToString();


            //Unboxing
            //1
            intVal = (int)objectVal;
            //2
            boolVal = bool.Parse(stringVal);
            //3
            int integer1 = (int)arrayList[0];
            //4
            char char1 = stringVal.Last();
            //5
            dateTimeVal = (DateTime)objDate;


        }
    }
}
