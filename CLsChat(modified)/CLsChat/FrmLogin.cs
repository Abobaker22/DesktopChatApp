using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLsChat
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            
            FrmSignUp form = new FrmSignUp();
            form.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        { 
            // need to test login, sign up done.
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please Enter Your UserName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Your Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string res = Ado.ValidateLogin($"select UserID From Users Where UserName = '{txtUserName.Text}' and Password = '{txtPassword.Text}'");
            if (res != null)
            {
                FrmMain frmMain = new FrmMain();
                this.Hide();
                frmMain.Show();
                
            }
            else
            {
                MessageBox.Show("invalid UserName Or Password","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Ado.OpenConnection();
            txtUserName.Focus();
        }
    }
}
