using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolAutomation
{
    public partial class NewRegistration : Form
    {
        public NewRegistration()
        {
            InitializeComponent();
        }

        student save = new student();
        SchoolDbEntities db = new SchoolDbEntities();
        public void Save()
        {
            save.IdentificationNumber = textBox_ID.Text;
            save.Class = Convert.ToInt32(textBox_Class.Text);
            save.FirstName = textBox_FirstName.Text;
            save.LastName = textBox_LastName.Text;
            save.Address = textBox_Address.Text;

            db.student.Add(save);
            db.SaveChanges();

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
