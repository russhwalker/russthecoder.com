
namespace CSharp8.DefaultInterfaceMembers
{
    public interface IWidget
    {
        string Name { get; set; }
        decimal Price { get; set; }

        decimal GetChargedPrice()
        {
            return Price;
        }

        string GetDisplay()
        {
            return $"{Name} : {GetChargedPrice().ToString("C")}";
        }
    }
}