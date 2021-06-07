using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using System.Data.SQLite;

namespace BookStoreVS
{
    
    public partial class EditEmployeeForm : Form
    {
        private EmploteeModel account = new EmploteeModel();
        public EditEmployeeForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
            {
                List<string> ValidUsers;
                string inputUsername = textBox7.Text.ToLower();
                string inputPassword = textBox8.Text;
                var employeeOutput = Cursor.Query<EmploteeModel>(string.Format("select * from employee where name ='{0}' and password ='{1}'", inputUsername, inputPassword), new DynamicParameters());
                List<EmploteeModel> Users = employeeOutput.ToList();
                if (Users.Count == 0)
                {
                    MessageBox.Show("Invalid Username/Password");
                }
                else
                {
                    account = Users[0];
                    textBox1.Text = account.name;
                    textBox2.Text = account.mail;
                    textBox3.Text = account.phone;
                    textBox4.Text = account.national_Id;
                    checkBox1.Checked = account.isAdmin.ToLower() == "true" ? true : false;
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Confirm to delete", "delete confirmation", MessageBoxButtons.OKCancel);
                if (confirm==DialogResult.OK)
                {
                    using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
                    {
                        Cursor.Execute(string.Format("delete from employee where name = '{0}' and password = '{1}'", textBox7.Text.ToLower(), textBox8.Text));
                        MessageBox.Show("Account Deleted");
                    }   
                }
               
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != textBox6.Text && textBox5.Text != "")
            {
                MessageBox.Show("Password is not the same in both fields");

            }
            else
            {
                account.name = textBox1.Text;
                account.mail = textBox2.Text;
                account.phone = textBox3.Text;
                account.national_Id = textBox4.Text;
                if (textBox5.Text!="")
                {
                    account.password = textBox5.Text;
                }
                account.isAdmin = checkBox1.Checked.ToString();
                using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
                {
                    Cursor.Execute("UPDATE employee SET name = @name, mail = @mail, phone = @phone," +
                        " national_Id = @national_Id, password = @password, isAdmin = @isAdmin WHERE id = @id", account);
                }
            }


        }
    }
}
