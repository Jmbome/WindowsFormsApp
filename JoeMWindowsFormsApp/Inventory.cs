using JoeMWindowsFormsApp.GridTables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoeMWindowsFormsApp
{
    class  Inventory
    {
        public static BindingList<Product> products = new BindingList<Product>();
        public static BindingList<Part> parts = new BindingList<Part>();
        public static void Product()
        {
            products.Add(
                new Product { IdCode = 0, Name = "Red Bicycle", Inventory = 15, Price = 11.44M, Min = 1, Max = 25 }
                );
            products.Add(
                new Product { IdCode = 1, Name = "Yellow Bicycle", Inventory = 19, Price = 9.66M, Min = 1, Max = 20 }
                );
            products.Add(
                new Product { IdCode = 2, Name = "Blue Bicycle", Inventory = 5, Price = 12.77M, Min = 1, Max = 25 }
                );

        }

        public static void Part()
        {
            parts.Add(
                new InHouseParts { IdCode = 0, Name = "Wheel", Inventory = 15, Price = 12.11M, Min = 5, Max = 25, MachineID = 45 }
                );
            parts.Add(
                new InHouseParts { IdCode = 1, Name = "Pedal", Inventory = 11, Price = 8.22M, Min = 5, Max = 25, MachineID = 60 }
                );
            parts.Add(
                new InHouseParts { IdCode = 2, Name = "Chain", Inventory = 12, Price = 8.33M, Min = 5, Max = 25, MachineID = 45 }
                );
            parts.Add(
                new InHouseParts { IdCode = 3, Name = "Seat", Inventory = 8, Price = 4.55M, Min = 2, Max = 15, MachineID = 60 }
                );
            parts.Add(
               new OutSourcedParts { IdCode = 4, Name = "Gasket", Inventory = 4, Price = 20.11M, Min = 5, Max = 25, CompanyName = "AutoZone" }
               );
            parts.Add(
                new OutSourcedParts { IdCode = 6, Name = "lamp", Inventory = 13, Price = 5.33M, Min = 5, Max = 25, CompanyName = "AutoZone" }
                );
           
        }


        /*********** METHODS ***********/

        // Add product
        public static void addProduct(Product item)
        {
            products.Add(item);
        }

        // Romove Product
        public static bool RemoveProduct(int prodID)
        {
            Product productToDelete = lookupProduct(prodID);
            try
            {
                products.Remove(productToDelete);
                return true;
            }
            catch
            {
                return false;
            }
          
        }

        // Lookup Product
        public static Product lookupProduct(int prodID)
        {
            foreach (Product prod in products)
            {
                if (prod.IdCode == prodID)
                {
                    return prod;
                }
            }
            Product emptyProd = new Product();                                        
            return emptyProd;
        }

        //Updates Product 
        public static void updateProduct(int prodID, Product updatedValue)
        {
            RemoveProduct(prodID);
            addProduct(updatedValue);

            foreach (Product currentValue in products)
            {
                if (currentValue.IdCode == prodID)                                       
                {
                    currentValue.AssociatedParts = updatedValue.AssociatedParts;
                }
            }
          
        }

        //Add Part
        public static void addPart(Part part)
        {
            parts.Add(part);
        }

        //Delete Part
        public static bool deletePart(int partId)
        {
            Part partToDelete = lookupPart(partId);
            try
            {
                parts.Remove(partToDelete);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Lookup Part
        public static Part lookupPart(int prtID)
        {
            foreach (Part part in parts)
            {
                if (part.IdCode == prtID)
                {
                    return part;
                }
            }

            return null;
        }

        //Update Part
        public static void updatePart(int prtID, Part prt)
        {

            deletePart(prtID);
            addPart(prt);
            
        }
    }
}
