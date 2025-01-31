using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliceLyC968.Model
{
    internal class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced(int partId, string name, decimal price, int inStock, int min, int max, string companyName)
        {
            PartID = partId;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            CompanyName = companyName;
        }
    }
}
