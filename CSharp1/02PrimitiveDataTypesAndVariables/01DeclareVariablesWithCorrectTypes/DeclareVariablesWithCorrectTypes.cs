using System;
using System.Collections.Generic;


namespace _01DeclareVariablesWithCorrectTypes
{
    class DeclareVariablesWithCorrectTypes
    {
        //moje da se izpolzva GetTypeCode()); ili GetType();
        //Console.WriteLine("Number {0} is of type {1}", number1, number1.GetTypeCode());
        //Console.WriteLine("The correct type of {0:N0} is {1}. {1} has min value: {2:N0} and max value {3:N0}.", shortNumber, shortNumber.GetType()
        static void Main()
        {
           
            ushort value1 = 52130;
            sbyte value2 = -115;
            int value3 = 4825932;
            byte value4 = 97;
            short value5 = -10000;
            object[] listOfValues ={value1, value2, value3, value4, value5};
                                 
            
           
            for (int i = 0; i < listOfValues.Length; i++)
            {
                Console.WriteLine("Variable{0} = {1} is of type {2}.", i + 1, listOfValues[i], listOfValues[i].GetType().Name, listOfValues[i].GetType().ReflectedType);
                byte byteNumber;
                sbyte sbyteNumber;
                short shortNumber;
                ushort ushortNumber;
                int intNumber;
                uint uintNumber;
                long longNumber;
                ulong ulongNumber;
                if (byte.TryParse(listOfValues[i].ToString(), out byteNumber))
                {
                    Console.WriteLine("The correct type of {0:N0} is {1}. {1} has min value: {2:N0} and max value {3:N0}.", byteNumber, byteNumber.GetType(), byte.MinValue, byte.MaxValue);
                }                
                else if (sbyte.TryParse(listOfValues[i].ToString(), out sbyteNumber))
                {
                    Console.WriteLine("The correct type of {0:N0} is {1}. {1} has min value: {2:N0} and max value {3:N0}.", sbyteNumber, sbyteNumber.GetType(), sbyte.MinValue, sbyte.MaxValue);
                }

                else if (short.TryParse(listOfValues[i].ToString(), out shortNumber))
                {
                    Console.WriteLine("The correct type of {0:N0} is {1}. {1} has min value: {2:N0} and max value {3:N0}.", shortNumber, shortNumber.GetType(), short.MinValue, short.MaxValue);
                }
                else if (ushort.TryParse(listOfValues[i].ToString(), out ushortNumber))
                {
                    Console.WriteLine("The correct type of {0:N0} is {1}. {1} has min value: {2:N0} and max value {3:N0}.", ushortNumber, ushortNumber.GetType(), ushort.MinValue, ushort.MaxValue);
                }
                else if (int.TryParse(listOfValues[i].ToString(), out intNumber))
                {
                    Console.WriteLine("The correct type of {0:N0} is {1}. {1} has min value: {2:N0} and max value {3:N0}.", intNumber, intNumber.GetType(), int.MinValue, int.MaxValue);
                }
                else if (uint.TryParse(listOfValues[i].ToString(), out uintNumber))
                {
                    Console.WriteLine("The correct type of {0:N0} is {1}. {1} has min value: {2:N0} and max value {3:N0}.", uintNumber, uintNumber.GetType(), uint.MinValue, uint.MaxValue);
                }
                else if (long.TryParse(listOfValues[i].ToString(), out longNumber))
                {
                    Console.WriteLine("The correct type of {0:N0} is {1}. {1} has min value: {2:N0} and max value {3:N0}.", longNumber, longNumber.GetType(), long.MinValue, long.MaxValue);
                }
                else if (ulong.TryParse(listOfValues[i].ToString(), out ulongNumber))
                {
                    Console.WriteLine("The correct type of {0:N0} is {1}. {1} has min value: {2:N0} and max value {3:N0}.", ulongNumber, ulongNumber.GetType(), ulong.MinValue, ulong.MaxValue);
                }
                Console.WriteLine();
            }           
        }
    }
}
