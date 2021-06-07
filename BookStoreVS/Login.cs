using System;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;


namespace BookStoreVS
{
    public partial class Login : Form
    {
        private void Start(string usr,string status)
        {
            Preload.User = usr;
            Preload.isAdmin = status.ToLower() == "true" ? true : false;
            var main = new MainWindow();
            main.Location = this.Location;
            main.StartPosition = FormStartPosition.Manual;
            main.Show();
            this.Hide();
            
        }
        public Login()
        {
            InitializeComponent();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
            {
                List<string> ValidUsers = new List<string>();
                string inputUsername = usernametxt.Text.ToLower();
                string inputPassword = passwordtxt.Text;
                var employeeOutput = Cursor.Query<EmploteeModel>(string.Format("select name,password,isAdmin from employee where name ='{0}' and password ='{1}'",inputUsername,inputPassword), new DynamicParameters());
                List<EmploteeModel> Users = employeeOutput.ToList();
                if (Users.Count==0)
                {
                    MessageBox.Show("Invalid Username/Password");
                }
                else
                { 
                    Start(inputUsername, Users[0].isAdmin);
                }
            }
        }


        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Start("Admin Demo", "True");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Start("Employee Demo", "False");
        }
    }
    
}
