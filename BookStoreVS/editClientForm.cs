using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace BookStoreVS
{
    public partial class editClientForm : Form
    {
        public editClientForm()
        {
            InitializeComponent();
        }
            private void checkbtn_Click(object sender, EventArgs e)
        {
            using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
            {
                var output = Cursor.Query<ClientModel>(string.Format("select * from client where id = {0}",ClientIdTxt.Text), new DynamicParameters());
                List<ClientModel> ClientsToEdit = output.ToList();
                if (ClientsToEdit.Count == 0)
                {
                    MessageBox.Show(string.Format("No client found with ID {0}", ClientIdTxt.Text));
                }
                else
                {
                    ClientModel ClientToEdit= new ClientModel();
                    ClientToEdit = ClientsToEdit[0];
                    ClientNameTxt.Text = ClientToEdit.name;
                    ClientPhoneText.Text = ClientToEdit.phone;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
            {
                var output = Cursor.Query<ClientModel>(string.Format("select * from client where id = {0}",ClientIdTxt.Text), new DynamicParameters());
                List<ClientModel> ClientsToEdit = output.ToList();
                if (ClientsToEdit.Count == 0)
                {
                    MessageBox.Show(string.Format("No client found with ID {0}", ClientIdTxt.Text));
                }
                else
                {
                    if ((ClientNameTxt.Text == "") || (ClientPhoneText.Text == ""))
                    {
                        MessageBox.Show("Invalid inputs");
                    }
                    else
                    {
                        ClientModel EditedClient = new ClientModel();
                        EditedClient = ClientsToEdit[0];
                        EditedClient.name = ClientNameTxt.Text;
                        EditedClient.phone = ClientPhoneText.Text;
                        Cursor.Execute("UPDATE client SET name = @name, phone = @phone WHERE id = @id", EditedClient);
                        MessageBox.Show("Client data successfully updated." +
                            "Please click the refresh button.");

                        Close();
                    }
                }
            }
        }
    }
}
