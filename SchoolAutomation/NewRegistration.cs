using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolAutomation
{
    public partial class NewRegistration : Form
    {
        public NewRegistration()
        {
            InitializeComponent();
        }

        SqlConnection connectionString = new SqlConnection("Server=(localdb)\\localDB1;Database=SchoolDb;Trusted_Connection=True;");


        public void Save()
        {
            connectionString.Open();

            SqlCommand write = new SqlCommand("insert into student values ('"+textBox_ID.Text.ToString()+"', '"+ Convert.ToInt32(textBox_Class.Text)+"' , '"+textBox_FirstName.Text.ToString()+"', '"+textBox_LastName.Text.ToString()+"', '"+textBox_Address.Text.ToString()+"')", connectionString);

            write.ExecuteNonQuery();


            MessageBox.Show("Kayıt başarılı", "Kaydedildi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Clear();

        }

        public void Clear()
        {
            textBox_Address.Text = "";
            textBox_Class.Text = "";
            textBox_FirstName.Text = "";
            textBox_LastName.Text = "";
            textBox_ID.Text = "";

        }

        private void NewRegistration_Load(object sender, EventArgs e)
        {

        }

        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {

        }

        public int YesOrNo()
        {
            if (textBox_ID.Text == "" || textBox_FirstName.Text == "" || textBox_LastName.Text == "" || Convert.ToInt32(textBox_Class.Text) < 0 || Convert.ToInt32(textBox_Class.Text) > 4 || textBox_Address.Text == "")
            {
                MessageBox.Show("Tüm bilgileri doğru girdiğinizden emin olunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            else
            {
                return 1;
            }


        }

        private void button_Save_Registration_Click(object sender, EventArgs e)
        {
            var i = YesOrNo();

            if (i == 0)
            {

            }

            else
            {
                Save();
                Clear();
            }

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            var i = YesOrNo();
            if (i == 0)
            {

            }

            else
            {
                Save();
                Clear();
            }

        }
    }
}
