using System;
using System.Windows.Forms;

namespace SchoolAutomation
{
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
        }





        public void List()
        {
            //db'den veri gelmesini sağla

        }

        private void AdminScreen_Load(object sender, EventArgs e)
        {
            List();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new NewRegistration().ShowDialog();

        }
    }
}
