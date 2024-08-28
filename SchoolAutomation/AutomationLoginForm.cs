using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
