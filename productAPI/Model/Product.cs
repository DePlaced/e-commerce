namespace productAPI.Model
{
    public class Product
    {
        public Product(string id, string name, string description, int price)
        {
            ID = id;
            Name = name;
            Description = description;
            Price = price;
        }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
