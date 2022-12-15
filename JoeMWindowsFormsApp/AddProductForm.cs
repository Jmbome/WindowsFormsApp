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
    public partial class AddProductForm : Form
    {
        Product product = new Product();
        public AddProductForm()
        {
            InitializeComponent();


            // Populate All Candidate Parts grid
            AllCandidatePartsDataGridView.DataSource = Inventory.parts;
            AssociatePartsDataGridView.DataSource = product.AssociatedParts;
        }

        // Clears Selection
        private void DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AllCandidatePartsDataGridView.ClearSelection();
            AssociatePartsDataGridView.ClearSelection();
        }


        // Add part to Associate part list
        private void AddCandidatePartButton_Click(object sender, EventArgs e)
        {
            if (AllCandidatePartsDataGridView.CurrentRow == null || !AllCandidatePartsDataGridView.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing was selected");
            }
            else
            {
                Part SelectedPart =  AllCandidatePartsDataGridView.CurrentRow.DataBoundItem as Part;
                product.AddAssociatedPart(SelectedPart);

            }
        }

        // candidate part search event listener
        private void SearchCandidatePartsButton_Click(object sender, EventArgs e)
        {
            string searchValue = CandidatePartsSearchTextBox.Text;
            bool found = false;

            if (searchValue != "")
            {
                for (int i = 0; i < Inventory.parts.Count; i++)
                {
                    if (Inventory.parts[i].Name.ToUpper().Contains(searchValue.ToUpper()))
                    {
                        AllCandidatePartsDataGridView.Rows[i].Selected = true;
                        found = true;
                    }
                }
                if (!found)
                {
                    MessageBox.Show("Record is not available!");
                }
            }
        }

        // AddProductForm load event listener
        private void AddProductForm_Load(object sender, EventArgs e)
        {
            ProductSaveButton.Enabled = false;
            NameTextBox.BackColor = Color.Salmon;
            InventoryTextBox.BackColor = Color.Salmon;
            PriceTextBox.BackColor = Color.Salmon;
            MaxTextBox.BackColor = Color.Salmon;
            MinTextBox.BackColor = Color.Salmon;
        }


        private void CheckIfNumeric(string checkData)

        {

            /*Method to check to see if textbox string value

             * is Numeric or not.*/

            var isNumeric = int.TryParse(checkData, out int n);

            if (isNumeric == false)

            {
                throw new Exception();
            }

        }

        
        private void CheckIfDecimal(string checkDec)

        {

            /*Method to check to see if textbox string value

            * is a Decimal or not.*/



            decimal decNum;

            var isDecimal = decimal.TryParse(checkDec, out decNum);

            if (isDecimal == false)

            {

                throw new Exception();

            }

        }

        /*Method to enable ProducttSaveButton only if all textbox

         * fields have been filled out correctly.*/
        private void EnableSaveButton()

        {

            if ((NameTextBox.BackColor == Color.White) && (PriceTextBox.BackColor == Color.White)
                && (MinTextBox.BackColor == Color.White) && (MaxTextBox.BackColor == Color.White)
                && (InventoryTextBox.BackColor == Color.White))

            {

                ProductSaveButton.Enabled = true;

            }

        }

        // NameTextBox event listener
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            /*When NameTextBox field changes verify if box is null or empty.

         * Change color if value is null or empty and disable Save Button

         * else change color to white if correct value is entered.*/



            if (string.IsNullOrEmpty(NameTextBox.Text))

            {

                NameTextBox.BackColor = Color.Salmon;

                ProductSaveButton.Enabled = false;

            }

            else

            {

                NameTextBox.BackColor = Color.White;

                EnableSaveButton();

            }
        }


        // Inventory event listener
        private void InventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            /*On InventorytextBox change, verify if value is numeric or not. If

            * value is numeric change color to white and call the EnableSaveButton

            * method. If value is not numeric, catch the exception from the

            * CheckIfNumeric method and change color to salmon, display tooltip to

            * provide hint of what needs to be entered and disable PartSaveButton.*/



            try

            {

                CheckIfNumeric(InventoryTextBox.Text);

                InventoryTextBox.BackColor = Color.White;

                EnableSaveButton();

            }

            catch (Exception)

            {

                InventoryTextBox.BackColor = Color.Salmon;

                ToolTip toolTipNum = new ToolTip();

                toolTipNum.SetToolTip(InventoryTextBox, "Numeric values only.");

                ProductSaveButton.Enabled = false;

            }
        }

        // Price event listener
        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {
            try

            {

                CheckIfDecimal(PriceTextBox.Text);

                PriceTextBox.BackColor = Color.White;

                EnableSaveButton();

            }

            catch (Exception)

            {

                PriceTextBox.BackColor = Color.Salmon;

                ToolTip toolTipDec = new ToolTip();

                toolTipDec.SetToolTip(PriceTextBox, "Numeric or Decimal values only.");

                ProductSaveButton.Enabled = false;

            }
        }

        // Max event listener
        private void MaxTextBox_TextChanged(object sender, EventArgs e)
        {
            try

            {

                CheckIfNumeric(MaxTextBox.Text);

                MaxTextBox.BackColor = Color.White;

                EnableSaveButton();

            }

            catch (Exception)

            {

                MaxTextBox.BackColor = Color.Salmon;

                ToolTip toolTipNum = new ToolTip();

                toolTipNum.SetToolTip(MaxTextBox, "Numeric values only.");

                ProductSaveButton.Enabled = false;

            }
        }

        //Min event listener
        private void MinTextBox_TextChanged(object sender, EventArgs e)
        {
            try

            {

                CheckIfNumeric(MinTextBox.Text);

                MinTextBox.BackColor = Color.White;

                EnableSaveButton();

            }

            catch (Exception)

            {

                MinTextBox.BackColor = Color.Salmon;

                ToolTip toolTipNum = new ToolTip();

                toolTipNum.SetToolTip(MinTextBox, "Numeric values only.");

                ProductSaveButton.Enabled = false;

            }
        }

        //ProductSaveButton event listener
        private void ProductSaveButton_Click(object sender, EventArgs e)
        {
            //throws an exception if min value is greater than max value
            if (Int32.Parse(MinTextBox.Text) > Int32.Parse(MaxTextBox.Text))

            {
                MessageBox.Show("Min value cannot be greater than Max value.");
                return;
            }


            /*throws an exception if inventory value is lesser than min value
             and greter than max value */
            if (Int32.Parse(InventoryTextBox.Text) < Int32.Parse(MinTextBox.Text) || Int32.Parse(InventoryTextBox.Text) > Int32.Parse(MaxTextBox.Text))
            {
                MessageBox.Show("Inventory cannot be greater than Max or less than Min.");
                return;
            }



            var myRandom = new Random();
            var newProductId = myRandom.Next(1000);


            var productName = NameTextBox.Text;
            var productPrice = decimal.Parse(PriceTextBox.Text);
            var maxValue = int.Parse(MaxTextBox.Text);
            var MinValue = int.Parse(MinTextBox.Text);
            var inventoryValue = int.Parse(InventoryTextBox.Text);


           
                var newProduct = new Product
                {
                    IdCode = newProductId,
                    Name = productName,
                    Inventory = inventoryValue,
                    Price = productPrice,
                    Max = maxValue,
                    Min = MinValue,
                   
                };
                Inventory.addProduct(newProduct);

            foreach (Part part in product.AssociatedParts)
            {
                newProduct.AddAssociatedPart(part);
            }

            this.Close();
        }

        //cancel and closes AddProduct form without any changes 
        private void ProductCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Delete Associated parts
        private void AssPartDeleteBtn_Click(object sender, EventArgs e)
        {
            if (AssociatePartsDataGridView.CurrentRow == null || !AssociatePartsDataGridView.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing was selected");
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Part SelectedPart = AssociatePartsDataGridView.CurrentRow.DataBoundItem as Part;
                    product.removeAssoicatedPart(SelectedPart);
                }
            }
        }
    }
}
