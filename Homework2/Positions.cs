using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class Positions
    {
        private List<Product> _products = new List<Product>();
        public List<Product> GetProduct()
        {
            _products.Add(new Product("Headphons", 80));
            _products.Add(new Product("Monitor", 100));
            _products.Add(new Product("Keyboard", 150));
            _products.Add(new Product("Jet", 300));
            _products.Add(new Product("IPhone", 120));
            _products.Add(new Product("Laptop", 200));
            return _products;
        }
    }
}
