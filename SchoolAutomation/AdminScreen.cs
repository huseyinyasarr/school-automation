using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolAutomation
{
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
        }

        SqlConnection connectionString = new SqlConnection("Server=(localdb)\\localDB1;Database=SchoolDb;Trusted_Connection=True;");

        private void List()
        {
            connectionString.Open();
            SqlCommand cmd = new SqlCommand("select *from student", connectionString);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();


                item.Text = reader.GetString(0);
                item.SubItems.Add(reader.GetString(2));
                item.SubItems.Add(reader.GetString(3));
                item.SubItems.Add(reader["Class"].ToString());
                item.SubItems.Add(reader.GetString(4));





                listView1.Items.Add(item);


            }
            connectionString.Close();

        }

       

        private void AdminScreen_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {





        }

        private void button1_Click(object sender, EventArgs e)
        {
            new NewRegistration().ShowDialog();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            ListViewItem item = new ListViewItem();

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Clear();
            List();
        }
    }
}
