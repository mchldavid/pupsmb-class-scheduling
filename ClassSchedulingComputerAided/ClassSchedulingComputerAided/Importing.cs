using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using ExcelDataReader;
using System.IO;


namespace ClassSchedulingComputerAided
{
    public partial class Importing : Form
    {
        public Importing()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Importing_Load(object sender, EventArgs e)
        {

        }

        DataSet result;

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opfd = new OpenFileDialog() { Filter = "Excel Workbook|*.xls;*.xlsx;*.xlsm", ValidateNames = true })
            {
                if (opfd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = File.Open(opfd.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateReader(fs);
                    result = reader.AsDataSet();
                    comboBox1.Items.Clear();
                    foreach (DataTable dt in result.Tables)
                        comboBox1.Items.Add(dt.TableName);
                    reader.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            

        //List<string> GetExcelSheetNames(string connect)
        //{
        //    OleDbConnection conn = new OleDbConnection(connect);
        //    conn.Open();
        //    DataTable datatable = new DataTable();
        //    datatable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
        //    conn.Close();
        //    List<string> sheetNames = new List<string>();
        //    foreach (DataRow row in datatable.Rows)
        //    {
        //        sheetNames.Add(row["TABLE_NAME"].ToString());
        //    }
        //    return sheetNames;
        //}
            ////string stringconn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + textBox1.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            ////OleDbConnection conn = new OleDbConnection(stringconn);
            ////if (textBox1.Text != "")
            ////{
            ////    OleDbDataAdapter da = new OleDbDataAdapter("Select * from [" + textBox2.Text + "$]", conn);
            ////    DataTable dt = new DataTable();
            ////    da.Fill(dt);
            ////    dataGridView1.DataSource = dt;
            ////}
            ////else
            ////    MessageBox.Show("ER");

            //string connectionString = @"provider = Microsoft.ACE.OLEDB.12.0; data source = "+textBox1.Text+"; Extended Properties = 'Excel 12.0'";

            //List<string> sheetNamess = GetExcelSheetNames(connectionString);
            ////for (int x = 0; x < sheetNamess.Count(); x++)
            ////{
            ////    comboBox1.Items.Add(sheetNamess[x]);
            ////}
            //listBox1.DataSource = sheetNamess;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = result.Tables[comboBox1.SelectedIndex];
        }
    }
}
