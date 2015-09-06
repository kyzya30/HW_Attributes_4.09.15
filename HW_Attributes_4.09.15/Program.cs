

namespace HW_Attributes_4._09._15
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass("1","2","3","4","5");

            Printer myPrinter = new Printer();
            myPrinter.Print(myclass);
        }
    }
}
