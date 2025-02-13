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
    public partial class FrmSignUp : Form
    {
        public FrmSignUp()
        {
            InitializeComponent();
        }

        private void lblCreate_Click(object sender, EventArgs e)
        {
            // i still need to validate the inputs
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("Please Enter Your FirstName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtLastName.Text == "")
            {
                MessageBox.Show("Please Enter Your LastName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUserName.Text == "")
            {
                MessageBox.Show("Please Enter Your UserName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Your Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtGroupID.Text == "")
            {
                MessageBox.Show("Please Enter Your GroupID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // i removed UserID cause it's auto increment (identity specification)
                Ado.ExecuteNonQuery($"INSERT INTO dbo.Users(UserName, FullName, Phone, Password, GroupID)" +
                    $" VALUES('{txtUserName.Text}','{txtFirstName.Text + " " + txtLastName.Text}','{txtPhone.Text}','{txtPassword.Text}',{txtGroupID.Text})");
                this.Close();
            }
        }

    }
}
