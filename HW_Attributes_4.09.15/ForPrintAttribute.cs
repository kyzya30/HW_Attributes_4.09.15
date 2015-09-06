using System;

namespace HW_Attributes_4._09._15
{
    [AttributeUsage(AttributeTargets.Property)]
    class ForPrintAttribute: Attribute
    {
        public ConsoleColor Color { get; set; }
    }
}
