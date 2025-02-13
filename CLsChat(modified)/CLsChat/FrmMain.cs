using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLsChat
{
    public partial class FrmMain : Form
    {
        SqlDataReader reader = null;

        private void MessageIsRead(object sender, DataGridViewCellEventArgs e, DataGridView dataGrid)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGrid.Columns[e.ColumnIndex].Name == "IsRead")
            {
                DataGridViewCheckBoxCell chkCell = (DataGridViewCheckBoxCell)dataGrid.Rows[e.RowIndex].Cells["IsRead"];
                bool isChecked = (bool)chkCell.Value;

                chkCell.Value = !isChecked; // Toggle the value in the DataGridView
                isChecked = !isChecked;

                // *** KEY CHANGE: Get the MessageID from the DataGridView row ***
                int messageId = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells["MessageID"].Value); // Assuming your ID column is named "MessageID"

                Ado.ExecuteNonQuery($"UPDATE Messages SET IsRead = {Convert.ToInt32(isChecked)} WHERE MessageID = {messageId}");
            }
        }

        private void ShowGrid(SqlDataReader reader,DataGridView dataGrid)
        {
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            dataGrid.DataSource = dt;
            dataGrid.Columns["MessageID"].Visible = false;
            dataGrid.Refresh();
        }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // i can also make one reader and assign new value each time to shorten code
            // display all users
            reader = Ado.ExecuteQuery($"Select UserName From Users Where UserID != {Ado.SenderID}");
            List<string> Users = Ado.GetUsers(reader, "UserName");
            foreach (var item in Users)
            {
                listOfUsers.Items.Add(item);
            }
            //
            // display inbox
            reader = Ado.ExecuteQuery($"SELECT M.MessageID, U1.UserName AS SenderName, M.Subject, M.Body, M.DateSent, M.IsRead " +
                                                        $"FROM Messages M " +
                                                        $"INNER JOIN Users U1 ON M.SenderID = U1.UserID " +
                                                        $"INNER JOIN Users U2 ON M.RecipientID = U2.UserID " +
                                                        $"WHERE U2.UserID  = {Ado.SenderID}");
            //DataTable dt = new DataTable();
            //dt.Load(reader);
            //reader.Close();
            //dataGridViewInbox.DataSource = dt;
            //dataGridViewInbox.Columns["MessageID"].Visible = false;
            //dataGridViewInbox.Refresh();
            ShowGrid(reader, dataGridViewInbox);

            //
            // display SentItems
            reader = Ado.ExecuteQuery($"SELECT M.MessageID, U2.UserName AS ReceiverName, M.Subject, M.Body, M.DateSent, M.IsRead " +
                                                        $"FROM Messages M " +
                                                        $"INNER JOIN Users U1 ON M.SenderID = U1.UserID " +
                                                        $"INNER JOIN Users U2 ON M.RecipientID = U2.UserID " +
                                                        $"WHERE U1.UserID = {Ado.SenderID}");
            //DataTable dt2 = new DataTable();
            //dt2.Load(reader);
            //reader.Close();
            //dataGridViewSentItems.DataSource = dt2;
            //dataGridViewSentItems.Columns["MessageID"].Visible = false;
            //dataGridViewSentItems.Refresh();
            ShowGrid(reader, dataGridViewSentItems);


            //
            // display Groups

            reader = Ado.ExecuteQuery("Select GroupName From Groups");
            List<string> GroupNames = Ado.GetUsers(reader, "GroupName"); // Get Users can also Get GrouNames

            // another option to fill combobox
            //foreach (var item in GroupNames)
            //{
            //    comboBoxGroups.Items.Add(item);
            //}
            // OR
            GroupNames.Insert(0, "None");
            comboBoxGroups.DataSource = GroupNames;
        }



        private void listOfUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listOfUsers.SelectedItem != null)
            {
                Ado.RecieverIDs.Clear();
                string selectedItem = listOfUsers.SelectedItem.ToString();
                reader = Ado.ExecuteQuery($"Select UserID From Users Where UserName = '{selectedItem}'");
                string ID = Ado.GetUsers(reader, "UserID")[0];
                Ado.RecieverIDs.Add(int.Parse(ID));
            }
        }
        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAll.Checked == true)
            {
                reader = Ado.ExecuteQuery($"Select UserID From Users Where UserID != {Ado.SenderID}");
                List<string> StringIDs = Ado.GetUsers(reader, "UserID");
                Ado.RecieverIDs.Clear();
                foreach (var item in StringIDs)
                {
                    Ado.RecieverIDs.Add(int.Parse(item));
                }
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (listOfUsers.SelectedItem == null && checkBoxAll.Checked == false && comboBoxGroups.SelectedItem.ToString() == "None")
            {
                MessageBox.Show("Please Select User To Send The Message to", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (var id in Ado.RecieverIDs)
                {
                    Ado.ExecuteNonQuery($"INSERT INTO Messages (SenderID, RecipientID, Subject, Body, IsRead) " +
                    $"VALUES ({Ado.SenderID}, {id}, '{txtSubject.Text}', '{txtmessage.Text}', 0);");
                }
                MessageBox.Show("Email Sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnInboxRefresh_Click(object sender, EventArgs e)
        {
            reader = Ado.ExecuteQuery($"SELECT M.MessageID, U1.UserName AS SenderName, M.Subject, M.Body, M.DateSent, M.IsRead " +
                                                        $"FROM Messages M " +
                                                        $"INNER JOIN Users U1 ON M.SenderID = U1.UserID " +
                                                        $"INNER JOIN Users U2 ON M.RecipientID = U2.UserID " +
                                                        $"WHERE U2.UserID  = {Ado.SenderID}");
            //DataTable dt = new DataTable();
            //dt.Load(reader);
            //reader.Close();
            //dataGridViewInbox.DataSource = dt;
            //dataGridViewInbox.Columns["MessageID"].Visible = false;
            //dataGridViewInbox.Refresh();
            ShowGrid(reader, dataGridViewInbox);

        }

        private void btnSentItemsRefresh_Click(object sender, EventArgs e)
        {
            reader = Ado.ExecuteQuery($"SELECT M.MessageID, U2.UserName AS ReceiverName, M.Subject, M.Body, M.DateSent, M.IsRead " +
                                                        $"FROM Messages M " +
                                                        $"INNER JOIN Users U1 ON M.SenderID = U1.UserID " +
                                                        $"INNER JOIN Users U2 ON M.RecipientID = U2.UserID " +
                                                        $"WHERE U1.UserID = {Ado.SenderID}");
            //DataTable dt2 = new DataTable();
            //dt2.Load(reader);
            //reader.Close();
            //dataGridViewSentItems.DataSource = dt2;
            //dataGridViewSentItems.Columns["MessageID"].Visible = false;
            //dataGridViewSentItems.Refresh();
            ShowGrid(reader, dataGridViewSentItems);
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmLogin frmlogin = Application.OpenForms["FrmLogin"] as FrmLogin; // Get a reference to FrmLogin
            if (frmlogin != null)
            {
                frmlogin.Show(); // Show frmlogin
            }
        }

        private void comboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGroups.SelectedItem.ToString() != "None")
            {
                Ado.RecieverIDs.Clear();
                string selectedGroup = comboBoxGroups.SelectedItem.ToString();
                reader = Ado.ExecuteQuery($"select UserID from users U inner join Groups G on U.GroupID = G.GroupID where GroupName = '{selectedGroup}' And UserID != {Ado.SenderID}");
                List<string> StringIDs = Ado.GetUsers(reader, "UserID");
                foreach (var item in StringIDs)
                {
                    Ado.RecieverIDs.Add(int.Parse(item));
                }

            }
        }

        private void dataGridViewInbox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageIsRead(sender,e, dataGridViewInbox);
        }
        private void dataGridViewSentItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageIsRead(sender, e, dataGridViewSentItems);
        }

        

    }
}