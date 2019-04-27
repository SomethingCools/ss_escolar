using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using ClosedXML.Excel;

namespace ss_escolar
{
    public partial class Form1 : Form
    {
        MySqlConnection mySqlConnection;
        MySqlCommand mySqlCommand;
        MySqlDataReader reader;
        public Form1()
        {
            InitializeComponent();
        }
        private void cargadatos()
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("host=localhost;user=root;password=1234;database=sistema_escolar");
                mySqlConnection.Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT matricula as 'Expediente',UPPER(ap1) as 'Appellido P',UPPER(ap2) as 'Apellido M',UPPER(nombre) as 'Primer nombre',nacimiento, correo, telefono FROM alumnos", mySqlConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargadatos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void InsertB_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO alumnos (matricula,ap1,ap2,nombre,nacimiento,correo,telefono) VALUES (" +
                textBoxMatricula.Text + ",'" +
                textBoxAp1.Text + "','" +
                textBoxAp2.Text + "','" +
                textBoxNom.Text + "','" +
                dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day + "','" +
                textBoxCorreo.Text + "'," +
                textBoxTel.Text +")";
            try
            {
                mySqlConnection = new MySqlConnection("host=localhost;user=root;password=1234;database=sistema_escolar;");
                mySqlConnection.Open();
                mySqlCommand = new MySqlCommand(query, mySqlConnection);
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("agregado");
                mySqlConnection.Close();
                cargadatos();
                mySqlConnection.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            {
                string query = "DELETE FROM alumnos WHERE matricula =" + textBoxMatricula.Text;
                try
                {
                    mySqlConnection = new MySqlConnection("host=localhost;user=root;password=1234;database=sistema_escolar;");
                    mySqlConnection.Open();
                    mySqlCommand = new MySqlCommand(query, mySqlConnection);
                    mySqlCommand.ExecuteNonQuery();
                    MessageBox.Show("borrado");
                    mySqlConnection.Close();
                    cargadatos();
                    mySqlConnection.Close();

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSQL_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Guardar";
            saveFileDialog1.FileName = "nombre de archivo*.sql"; 
            saveFileDialog1.InitialDirectory = @"E:/"; //direccion
            saveFileDialog1.Filter = "archivo sql|*.sql";

            saveFileDialog1.ShowDialog();

            string archivo;
            archivo = saveFileDialog1.FileName;
            MessageBox.Show(archivo);
            StreamWriter writer = new StreamWriter(archivo);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                writer.WriteLine("INSERT INTO alumnos (matricula,ap1,ap2,nombre,nacimiento,correo,telefono) VALUES ("+ 
                    dataGridView1[0,i].Value.ToString()+",'"+
                    dataGridView1[1,i].Value.ToString()+"','"+
                    dataGridView1[2,i].Value.ToString()+"','"+
                    dataGridView1[3, i].Value.ToString()+"','"+
                    Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Year+ "-"+
                    Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Month + "-" +
                    Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Day + "','" +
                    dataGridView1[5, i].Value.ToString()+"'," + 
                    dataGridView1[6, i].Value.ToString()+");");

            }
            writer.Close();
       
        }

        private void buttonCSV_Click(object sender, EventArgs e)
        {

            saveFileDialog1.Title = "Guardar";
            saveFileDialog1.FileName = "nombre de archivo*.csv";
            saveFileDialog1.InitialDirectory = @"E:/"; //direccion
            saveFileDialog1.Filter = "archivo sql|*.csv";

            saveFileDialog1.ShowDialog();

            string archivo;
            archivo = saveFileDialog1.FileName;
            MessageBox.Show(archivo);
            StreamWriter writer = new StreamWriter(archivo);
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (i == dataGridView1.ColumnCount)
                {
                    writer.Write((dataGridView1.Columns[i].HeaderText));

                }
                else
                {
                    writer.WriteLine();
                    writer.Write((dataGridView1.Columns[i].HeaderText) + ";");

                }
            }

            writer.WriteLine();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                writer.WriteLine(
                    dataGridView1[0, i].Value.ToString() + ";" +
                    dataGridView1[1, i].Value.ToString() + ";" +
                    dataGridView1[2, i].Value.ToString() + ";" +
                    dataGridView1[3, i].Value.ToString() + ";" +
                    Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Year + "-" +
                    Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Month + "-" +
                    Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Day + ";" +
                    dataGridView1[5, i].Value.ToString() + ";" +
                    dataGridView1[6, i].Value.ToString());

            }
            writer.Close();
        }

        private void buttonJson_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Guardar";
            saveFileDialog1.FileName = "nombre de archivo*.json";
            saveFileDialog1.InitialDirectory = @"E:/"; //direccion
            saveFileDialog1.Filter = "archivo json|*.json";

            saveFileDialog1.ShowDialog();

            string archivo;
            archivo = saveFileDialog1.FileName;
            MessageBox.Show(archivo);
            StreamWriter writer = new StreamWriter(archivo);
            writer.WriteLine("{ \"sistema_escolar\" :");
            writer.WriteLine("\t{");
            writer.WriteLine("\t\t \"alumnos\" : [");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if ((i+1) == dataGridView1.Rows.Count)
                {
                    writer.WriteLine("\t\t{");
                    writer.WriteLine(("\t\t \"Matricula\" : ") + "\"" + dataGridView1[0, i].Value.ToString() + "\",");
                    writer.WriteLine(("\t\t \"Apellido P\" :") + "\"" + dataGridView1[1, i].Value.ToString() + "\",");
                    writer.WriteLine(("\t\t \"Apellido M\" : ") + "\"" + dataGridView1[2, i].Value.ToString() + "\",");
                    writer.WriteLine(("\t\t \"Nombre\" : ") + "\"" + dataGridView1[3, i].Value.ToString() + "\",");
                    writer.WriteLine(("\t\t \"Fecha n\" : ") + "\"" + Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Year + "/" +
                        Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Month + "/" +
                        Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Day + "\",");
                    writer.WriteLine(("\t\t \"Correo\" : ") + dataGridView1[5, i].Value.ToString() + "\",");
                    writer.WriteLine(("\t\t \"Telefono\" : ") + "\"" + dataGridView1[6, i].Value.ToString() + ",");
                    writer.WriteLine("\t\t}");
                }
                else
                {
                    writer.WriteLine("\t\t{");
                    writer.WriteLine(("\t\t \"Matricula\" : ") + "\"" + dataGridView1[0, i].Value.ToString() + "\",");
                    writer.WriteLine(("\t\t \"Apellido P\" :") + "\"" + dataGridView1[1, i].Value.ToString() + "\",");
                    writer.WriteLine(("\t\t \"Apellido M\" : ") + "\"" + dataGridView1[2, i].Value.ToString() + "\",");
                    writer.WriteLine(("\t\t \"Nombre\" : ") + "\"" + dataGridView1[3, i].Value.ToString() + "\",");
                    writer.WriteLine(("\t\t \"Fecha n\" : ") + "\"" + Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Year + "/" +
                        Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Month + "/" +
                        Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Day + "\",");
                    writer.WriteLine(("\t\t \"Correo\" : ") + dataGridView1[5, i].Value.ToString() + "\",");
                    writer.WriteLine(("\t\t \"Telefono\" : ") + "\"" + dataGridView1[6, i].Value.ToString() + ",");
                    writer.WriteLine("\t\t},");
                } 
            }
            writer.WriteLine("\t}");
            writer.WriteLine("\t\t}");
            writer.WriteLine("\t\t\t]");
            writer.Close();

        }

        private void buttonEXL_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Guardar";
            saveFileDialog1.FileName = "nombre de archivo*.xlsx";
            saveFileDialog1.InitialDirectory = @"E:/"; //direccion
            saveFileDialog1.Filter = "archivo xlsx|*.xlsx";

            saveFileDialog1.ShowDialog();

            string archivo;
            archivo = saveFileDialog1.FileName;
            MessageBox.Show(archivo);
            var workbook = new XLWorkbook();
            var hoja = workbook.Worksheets.Add("Alumnos");
            hoja.Cell(1, 1).Value = "Matricula";
            hoja.Cell(1, 1).Style.Font.Bold = true;
            //--------------------------------------------
            hoja.Cell(1, 2).Value = "Apellido P";
            hoja.Cell(1, 2).Style.Font.Bold = true;
            //--------------------------------------------
            hoja.Cell(1, 3).Value = "Apellido M";
            hoja.Cell(1, 3).Style.Font.Bold = true;
            //--------------------------------------------
            hoja.Cell(1, 4).Value = "Nombre";
            hoja.Cell(1, 4).Style.Font.Bold = true;
            //--------------------------------------------
            hoja.Cell(1, 5).Value = "Fecha Nacimiento";
            hoja.Cell(1, 5).Style.Font.Bold = true;
            //--------------------------------------------
            hoja.Cell(1, 6).Value = "Correo";
            hoja.Cell(1, 6).Style.Font.Bold = true;
            //--------------------------------------------
            hoja.Cell(1, 7).Value = "Telefono";
            hoja.Cell(1, 7).Style.Font.Bold = true;
            //--------------------------------------------
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int k = 0; k < dataGridView1.Columns.Count; k++)
                {
                    hoja.Cell((i + 2), (k + 1)).Value = dataGridView1.Rows[i].Cells[k].Value.ToString();
                }
            }

            workbook.SaveAs(archivo);
            
        }

        private void buttonPDF_Click(object sender, EventArgs e)
        {

        }
    }
}
