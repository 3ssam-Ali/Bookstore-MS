using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace BookStoreVS
{
    public partial class editBookForm : Form
    {
        public editBookForm()
        {
            InitializeComponent();
        }
        private void selectBookbtn_Click(object sender, EventArgs e)
        {
            using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
            { 
                var FoundBooks = Cursor.Query<BookModel>(string.Format("select * from book where id = {0}", BookIdTextBox.Text), new DynamicParameters());
                List<BookModel> FoundBook = FoundBooks.ToList();
                if (FoundBook.Count == 0)
                {
                    MessageBox.Show(string.Format("No book found with ID = {0}", BookIdTextBox.Text));
                }
                else
                {
                    BookModel BookToEdit = new BookModel();
                    BookToEdit = FoundBook[0];
                    var output = Cursor.Query<CategoryModel>(string.Format("select name from category where id = {0}", BookToEdit.category_id), new DynamicParameters());
                    List<CategoryModel> BookCategory = output.ToList();
                    CategoryChoice.SelectedItem = BookCategory[0].name;
                    nametxt.Text = BookToEdit.name;
                    PriceNumeric.Value = BookToEdit.price;
                    PublisherText.Text = BookToEdit.publisher;
                    AuthorText.Text = BookToEdit.author;
                    StockNumeric.Value = BookToEdit.amount_instock;
                }
            }
        }

        private void EditBookButton_Click(object sender, EventArgs e)
        {
            using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
            {
                List<string> ValidCategpries = new List<string>();
                var Categories = Cursor.Query<CategoryModel>("select name from category", new DynamicParameters());
                List<CategoryModel> AllCategories = Categories.ToList();
                foreach (CategoryModel I in AllCategories)
                {
                    ValidCategpries.Add(I.name);
                }
                if ((nametxt.Text == "") || (CategoryChoice.SelectedItem == null) || (!ValidCategpries.Contains(CategoryChoice.SelectedItem.ToString())) || (PriceNumeric.Value == 0) || (PublisherText.Text == "") || (AuthorText.Text == ""))
                {
                    MessageBox.Show("Invalid inputs");
                }
                else
                {
                    BookModel EditedBook = new BookModel();
                    EditedBook.id = int.Parse(BookIdTextBox.Text);
                    EditedBook.name = nametxt.Text;
                    EditedBook.price = Convert.ToInt32(PriceNumeric.Value);
                    EditedBook.publisher = PublisherText.Text;
                    EditedBook.author = AuthorText.Text;
                    EditedBook.amount_instock = Convert.ToInt32(StockNumeric.Value);
                    var output = Cursor.Query<CategoryModel>(string.Format("select id from category where name = '{0}'", CategoryChoice.SelectedItem), new DynamicParameters());
                    List<CategoryModel> BookCategory = output.ToList();
                    EditedBook.category_id = BookCategory[0].id;
                    Cursor.Execute("UPDATE book SET name = @name, author = @author, amount_instock = @amount_instock, " +
                        "price = @price, publisher = @publisher, category_id = @category_id WHERE id = @id", EditedBook);

                    MessageBox.Show("Book successfully updated.");
                    Close();
                }
            }
        }

        private void editBookForm_Load(object sender, EventArgs e)
        {
            using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
            {
                var output = Cursor.Query<CategoryModel>(("select name from category"), new DynamicParameters());
                List<CategoryModel> AllCategories = output.ToList();
                foreach (CategoryModel I in AllCategories)
                {
                    CategoryChoice.Items.Add(I.name);
                }
            }
        }
    }
}
