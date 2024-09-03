using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace SchoolAutomation
{
    public partial class ImportFileScreen : Form
    {
        public ImportFileScreen()
        {
            InitializeComponent();
        }

        //SqlConnection connectionString = new SqlConnection("Server=(localdb)\\localDB1;Database=SchoolDb;Trusted_Connection=True;");



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

                OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filepath + ";Extended Properties='Excel 12.0;IMEX=1;'");

                conn.Open();

                OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from [Sayfa1$]", conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView_ImportData.DataSource = dataTable;
                conn.Close();

            }
        }

        private void ImportFileScreen_Load(object sender, EventArgs e)
        {

        }

        private void SaveDataGridViewToSQL()
        {
            string connectionString = "Server=(localdb)\\localDB1;Database=SchoolDb;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (DataGridViewRow row in dataGridView_ImportData.Rows)
                {
                    if (row.IsNewRow) continue;

                    string column1Value = row.Cells["IdentificationNumber"].Value.ToString();
                    string column2Value = row.Cells["Class"].Value.ToString();
                    string column3Value = row.Cells["FirstName"].Value.ToString();
                    string column4Value = row.Cells["LastName"].Value.ToString();
                    string column5Value = row.Cells["Address"].Value.ToString();
                    string column6Value = row.Cells["Password"].Value.ToString();


                    string query = "INSERT INTO student (IdentificationNumber, Class, FirstName, LastName, Address, Password) VALUES (@IdentificationNumber, @Class, @FirstName,@LastName, @Address, @Password)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdentificationNumber", column1Value);
                        command.Parameters.AddWithValue("@Class", column2Value);
                        command.Parameters.AddWithValue("@FirstName", column3Value);
                        command.Parameters.AddWithValue("@LastName", column4Value);
                        command.Parameters.AddWithValue("@Address", column5Value);
                        command.Parameters.AddWithValue("@Password", PasswordEncryptor.MD5Hash(column6Value));

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Veriler başarıyla kaydedildi.");

            }

        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            SaveDataGridViewToSQL();



        }
    }
}

