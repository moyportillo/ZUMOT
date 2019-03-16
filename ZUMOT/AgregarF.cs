using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using administracion1;
using System.Data.SqlClient;

namespace pantallas
{
    public partial class AgregarF : Form
    {
        

        public AgregarF()
        {
            InitializeComponent();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarD Nuevo = new AgregarD();
            Nuevo.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Existencia Nuevo = new Existencia();
            Nuevo.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AgregarD Nuevo = new AgregarD();
            Nuevo.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarF_Load(object sender, EventArgs e)
        {
            conexion datos = new conexion();
            grupoDato.Enabled = false;
            
            
            
            
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            buscarCliente(txtidentidad.Text);
        }


        public void buscarCliente(string id)
        {
            if (txtidentidad.Text == "")
            {
                MessageBox.Show("Campo Identidad Vacio. Ingrese la Identidad del Cliente");
            }
            else
            {
                try
                {
                    conexion.enlace();
                    SqlCommand comando = new SqlCommand("select nombre_cliente, apellido_cliente from proyecto where identidad_cliente = @identidad", conexion.enlace());
                    comando.Parameters.AddWithValue("identidad", id);
                    SqlDataAdapter dtadapter = new SqlDataAdapter(comando);
                    DataTable datatabla = new DataTable();
                    dtadapter.Fill(datatabla);
                    if (datatabla.Rows.Count == 1)
                    {
                        labNombre.Text = datatabla.Rows[0][0].ToString() + " " + datatabla.Rows[0][1].ToString();
                        grupoDato.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("No se Encontró el Cliente. Intente ingresar nuevamente la identidad del cliente.");
                        txtidentidad.Clear();
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show("Se produjo un Error: "+ e);
                }
                finally
                {
                    conexion.enlace().Close();
                }
            }
        }

        private void grupoCliente_Enter(object sender, EventArgs e)
        {

        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            datosFactura(Convert.ToInt32(txtfactura.Text), txtcasacomercial.Text, Convert.ToDateTime(fechaTime.Text), txtidentidad.Text);
        }


        public void datosFactura(int factura, string casaComercial, DateTime fecha, string id)
        {
            conexion.enlace();
            SqlCommand comando = new SqlCommand("insert into compra (id_factura, nombre_casa_comercial, id_tipo_compra, fecha_compra, identidad_cliente) values ('"+factura+"','"+casaComercial+"','1','"+fecha+"','"+id+"')", conexion.enlace());
            int filas = comando.ExecuteNonQuery();

            if (filas == 1)
            {
                MessageBox.Show("Ingreso de Factura Exitosamente");
            }
            else
            {
                MessageBox.Show("No se Pudieron Ingresar los Datos de Factura.");
               
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            AgregarD viewdetalleFac = new AgregarD();
            this.Hide();
            viewdetalleFac.ShowDialog();
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.enlace();
                SqlCommand comando = new SqlCommand("insert into compra (id_factura, fecha_compra, nombre_casa_comercial, id_tipo_compra) value ('" + Convert.ToInt64(existenciaFactura.Text) + "', '" + Convert.ToDateTime(datefecha.Text) + "', '" + casaExistencia.Text + "', '2')", conexion.enlace());
                comando.ExecuteNonQuery();
                
                MessageBox.Show("Se Ingreso la Factura Exitosamente.");
            }
                
            catch(Exception ex)
            {
                MessageBox.Show("No se produjo el ingreso de Factura> " + ex);
            }

        }

        private void tablaDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AgregarD detalle = new AgregarD();
            
            detalle.ShowDialog();
        }
    }
}
