using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Restaurant_Management_System
{
    public partial class Login : Form
    {
        string reg_user = "Restaurant";
        string reg_pass = "1234";
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text == reg_user) && (txtPass.Text == reg_pass))
            {
                string message = "Login successfully!";
                MessageBox.Show(message);
                Hide();
                Form1 f1 = new Form1();
                f1.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
