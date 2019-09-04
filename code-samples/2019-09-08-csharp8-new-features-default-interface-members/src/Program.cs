using System;

namespace CSharp8.DefaultInterfaceMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            IWidget regularWidget = new RegularWidget
            {
                Name = "reg-widget",
                Price = 5M
            };
            Console.WriteLine(regularWidget.GetDisplay());

            IWidget specialWidget = new SpecialWidget
            {
                Name = "spec-widget",
                Price = 7.50M
            };
            Console.WriteLine(specialWidget.GetDisplay());
        }
    }
}