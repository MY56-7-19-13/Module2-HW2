using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class Order
    {
        private int _createId = new Random().Next(212, 73892);
        private int _orderId;
        public int OrderId
        {
            get { return _orderId; }
        }

        public List<Product> ProductsInOrder { get; set; }
        public Order(List<Product> productsInOrder)
        {
            ProductsInOrder = productsInOrder;
            _orderId = _createId;
        }
    }
}
