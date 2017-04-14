using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCToolsTutorial.Models
{
    public class LinqValueCalculator
    {
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return products.Sum<Product>(p => p.Price);
        }
    }
}
