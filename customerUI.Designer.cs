
namespace CMPT_291_Project
{
    partial class customerUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.userTabUserList = new System.Windows.Forms.Label();
            this.Users = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerSearchBox = new System.Windows.Forms.TextBox();
            this.custSearchButton = new System.Windows.Forms.Button();
            this.customerDropdown = new System.Windows.Forms.ComboBox();
            this.custAcctNo = new System.Windows.Forms.Label();
            this.changeUserType = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Users)).BeginInit();
            this.SuspendLayout();
            // 
            // userTabUserList
            // 
            this.userTabUserList.AutoSize = true;
            this.userTabUserList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.userTabUserList.Location = new System.Drawing.Point(16, 17);
            this.userTabUserList.Name = "userTabUserList";
            this.userTabUserList.Size = new System.Drawing.Size(207, 31);
            this.userTabUserList.TabIndex = 288;
            this.userTabUserList.Text = "Who\'s renting?";
            this.userTabUserList.Click += new System.EventHandler(this.userTabUserList_Click);
            // 
            // Users
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.Users.Location = new System.Drawing.Point(16, 50);
            this.Users.Name = "Users";
            this.Users.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Users.Size = new System.Drawing.Size(770, 420);
            this.Users.TabIndex = 295;
            this.Users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Users_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 69;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 115;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewTextBoxColumn6.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 155;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewTextBoxColumn7.HeaderText = "Phone No.";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 176;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewTextBoxColumn8.HeaderText = "Plan";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // customerSearchBox
            // 
            this.customerSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerSearchBox.Location = new System.Drawing.Point(259, 476);
            this.customerSearchBox.Name = "customerSearchBox";
            this.customerSearchBox.Size = new System.Drawing.Size(91, 26);
            this.customerSearchBox.TabIndex = 355;
            // 
            // custSearchButton
            // 
            this.custSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custSearchButton.Location = new System.Drawing.Point(359, 476);
            this.custSearchButton.Name = "custSearchButton";
            this.custSearchButton.Size = new System.Drawing.Size(71, 28);
            this.custSearchButton.TabIndex = 354;
            this.custSearchButton.Text = "Search";
            this.custSearchButton.UseVisualStyleBackColor = true;
            this.custSearchButton.Click += new System.EventHandler(this.custSearchButton_Click_1);
            // 
            // customerDropdown
            // 
            this.customerDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerDropdown.FormattingEnabled = true;
            this.customerDropdown.Location = new System.Drawing.Point(15, 476);
            this.customerDropdown.Name = "customerDropdown";
            this.customerDropdown.Size = new System.Drawing.Size(238, 28);
            this.customerDropdown.TabIndex = 353;
            // 
            // custAcctNo
            // 
            this.custAcctNo.AutoSize = true;
            this.custAcctNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custAcctNo.Location = new System.Drawing.Point(840, 139);
            this.custAcctNo.Name = "custAcctNo";
            this.custAcctNo.Size = new System.Drawing.Size(94, 13);
            this.custAcctNo.TabIndex = 356;
            this.custAcctNo.Text = "custAcctNoHolder";
            this.custAcctNo.Visible = false;
            // 
            // changeUserType
            // 
            this.changeUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeUserType.Location = new System.Drawing.Point(858, 21);
            this.changeUserType.Name = "changeUserType";
            this.changeUserType.Size = new System.Drawing.Size(107, 27);
            this.changeUserType.TabIndex = 357;
            this.changeUserType.Text = "Change User Type";
            this.changeUserType.UseVisualStyleBackColor = true;
            this.changeUserType.Click += new System.EventHandler(this.changeUserType_Click_1);
            // 
            // customerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 561);
            this.Controls.Add(this.changeUserType);
            this.Controls.Add(this.customerSearchBox);
            this.Controls.Add(this.custSearchButton);
            this.Controls.Add(this.customerDropdown);
            this.Controls.Add(this.userTabUserList);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.custAcctNo);
            this.Name = "customerUI";
            this.Text = "customerUI";
            ((System.ComponentModel.ISupportInitialize)(this.Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label userTabUserList;
        private System.Windows.Forms.DataGridView Users;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox customerSearchBox;
        private System.Windows.Forms.Button custSearchButton;
        private System.Windows.Forms.ComboBox customerDropdown;
        private System.Windows.Forms.Label custAcctNo;
        private System.Windows.Forms.Button changeUserType;
    }
}