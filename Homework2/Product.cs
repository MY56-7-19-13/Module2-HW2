using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class Product
    {
        private string _nameProduct;
        private int _priceOfProduct;
        public string NameProduct
        {
            get { return _nameProduct; }
        }

        public int PriceOfProduct
        {
            get { return _priceOfProduct; }
        }

        public Product(string nameProduct, int priceOfProduct)
        {
            _nameProduct = nameProduct;
            _priceOfProduct = priceOfProduct;
        }
    }
}
