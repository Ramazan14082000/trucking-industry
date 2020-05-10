using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Курс_3
{
    public partial class Form4 : Form
    {
        private SqlCommandBuilder sqlCommandBuilder = null;
        private SqlDataAdapter SqlDataAdapter = null;
        private DataSet DataSet = null;
        private static readonly string kkk = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @Directory.GetCurrentDirectory() + @"\Database0.mdf;Integrated Security=True";
        private readonly SqlConnection connection = new SqlConnection(@kkk);
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadDB();
        }
        private void Reload()
        {
            try
            {
                connection.Open();

                DataSet.Tables["Грузовики"].Clear();
                SqlDataAdapter.Fill(DataSet, "Грузовики");
                dataGridView1.DataSource = DataSet.Tables["Грузовики"];

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
                            DataSet.Tables["Грузовики"].Rows[rowIndex].Delete();
                            SqlDataAdapter.Update(DataSet, "Грузовики");

                        }

                    }


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

                SqlDataAdapter = new SqlDataAdapter("SELECT *,'Delete' AS [Delete] FROM [Грузовики]", connection);
                sqlCommandBuilder = new SqlCommandBuilder(SqlDataAdapter);
                sqlCommandBuilder.GetDeleteCommand();
                sqlCommandBuilder.GetInsertCommand();
                sqlCommandBuilder.GetUpdateCommand();

                DataSet = new DataSet();
                SqlDataAdapter.Fill(DataSet, "Грузовики");
                dataGridView1.DataSource = DataSet.Tables["Грузовики"];

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


        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewK newK = new NewK();
            newK.Show();
            Hide();
        }

        private void водителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewV newV = new NewV();
            newV.Show();
            Hide();
        }

        private void грузовикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewZ newZ = new NewZ();
            newZ.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Marktb.Text.Length != 0) & (colortb.Text.Length != 0) & (REGtb.Text.Length != 0))
                {
                    connection.Open();
                    string sqlcom = "INSERT INTO [Грузовики]([Марка],[Год выпуска],[Цвет],[Номер])VALUES(@Марка,@Год,@Цвет,@Номер)";

                    SqlCommand command = new SqlCommand(sqlcom, connection);
                    command.Parameters.AddWithValue("Марка", Marktb.Text);
                    command.Parameters.AddWithValue("Год", Yeardt.Value);
                    command.Parameters.AddWithValue("Цвет", colortb.Text);
                    command.Parameters.AddWithValue("Номер", REGtb.Text);

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
