using System;


namespace _02ValuesToBeAssignedToFloatOrDouble
{
    class ValuesToBeAssignedToFloatOrDouble
    {
        static void Main()
        {
            //http://msdn.microsoft.com/en-us/library/b1e65aza.aspx
            //float type has precision of 7 digits i.e it if is a real number the lenght should be 8 characters 
            //7 digits +"." 32-bit floating-point values

            System.Globalization.NumberStyles style = System.Globalization.NumberStyles.Number;
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CreateSpecificCulture("en-GB");
            string stringValue;
            float floatValue;          

            Console.WriteLine("The values are: 34.567839023, 12.345, 8923.1234857, 3456.091");
           
            object[] listOfNumericValues = { 34.567839023, 12.345, 8923.1234857, 3456.091 };
            for (int i = 0; i < listOfNumericValues.Length; i++)
            {
               
                if (listOfNumericValues[i] is double)
                {
                    Console.WriteLine((i+1)+": " +listOfNumericValues[i] + " can be assigned to a variable of type " + listOfNumericValues[i].GetType().Name +".");

                    stringValue = listOfNumericValues[i].ToString();
                    if (stringValue.Length <= 8)
                    {
                        if (Single.TryParse(stringValue, style, culture, out floatValue))
                        {                           
                            Console.Write("   {0} can be assigned to float ({1}) as well \n", floatValue, floatValue.GetType().Name);
                        }
                        else
                            Console.WriteLine("Unable to convert '{0}' to float.", stringValue);
                    }                    
                }
            }
        }
    }
}
