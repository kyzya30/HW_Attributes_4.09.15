using System;
using System.Reflection;


namespace HW_Attributes_4._09._15
{
    internal class Printer
    {
        public void Print<T>(T obj)
        {
            Type myType = obj.GetType();
            PropertyInfo[] properties = myType.GetProperties();

            for (int i = 0; i < 5; i++)
            {
                object[] attribute = properties[i].GetCustomAttributes(true);


                foreach (var attrib in attribute)
                {
                    ForPrintAttribute myForPrintAttribute = attrib as ForPrintAttribute;

                    if (myForPrintAttribute != null)
                    {
                        Console.ForegroundColor = myForPrintAttribute.Color;
                    }
                    Console.WriteLine(properties[i].GetValue(obj));
                } 
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}

