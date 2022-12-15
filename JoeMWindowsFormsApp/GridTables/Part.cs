using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoeMWindowsFormsApp.GridTables
{
   public abstract class Part
    {
        public int IdCode { get; set; }
        public string Name { get; set; }
        public int Inventory { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

       


        /*    public override string ToString()
            {
                return IdCode + Name + Inventory + Price + Min + Max;
            }
          */
    }

    
}
