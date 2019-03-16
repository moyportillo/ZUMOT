using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using administracion1;

namespace PANTALLASVENDEDORES
{
    public partial class consultadeinformacioncliente : Form
    {
        public consultadeinformacioncliente()
        {
            InitializeComponent();
        }

        private void codigoconcli_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void consultadeinformacioncliente_Load(object sender, EventArgs e)
        {
            

        }
        public void consulta(TextBox Cconsulta)
        {
            conexion.enlace();
            try
            {
                SqlDataAdapter dtadapter = new SqlDataAdapter("select * from proyecto where identidad_cliente ='" + Cconsulta.Text + "'", conexion.enlace());
                DataTable datatabla = new DataTable();
                dtadapter.Fill(datatabla);
                dtvcliconsu.DataSource = datatabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se Pudo mostrar la Lista de Clientes." + ex);
            }
            finally
            {
                conexion.enlace().Close();
            }
        }

        private void btncliconsu_Click(object sender, EventArgs e)
        {
            
        }

        private void txtcodiconsucli_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            consulta(txtcodiconsucli);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
