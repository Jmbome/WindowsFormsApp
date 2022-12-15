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
    public partial class AddPartsForm : Form
    {
        public AddPartsForm()
        {
            InitializeComponent();

        }

       
        //Outsourced radio button click Event listener 
        private void OutSourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LabelIDName.Text = "Company Name";

           

            if (string.IsNullOrWhiteSpace(IDCompanyNameTextBox.Text))

            {

                ToolTip toolTipNonNum = new ToolTip();

                toolTipNonNum.SetToolTip(IDCompanyNameTextBox, "Please enter company name.");

                IDCompanyNameTextBox.BackColor = Color.Salmon;

            }

            else

            {

                ToolTip toolTipNonNum = new ToolTip();

                toolTipNonNum.SetToolTip(IDCompanyNameTextBox, "Please enter company name.");

                IDCompanyNameTextBox.BackColor = Color.White;

            }

        }

        //Inhouse radio button click Event listener 
        private void InHouseRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            LabelIDName.Text = "Machine ID";

            try

            {

                CheckIfNumeric(IDCompanyNameTextBox.Text);

                ToolTip toolTipNum = new ToolTip();

                toolTipNum.SetToolTip(IDCompanyNameTextBox, "Machine ID number required.");

                IDCompanyNameTextBox.BackColor = Color.White;

            }

            catch (Exception)

            {

                ToolTip toolTipNum = new ToolTip();

                toolTipNum.SetToolTip(IDCompanyNameTextBox, "Machine ID number required.");

                IDCompanyNameTextBox.BackColor = Color.Salmon;

            }

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

        /*Method to enable PartSaveButton only if all textbox

           * fields have been filled out correctly.*/
        private void EnableSaveButton()

        {

            if ((NametextBox.BackColor == Color.White) && (PriceCostTextBox.BackColor == Color.White) 
                && (MinTextBox.BackColor == Color.White) && (MaxtextBox.BackColor == Color.White) 
                && (InventorytextBox.BackColor == Color.White) && (IDCompanyNameTextBox.BackColor == Color.White))

            {

                PartSaveButton.Enabled = true;

            }

        }

        //Sets up AddPartsForm on loading
        private void AddPartsForm_Load_1(object sender, EventArgs e)
        {

            InHouseRadioButton.Checked = true;
            PartSaveButton.Enabled = false;
            NametextBox.BackColor = Color.Salmon;
            InventorytextBox.BackColor = Color.Salmon;
            PriceCostTextBox.BackColor = Color.Salmon;
            MaxtextBox.BackColor = Color.Salmon;
            MinTextBox.BackColor = Color.Salmon;
            IDCompanyNameTextBox.BackColor = Color.Salmon;


        }


        //NametextBox event listener
        private void NametextBox_TextChanged_1(object sender, EventArgs e)
        {
            /*When NameTextBox field changes verify if box is null or empty.

           * Change color if value is null or empty and disable Save Button

           * else change color to white if correct value is entered.*/



            if (string.IsNullOrEmpty(NametextBox.Text))

            {

                NametextBox.BackColor = Color.Salmon;

                PartSaveButton.Enabled = false;

            }

            else

            {

                NametextBox.BackColor = Color.White;

                EnableSaveButton();

            }
        }


        //InventorytextBox event listener
        private void InventorytextBox_TextChanged(object sender, EventArgs e)
        {
            /*On InventorytextBox change, verify if value is numeric or not. If

             * value is numeric change color to white and call the EnableSaveButton

             * method. If value is not numeric, catch the exception from the

             * CheckIfNumeric method and change color to salmon, display tooltip to

             * provide hint of what needs to be entered and disable PartSaveButton.*/



            try

            {

                CheckIfNumeric(InventorytextBox.Text);

                InventorytextBox.BackColor = Color.White;

                EnableSaveButton();

            }

            catch (Exception)

            {

                InventorytextBox.BackColor = Color.Salmon;

                ToolTip toolTipNum = new ToolTip();

                toolTipNum.SetToolTip(InventorytextBox, "Numeric values only.");

                PartSaveButton.Enabled = false;

            }
        }


        //Part Save button event listener
        private void PartSaveButton_Click(object sender, EventArgs e)
        {
           // Form1 mainForm = new Form1();
            //throws an exception if min value is greater than max value
             if (Int32.Parse(MinTextBox.Text) > Int32.Parse(MaxtextBox.Text))

            {
                MessageBox.Show("Min value cannot be greater than Max value.");
                return;
            }


             /*throws an exception if inventory value is lesser than min value
              and greter than max value */
            if (Int32.Parse(InventorytextBox.Text) < Int32.Parse(MinTextBox.Text) || Int32.Parse(InventorytextBox.Text) > Int32.Parse(MaxtextBox.Text))
            {
                MessageBox.Show("Inventory cannot be greater than Max or less than Min.");
                return;
            }



            var myRandom = new Random();
            var newPartId = myRandom.Next(1000);


            var partName = NametextBox.Text;
            var partPrice = decimal.Parse(PriceCostTextBox.Text);
            var maxValue = int.Parse(MaxtextBox.Text);
            var MinValue = int.Parse(MinTextBox.Text);
            var inventoryValue = int.Parse(InventorytextBox.Text);


            if (InHouseRadioButton.Checked)
            {
                var machineId = int.Parse(IDCompanyNameTextBox.Text);

                var tempInHouse = new InHouseParts
                {
                    IdCode = newPartId,
                    Name = partName,
                    Inventory = inventoryValue,
                    Price = partPrice,
                    Max = maxValue,
                    Min = MinValue,
                    MachineID = machineId
                };
                Inventory.addPart(tempInHouse);
            }
            else
            {
                var comName = IDCompanyNameTextBox.Text;

                var tempOutSourced = new OutSourcedParts
                {
                    IdCode = newPartId,
                    Name = partName,
                    Inventory = inventoryValue,
                    Price = partPrice,
                    Max = maxValue,
                    Min = MinValue,
                    CompanyName = comName
                };
                Inventory.addPart(tempOutSourced);
               
            }
            this.Close();
           // mainForm.Visible = true;
        }

        //Price/Cost event Listener
        private void PriceCostTextBox_TextChanged(object sender, EventArgs e)
        {
            try

            {

                CheckIfDecimal(PriceCostTextBox.Text);

                PriceCostTextBox.BackColor = Color.White;

                EnableSaveButton();

            }

            catch (Exception)

            {

                PriceCostTextBox.BackColor = Color.Salmon;

                ToolTip toolTipDec = new ToolTip();

                toolTipDec.SetToolTip(PriceCostTextBox, "Numeric or Decimal values only.");

                PartSaveButton.Enabled = false;

            }
        }

        // MaxTextBox event listener
        private void MaxtextBox_TextChanged(object sender, EventArgs e)
        {
            try

            {

                CheckIfNumeric(MaxtextBox.Text);

                MaxtextBox.BackColor = Color.White;

                EnableSaveButton();

            }

            catch (Exception)

            {

                MaxtextBox.BackColor = Color.Salmon;

                ToolTip toolTipNum = new ToolTip();

                toolTipNum.SetToolTip(MaxtextBox, "Numeric values only.");

                PartSaveButton.Enabled = false;

            }
        }

        //MinTextBox event listener
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

                PartSaveButton.Enabled = false;

            }
        }

        //ID/CompanyName event listener
        private void IDCompanyNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (InHouseRadioButton.Checked)

            {

                if (string.IsNullOrWhiteSpace(IDCompanyNameTextBox.Text) || !(int.TryParse(IDCompanyNameTextBox.Text, out int x)))

                {

                    IDCompanyNameTextBox.BackColor = Color.Salmon;

                    PartSaveButton.Enabled = false;

                }

                else

                {

                    IDCompanyNameTextBox.BackColor = Color.White;

                    EnableSaveButton();

                }

            }

            if (OutSourcedRadioButton.Checked)

            {

                if (string.IsNullOrWhiteSpace(IDCompanyNameTextBox.Text))

                {

                    IDCompanyNameTextBox.BackColor = Color.Salmon;

                    PartSaveButton.Enabled = false;

                }
                else
                {

                    IDCompanyNameTextBox.BackColor = Color.White;

                    EnableSaveButton();

                }

            }
        }


        /*cancel button event listener
         * close AddPart form
         */
        private void PrtFrmCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
