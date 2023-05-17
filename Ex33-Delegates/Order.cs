using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ex33_Delegates
{
    public class Order
    {

        public BonusProvider Bonus { get; set; }

        public List<Product> products { get; set; }

        public Order()
        {
            this.products = new List<Product>();
        }

        public void AddProduct(Product product) { products.Add(product);}

        public double GetValueOfProducts() {
            double sum = 0;
            foreach(Product product in products) { sum += product.Value; }
            return sum;
        }

        public double GetBonus()
        {
            return Bonus(GetValueOfProducts());
        }

        public double GetTotalPrice()
        {
            return GetValueOfProducts() - GetBonus();
        }


    }
}
