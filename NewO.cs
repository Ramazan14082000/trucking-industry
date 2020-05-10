using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace Курс_3
{
    public partial class NewO : Form
    {
        private static readonly string kkk = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @Directory.GetCurrentDirectory() + @"\Database0.mdf;Integrated Security=True";
        private readonly SqlConnection connection = new SqlConnection(@kkk);

        public NewO()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        private void dt()
        {

            try
            {
                connection.Open();
                DataSet ds = new DataSet();
                string txtquery =
                    "SELECT [ФИО водителя]" +
                    ",[Клиент]" +
                    ",[Груз]" +
                    ",[Грузовики].Марка" +
                    ",Грузовики.Номер" +
                    ",Грузовики.Цвет" +
                    ",Заявка.Организация" +
                    ",Заявка.Стоимость" +
                    ",SUM(Заявка.Стоимость) over() 'Прибыль'" +
                    ",SUM(Водители.Зарплата) OVER() 'Зарплата водителей' " +
                    " FROM[Заявка]" +
                    " JOIN[Водители] ON Заявка.[Код водителя]=Водители.[Код водителя]" +
                    " JOIN[Грузовики] ON Заявка.[Код грузовика]= Грузовики.[Код грузовика]";


                SqlDataAdapter dataAdapter = new SqlDataAdapter(txtquery, connection);
                //Вторым параметром ты присваиваешь имя для текущей таблицы в датасете
                dataAdapter.Fill(ds, "Заявка");
                //Здесь указываешь имя нужной таблицы            
                dataGridView1.DataSource = ds.Tables["Заявка"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {

                connection.Close();
            }
        }
        private void NewO_Load(object sender, EventArgs e)
        {

            dt();
           
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application excelapp = new Excel.Application();
                Excel.Workbook workbook = excelapp.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.ActiveSheet;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {



                    for (int i = 0; i < dataGridView1.RowCount + 1; i++)
                    {
                        for (int j = 1; j < dataGridView1.ColumnCount + 1; j++)
                        {
                            if (i == 0)
                            {
                                worksheet.Rows[i + 1].Columns[j] = dataGridView1.Columns[j - 1].HeaderText;
                            }
                            else
                                worksheet.Rows[i + 1].Columns[j] = dataGridView1.Rows[i - 1].Cells[j - 1].Value;
                        }
                    }

                    excelapp.AlertBeforeOverwriting = false;
                    workbook.SaveAs(saveFileDialog1.FileName);
                    excelapp.Quit();



                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }



        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewZ newZ = new NewZ();
            newZ.Show();
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
    }
}
