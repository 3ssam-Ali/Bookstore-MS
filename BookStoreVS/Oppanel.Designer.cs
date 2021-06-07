
namespace BookStoreVS
{
    partial class Oppanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bookNameTxtBox = new System.Windows.Forms.TextBox();
            this.ClienttxtBox = new System.Windows.Forms.TextBox();
            this.salebtn = new System.Windows.Forms.Button();
            this.requestbtn = new System.Windows.Forms.Button();
            this.addClientbtn = new System.Windows.Forms.Button();
            this.SalesGrid = new System.Windows.Forms.DataGridView();
            this.saleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client";
            // 
            // bookNameTxtBox
            // 
            this.bookNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNameTxtBox.Location = new System.Drawing.Point(132, 53);
            this.bookNameTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.bookNameTxtBox.Name = "bookNameTxtBox";
            this.bookNameTxtBox.Size = new System.Drawing.Size(168, 24);
            this.bookNameTxtBox.TabIndex = 3;
            // 
            // ClienttxtBox
            // 
            this.ClienttxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienttxtBox.Location = new System.Drawing.Point(132, 91);
            this.ClienttxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.ClienttxtBox.Name = "ClienttxtBox";
            this.ClienttxtBox.Size = new System.Drawing.Size(168, 24);
            this.ClienttxtBox.TabIndex = 4;
            this.ClienttxtBox.Text = "Unknown";
            // 
            // salebtn
            // 
            this.salebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salebtn.Location = new System.Drawing.Point(470, 53);
            this.salebtn.Margin = new System.Windows.Forms.Padding(2);
            this.salebtn.Name = "salebtn";
            this.salebtn.Size = new System.Drawing.Size(90, 26);
            this.salebtn.TabIndex = 5;
            this.salebtn.Text = "Sale";
            this.salebtn.UseVisualStyleBackColor = true;
            this.salebtn.Click += new System.EventHandler(this.salebtn_Click);
            // 
            // requestbtn
            // 
            this.requestbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestbtn.Location = new System.Drawing.Point(470, 91);
            this.requestbtn.Margin = new System.Windows.Forms.Padding(2);
            this.requestbtn.Name = "requestbtn";
            this.requestbtn.Size = new System.Drawing.Size(90, 26);
            this.requestbtn.TabIndex = 6;
            this.requestbtn.Text = "Request";
            this.requestbtn.UseVisualStyleBackColor = true;
            this.requestbtn.Click += new System.EventHandler(this.requestbtn_Click);
            // 
            // addClientbtn
            // 
            this.addClientbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClientbtn.Location = new System.Drawing.Point(470, 127);
            this.addClientbtn.Margin = new System.Windows.Forms.Padding(2);
            this.addClientbtn.Name = "addClientbtn";
            this.addClientbtn.Size = new System.Drawing.Size(90, 26);
            this.addClientbtn.TabIndex = 7;
            this.addClientbtn.Text = "Add client";
            this.addClientbtn.UseVisualStyleBackColor = true;
            this.addClientbtn.Click += new System.EventHandler(this.addClientbtn_Click);
            // 
            // SalesGrid
            // 
            this.SalesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SalesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleId,
            this.bookName,
            this.dateTime,
            this.quantity,
            this.price,
            this.total});
            this.SalesGrid.Location = new System.Drawing.Point(2, 208);
            this.SalesGrid.Margin = new System.Windows.Forms.Padding(2);
            this.SalesGrid.Name = "SalesGrid";
            this.SalesGrid.RowHeadersWidth = 51;
            this.SalesGrid.RowTemplate.Height = 24;
            this.SalesGrid.Size = new System.Drawing.Size(688, 377);
            this.SalesGrid.TabIndex = 8;
            // 
            // saleId
            // 
            this.saleId.HeaderText = "Sale Id";
            this.saleId.MinimumWidth = 6;
            this.saleId.Name = "saleId";
            this.saleId.ReadOnly = true;
            // 
            // bookName
            // 
            this.bookName.HeaderText = "Book name";
            this.bookName.MinimumWidth = 6;
            this.bookName.Name = "bookName";
            this.bookName.ReadOnly = true;
            // 
            // dateTime
            // 
            this.dateTime.HeaderText = "Date/time";
            this.dateTime.MinimumWidth = 6;
            this.dateTime.Name = "dateTime";
            this.dateTime.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Column1";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // quantityNumeric
            // 
            this.quantityNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityNumeric.Location = new System.Drawing.Point(132, 127);
            this.quantityNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.quantityNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityNumeric.Name = "quantityNumeric";
            this.quantityNumeric.Size = new System.Drawing.Size(167, 23);
            this.quantityNumeric.TabIndex = 9;
            this.quantityNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quantity";
            // 
            // Oppanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantityNumeric);
            this.Controls.Add(this.SalesGrid);
            this.Controls.Add(this.addClientbtn);
            this.Controls.Add(this.requestbtn);
            this.Controls.Add(this.salebtn);
            this.Controls.Add(this.ClienttxtBox);
            this.Controls.Add(this.bookNameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Oppanel";
            this.Size = new System.Drawing.Size(692, 587);
            this.Load += new System.EventHandler(this.Oppanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bookNameTxtBox;
        private System.Windows.Forms.TextBox ClienttxtBox;
        private System.Windows.Forms.Button salebtn;
        private System.Windows.Forms.Button requestbtn;
        private System.Windows.Forms.Button addClientbtn;
        private System.Windows.Forms.DataGridView SalesGrid;

        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.NumericUpDown quantityNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}
