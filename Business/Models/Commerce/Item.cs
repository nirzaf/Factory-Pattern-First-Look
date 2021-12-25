namespace Factory_Pattern_First_Look.Business.Models.Commerce
{
    public class Item
    {
        public string Id { get; }
        public string Name { get; }
        public decimal Price { get; }

        public Item(string id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}