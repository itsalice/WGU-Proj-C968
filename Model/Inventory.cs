using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AliceLyC968.Model
{
    internal class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static Product CurrProduct { get; set; }
        public static Part CurrPart { get; set; }

        private static int PartID { get; set; }
        private static int ProductID { get; set; }

        //static Inventory()
        //{
        //    addPart(new Inhouse(0, "Wheel", 12.99M, 12, 1, 13, 1234));
        //    addPart(new Inhouse(1, "Brake", 2.99M, 13, 1, 20, 4567));
        //    addPart(new Outsourced(2, "Horn", 12.55M, 20, 2, 20, "PD-BRITE"));
        //    addProduct(new Product(0, "Red Car", 125.99M, 7, 1, 10));
        //}

        public static void addProduct(Product product)
        {
            Products.Add(product);
        }

        public static bool removeProduct(int ProductID)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == ProductID)
                {
                    Products.Remove(product);
                    return true;
                }
            }
            return false;
        }

        public static Product lookupProduct(int ProductID)
        {
            foreach (Product prod in Products)
            {
                if (prod.ProductID == ProductID)
                {
                    return prod;
                }
            }

            return null;
        }

        public static void updateProduct(int ProductId, Product product)
        {
            foreach (Product prod in Products)
            {
                if (prod.ProductID == ProductId)
                {
                    prod.Name = product.Name;
                    prod.Price = product.Price;
                    prod.InStock = product.InStock;
                    prod.Min = product.Min;
                    prod.Max = product.Max;
                    prod.AssociatedParts = product.AssociatedParts;

                    System.Diagnostics.Trace.WriteLine(prod.AssociatedParts.Count);
                }
            }
        }

        public static void addPart(Part part)
        {
            AllParts.Add(part);
        }

        public static bool deletePart(int PartID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == PartID)
                {
                    AllParts.Remove(part);
                    return true;
                }
            }
            return false;
        }

        public static Part lookupPart(int PartID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == PartID)
                {
                    return part;
                }
            }

            return null;
        }

        public static void updatePart(int PartID, Part part)
        {
            if (PartID == part.PartID) {
                AllParts.Remove(part);
                AllParts.Add(part);
            }
            else
            {
                AllParts.Add(part);
            }
        }
    }
}
