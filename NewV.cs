using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Курс_3
{
    public partial class NewV : Form
    {
        private SqlCommandBuilder sqlCommandBuilder = null;
        private SqlDataAdapter SqlDataAdapter = null;
        private DataSet DataSet = null;
        private static readonly string kkk = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @Directory.GetCurrentDirectory() + @"\Database0.mdf;Integrated Security=True";
        private readonly SqlConnection connection = new SqlConnection(@kkk);

        public NewV()
        {
            InitializeComponent();
        }
        private void Reload()
        {
            try
            {
                connection.Open();

                DataSet.Tables["Водители"].Clear();
                SqlDataAdapter.Fill(DataSet, "Водители");
                dataGridView1.DataSource = DataSet.Tables["Водители"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[10, i] = linkCell;


                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == 10)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();

                    if (task == "Delete")
                    {

                        if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;
                            dataGridView1.Rows.RemoveAt(rowIndex);
                            DataSet.Tables["Водители"].Rows[rowIndex].Delete();
                            SqlDataAdapter.Update(DataSet, "Водители");

                        }

                    }


                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);

            }
            finally
            {
                Reload();
            }

        }
        private void LoadDB()
        {
            try
            {
                connection.Open();

                SqlDataAdapter = new SqlDataAdapter("SELECT *,'Delete' AS [Delete] FROM [Водители]", connection);
                sqlCommandBuilder = new SqlCommandBuilder(SqlDataAdapter);
                sqlCommandBuilder.GetDeleteCommand();
                sqlCommandBuilder.GetInsertCommand();
                sqlCommandBuilder.GetUpdateCommand();

                DataSet = new DataSet();
                SqlDataAdapter.Fill(DataSet, "Водители");
                dataGridView1.DataSource = DataSet.Tables["Водители"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[10, i] = linkCell;


                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                connection.Close();
            }

        }



        private void NewV_Load(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewK newK = new NewK();
            newK.Show();
            Hide();
        }

        private void водителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewZ newZ = new NewZ();
            newZ.Show();
            Hide();
        }

        private void грузовикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((FIOtb.Text.Length != 0) & (TABNtb.Text.Length != 0) & (Adrtb.Text.Length != 0) & (NOMtb.Text.Length != 0) & (PASStb.Text.Length != 0) & (ZARtb.Text.Length != 0))
                {
                    connection.Open();
                    string sqlcom = "INSERT INTO [Водители]([ФИО],[Табельный номер],[Паспортные данные],[Адрес],[Телефон],[Дата рождения],[Дата приема],[Зарплата])VALUES(@ФИО,@Табельный,@Паспортные,@Адрес,@Телефон,@рождения,@приема,@Зарплата)";

                    SqlCommand command = new SqlCommand(sqlcom, connection);
                    command.Parameters.AddWithValue("ФИО", FIOtb.Text);
                    command.Parameters.AddWithValue("Табельный", int.Parse(TABNtb.Text));
                    command.Parameters.AddWithValue("Адрес", Adrtb.Text);
                    command.Parameters.AddWithValue("Телефон", NOMtb.Text);
                    command.Parameters.AddWithValue("Паспортные", int.Parse(PASStb.Text));
                    command.Parameters.AddWithValue("рождения", DATERO.Value);
                    command.Parameters.AddWithValue("приема", DATEPR.Value);
                    command.Parameters.AddWithValue("Зарплата", decimal.Parse(ZARtb.Text));

                    command.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Заполните все поля");

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);

            }
            finally
            {
                connection.Close();
                Reload();


            }



        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewO newO = new NewO();
            newO.Show();
            Hide();
        }
    }
}
