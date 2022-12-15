using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JoeMWindowsFormsApp.GridTables;

namespace JoeMWindowsFormsApp
{
     public class InHouseParts: Part
    {
        private int machineID;

        public int MachineID { get; set; }

        // Create Constructor

        public InHouseParts() { }
        public InHouseParts(int partID, string name, int inventory, decimal price, int max, int min)
        {
            IdCode = partID;
            Inventory = inventory;
            Name = name;
            Price = price;
            Max = max;
            Min = min;
           
        }
        public InHouseParts(int partID, string name, int inventory, decimal price, int max, int min, int machineID)
        {
            IdCode = partID;
            Name = name;
            Inventory = inventory;
            Price =  price;
            Max = max;
            Min = min;
            MachineID = machineID;
        }

      
    }

}
