using ProductProject.Models;

namespace ProductProject.Repos
{
    class ProductRepo
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            if (product.Quantity > 0)
            {
                products.Add(product);
            }
            else
            {
                throw new InvalidOperationException("Csak pozitív raktárkészlettel rendelkező terméket lehet hozzáadni.");
            }
        }

        public void RemoveProduct(string productName)
        {
            var product = products.Find(p => p.Name == productName);
            if (product == null)
            {
                throw new InvalidOperationException("A termék nem található.");
            }
            if (product.Quantity == 0)
            {
                products.Remove(product);
            }
            else
            {
                throw new InvalidOperationException("A termék még elérhető a raktáron, nem törölhető.");
            }
        }

        public void ListProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
