using System;
using System.Windows.Forms;

namespace SchoolAutomation
{
    public partial class AutomationLoginForm : Form
    {
        



        public AutomationLoginForm()
        {
            InitializeComponent();
        }

        private void AutomationLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button_Student_Login_Click(object sender, EventArgs e)
        {

        }


        private void button_Teacher_Login_Click(object sender, EventArgs e)
        {

            new AdminScreen().ShowDialog();

        }

        private void groupBox_Teacher_Login_Enter(object sender, EventArgs e)
        {

        }
    }
}
