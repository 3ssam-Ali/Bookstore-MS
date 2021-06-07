using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace BookStoreVS
{
    public partial class restockForm : Form
    {
        public restockForm()
        {
            InitializeComponent();
        }

        private void checkbtn_Click(object sender, EventArgs e)
        {
            using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
            {

                var output = Cursor.Query<BookModel>(string.Format("select name,amount_instock from book where id = {0}", bookIdtxt.Text), new DynamicParameters());
                List<BookModel> FoundBook = output.ToList();
                if (FoundBook.Count == 0)
                {
                    MessageBox.Show(string.Format("No book found with ID = {0}"), bookIdtxt.Text);
                }
                else
                {
                    MessageBox.Show(string.Format("Book {0} found with {1} copies in stock.", FoundBook[0].name, FoundBook[0].amount_instock));
                }
            }
        }

        private void restockbtn_Click(object sender, EventArgs e)
        {
            using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
            {

                var output = Cursor.Query<BookModel>(string.Format("select id,name,amount_instock from book where id = {0}", bookIdtxt.Text), new DynamicParameters());
                List<BookModel> FoundBook = output.ToList();
                if (FoundBook.Count == 0)
                {
                    MessageBox.Show(string.Format("No book found with ID = {0}"), bookIdtxt.Text);
                }
                else
                {
                    FoundBook[0].amount_instock += Convert.ToInt32(amountNumeric.Value);
                    Cursor.Execute("update book set amount_instock = @amount_instock where id = @id", FoundBook[0]);
                    MessageBox.Show(string.Format("Added {0} copies to stock of {1}",Convert.ToInt32(amountNumeric.Value), FoundBook[0].name));
                    Close();
                }
            }
        }
    }
}
