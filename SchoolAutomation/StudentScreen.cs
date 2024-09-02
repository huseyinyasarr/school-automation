using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace SchoolAutomation
{
    public partial class StudentScreen : Form
    {
        SqlConnection connectionString = new SqlConnection("Server=(localdb)\\localDB1;Database=SchoolDb;Trusted_Connection=True;");

        public string id;

        public StudentScreen()
        {
            InitializeComponent();
            
        }

        

        private void StudentScreen_FormClosed(object sender, FormClosedEventArgs e)
        {         
            
            Application.Exit();
        }

        private void StudentScreen_Load(object sender, EventArgs e)
        {
            
            textBox_Student_ID.Text = id;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Student_Save_Edit_Click(object sender, EventArgs e)
        {
            connectionString.Open();

            //SqlCommand write = new SqlCommand("UPDATE student SET FirstName=@FirstName, LastName=@LastName, Address=@Address WHERE IdentificationNumber=@IdentificationNumber", connectionString);

            SqlCommand write = new SqlCommand("UPDATE student SET Address=@Address WHERE IdentificationNumber=@IdentificationNumber", connectionString);

            write.Parameters.AddWithValue("@IdentificationNumber", id);
            write.Parameters.AddWithValue("@Address", textBox_Student_Address.Text);

            write.ExecuteNonQuery();
            connectionString.Close();


            MessageBox.Show("Kayıt başarılı", "Kaydedildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
