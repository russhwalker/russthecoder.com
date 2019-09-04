using System;

namespace CSharp8.DefaultInterfaceMembers
{
    public class SpecialWidget : IWidget
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal GetChargedPrice()
        {
            return Price * 2M;
        }
    }
}