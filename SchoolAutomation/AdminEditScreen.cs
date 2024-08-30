﻿using System;
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

                List();


                MessageBox.Show("Silme işlemi başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme işlemi başarısız. Mesaj : "+ex.Message, "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Clear_TextBox();
            connectionString.Open();
            SqlCommand cmd = new SqlCommand("select *from student", connectionString);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();


                textBox_IdentificationNumber_Edit.Text = reader.GetString(0);
                textBox_FirstName_Edit.Text = reader.GetString(2);
                textBox_LastName_Edit.Text = reader.GetString(3);
                textBox_Class_Edit.Text = reader[1].ToString(); 
                textBox_Address_Edit.Text = reader.GetString(4);



               

            }
            connectionString.Close();
        }
    }
}
