
namespace BookStoreVS
{
    partial class Stockpanel
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
            this.StockGrid = new System.Windows.Forms.DataGridView();
            this.Bookid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copiesInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchbtn = new System.Windows.Forms.Button();
            this.Searchtxtbx = new System.Windows.Forms.TextBox();
            this.addbookbtn = new System.Windows.Forms.Button();
            this.editBookInfoBtn = new System.Windows.Forms.Button();
            this.restockbtn = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StockGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StockGrid
            // 
            this.StockGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StockGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bookid,
            this.bookname,
            this.category,
            this.author,
            this.publisher,
            this.price,
            this.copiesInStock});
            this.StockGrid.Location = new System.Drawing.Point(2, 163);
            this.StockGrid.Margin = new System.Windows.Forms.Padding(2);
            this.StockGrid.Name = "StockGrid";
            this.StockGrid.ReadOnly = true;
            this.StockGrid.RowHeadersWidth = 40;
            this.StockGrid.RowTemplate.Height = 24;
            this.StockGrid.Size = new System.Drawing.Size(688, 357);
            this.StockGrid.TabIndex = 0;
            // 
            // Bookid
            // 
            this.Bookid.HeaderText = "book id";
            this.Bookid.MinimumWidth = 6;
            this.Bookid.Name = "Bookid";
            this.Bookid.ReadOnly = true;
            // 
            // bookname
            // 
            this.bookname.HeaderText = "book name";
            this.bookname.MinimumWidth = 6;
            this.bookname.Name = "bookname";
            this.bookname.ReadOnly = true;
            // 
            // category
            // 
            this.category.HeaderText = "category";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // author
            // 
            this.author.HeaderText = "author";
            this.author.MinimumWidth = 6;
            this.author.Name = "author";
            this.author.ReadOnly = true;
            // 
            // publisher
            // 
            this.publisher.HeaderText = "publisher";
            this.publisher.MinimumWidth = 6;
            this.publisher.Name = "publisher";
            this.publisher.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // copiesInStock
            // 
            this.copiesInStock.HeaderText = "Copies In Stock";
            this.copiesInStock.MinimumWidth = 6;
            this.copiesInStock.Name = "copiesInStock";
            this.copiesInStock.ReadOnly = true;
            // 
            // searchbtn
            // 
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(208, 74);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(101, 28);
            this.searchbtn.TabIndex = 1;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Visible = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // Searchtxtbx
            // 
            this.Searchtxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchtxtbx.Location = new System.Drawing.Point(166, 32);
            this.Searchtxtbx.Margin = new System.Windows.Forms.Padding(2);
            this.Searchtxtbx.Name = "Searchtxtbx";
            this.Searchtxtbx.Size = new System.Drawing.Size(143, 24);
            this.Searchtxtbx.TabIndex = 2;
            this.Searchtxtbx.TextChanged += new System.EventHandler(this.Searchtxtbx_TextChanged);
            // 
            // addbookbtn
            // 
            this.addbookbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbookbtn.Location = new System.Drawing.Point(499, 28);
            this.addbookbtn.Margin = new System.Windows.Forms.Padding(2);
            this.addbookbtn.Name = "addbookbtn";
            this.addbookbtn.Size = new System.Drawing.Size(136, 28);
            this.addbookbtn.TabIndex = 3;
            this.addbookbtn.Text = "Add new book";
            this.addbookbtn.UseVisualStyleBackColor = true;
            this.addbookbtn.Click += new System.EventHandler(this.addbookbtn_Click);
            // 
            // editBookInfoBtn
            // 
            this.editBookInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBookInfoBtn.Location = new System.Drawing.Point(499, 74);
            this.editBookInfoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.editBookInfoBtn.Name = "editBookInfoBtn";
            this.editBookInfoBtn.Size = new System.Drawing.Size(136, 28);
            this.editBookInfoBtn.TabIndex = 4;
            this.editBookInfoBtn.Text = "Edit book info";
            this.editBookInfoBtn.UseVisualStyleBackColor = true;
            this.editBookInfoBtn.Click += new System.EventHandler(this.editBookInfoBtn_Click);
            // 
            // restockbtn
            // 
            this.restockbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restockbtn.Location = new System.Drawing.Point(499, 121);
            this.restockbtn.Margin = new System.Windows.Forms.Padding(2);
            this.restockbtn.Name = "restockbtn";
            this.restockbtn.Size = new System.Drawing.Size(136, 28);
            this.restockbtn.TabIndex = 5;
            this.restockbtn.Text = "Restock";
            this.restockbtn.UseVisualStyleBackColor = true;
            this.restockbtn.Click += new System.EventHandler(this.restockbtn_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.Location = new System.Drawing.Point(208, 106);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(2);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(101, 28);
            this.RefreshButton.TabIndex = 6;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search by name";
            // 
            // Stockpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.restockbtn);
            this.Controls.Add(this.editBookInfoBtn);
            this.Controls.Add(this.addbookbtn);
            this.Controls.Add(this.Searchtxtbx);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.StockGrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Stockpanel";
            this.Size = new System.Drawing.Size(692, 587);
            this.Load += new System.EventHandler(this.Stockpanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StockGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bookid;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookname;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn copiesInStock;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox Searchtxtbx;
        private System.Windows.Forms.Button addbookbtn;
        private System.Windows.Forms.Button editBookInfoBtn;
        private System.Windows.Forms.Button restockbtn;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label label1;
    }
}
