using System;
using System.ComponentModel;
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

        SqlConnection connectionString = new SqlConnection("Server=(localdb)\\localDB1;Database=SchoolDb;Trusted_Connection=True;");

        public void Delete()
        {
            try
            {
                connectionString.Open();

                SqlCommand delete = new SqlCommand("delete from student where IdentificationNumber='" + listView1.SelectedItems[0].SubItems[0].Text + "'", connectionString);

                delete.ExecuteNonQuery();

                connectionString.Close();

                Clear();
                List();


                MessageBox.Show("Silme işlemi başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme işlemi başarısız. Mesaj : " + ex.Message, "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        public void Clear_TextBox()
        {
            textBox_Address_Edit.Text = "";
            textBox_Class_Edit.Text = "";
            textBox_FirstName_Edit.Text = "";
            textBox_LastName_Edit.Text = "";
            textBox_IdentificationNumber_Edit.Text = "";
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_List_Edit_Click(object sender, EventArgs e)
        {
            Clear();
            List();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Delete();
            Clear();
            List();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Clear_TextBox();

                textBox_IdentificationNumber_Edit.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox_FirstName_Edit.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox_LastName_Edit.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBox_Class_Edit.Text = listView1.SelectedItems[0].SubItems[3].Text;
                textBox_Address_Edit.Text = listView1.SelectedItems[0].SubItems[4].Text;

                Clear();
                List();
            }
            catch (Exception)
            {

                MessageBox.Show("Herhangi bir öğrenci seçilmedi.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }


        }

        private void button_Save_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                connectionString.Open();

                SqlCommand write = new SqlCommand("UPDATE student SET Class=@Class, FirstName=@FirstName, LastName=@LastName, Address=@Address WHERE IdentificationNumber=@IdentificationNumber", connectionString);

                write.Parameters.AddWithValue("@IdentificationNumber", textBox_IdentificationNumber_Edit.Text);
                write.Parameters.AddWithValue("@FirstName", textBox_FirstName_Edit.Text);
                write.Parameters.AddWithValue("@LastName", textBox_LastName_Edit.Text);
                write.Parameters.AddWithValue("@Class", Convert.ToInt32(textBox_Class_Edit.Text));
                write.Parameters.AddWithValue("@Address", textBox_Address_Edit.Text);




                write.ExecuteNonQuery();
                connectionString.Close();


                MessageBox.Show("Kayıt başarılı", "Kaydedildi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_TextBox();
                Clear();
                List();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
