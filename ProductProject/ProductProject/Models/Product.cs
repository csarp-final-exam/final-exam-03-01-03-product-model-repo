namespace ProductProject.Models
{
    class Product
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }
        public string Category { get; set; }

        public Product(string name, string category)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("A termék neve nem lehet üres vagy null.");
            if (string.IsNullOrWhiteSpace(category))
                throw new ArgumentException("A kategória neve nem lehet üres vagy null.");

            Name = name;
            Price = 0;
            Quantity = 0;
            Category = category;
        }

        public void SetPrice(decimal price)
        {
            if (price < 0)
                throw new ArgumentException("Az ár nem lehet negatív.");
            Price = price;
        }

        public void SetQuantity(int quantity)
        {
            if (quantity < 0)
                throw new ArgumentException("A mennyiség nem lehet negatív.");
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Termék: {Name}, Ár: {Price} Ft, Mennyiség: {Quantity} db, Kategória: {Category}";
        }
    }
}
