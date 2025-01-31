using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliceLyC968.Model
{
    internal class Inhouse : Part
    {
        public int MachineID { get; set; }

        public Inhouse(int partId, string name, decimal price, int inStock, int min, int max, int machineId)
        {
            PartID = partId;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            MachineID = machineId;
        }
    }
}
