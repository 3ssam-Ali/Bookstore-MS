using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using Dapper;

namespace BookStoreVS
{
    public partial class Controlspanel : UserControl
    {
        public Controlspanel()
        {
            InitializeComponent();
        }

        private void addEmployeebtn_Click(object sender, EventArgs e)
        {
            addEmployeeForm addEmployeeForm1 = new addEmployeeForm();
            addEmployeeForm1.Show();
        }

        private void editEmployeebtn_Click(object sender, EventArgs e)
        {
            EditEmployeeForm editEmployeeForm1 = new EditEmployeeForm();
            editEmployeeForm1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("coming soon");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("coming soon");
        }

        private void SuppAddButton_Click(object sender, EventArgs e)
        {
            using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
            {
                SupplierModel NewSupp = new SupplierModel();
                NewSupp.name = SuppNameTxt.Text;
                NewSupp.phone = SuppPhoneTxt.Text;
                NewSupp.mail = SuppEmailTxt.Text;
                Cursor.Execute("insert into supplier(name,phone,mail) values(@name,@phone,@mail)", NewSupp);
            }
        } 

        private void PubAddbutton_Click(object sender, EventArgs e)
        {
            using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
            {
                PublisherModel NewPub = new PublisherModel();
                NewPub.name = PubNameTxt.Text;
                NewPub.address = PubAddressTxt.Text;
                NewPub.email = PubEmailTxt.Text;
                Cursor.Execute("insert into publisher(name,email,address) values(@name,@email,@address)", NewPub);
            }
        }

        private void CategoryAddButton_Click(object sender, EventArgs e)
        {
            using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
            {
                CategoryModel NewCategory = new CategoryModel();
                NewCategory.name = CategoryTxt.Text;
                Cursor.Execute("insert into category(name) values(@name)", NewCategory);
            }
        }

        private void CategoryDelButton_Click(object sender, EventArgs e)
        {
            using (IDbConnection Cursor = new SQLiteConnection("Data Source=.\\database.db;Version=3;"))
            {
                CategoryModel NewCategory = new CategoryModel();
                NewCategory.name = CategoryTxt.Text;
                Cursor.Execute("delete from category where name = @name", NewCategory);
            }
        }
    }
}
