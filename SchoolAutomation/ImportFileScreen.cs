using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolAutomation
{
    public partial class ImportFileScreen : Form
    {
        public ImportFileScreen()
        {
            InitializeComponent();
        }

        SqlConnection connectionString = new SqlConnection("Server=(localdb)\\localDB1;Database=SchoolDb;Trusted_Connection=True;");



        private void dataGridView_ImportData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_ImportFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Dosyaları(*.xlsx)|*.xlsx|Tüm Dosyalar(*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialog.FileName;
                textBox_FilePath.Text = filepath;
            }
        }
    }
}
