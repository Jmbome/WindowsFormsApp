
namespace JoeMWindowsFormsApp
{
    partial class ModifyProductForm
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
            this.AllCandidatePartsDataGridView = new System.Windows.Forms.DataGridView();
            this.AssociatePartsDataGridView = new System.Windows.Forms.DataGridView();
            this.AssPartsDeleteBtn = new System.Windows.Forms.Button();
            this.ProdFormCancelBtn = new System.Windows.Forms.Button();
            this.ProductSaveButton = new System.Windows.Forms.Button();
            this.AddCandidatePartButton = new System.Windows.Forms.Button();
            this.SearchCandidatePartsButton = new System.Windows.Forms.Button();
            this.CandidatePartsSearchTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.InventoryTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.MaxTextBox = new System.Windows.Forms.TextBox();
            this.MinTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AllCandidatePartsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatePartsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AllCandidatePartsDataGridView
            // 
            this.AllCandidatePartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllCandidatePartsDataGridView.Location = new System.Drawing.Point(565, 101);
            this.AllCandidatePartsDataGridView.MultiSelect = false;
            this.AllCandidatePartsDataGridView.Name = "AllCandidatePartsDataGridView";
            this.AllCandidatePartsDataGridView.ReadOnly = true;
            this.AllCandidatePartsDataGridView.RowHeadersVisible = false;
            this.AllCandidatePartsDataGridView.RowHeadersWidth = 51;
            this.AllCandidatePartsDataGridView.RowTemplate.Height = 24;
            this.AllCandidatePartsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllCandidatePartsDataGridView.Size = new System.Drawing.Size(591, 185);
            this.AllCandidatePartsDataGridView.TabIndex = 0;
            this.AllCandidatePartsDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataBindingComplete);
            // 
            // AssociatePartsDataGridView
            // 
            this.AssociatePartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssociatePartsDataGridView.Location = new System.Drawing.Point(565, 388);
            this.AssociatePartsDataGridView.MultiSelect = false;
            this.AssociatePartsDataGridView.Name = "AssociatePartsDataGridView";
            this.AssociatePartsDataGridView.ReadOnly = true;
            this.AssociatePartsDataGridView.RowHeadersVisible = false;
            this.AssociatePartsDataGridView.RowHeadersWidth = 51;
            this.AssociatePartsDataGridView.RowTemplate.Height = 24;
            this.AssociatePartsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AssociatePartsDataGridView.Size = new System.Drawing.Size(591, 177);
            this.AssociatePartsDataGridView.TabIndex = 1;
            // 
            // AssPartsDeleteBtn
            // 
            this.AssPartsDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssPartsDeleteBtn.Location = new System.Drawing.Point(1043, 593);
            this.AssPartsDeleteBtn.Name = "AssPartsDeleteBtn";
            this.AssPartsDeleteBtn.Size = new System.Drawing.Size(73, 30);
            this.AssPartsDeleteBtn.TabIndex = 2;
            this.AssPartsDeleteBtn.Text = "Delete";
            this.AssPartsDeleteBtn.UseVisualStyleBackColor = true;
            this.AssPartsDeleteBtn.Click += new System.EventHandler(this.AssPartsDeleteBtn_Click);
            // 
            // ProdFormCancelBtn
            // 
            this.ProdFormCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdFormCancelBtn.Location = new System.Drawing.Point(1043, 642);
            this.ProdFormCancelBtn.Name = "ProdFormCancelBtn";
            this.ProdFormCancelBtn.Size = new System.Drawing.Size(74, 32);
            this.ProdFormCancelBtn.TabIndex = 3;
            this.ProdFormCancelBtn.Text = "Cancel";
            this.ProdFormCancelBtn.UseVisualStyleBackColor = true;
            this.ProdFormCancelBtn.Click += new System.EventHandler(this.ProdFormCancelBtn_Click);
            // 
            // ProductSaveButton
            // 
            this.ProductSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductSaveButton.Location = new System.Drawing.Point(937, 642);
            this.ProductSaveButton.Name = "ProductSaveButton";
            this.ProductSaveButton.Size = new System.Drawing.Size(75, 32);
            this.ProductSaveButton.TabIndex = 4;
            this.ProductSaveButton.Text = "Save";
            this.ProductSaveButton.UseVisualStyleBackColor = true;
            this.ProductSaveButton.Click += new System.EventHandler(this.ProductSaveButton_Click);
            // 
            // AddCandidatePartButton
            // 
            this.AddCandidatePartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCandidatePartButton.Location = new System.Drawing.Point(1043, 304);
            this.AddCandidatePartButton.Name = "AddCandidatePartButton";
            this.AddCandidatePartButton.Size = new System.Drawing.Size(73, 33);
            this.AddCandidatePartButton.TabIndex = 5;
            this.AddCandidatePartButton.Text = "Add";
            this.AddCandidatePartButton.UseVisualStyleBackColor = true;
            this.AddCandidatePartButton.Click += new System.EventHandler(this.AddCandidatePartButton_Click);
            // 
            // SearchCandidatePartsButton
            // 
            this.SearchCandidatePartsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCandidatePartsButton.Location = new System.Drawing.Point(763, 31);
            this.SearchCandidatePartsButton.Name = "SearchCandidatePartsButton";
            this.SearchCandidatePartsButton.Size = new System.Drawing.Size(84, 33);
            this.SearchCandidatePartsButton.TabIndex = 6;
            this.SearchCandidatePartsButton.Text = "Search";
            this.SearchCandidatePartsButton.UseVisualStyleBackColor = true;
            this.SearchCandidatePartsButton.Click += new System.EventHandler(this.SearchCandidatePartsButton_Click);
            // 
            // CandidatePartsSearchTextBox
            // 
            this.CandidatePartsSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CandidatePartsSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CandidatePartsSearchTextBox.Location = new System.Drawing.Point(876, 31);
            this.CandidatePartsSearchTextBox.Multiline = true;
            this.CandidatePartsSearchTextBox.Name = "CandidatePartsSearchTextBox";
            this.CandidatePartsSearchTextBox.Size = new System.Drawing.Size(278, 33);
            this.CandidatePartsSearchTextBox.TabIndex = 7;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdTextBox.Enabled = false;
            this.IdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTextBox.Location = new System.Drawing.Point(180, 193);
            this.IdTextBox.Multiline = true;
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(198, 37);
            this.IdTextBox.TabIndex = 8;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(180, 252);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(198, 34);
            this.NameTextBox.TabIndex = 9;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // InventoryTextBox
            // 
            this.InventoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InventoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryTextBox.Location = new System.Drawing.Point(180, 309);
            this.InventoryTextBox.Multiline = true;
            this.InventoryTextBox.Name = "InventoryTextBox";
            this.InventoryTextBox.Size = new System.Drawing.Size(198, 35);
            this.InventoryTextBox.TabIndex = 10;
            this.InventoryTextBox.TextChanged += new System.EventHandler(this.InventoryTextBox_TextChanged);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTextBox.Location = new System.Drawing.Point(180, 366);
            this.PriceTextBox.Multiline = true;
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(198, 33);
            this.PriceTextBox.TabIndex = 11;
            this.PriceTextBox.TextChanged += new System.EventHandler(this.PriceTextBox_TextChanged);
            // 
            // MaxTextBox
            // 
            this.MaxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxTextBox.Location = new System.Drawing.Point(122, 437);
            this.MaxTextBox.Multiline = true;
            this.MaxTextBox.Name = "MaxTextBox";
            this.MaxTextBox.Size = new System.Drawing.Size(112, 28);
            this.MaxTextBox.TabIndex = 12;
            this.MaxTextBox.TextChanged += new System.EventHandler(this.MaxTextBox_TextChanged);
            // 
            // MinTextBox
            // 
            this.MinTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinTextBox.Location = new System.Drawing.Point(341, 437);
            this.MinTextBox.Multiline = true;
            this.MinTextBox.Name = "MinTextBox";
            this.MinTextBox.Size = new System.Drawing.Size(112, 28);
            this.MinTextBox.TabIndex = 13;
            this.MinTextBox.TextChanged += new System.EventHandler(this.MinTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Inventory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(281, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(562, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Parts Associated with the Product";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(562, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "All candidate Parts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(48, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "Modify Product";
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 700);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinTextBox);
            this.Controls.Add(this.MaxTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.InventoryTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.CandidatePartsSearchTextBox);
            this.Controls.Add(this.SearchCandidatePartsButton);
            this.Controls.Add(this.AddCandidatePartButton);
            this.Controls.Add(this.ProductSaveButton);
            this.Controls.Add(this.ProdFormCancelBtn);
            this.Controls.Add(this.AssPartsDeleteBtn);
            this.Controls.Add(this.AssociatePartsDataGridView);
            this.Controls.Add(this.AllCandidatePartsDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ModifyProductForm";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.AllCandidatePartsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatePartsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllCandidatePartsDataGridView;
        private System.Windows.Forms.DataGridView AssociatePartsDataGridView;
        private System.Windows.Forms.Button AssPartsDeleteBtn;
        private System.Windows.Forms.Button ProdFormCancelBtn;
        private System.Windows.Forms.Button ProductSaveButton;
        private System.Windows.Forms.Button AddCandidatePartButton;
        private System.Windows.Forms.Button SearchCandidatePartsButton;
        private System.Windows.Forms.TextBox CandidatePartsSearchTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox InventoryTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox MaxTextBox;
        private System.Windows.Forms.TextBox MinTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}