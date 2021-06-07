using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace BookStoreVS
{
    public partial class Oppanel : UserControl
    {
        public Oppanel()
        {
            InitializeComponent();
        }
        public void LoadAutoComplete()
        {
            AutoCompleteStringCollection SuggestedBookNames = new AutoCompleteStringCollection();
            AutoCompleteStringCollection SuggestedClientNames = new AutoCompleteStringCollection();
            using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
            {
                var bookOutput = Cursor.Query<BookModel>("select name from book", new DynamicParameters());
                List<BookModel> SuggestedBooks = bookOutput.ToList();
                var clientOutput = Cursor.Query<ClientModel>("select name from client", new DynamicParameters());
                List<ClientModel> SuggestedClients = clientOutput.ToList();
                for (int i = 0; i < SuggestedBooks.Count(); i++)
                {
                    SuggestedBookNames.Add(SuggestedBooks[i].name);
                }
                for (int i = 0; i < SuggestedClients.Count(); i++)
                {
                    SuggestedClientNames.Add(SuggestedClients[i].name);
                }
                bookNameTxtBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                bookNameTxtBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                bookNameTxtBox.AutoCompleteCustomSource = SuggestedBookNames;
                ClienttxtBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                ClienttxtBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                ClienttxtBox.AutoCompleteCustomSource = SuggestedClientNames;
            }
        }
        private void Oppanel_Load(object sender, EventArgs e)
        {
            LoadAutoComplete();
        }
        public void LoadSales()
        {
            SalesGrid.Rows.Clear();
            using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
            {
                var output = Cursor.Query<SaleModel>("select * from sale", new DynamicParameters());
                List<SaleModel> AllSales = output.ToList();
                foreach (SaleModel I in AllSales)
                {
                    DataGridViewRow NewRow = new DataGridViewRow();
                    NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.id });
                    NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.book_name });
                    NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.op_time });
                    NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.quantity });
                    NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.price });
                    NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.quantity * I.price });
                    SalesGrid.Rows.Add(NewRow);
                }
            }
        }
        private void addClientbtn_Click(object sender, EventArgs e)
        {
            addClient addClientForm = new addClient();
            addClientForm.Show();
        }

        private void requestbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("coming soon");
        }

        private void salebtn_Click(object sender, EventArgs e)
        {
            using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
            {
                List<string> ValidBookNames = new List<string>();
                List<string> ValidClientNames = new List<string>();
                var bookOutput = Cursor.Query<BookModel>("select name from book", new DynamicParameters());
                List<BookModel> SuggestedBooks = bookOutput.ToList();
                var clientOutput = Cursor.Query<ClientModel>("select name from client", new DynamicParameters());
                List<ClientModel> SuggestedClients = clientOutput.ToList();
                for (int i = 0; i < SuggestedBooks.Count(); i++)
                {
                    ValidBookNames.Add(SuggestedBooks[i].name);
                }
                for (int i = 0; i < SuggestedClients.Count(); i++)
                {
                    ValidClientNames.Add(SuggestedClients[i].name);
                }
                if ((ValidBookNames.Contains(bookNameTxtBox.Text)))
                {
                    var CheckBookName = Cursor.Query<BookModel>(string.Format("select * from book where name = '{0}'", bookNameTxtBox.Text), new DynamicParameters());
                    List<BookModel> FoundBooks = CheckBookName.ToList();
                    if ((FoundBooks[0].amount_instock == 0) || (FoundBooks[0].amount_instock < quantityNumeric.Value))
                    {
                        MessageBox.Show("Not enough copies in stock!");
                    }
                    else
                    {
                        SaleModel NewSale = new SaleModel();
                        NewSale.op_time = DateTime.Now;
                        NewSale.quantity = Convert.ToInt32(quantityNumeric.Value);
                        if (ValidClientNames.Contains(ClienttxtBox.Text))
                        {
                            NewSale.client = ClienttxtBox.Text;
                        }
                        else
                        {
                            NewSale.client = "Unknown";
                        }
                        NewSale.book_name = bookNameTxtBox.Text;
                        NewSale.price = FoundBooks[0].price;
                        NewSale.book_id = FoundBooks[0].id;
                        Cursor.Execute("INSERT INTO sale(op_time, quantity, client,book_name,price,book_id) VALUES(@op_time,@quantity,@client,@book_name,@price,@book_id)", NewSale);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid inputs. Book doesn't exist");
                }
            }
            bookNameTxtBox.Clear();
            ClienttxtBox.Text = "Unknown";
            quantityNumeric.Value = 1;
            LoadSales();
        }
    }
}
