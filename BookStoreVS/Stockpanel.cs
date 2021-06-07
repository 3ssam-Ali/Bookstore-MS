using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace BookStoreVS
{
    public partial class Stockpanel : UserControl
    {
        public Stockpanel()
        {
            InitializeComponent();
        }
        public void LoadStock()
        {
            StockGrid.Rows.Clear();
            using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
            {
                var output = Cursor.Query<BookModel>("select * from book", new DynamicParameters());
                List<BookModel> AllBooks = output.ToList();
                foreach (BookModel I in AllBooks)
                {
                    DataGridViewRow NewRow = new DataGridViewRow();
                    NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.id });
                    NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.name});
                    var CategoryOutput = Cursor.Query<CategoryModel>(string.Format("select name from category where id ={0}",I.category_id), new DynamicParameters());
                    List<CategoryModel> categoryFound= CategoryOutput.ToList();
                    NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = categoryFound[0].name });
                    NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.author});
                    NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.publisher });
                    NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.price });
                    NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.amount_instock});
                    StockGrid.Rows.Add(NewRow);
                }
            }
        }
        private void editBookInfoBtn_Click(object sender, EventArgs e)
        {
            editBookForm editBookForm1 = new editBookForm();
            editBookForm1.Show();
        }

        private void restockbtn_Click(object sender, EventArgs e)
        {
            restockForm restockForm1 = new restockForm();
            restockForm1.Show();
        }

        private void addbookbtn_Click(object sender, EventArgs e)
        {
            addBookForm addBookForm1 = new addBookForm();
            addBookForm1.Show();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (Searchtxtbx.TextLength == 0)
            {
                StockGrid.Rows.Clear();
                LoadStock();
            }
            else
            {
                StockGrid.Rows.Clear();
                using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
                {
                    var output = Cursor.Query<BookModel>(string.Format("select * from book where name like '%{0}%'", Searchtxtbx.Text), new DynamicParameters());
                    List<BookModel> AllBooks = output.ToList();
                    foreach (BookModel I in AllBooks)
                    {
                        DataGridViewRow NewRow = new DataGridViewRow();
                        NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.id });
                        NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.name });
                        var CategoryOutput = Cursor.Query<CategoryModel>(string.Format("select name from category where id ={0}", I.category_id), new DynamicParameters());
                        List<CategoryModel> categoryFound = CategoryOutput.ToList();
                        NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = categoryFound[0].name });
                        NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.author });
                        NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.publisher });
                        NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.price });
                        NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.amount_instock });
                        StockGrid.Rows.Add(NewRow);
                    }
                }
            }
        }
        private void Stockpanel_Load(object sender, EventArgs e)
        {
            LoadStock();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadStock();
        }

        private void Searchtxtbx_TextChanged(object sender, EventArgs e)
        {
            if (Searchtxtbx.TextLength == 0)
            {
                StockGrid.Rows.Clear();
                LoadStock();
            }
            else
            {
                StockGrid.Rows.Clear();
                using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
                {
                    var output = Cursor.Query<BookModel>(string.Format("select * from book where name like '%{0}%'", Searchtxtbx.Text), new DynamicParameters());
                    List<BookModel> AllBooks = output.ToList();
                    foreach (BookModel I in AllBooks)
                    {
                        DataGridViewRow NewRow = new DataGridViewRow();
                        NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.id });
                        NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.name });
                        var CategoryOutput = Cursor.Query<CategoryModel>(string.Format("select name from category where id ={0}", I.category_id), new DynamicParameters());
                        List<CategoryModel> categoryFound = CategoryOutput.ToList();
                        NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = categoryFound[0].name });
                        NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.author });
                        NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.publisher });
                        NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.price });
                        NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.amount_instock });
                        StockGrid.Rows.Add(NewRow);
                    }
                }
            }
        }
    }
}
