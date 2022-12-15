
namespace JoeMWindowsFormsApp
{
    partial class Form1
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
            this.PartsView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductsView = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddPartBtn = new System.Windows.Forms.Button();
            this.ModifyPartButton = new System.Windows.Forms.Button();
            this.PartsDeleteButton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ModifyProductButton = new System.Windows.Forms.Button();
            this.ProductDeleteButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SearchProductbutton = new System.Windows.Forms.Button();
            this.SearchPartButton = new System.Windows.Forms.Button();
            this.PartSearchTextBox = new System.Windows.Forms.TextBox();
            this.ProductSearchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PartsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsView)).BeginInit();
            this.SuspendLayout();
            // 
            // PartsView
            // 
            this.PartsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.PartsView.Location = new System.Drawing.Point(29, 83);
            this.PartsView.MultiSelect = false;
            this.PartsView.Name = "PartsView";
            this.PartsView.ReadOnly = true;
            this.PartsView.RowHeadersVisible = false;
            this.PartsView.RowHeadersWidth = 51;
            this.PartsView.RowTemplate.Height = 24;
            this.PartsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PartsView.Size = new System.Drawing.Size(537, 340);
            this.PartsView.TabIndex = 0;
            this.PartsView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.BindingComplete);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdCode";
            this.Column1.HeaderText = "Part ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 90;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Inventory";
            this.Column3.HeaderText = "Inventory";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 90;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Price";
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 90;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MIn";
            this.Column5.HeaderText = "Min";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 85;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Max";
            this.Column6.HeaderText = "Max";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 89;
            // 
            // ProductsView
            // 
            this.ProductsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.ProductsView.Location = new System.Drawing.Point(646, 83);
            this.ProductsView.MultiSelect = false;
            this.ProductsView.Name = "ProductsView";
            this.ProductsView.ReadOnly = true;
            this.ProductsView.RowHeadersVisible = false;
            this.ProductsView.RowHeadersWidth = 51;
            this.ProductsView.RowTemplate.Height = 24;
            this.ProductsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsView.Size = new System.Drawing.Size(532, 340);
            this.ProductsView.TabIndex = 1;
            this.ProductsView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.BindingComplete);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Idcode";
            this.Column7.HeaderText = "Product ID";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 90;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Name";
            this.Column8.HeaderText = "Name";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 90;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Inventory";
            this.Column9.HeaderText = "Inventory";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 90;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Price";
            this.Column10.HeaderText = "Price";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 90;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "MIn";
            this.Column11.HeaderText = "Min";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 84;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Max";
            this.Column12.HeaderText = "Max";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 85;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(25, 41);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Label1.Size = new System.Drawing.Size(87, 39);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Parts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(656, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Inventory Management System";
            // 
            // AddPartBtn
            // 
            this.AddPartBtn.Location = new System.Drawing.Point(309, 446);
            this.AddPartBtn.Name = "AddPartBtn";
            this.AddPartBtn.Size = new System.Drawing.Size(75, 42);
            this.AddPartBtn.TabIndex = 5;
            this.AddPartBtn.Text = "Add";
            this.AddPartBtn.UseVisualStyleBackColor = true;
            this.AddPartBtn.Click += new System.EventHandler(this.AddPartBtn_Click);
            // 
            // ModifyPartButton
            // 
            this.ModifyPartButton.Location = new System.Drawing.Point(399, 446);
            this.ModifyPartButton.Name = "ModifyPartButton";
            this.ModifyPartButton.Size = new System.Drawing.Size(75, 42);
            this.ModifyPartButton.TabIndex = 6;
            this.ModifyPartButton.Text = "Modify";
            this.ModifyPartButton.UseVisualStyleBackColor = true;
            this.ModifyPartButton.Click += new System.EventHandler(this.ModifyPartButton_Click);
            // 
            // PartsDeleteButton
            // 
            this.PartsDeleteButton.Location = new System.Drawing.Point(490, 446);
            this.PartsDeleteButton.Name = "PartsDeleteButton";
            this.PartsDeleteButton.Size = new System.Drawing.Size(75, 42);
            this.PartsDeleteButton.TabIndex = 7;
            this.PartsDeleteButton.Text = "Delete";
            this.PartsDeleteButton.UseVisualStyleBackColor = true;
            this.PartsDeleteButton.Click += new System.EventHandler(this.PartsDeleteButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(912, 446);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(75, 42);
            this.AddProductButton.TabIndex = 8;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // ModifyProductButton
            // 
            this.ModifyProductButton.Location = new System.Drawing.Point(1003, 446);
            this.ModifyProductButton.Name = "ModifyProductButton";
            this.ModifyProductButton.Size = new System.Drawing.Size(75, 42);
            this.ModifyProductButton.TabIndex = 9;
            this.ModifyProductButton.Text = "Modify";
            this.ModifyProductButton.UseVisualStyleBackColor = true;
            this.ModifyProductButton.Click += new System.EventHandler(this.ModifyProductButton_Click);
            // 
            // ProductDeleteButton
            // 
            this.ProductDeleteButton.Location = new System.Drawing.Point(1094, 446);
            this.ProductDeleteButton.Name = "ProductDeleteButton";
            this.ProductDeleteButton.Size = new System.Drawing.Size(75, 42);
            this.ProductDeleteButton.TabIndex = 10;
            this.ProductDeleteButton.Text = "Delete";
            this.ProductDeleteButton.UseVisualStyleBackColor = true;
            this.ProductDeleteButton.Click += new System.EventHandler(this.ProductDeleteButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(1094, 506);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 42);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SearchProductbutton
            // 
            this.SearchProductbutton.Location = new System.Drawing.Point(824, 36);
            this.SearchProductbutton.Name = "SearchProductbutton";
            this.SearchProductbutton.Size = new System.Drawing.Size(75, 28);
            this.SearchProductbutton.TabIndex = 12;
            this.SearchProductbutton.Text = "Search";
            this.SearchProductbutton.UseVisualStyleBackColor = true;
            this.SearchProductbutton.Click += new System.EventHandler(this.SearchProductbutton_Click);
            // 
            // SearchPartButton
            // 
            this.SearchPartButton.Location = new System.Drawing.Point(203, 36);
            this.SearchPartButton.Name = "SearchPartButton";
            this.SearchPartButton.Size = new System.Drawing.Size(75, 28);
            this.SearchPartButton.TabIndex = 13;
            this.SearchPartButton.Text = "Search";
            this.SearchPartButton.UseVisualStyleBackColor = true;
            this.SearchPartButton.Click += new System.EventHandler(this.SearchPartButton_Click);
            // 
            // PartSearchTextBox
            // 
            this.PartSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PartSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartSearchTextBox.Location = new System.Drawing.Point(300, 36);
            this.PartSearchTextBox.MaxLength = 40;
            this.PartSearchTextBox.Multiline = true;
            this.PartSearchTextBox.Name = "PartSearchTextBox";
            this.PartSearchTextBox.Size = new System.Drawing.Size(265, 28);
            this.PartSearchTextBox.TabIndex = 14;
            // 
            // ProductSearchTextBox
            // 
            this.ProductSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductSearchTextBox.Location = new System.Drawing.Point(923, 36);
            this.ProductSearchTextBox.MaxLength = 40;
            this.ProductSearchTextBox.Multiline = true;
            this.ProductSearchTextBox.Name = "ProductSearchTextBox";
            this.ProductSearchTextBox.Size = new System.Drawing.Size(255, 28);
            this.ProductSearchTextBox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 560);
            this.Controls.Add(this.ProductSearchTextBox);
            this.Controls.Add(this.PartSearchTextBox);
            this.Controls.Add(this.SearchPartButton);
            this.Controls.Add(this.SearchProductbutton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ProductDeleteButton);
            this.Controls.Add(this.ModifyProductButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.PartsDeleteButton);
            this.Controls.Add(this.ModifyPartButton);
            this.Controls.Add(this.AddPartBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ProductsView);
            this.Controls.Add(this.PartsView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.PartsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PartsView;
        private System.Windows.Forms.DataGridView ProductsView;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddPartBtn;
        private System.Windows.Forms.Button ModifyPartButton;
        private System.Windows.Forms.Button PartsDeleteButton;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button ModifyProductButton;
        private System.Windows.Forms.Button ProductDeleteButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SearchProductbutton;
        private System.Windows.Forms.Button SearchPartButton;
        private System.Windows.Forms.TextBox PartSearchTextBox;
        private System.Windows.Forms.TextBox ProductSearchTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}

