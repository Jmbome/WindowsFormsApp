using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoeMWindowsFormsApp.GridTables
{
   public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int IdCode { get; set; }
        public string Name { get; set; }
        public int Inventory { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product() { }
        public Product(int prodID, string name, int inventory, decimal price, int max, int min)
        {
            IdCode = prodID;
            Name = name;
            Inventory = inventory;
            Price = price;
            Max = max;
            Min = min;
        }


        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }


        //Delete AssoicatedPart
        public  bool removeAssoicatedPart(Part part)
        {
            Part partToDelete = lookupAssoicatedPart(part);
            try
            {
                AssociatedParts.Remove(partToDelete);
                return true;
            }
            catch
            {
                return false;
            }
        }


        //Lookup AssoicatedPart
        public  Part lookupAssoicatedPart(Part prt)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.IdCode == prt.IdCode)
                {
                    return part;
                }
            }

            return null;
        }
    }
}
