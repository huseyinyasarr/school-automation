using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolAutomation
{
    public partial class AdminEditScreen : Form
    {
        public AdminEditScreen()
        {
            InitializeComponent();
            Clear();
            List();
        }

        AdminScreen adminScreen = new AdminScreen();

        public void List()
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

        public void Clear()
        {
            listView1.Items.Clear();
        }

        SqlConnection connectionString = new SqlConnection("Server=(localdb)\\localDB1;Database=SchoolDb;Trusted_Connection=True;");

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_List_Edit_Click(object sender, EventArgs e)
        {
            Clear();
            List();
        }
    }
}
