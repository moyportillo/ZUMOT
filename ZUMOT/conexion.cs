using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Forms;

namespace administracion1
{
    
    public class conexion
    {
         
        SqlConnection conectar;
        SqlCommand comando;
        SqlDataReader dataleer;
        //---------------CONEXION A LA BASE DE DATOS---------------------------

        public static SqlConnection enlace()
        {
            SqlConnection conexiondata = new SqlConnection("Data Source=DESKTOP-S0OC9DG\\SQLEXPRESS;Initial Catalog=Data_ZUMOT;Integrated Security=True");
            
                conexiondata.Open();
                return conexiondata;
            
     
        }

     
        
        //-------------------------SELECCION DE TIPO DE MATERIAL---------------------------
        public void SeleccionTipoMaterial(ComboBox t)
        {
            conectar = conexion.enlace();
            comando = new SqlCommand(string.Format("SELECT nombre_tipo_material FROM tipo_material"), conectar);
            dataleer = comando.ExecuteReader();

            while (dataleer.Read())
            {
                t.Items.Add(dataleer[0].ToString());
            }

            conectar.Close();
            t.Items.Insert(0, "SELECCIONE EL TIPO DE MATERIAL");
            t.SelectedIndex = 0;
            return;
        }



        //---------------------------SELECCION DE MATERIAL POR TIPO-------------------------

        public void SeleccionMaterial(ComboBox t, string m)
        {
            conectar = conexion.enlace();
            comando = new SqlCommand(string.Format("select a.nombre_material from material a inner join tipo_material b on a.id_tipomaterial = b.id_tipo_material where b.nombre_tipo_material = '" + m + "' order by a.nombre_material"), conectar);
            dataleer = comando.ExecuteReader();

            while (dataleer.Read())
            {
                t.Items.Add(dataleer[0].ToString());
            }

            conectar.Close();
            t.Items.Insert(0, "SELECCIONE MATERIAL");
            t.SelectedIndex = 0;
            return;
        }

        public void buscarProyecto(string id)
        {
            conectar = conexion.enlace();
            SqlDataAdapter mostrar = new SqlDataAdapter(string.Format("select identidad_cliente, nombre_cliente + apellido_cliente from proyecto identidad_cliente like '%" + id + "%'"), conectar);
            DataSet ds = new DataSet();
            mostrar.Fill(ds, "proyecto");

        }
    
    }
}
