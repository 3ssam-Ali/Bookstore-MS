
namespace BookStoreVS
{
    partial class editBookForm
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
            this.StockNumeric = new System.Windows.Forms.NumericUpDown();
            this.PriceNumeric = new System.Windows.Forms.NumericUpDown();
            this.EditBookButton = new System.Windows.Forms.Button();
            this.CategoryChoice = new System.Windows.Forms.ComboBox();
            this.AuthorText = new System.Windows.Forms.TextBox();
            this.PublisherText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BookIdTextBox = new System.Windows.Forms.TextBox();
            this.SearchBookButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StockNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // StockNumeric
            // 
            this.StockNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockNumeric.Location = new System.Drawing.Point(154, 285);
            this.StockNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.StockNumeric.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.StockNumeric.Name = "StockNumeric";
            this.StockNumeric.Size = new System.Drawing.Size(137, 23);
            this.StockNumeric.TabIndex = 28;
            // 
            // PriceNumeric
            // 
            this.PriceNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceNumeric.Location = new System.Drawing.Point(154, 195);
            this.PriceNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.PriceNumeric.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.PriceNumeric.Name = "PriceNumeric";
            this.PriceNumeric.Size = new System.Drawing.Size(137, 23);
            this.PriceNumeric.TabIndex = 27;
            // 
            // EditBookButton
            // 
            this.EditBookButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBookButton.Location = new System.Drawing.Point(113, 347);
            this.EditBookButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditBookButton.Name = "EditBookButton";
            this.EditBookButton.Size = new System.Drawing.Size(109, 32);
            this.EditBookButton.TabIndex = 26;
            this.EditBookButton.Text = "Save Changes";
            this.EditBookButton.UseVisualStyleBackColor = true;
            this.EditBookButton.Click += new System.EventHandler(this.EditBookButton_Click);
            // 
            // CategoryChoice
            // 
            this.CategoryChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryChoice.FormattingEnabled = true;
            this.CategoryChoice.Location = new System.Drawing.Point(153, 165);
            this.CategoryChoice.Margin = new System.Windows.Forms.Padding(2);
            this.CategoryChoice.Name = "CategoryChoice";
            this.CategoryChoice.Size = new System.Drawing.Size(137, 25);
            this.CategoryChoice.TabIndex = 25;
            // 
            // AuthorText
            // 
            this.AuthorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorText.Location = new System.Drawing.Point(154, 255);
            this.AuthorText.Margin = new System.Windows.Forms.Padding(2);
            this.AuthorText.Name = "AuthorText";
            this.AuthorText.Size = new System.Drawing.Size(137, 23);
            this.AuthorText.TabIndex = 24;
            // 
            // PublisherText
            // 
            this.PublisherText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublisherText.Location = new System.Drawing.Point(153, 225);
            this.PublisherText.Margin = new System.Windows.Forms.Padding(2);
            this.PublisherText.Name = "PublisherText";
            this.PublisherText.Size = new System.Drawing.Size(137, 23);
            this.PublisherText.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 285);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Amount in stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Publisher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Book name";
            // 
            // nametxt
            // 
            this.nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(153, 135);
            this.nametxt.Margin = new System.Windows.Forms.Padding(2);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(137, 23);
            this.nametxt.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Book Id";
            // 
            // BookIdTextBox
            // 
            this.BookIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIdTextBox.Location = new System.Drawing.Point(154, 20);
            this.BookIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.BookIdTextBox.Name = "BookIdTextBox";
            this.BookIdTextBox.Size = new System.Drawing.Size(137, 23);
            this.BookIdTextBox.TabIndex = 29;
            // 
            // SearchBookButton
            // 
            this.SearchBookButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBookButton.Location = new System.Drawing.Point(128, 67);
            this.SearchBookButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBookButton.Name = "SearchBookButton";
            this.SearchBookButton.Size = new System.Drawing.Size(82, 32);
            this.SearchBookButton.TabIndex = 31;
            this.SearchBookButton.Text = "Select book";
            this.SearchBookButton.UseVisualStyleBackColor = true;
            this.SearchBookButton.Click += new System.EventHandler(this.selectBookbtn_Click);
            // 
            // editBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 414);
            this.Controls.Add(this.SearchBookButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BookIdTextBox);
            this.Controls.Add(this.StockNumeric);
            this.Controls.Add(this.PriceNumeric);
            this.Controls.Add(this.EditBookButton);
            this.Controls.Add(this.CategoryChoice);
            this.Controls.Add(this.AuthorText);
            this.Controls.Add(this.PublisherText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nametxt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "editBookForm";
            this.Text = "Edit book data";
            this.Load += new System.EventHandler(this.editBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown StockNumeric;
        private System.Windows.Forms.NumericUpDown PriceNumeric;
        private System.Windows.Forms.Button EditBookButton;
        private System.Windows.Forms.ComboBox CategoryChoice;
        private System.Windows.Forms.TextBox AuthorText;
        private System.Windows.Forms.TextBox PublisherText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BookIdTextBox;
        private System.Windows.Forms.Button SearchBookButton;
    }
}