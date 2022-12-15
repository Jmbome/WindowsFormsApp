
namespace JoeMWindowsFormsApp
{
    partial class AddPartsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.InventorytextBox = new System.Windows.Forms.TextBox();
            this.PriceCostTextBox = new System.Windows.Forms.TextBox();
            this.MaxtextBox = new System.Windows.Forms.TextBox();
            this.IDCompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.MinTextBox = new System.Windows.Forms.TextBox();
            this.PartSaveButton = new System.Windows.Forms.Button();
            this.PrtFrmCancelButton = new System.Windows.Forms.Button();
            this.InHouseRadioButton = new System.Windows.Forms.RadioButton();
            this.OutSourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.AddPart = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Inventorylabel = new System.Windows.Forms.Label();
            this.PriceCostlabel = new System.Windows.Forms.Label();
            this.Maxlabel = new System.Windows.Forms.Label();
            this.MinLabel = new System.Windows.Forms.Label();
            this.LabelIDName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // IDtextBox
            // 
            this.IDtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDtextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.IDtextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.IDtextBox.Enabled = false;
            this.IDtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDtextBox.Location = new System.Drawing.Point(179, 80);
            this.IDtextBox.Multiline = true;
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.ReadOnly = true;
            this.IDtextBox.Size = new System.Drawing.Size(250, 34);
            this.IDtextBox.TabIndex = 0;
            // 
            // NametextBox
            // 
            this.NametextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NametextBox.Location = new System.Drawing.Point(179, 132);
            this.NametextBox.Multiline = true;
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(250, 37);
            this.NametextBox.TabIndex = 1;
            this.NametextBox.TextChanged += new System.EventHandler(this.NametextBox_TextChanged_1);
            // 
            // InventorytextBox
            // 
            this.InventorytextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InventorytextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventorytextBox.Location = new System.Drawing.Point(179, 185);
            this.InventorytextBox.Multiline = true;
            this.InventorytextBox.Name = "InventorytextBox";
            this.InventorytextBox.Size = new System.Drawing.Size(250, 40);
            this.InventorytextBox.TabIndex = 2;
            this.InventorytextBox.TextChanged += new System.EventHandler(this.InventorytextBox_TextChanged);
            // 
            // PriceCostTextBox
            // 
            this.PriceCostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceCostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceCostTextBox.Location = new System.Drawing.Point(179, 246);
            this.PriceCostTextBox.Multiline = true;
            this.PriceCostTextBox.Name = "PriceCostTextBox";
            this.PriceCostTextBox.Size = new System.Drawing.Size(250, 39);
            this.PriceCostTextBox.TabIndex = 3;
            this.PriceCostTextBox.TextChanged += new System.EventHandler(this.PriceCostTextBox_TextChanged);
            // 
            // MaxtextBox
            // 
            this.MaxtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxtextBox.Location = new System.Drawing.Point(179, 306);
            this.MaxtextBox.Multiline = true;
            this.MaxtextBox.Name = "MaxtextBox";
            this.MaxtextBox.Size = new System.Drawing.Size(126, 41);
            this.MaxtextBox.TabIndex = 4;
            this.MaxtextBox.TextChanged += new System.EventHandler(this.MaxtextBox_TextChanged);
            // 
            // IDCompanyNameTextBox
            // 
            this.IDCompanyNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDCompanyNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDCompanyNameTextBox.Location = new System.Drawing.Point(179, 365);
            this.IDCompanyNameTextBox.Multiline = true;
            this.IDCompanyNameTextBox.Name = "IDCompanyNameTextBox";
            this.IDCompanyNameTextBox.Size = new System.Drawing.Size(250, 35);
            this.IDCompanyNameTextBox.TabIndex = 5;
            this.IDCompanyNameTextBox.Text = "\r\n";
            this.IDCompanyNameTextBox.TextChanged += new System.EventHandler(this.IDCompanyNameTextBox_TextChanged);
            // 
            // MinTextBox
            // 
            this.MinTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinTextBox.Location = new System.Drawing.Point(380, 306);
            this.MinTextBox.Multiline = true;
            this.MinTextBox.Name = "MinTextBox";
            this.MinTextBox.Size = new System.Drawing.Size(132, 41);
            this.MinTextBox.TabIndex = 6;
            this.MinTextBox.TextChanged += new System.EventHandler(this.MinTextBox_TextChanged);
            // 
            // PartSaveButton
            // 
            this.PartSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartSaveButton.Location = new System.Drawing.Point(330, 420);
            this.PartSaveButton.Name = "PartSaveButton";
            this.PartSaveButton.Size = new System.Drawing.Size(75, 43);
            this.PartSaveButton.TabIndex = 7;
            this.PartSaveButton.Text = "Save";
            this.PartSaveButton.UseVisualStyleBackColor = true;
            this.PartSaveButton.Click += new System.EventHandler(this.PartSaveButton_Click);
            // 
            // PrtFrmCancelButton
            // 
            this.PrtFrmCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrtFrmCancelButton.Location = new System.Drawing.Point(437, 420);
            this.PrtFrmCancelButton.Name = "PrtFrmCancelButton";
            this.PrtFrmCancelButton.Size = new System.Drawing.Size(75, 43);
            this.PrtFrmCancelButton.TabIndex = 8;
            this.PrtFrmCancelButton.Text = "Cancel";
            this.PrtFrmCancelButton.UseVisualStyleBackColor = true;
            this.PrtFrmCancelButton.Click += new System.EventHandler(this.PrtFrmCancelButton_Click);
            // 
            // InHouseRadioButton
            // 
            this.InHouseRadioButton.AutoSize = true;
            this.InHouseRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InHouseRadioButton.Location = new System.Drawing.Point(148, 21);
            this.InHouseRadioButton.Name = "InHouseRadioButton";
            this.InHouseRadioButton.Size = new System.Drawing.Size(94, 21);
            this.InHouseRadioButton.TabIndex = 9;
            this.InHouseRadioButton.TabStop = true;
            this.InHouseRadioButton.Text = "In-House";
            this.InHouseRadioButton.UseVisualStyleBackColor = true;
            this.InHouseRadioButton.CheckedChanged += new System.EventHandler(this.InHouseRadioButton_CheckedChanged_1);
            // 
            // OutSourcedRadioButton
            // 
            this.OutSourcedRadioButton.AutoSize = true;
            this.OutSourcedRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutSourcedRadioButton.Location = new System.Drawing.Point(292, 21);
            this.OutSourcedRadioButton.Name = "OutSourcedRadioButton";
            this.OutSourcedRadioButton.Size = new System.Drawing.Size(113, 21);
            this.OutSourcedRadioButton.TabIndex = 10;
            this.OutSourcedRadioButton.TabStop = true;
            this.OutSourcedRadioButton.Text = "Outsourced";
            this.OutSourcedRadioButton.UseVisualStyleBackColor = true;
            this.OutSourcedRadioButton.CheckedChanged += new System.EventHandler(this.OutSourcedRadioButton_CheckedChanged);
            // 
            // AddPart
            // 
            this.AddPart.AutoSize = true;
            this.AddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPart.Location = new System.Drawing.Point(12, 21);
            this.AddPart.Name = "AddPart";
            this.AddPart.Size = new System.Drawing.Size(72, 18);
            this.AddPart.TabIndex = 11;
            this.AddPart.Text = "Add Part";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel.Location = new System.Drawing.Point(98, 85);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(23, 17);
            this.IDlabel.TabIndex = 12;
            this.IDlabel.Text = "ID";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.Location = new System.Drawing.Point(98, 137);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(49, 17);
            this.Namelabel.TabIndex = 13;
            this.Namelabel.Text = "Name";
            // 
            // Inventorylabel
            // 
            this.Inventorylabel.AutoSize = true;
            this.Inventorylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventorylabel.Location = new System.Drawing.Point(98, 190);
            this.Inventorylabel.Name = "Inventorylabel";
            this.Inventorylabel.Size = new System.Drawing.Size(75, 17);
            this.Inventorylabel.TabIndex = 14;
            this.Inventorylabel.Text = "Inventory";
            // 
            // PriceCostlabel
            // 
            this.PriceCostlabel.AutoSize = true;
            this.PriceCostlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceCostlabel.Location = new System.Drawing.Point(79, 251);
            this.PriceCostlabel.Name = "PriceCostlabel";
            this.PriceCostlabel.Size = new System.Drawing.Size(92, 17);
            this.PriceCostlabel.TabIndex = 15;
            this.PriceCostlabel.Text = "Price / Cost";
            // 
            // Maxlabel
            // 
            this.Maxlabel.AutoSize = true;
            this.Maxlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maxlabel.Location = new System.Drawing.Point(98, 318);
            this.Maxlabel.Name = "Maxlabel";
            this.Maxlabel.Size = new System.Drawing.Size(36, 17);
            this.Maxlabel.TabIndex = 16;
            this.Maxlabel.Text = "Max";
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinLabel.Location = new System.Drawing.Point(327, 318);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(33, 17);
            this.MinLabel.TabIndex = 17;
            this.MinLabel.Text = "Min";
            // 
            // LabelIDName
            // 
            this.LabelIDName.AutoSize = true;
            this.LabelIDName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIDName.Location = new System.Drawing.Point(28, 370);
            this.LabelIDName.Name = "LabelIDName";
            this.LabelIDName.Size = new System.Drawing.Size(93, 17);
            this.LabelIDName.TabIndex = 18;
            this.LabelIDName.Text = "Machine  ID";
            // 
            // AddPartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 497);
            this.Controls.Add(this.LabelIDName);
            this.Controls.Add(this.MinLabel);
            this.Controls.Add(this.Maxlabel);
            this.Controls.Add(this.PriceCostlabel);
            this.Controls.Add(this.Inventorylabel);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.AddPart);
            this.Controls.Add(this.OutSourcedRadioButton);
            this.Controls.Add(this.InHouseRadioButton);
            this.Controls.Add(this.PrtFrmCancelButton);
            this.Controls.Add(this.PartSaveButton);
            this.Controls.Add(this.MinTextBox);
            this.Controls.Add(this.IDCompanyNameTextBox);
            this.Controls.Add(this.MaxtextBox);
            this.Controls.Add(this.PriceCostTextBox);
            this.Controls.Add(this.InventorytextBox);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.IDtextBox);
            this.Name = "AddPartsForm";
            this.Text = "Part";
            this.Load += new System.EventHandler(this.AddPartsForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button PrtFrmCancelButton;
        private System.Windows.Forms.Button PartSaveButton;
        private System.Windows.Forms.TextBox MinTextBox;
        private System.Windows.Forms.TextBox IDCompanyNameTextBox;
        private System.Windows.Forms.TextBox MaxtextBox;
        private System.Windows.Forms.TextBox PriceCostTextBox;
        private System.Windows.Forms.TextBox InventorytextBox;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.Label LabelIDName;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Label Maxlabel;
        private System.Windows.Forms.Label PriceCostlabel;
        private System.Windows.Forms.Label Inventorylabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label AddPart;
        private System.Windows.Forms.RadioButton OutSourcedRadioButton;
        private System.Windows.Forms.RadioButton InHouseRadioButton;
    }
}