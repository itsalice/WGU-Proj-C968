﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliceLyC968.Model
{
    internal class Product
    {
        //public static BindingList<Part> AssociatedParts = new BindingList<Part>();

        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public BindingList<Part> AssociatedParts { get; set; }

        public Product(int productID, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            AssociatedParts = new BindingList<Part>();
        }

        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int PartId)
        {
            bool isRemoved = false;
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == PartId)
                {
                    AssociatedParts.Remove(part);
                    isRemoved = true;
                }
                else
                {
                    isRemoved = false;
                }
            }

            return isRemoved;
        }

        public Part lookupAssociatedPart(int PartId)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == PartId) { 
                    return part;
                }
            }
            return null;
        }
    }
}
