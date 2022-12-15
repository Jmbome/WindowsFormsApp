using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoeMWindowsFormsApp.GridTables;

namespace JoeMWindowsFormsApp
{
    class OutSourcedParts:Part
    {
        //private string companyName;

        public string CompanyName { get; set; }

        // Create Constructor
        public OutSourcedParts() { }
        public OutSourcedParts(int partID, string name, int inventory, decimal price, int max, int min)
        {
            IdCode = partID;
            Name = name;
            Inventory = inventory;
            Price = price;
            Max = max;
            Min = min;
        }

        public OutSourcedParts(int partID, string name, int inventory, decimal price, int max, int min, string compName)
        {
            IdCode = partID;
            Name = name;
            Inventory = inventory;
            Price = price;
            Max = max;
            Min = min;
            CompanyName = compName;
        }
    }
}
