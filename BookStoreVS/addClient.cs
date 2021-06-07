using Dapper;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BookStoreVS
{
    public partial class addClient : Form
    {
        public addClient()
        {
            InitializeComponent();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            foreach (Form I in Application.OpenForms)
            {
                if (I.Visible)
                {
                    cnt += 1;
                }
            }
            if (cnt == 0)
            {
                Application.Exit();
            }
        }
        private void AddClientButton_Click(object sender, EventArgs e)
        {
            ClientModel NewClient = new ClientModel();
            NewClient.name = AddClientName.Text;
            NewClient.phone = AddClientPhone.Text;
            NewClient.date_joined = DateTime.Today;
            using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
            {
                Cursor.Execute("INSERT INTO client(name, phone, date_joined) VALUES(@name,@phone,@date_joined)", NewClient);
            }
            MessageBox.Show("Client successfully added.");
            Close();

        }
    }
}
