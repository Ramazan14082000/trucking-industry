using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Курс_3
{
    public partial class NewZ : Form
    {
        private SqlCommandBuilder sqlCommandBuilder = null;
        private SqlDataAdapter SqlDataAdapter = null;
        private DataSet DataSet = null;
        private static readonly string kkk = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @Directory.GetCurrentDirectory() + @"\Database0.mdf;Integrated Security=True";
        private readonly SqlConnection connection = new SqlConnection(@kkk);

        public NewZ()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == 14)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();

                    if (task == "Delete")
                    {

                        if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;
                            dataGridView1.Rows.RemoveAt(rowIndex);
                            DataSet.Tables["Заявка"].Rows[rowIndex].Delete();
                            SqlDataAdapter.Update(DataSet, "Заявка");

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
        private void Reload()
        {
            try
            {
                connection.Open();

                DataSet.Tables["Заявка"].Clear();
                SqlDataAdapter.Fill(DataSet, "Заявка");
                dataGridView1.DataSource = DataSet.Tables["Заявка"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[14, i] = linkCell;


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

        private void LoadDB()
        {
            try
            {
                connection.Open();

                SqlDataAdapter = new SqlDataAdapter("SELECT *,'Delete' AS [Delete] FROM [Заявка]", connection);
                sqlCommandBuilder = new SqlCommandBuilder(SqlDataAdapter);
                sqlCommandBuilder.GetDeleteCommand();
                sqlCommandBuilder.GetInsertCommand();
                sqlCommandBuilder.GetUpdateCommand();

                DataSet = new DataSet();
                SqlDataAdapter.Fill(DataSet, "Заявка");
                dataGridView1.DataSource = DataSet.Tables["Заявка"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[14, i] = linkCell;


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
        private void ViewsFIO()
        {
            try
            {
                connection.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT [ФИО],[Код водителя] FROM [Водители]", connection);
                DataTable table1 = new DataTable();
                SqlDataAdapter sqlData = new SqlDataAdapter(cmd1);
                sqlData.Fill(table1);
                FIOVtb.DataSource = table1;
                FIOVtb.DisplayMember = "ФИО";
                FIOVtb.ValueMember = "Код водителя";
                FIOVtb.SelectedValue = "Код водителя";
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
        private void ViewsGruz()
        {
            try
            {
                connection.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT [Марка], [Код грузовика] FROM [Грузовики]", connection);
                DataTable table2 = new DataTable();
                SqlDataAdapter sqlData2 = new SqlDataAdapter(cmd2);
                sqlData2.Fill(table2);
                GRtb.DataSource = table2;
                GRtb.DisplayMember = "Марка";
                GRtb.ValueMember = "Код грузовика";
                GRtb.SelectedValue = "Код грузовика";
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
        private void ViewsCLIENT()
        {
            try
            {
                connection.Open();
                SqlCommand cmd3 = new SqlCommand("SELECT [Клиент],[Код клиента] FROM [Клиенты]", connection);
                DataTable table3 = new DataTable();
                SqlDataAdapter sqlData3 = new SqlDataAdapter(cmd3);
                sqlData3.Fill(table3);
                CLIENTtb.DataSource = table3;
                CLIENTtb.DisplayMember = "Клиент";
                CLIENTtb.ValueMember = "Код клиента";
                CLIENTtb.SelectedValue = "Код клиента";
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
        private void Form1_Load(object sender, EventArgs e)
        {
            ViewsFIO();
            ViewsGruz();
            ViewsCLIENT();
            STOPL.Items.Add("Оплачено");
            STOPL.Items.Add("Не оплачено");
            LoadDB();
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

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
            Form4 form4 = new Form4();
            form4.Show();
            Hide();
        }
        private void dt()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT *FROM [Заявка]", connection);
                //Вторым параметром ты присваиваешь имя для текущей таблицы в датасете
                dataAdapter.Fill(ds, "[Заявка]");
                //Здесь указываешь имя нужной таблицы            
                dataGridView1.DataSource = ds.Tables["[Заявка]"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Orgtb.Text.Length != 0) & (CLIENTtb.Text.Length != 0) & (FIOVtb.Text.Length != 0) & (ADRtb.Text.Length != 0) & (NAMEGRtb.Text.Length != 0) & (GRtb.Text.Length != 0) & (STtb.Text.Length != 0) & (STOPL.Text.Length != 0))
                {
                    connection.Open();
                    string sqlcom = "INSERT INTO [Заявка](Организация,Клиент,[Код клиента],[ФИО водителя],[Код водителя],[Дата отгрузки],[Адрес отгрузки],Груз,[Номер грузовика],[Код грузовика],[Дата выгрузки],Стоимость,Оплачено)VALUES(@Организация,@Клиент,@КодК,@ФИО,@Код,@отгрузки,@Адрес,@Груз,@грузовик,@КодГ,@выгрузки,@Стоимость,@Оплачено)";

                    SqlCommand command = new SqlCommand(sqlcom, connection);
                    command.Parameters.AddWithValue("Организация", Orgtb.Text);
                    command.Parameters.AddWithValue("Клиент", CLIENTtb.Text);
                    command.Parameters.AddWithValue("ФИО", FIOVtb.Text);
                    command.Parameters.AddWithValue("Код", FIOVtb.SelectedValue);
                    command.Parameters.AddWithValue("отгрузки", DATEOTtb.Value);
                    command.Parameters.AddWithValue("Адрес", ADRtb.Text);
                    command.Parameters.AddWithValue("Груз", NAMEGRtb.Text);
                    command.Parameters.AddWithValue("КодК", CLIENTtb.SelectedValue);

                    command.Parameters.AddWithValue("КодГ", GRtb.SelectedValue);

                    command.Parameters.AddWithValue("грузовик", GRtb.Text);
                    command.Parameters.AddWithValue("выгрузки", DATEVG.Value);
                    command.Parameters.AddWithValue("Стоимость", STtb.Text);
                    command.Parameters.AddWithValue("Оплачено", STOPL.Text);

                    command.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Запоните все поля");


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

        private void FIOVtb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void GRtb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CLIENTtb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void STOPL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewO newO = new NewO();
            newO.Show();
            Hide();
        }
    }
}
