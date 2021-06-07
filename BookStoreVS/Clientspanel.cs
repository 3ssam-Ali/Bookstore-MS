using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace BookStoreVS
{
    public partial class Clientspanel : UserControl
    {
        public Clientspanel()
        {
            InitializeComponent();
        }
        public void LoadClients()
        {
            using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
            {
                var output = Cursor.Query<ClientModel>(string.Format("select * from client"), new DynamicParameters());
                List<ClientModel> AllClients = output.ToList();
                ClientsGrid.Rows.Clear();
                foreach (ClientModel I in AllClients)
                {
                    DataGridViewRow NewRow = new DataGridViewRow();
                    NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.id });
                    NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.name });
                    NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.phone });
                    NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.date_joined.Date });

                    ClientsGrid.Rows.Add(NewRow);
                }
            }
        }
        private void Clientspanel_Load(object sender, EventArgs e)
        {
            LoadClients();
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
            {
                var output = Cursor.Query<ClientModel>(string.Format("select * from client where name like %{0}%",ClientNametxt.Text), new DynamicParameters());
                List<ClientModel> AllClients = output.ToList();
                ClientsGrid.Rows.Clear();
                foreach (ClientModel I in AllClients)
                {
                    DataGridViewRow NewRow = new DataGridViewRow();
                    NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.id });
                    NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.name });
                    NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.phone });
                    NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.date_joined.Date });
                    ClientsGrid.Rows.Add(NewRow);
                }
            }
        }

        private void EditClientButton_Click(object sender, EventArgs e)
        {
            editClientForm editClientForm1 = new editClientForm();
            editClientForm1.Show();
        }

        private void ClientNametxt_TextChanged(object sender, EventArgs e)
        {
            using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
            {
                var output = Cursor.Query<ClientModel>(string.Format("select * from client where name like '%{0}%'", ClientNametxt.Text), new DynamicParameters());
                List<ClientModel> AllClients = output.ToList();
                ClientsGrid.Rows.Clear();
                foreach (ClientModel I in AllClients)
                {
                    DataGridViewRow NewRow = new DataGridViewRow();
                    NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.id });
                    NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.name });
                    NewRow.Cells.Add(new DataGridViewTextBoxCell { Value = I.phone });
                    ClientsGrid.Rows.Add(NewRow);
                }
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadClients();
        }
    }
}
