using System;
using System.Windows.Forms;

namespace BookStoreVS
{
    public partial class MainWindow : Form
    {
        public void BtnClose_Click(object sender, EventArgs e)
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
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void MainWindow_Load(object sender, EventArgs e)
        {
            oppanel1.LoadSales();
            usernamelabel.Text = Preload.User;
            if (!Preload.isAdmin)
            {
                
                controlsbtn.Visible = false;
                reportbtn.Visible = false;
                controlspanel1.Visible = false;
            }
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        
        private void opbtn_Click(object sender, EventArgs e)
        {
            oppanel1.BringToFront();
        }

        private void stockbtn_Click(object sender, EventArgs e)
        {
            stockpanel1.BringToFront();
        }

        private void clientbtn_Click(object sender, EventArgs e)
        {
            clientspanel1.BringToFront();
        }

        private void reportbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon");
        }

        private void controlsbtn_Click(object sender, EventArgs e)
        {
            controlspanel1.BringToFront();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Login login1=new Login();
            login1.Show();
            Close();
        }
    }
}
