namespace CLsChat
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblGroup = new System.Windows.Forms.Label();
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.listOfUsers = new System.Windows.Forms.ListBox();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmessage = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnInboxRefresh = new System.Windows.Forms.Button();
            this.dataGridViewInbox = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSentItemsRefresh = new System.Windows.Forms.Button();
            this.dataGridViewSentItems = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInbox)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSentItems)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(35, 47);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1348, 528);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.lblGroup);
            this.tabPage1.Controls.Add(this.comboBoxGroups);
            this.tabPage1.Controls.Add(this.listOfUsers);
            this.tabPage1.Controls.Add(this.checkBoxAll);
            this.tabPage1.Controls.Add(this.btnSend);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtmessage);
            this.tabPage1.Controls.Add(this.txtSubject);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1340, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Message";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(1133, 34);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(44, 16);
            this.lblGroup.TabIndex = 13;
            this.lblGroup.Text = "Group";
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Location = new System.Drawing.Point(1183, 29);
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Size = new System.Drawing.Size(121, 24);
            this.comboBoxGroups.TabIndex = 12;
            this.comboBoxGroups.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroups_SelectedIndexChanged);
            // 
            // listOfUsers
            // 
            this.listOfUsers.FormattingEnabled = true;
            this.listOfUsers.ItemHeight = 16;
            this.listOfUsers.Location = new System.Drawing.Point(1039, 62);
            this.listOfUsers.Margin = new System.Windows.Forms.Padding(4);
            this.listOfUsers.Name = "listOfUsers";
            this.listOfUsers.Size = new System.Drawing.Size(265, 356);
            this.listOfUsers.TabIndex = 11;
            this.listOfUsers.SelectedIndexChanged += new System.EventHandler(this.listOfUsers_SelectedIndexChanged);
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Location = new System.Drawing.Point(1039, 33);
            this.checkBoxAll.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(44, 20);
            this.checkBoxAll.TabIndex = 10;
            this.checkBoxAll.Text = "All";
            this.checkBoxAll.UseVisualStyleBackColor = true;
            this.checkBoxAll.CheckedChanged += new System.EventHandler(this.checkBoxAll_CheckedChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(140, 442);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 28);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Subject";
            // 
            // txtmessage
            // 
            this.txtmessage.Location = new System.Drawing.Point(140, 78);
            this.txtmessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtmessage.Multiline = true;
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.Size = new System.Drawing.Size(816, 356);
            this.txtmessage.TabIndex = 4;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(140, 34);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(816, 22);
            this.txtSubject.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnInboxRefresh);
            this.tabPage2.Controls.Add(this.dataGridViewInbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1340, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "inbox";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnInboxRefresh
            // 
            this.btnInboxRefresh.Location = new System.Drawing.Point(1207, 58);
            this.btnInboxRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnInboxRefresh.Name = "btnInboxRefresh";
            this.btnInboxRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnInboxRefresh.TabIndex = 1;
            this.btnInboxRefresh.Text = "Refresh";
            this.btnInboxRefresh.UseVisualStyleBackColor = true;
            this.btnInboxRefresh.Click += new System.EventHandler(this.btnInboxRefresh_Click);
            // 
            // dataGridViewInbox
            // 
            this.dataGridViewInbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewInbox.Location = new System.Drawing.Point(4, 154);
            this.dataGridViewInbox.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewInbox.Name = "dataGridViewInbox";
            this.dataGridViewInbox.RowHeadersWidth = 51;
            this.dataGridViewInbox.Size = new System.Drawing.Size(1332, 341);
            this.dataGridViewInbox.TabIndex = 0;
            this.dataGridViewInbox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInbox_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSentItemsRefresh);
            this.tabPage3.Controls.Add(this.dataGridViewSentItems);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1340, 499);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "sent items";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSentItemsRefresh
            // 
            this.btnSentItemsRefresh.Location = new System.Drawing.Point(1184, 36);
            this.btnSentItemsRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnSentItemsRefresh.Name = "btnSentItemsRefresh";
            this.btnSentItemsRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnSentItemsRefresh.TabIndex = 2;
            this.btnSentItemsRefresh.Text = "Refresh";
            this.btnSentItemsRefresh.UseVisualStyleBackColor = true;
            this.btnSentItemsRefresh.Click += new System.EventHandler(this.btnSentItemsRefresh_Click);
            // 
            // dataGridViewSentItems
            // 
            this.dataGridViewSentItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSentItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewSentItems.Location = new System.Drawing.Point(0, 158);
            this.dataGridViewSentItems.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSentItems.Name = "dataGridViewSentItems";
            this.dataGridViewSentItems.RowHeadersWidth = 51;
            this.dataGridViewSentItems.Size = new System.Drawing.Size(1340, 341);
            this.dataGridViewSentItems.TabIndex = 1;
            this.dataGridViewSentItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSentItems_CellContentClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 590);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInbox)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSentItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewInbox;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmessage;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Button btnInboxRefresh;
        private System.Windows.Forms.Button btnSentItemsRefresh;
        private System.Windows.Forms.DataGridView dataGridViewSentItems;
        private System.Windows.Forms.CheckBox checkBoxAll;
        private System.Windows.Forms.ListBox listOfUsers;
        private System.Windows.Forms.ComboBox comboBoxGroups;
        private System.Windows.Forms.Label lblGroup;




        //

    }
}