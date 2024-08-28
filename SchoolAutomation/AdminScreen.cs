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
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
        }
        
        SchoolDbEntities db = new SchoolDbEntities();

       

        public void List()
        {
            dataGridView_AdminScreen.DataSource = db.student.ToList();
        
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
