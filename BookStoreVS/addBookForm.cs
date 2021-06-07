using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace BookStoreVS
{
    public partial class addBookForm : Form
    {
        public addBookForm()
        {
            InitializeComponent();
        }
            private void addBookbtn_Click(object sender, EventArgs e)
        {
            if ((nametxt.Text == "") || (CategoryChoice.SelectedItem == null) || (PriceNumeric.Value == 0) || (PublisherTextBox.Text == "") || (AuthorTextBox.Text == ""))
            {
                MessageBox.Show("Invalid inputs");
            }
            else
            {
                using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
                {
                    
                    var output = Cursor.Query<CategoryModel>(string.Format("select id from category where name = '{0}'", CategoryChoice.SelectedItem.ToString()), new DynamicParameters());
                    BookModel NewBook = new BookModel();
                    NewBook.name = nametxt.Text;
                    List<CategoryModel> AllCategories = output.ToList();
                    NewBook.category_id = AllCategories[0].id;
                    NewBook.price = Convert.ToInt32(PriceNumeric.Value);
                    NewBook.publisher = PublisherTextBox.Text;
                    NewBook.author = AuthorTextBox.Text;
                    NewBook.amount_instock = Convert.ToInt32(StockNumeric.Value);
                    Cursor.Execute("insert into book (name, author, amount_instock, price, publisher, category_id ) " +
                        "values (@name,@author,@amount_instock,@price,@publisher,@category_id)", NewBook);
                    MessageBox.Show("Book added successfully. Please click the refresh button.");
                    Close();
                    
                }
            }
        }
        private void addBookForm_Load(object sender, EventArgs e)
        {
            using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
            {
                var output = Cursor.Query<CategoryModel>("select * from category", new DynamicParameters());
                List<CategoryModel> AllCategories = output.ToList();
                foreach (CategoryModel I in AllCategories)
                {
                    CategoryChoice.Items.Add(I.name);
                }
            }
        }
    }
}
