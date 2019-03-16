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
using pantallas;
using System.Data.SqlClient;


namespace pantallas
{
    public partial class AgregarD : Form
    {
        public string codigo { get; set; }
        public string tipoMate { get; set; }
        public string material { get; set; }
        public string cantidad { get; set; }
        public string precio { get; set; }

        int posicion;
       
        public AgregarD()
        {
            InitializeComponent();
           
        }
        conexion database = new conexion();
        AgregarF viewFactura = new AgregarF();




        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AgregarF Nuevo = new AgregarF();
            Nuevo.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AgregarF Nuevo = new AgregarF();
            Nuevo.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AgregarF Nuevo = new AgregarF();
            Nuevo.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void AgregarD_Load(object sender, EventArgs e)
        {

            
            labFactura.Show();
            database.SeleccionTipoMaterial(combTipomaterial);
            combTipomaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            combMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            combMaterial.Enabled = false;
            btnModificar.Enabled = false;
            btnDelete.Enabled = false;
            btnAgregar.Enabled = true;
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void combTipomaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            combMaterial.Items.Clear();

            if (combTipomaterial.SelectedIndex > 0)
            {
                combMaterial.Enabled = true;
                database.SeleccionMaterial(combMaterial, combTipomaterial.Text);
            }
            else
            {
                combMaterial.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //---------------------------BOTON AGREGAR----------------------------------------------------------
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string tipo, material, cantidad, precio;
            tipo = combTipomaterial.Text;
            material = combMaterial.Text;
            cantidad = txtCantidad.Text;
            precio = txtPrecio.Text;
            conexion.enlace();
            SqlCommand comando = new SqlCommand("select id_material from material where nombre_material = '" + material + "'", conexion.enlace());
            SqlDataAdapter dtadapter = new SqlDataAdapter(comando);
            DataTable datatabla = new DataTable();
            dtadapter.Fill(datatabla);
            string codigo = datatabla.Rows[0][0].ToString();
            tablaDatos.Rows.Add(codigo, tipo, material, cantidad,  precio);
            limpiar();
            
        }
        //----------------------------LIMPIAR LOS DATOS DEL DETALLE--------------------------------------
        public void limpiar()
        {
            combTipomaterial.SelectedIndex = 0;
            txtCantidad.Clear();
            txtPrecio.Clear();
        }

        //-----------------------------SELECCION EN DATAGRIDVIEW-------------------------------------------
        private void tablaDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = tablaDatos.CurrentRow.Index;

            combTipomaterial.Text = tablaDatos[1, posicion].Value.ToString();
            combMaterial.Text = tablaDatos[2, posicion].Value.ToString();
            txtCantidad.Text = tablaDatos[3, posicion].Value.ToString();
            txtPrecio.Text = tablaDatos[4, posicion].Value.ToString();

            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnDelete.Enabled = true;

        }

        //----------------------------BOTON MODIFICAR-------------------------------------------------------
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string cod,tipo, material, cantidad, precio;

            tipo = combTipomaterial.Text;
            material = combMaterial.Text;
            cantidad = txtCantidad.Text;
            precio = txtPrecio.Text;

            conexion.enlace();
            SqlCommand comando = new SqlCommand("select id_material from material where nombre_material = '" + material + "'", conexion.enlace());
            SqlDataAdapter dtadapter = new SqlDataAdapter(comando);
            DataTable datatable = new DataTable();
            dtadapter.Fill(datatable);
            cod = datatable.Rows[0][0].ToString();

            tablaDatos[0, posicion].Value = cod;
            tablaDatos[1, posicion].Value = combTipomaterial.Text;
            tablaDatos[2, posicion].Value = combMaterial.Text;
            tablaDatos[3, posicion].Value = txtCantidad.Text;
            tablaDatos[4, posicion].Value = txtPrecio.Text;

            limpiar();
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnDelete.Enabled = false;
            


        }
        //-------------------BOTON ELEMINAR--------------------------
        private void button1_Click_1(object sender, EventArgs e)
        {
            tablaDatos.Rows.RemoveAt(posicion);
            limpiar();
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnDelete.Enabled = false;


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < tablaDatos.Rows.Count; i++)
            {
                conexion control = new conexion();

                codigo = (string)this.tablaDatos.Rows[i].Cells[0].Value;
                tipoMate = (string)this.tablaDatos.Rows[i].Cells[1].Value;
                material = (string)this.tablaDatos.Rows[i].Cells[2].Value;
                cantidad = (string)this.tablaDatos.Rows[i].Cells[3].Value;
                precio = (string)this.tablaDatos.Rows[i].Cells[4].Value;

                viewFactura.listaMateriales.Rows.Add(codigo, tipoMate, material, cantidad, precio);

            }
            
            this.Close();
            viewFactura.Show();
        } 
    }
}
