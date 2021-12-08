using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT_291_Project
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void CustomerUI_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerUI settingsWindow = new customerUI();
            settingsWindow.Show();
        }

        private void EmployeeUI_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserAndEmployee2 settingsWindow1 = new UserAndEmployee2();
            settingsWindow1.Show();
        }
    }
}
