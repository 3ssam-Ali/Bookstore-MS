using System;
using Dapper;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BookStoreVS
{
    public partial class addEmployeeForm : Form
    {
        private List<string> usernames = new List<string>();
        
        public addEmployeeForm()
        {
            InitializeComponent();
        }

        private void addEmployeeForm_Load(object sender, EventArgs e)
        {
            using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
            {
                var employeeOutput = Cursor.Query<EmploteeModel>("select name from employee", new DynamicParameters());
                List<EmploteeModel> Users = employeeOutput.ToList();
                for (int i = 0; i < Users.Count(); i++)
                {
                  
                   this.usernames.Add(Users[i].name);
                }
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (usernames.Contains(textBox1.Text.ToLower()) && textBox1.Text!="")
            {
                warning.Visible = true;
            }
            else
            {
                warning.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
            {
                string name = textBox1.Text.ToLower();
                string email = textBox2.Text;
                string phone = textBox3.Text;
                string nationalId = textBox4.Text;
                string password = textBox5.Text;
                string password2 = textBox6.Text;
                string admin = checkBox1.Checked.ToString();
                if (password != password2)
                {
                    MessageBox.Show("Password is not the same in both fields");
                }
                else
                {
                    Cursor.Execute(string.Format("insert into employee (name, mail, phone, national_Id, password, isAdmin ) " +
                            "values ('{0}','{1}','{2}','{3}','{4}','{5}')", name, email, phone, nationalId, password, admin));
                    MessageBox.Show("Account added successfully.");
                }
            }
        }
    }
}
