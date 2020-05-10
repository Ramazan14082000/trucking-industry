using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Курс_3
{
    public partial class NewK : Form
    {
        private SqlCommandBuilder sqlCommandBuilder = null;
        private SqlDataAdapter SqlDataAdapter = null;
        private DataSet DataSet = null;
        private static readonly string kkk = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @Directory.GetCurrentDirectory() + @"\Database0.mdf;Integrated Security=True";
        private readonly SqlConnection connection = new SqlConnection(@kkk);

        public NewK()
        {
            InitializeComponent();
        }
        private void Reload()
        {
            try
            {
                connection.Open();

                DataSet.Tables["Клиенты"].Clear();
                SqlDataAdapter.Fill(DataSet, "Клиенты");
                dataGridView1.DataSource = DataSet.Tables["Клиенты"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[5, i] = linkCell;


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

                if (e.ColumnIndex == 5)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                    if (task == "Delete")
                    {

                        if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;
                            dataGridView1.Rows.RemoveAt(rowIndex);
                            DataSet.Tables["Клиенты"].Rows[rowIndex].Delete();
                            SqlDataAdapter.Update(DataSet, "Клиенты");

                        }

                    }

                    Reload();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void LoadDB()
        {
            try
            {
                connection.Open();

                SqlDataAdapter = new SqlDataAdapter("SELECT *,'Delete' AS [Delete] FROM [Клиенты]", connection);
                sqlCommandBuilder = new SqlCommandBuilder(SqlDataAdapter);
                sqlCommandBuilder.GetDeleteCommand();
                sqlCommandBuilder.GetInsertCommand();
                sqlCommandBuilder.GetUpdateCommand();

                DataSet = new DataSet();
                SqlDataAdapter.Fill(DataSet, "Клиенты");
                dataGridView1.DataSource = DataSet.Tables["Клиенты"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[5, i] = linkCell;


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



        private void NewK_Load(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((FIOtb.Text.Length != 0) & (ADRtb.Text.Length != 0) & (Teltb.Text.Length != 0) & (Mailtb.Text.Length != 0))
                {
                    connection.Open();
                    string sqlcom = "INSERT INTO [Клиенты]([Клиент],[Адрес],[Телефон],[Электронная почта])VALUES(@Клиент,@Адрес,@Телефон,@Электронная)";

                    SqlCommand command = new SqlCommand(sqlcom, connection);
                    command.Parameters.AddWithValue("Клиент", FIOtb.Text);
                    command.Parameters.AddWithValue("Адрес", ADRtb.Text);
                    command.Parameters.AddWithValue("Телефон", Teltb.Text);
                    command.Parameters.AddWithValue("Электронная", Mailtb.Text);

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

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewV newV = new NewV();
            newV.Show();
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

        private void NewK_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewO newO = new NewO();
            newO.Show();
            Hide();
        }
    }
}
