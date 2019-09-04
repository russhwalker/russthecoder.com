using System;

namespace CSharp8.DefaultInterfaceMembers
{
    public class RegularWidget : IWidget
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}