using System;

namespace HW_Attributes_4._09._15
{
    class MyClass
    {
        public MyClass(string prop1, string prop2, string prop3,string prop4, string prop5)
        {
            Property1 = prop1;
            Property2 = prop2;
            Property3 = prop3;
            Property4 = prop4;
            Property5 = prop5;
        }
        [ForPrint(Color = ConsoleColor.Green)]
        public string Property1 { get; set; }
        public string Property2 { get; set; }
        [ForPrint(Color = ConsoleColor.Yellow)]
        public string Property3 { get; set; }
        public string Property4 { get; set; }
        [ForPrint(Color = ConsoleColor.Red)]
        public string Property5 { get; set; }
    }
}
