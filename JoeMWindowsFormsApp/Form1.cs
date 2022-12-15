using JoeMWindowsFormsApp.GridTables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoeMWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // pre-populate the list
            Inventory.Product();
            Inventory.Part();

            // Set Data Source
            PartsView.DataSource = Inventory.parts;
            ProductsView.DataSource = Inventory.products;
            

            // Remove Bottom row
            PartsView.AllowUserToAddRows = false;
            ProductsView.AllowUserToAddRows = false;
        }


        // Search through  list of parts in PartsView grid 
        private void SearchPartButton_Click(object sender, EventArgs e)
        {
            string searchValue = PartSearchTextBox.Text;
            bool found = false;

          if (searchValue != "")
          {
            for (int i = 0; i < Inventory.parts.Count; i++)
            {
                if (Inventory.parts[i].Name.ToUpper().Contains(searchValue.ToUpper()))
                {
                    PartsView.Rows[i].Selected = true;
                    found = true;
                }
            }
            if (!found)
            {
                MessageBox.Show("Record is not available!");
            }
          }  
        }

        //Display AddPart Form
        private void AddPartBtn_Click(object sender, EventArgs e)
        {
            AddPartsForm part = new AddPartsForm();
            part.Show();
           // this.Visible = false;
        }
         
        //Display ModifyPart Form
        private void ModifyPartButton_Click(object sender, EventArgs e)
        {
             if (PartsView.CurrentRow == null || !PartsView.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing was selected");
                return;
            }
            else
            {
                var selectedGridPart = (Part)PartsView.CurrentRow.DataBoundItem;
                ModifyPartsForm part = new ModifyPartsForm(selectedGridPart);
                part.Show();
                
            } 
        }

        //Display AddProduct Form
        private void AddProductButton_Click(object sender, EventArgs e)
        {
              AddProductForm product = new AddProductForm();
             product.Show();
        }

        //Display ModifyProduct Form
        private void ModifyProductButton_Click(object sender, EventArgs e)
        {
            if (ProductsView.CurrentRow == null || !ProductsView.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing was selected");
                return;
            }
            else
            {
                var selectedGridProduct = (Product)ProductsView.CurrentRow.DataBoundItem;
                ModifyProductForm product = new ModifyProductForm(selectedGridProduct);
                product.Show();

            }
            
        }

        // Clears Selection
        private void BindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            PartsView.ClearSelection();
            ProductsView.ClearSelection();
            
        }


        //Delete Part row
        private void PartsDeleteButton_Click(object sender, EventArgs e)
        {
            if (PartsView.CurrentRow == null || !PartsView.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing was selected");
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Part SelectedPart = PartsView.CurrentRow.DataBoundItem as Part;
                    Inventory.parts.Remove(SelectedPart);
                }
            }
        }


        // Search through  list of products in ProductsView grid 
        private void SearchProductbutton_Click(object sender, EventArgs e)
        {
            string searchValue = ProductSearchTextBox.Text;
            bool found = false;

            if (searchValue != "")
            {
                for (int i = 0; i < Inventory.products.Count; i++)
                {
                    if (Inventory.products[i].Name.ToUpper().Contains(searchValue.ToUpper()))
                    {
                        ProductsView.Rows[i].Selected = true;
                        found = true;
                    }
                }
                if (!found)
                {
                    MessageBox.Show("Record is not available!");
                }
            }
        }


        //Deletes selected product
        private void ProductDeleteButton_Click(object sender, EventArgs e)
        {
            if (ProductsView.CurrentRow == null || !ProductsView.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing was selected");
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Product SelectedProduct = ProductsView.CurrentRow.DataBoundItem as Product;

                    if (SelectedProduct.AssociatedParts.Count > 0)
                    {
                        MessageBox.Show("Cannot delete product with associated parts. Please remove parts attached to this product.");
                        return;
                    }
                    Inventory.products.Remove(SelectedProduct);
                }
            }
        }

        //Exit Main Form
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
