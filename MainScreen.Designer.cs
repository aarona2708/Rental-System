
namespace CMPT_291_Project
{
    partial class MainScreen
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
            this.UserType = new System.Windows.Forms.Label();
            this.CustomerUI = new System.Windows.Forms.Button();
            this.EmployeeUI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserType
            // 
            this.UserType.AutoSize = true;
            this.UserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserType.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.UserType.Location = new System.Drawing.Point(388, 214);
            this.UserType.Name = "UserType";
            this.UserType.Size = new System.Drawing.Size(229, 37);
            this.UserType.TabIndex = 189;
            this.UserType.Text = "Type of User?";
            // 
            // CustomerUI
            // 
            this.CustomerUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerUI.Location = new System.Drawing.Point(407, 263);
            this.CustomerUI.Name = "CustomerUI";
            this.CustomerUI.Size = new System.Drawing.Size(88, 28);
            this.CustomerUI.TabIndex = 188;
            this.CustomerUI.Text = "Customer";
            this.CustomerUI.UseVisualStyleBackColor = true;
            this.CustomerUI.Click += new System.EventHandler(this.CustomerUI_Click);
            // 
            // EmployeeUI
            // 
            this.EmployeeUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeUI.Location = new System.Drawing.Point(501, 264);
            this.EmployeeUI.Name = "EmployeeUI";
            this.EmployeeUI.Size = new System.Drawing.Size(88, 28);
            this.EmployeeUI.TabIndex = 187;
            this.EmployeeUI.Text = "Manager";
            this.EmployeeUI.UseVisualStyleBackColor = true;
            this.EmployeeUI.Click += new System.EventHandler(this.EmployeeUI_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 561);
            this.Controls.Add(this.UserType);
            this.Controls.Add(this.CustomerUI);
            this.Controls.Add(this.EmployeeUI);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserType;
        private System.Windows.Forms.Button CustomerUI;
        private System.Windows.Forms.Button EmployeeUI;
    }
}