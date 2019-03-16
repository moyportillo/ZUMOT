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

     

        public int VerificarPreguntas(string pre, string user)
        {

            SqlCommand cmd;
            

            conectar = conexion.enlace();
            SqlConnection cn = conexion.enlace();
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from empleado_respuestas a inner join empleados b on a.id_empleado = b.id_empleado where b.usuario_empleado = @user and a.Respuesta_Pregunta1 = @pre", conectar);
                cmd.Parameters.AddWithValue("user", user);
                cmd.Parameters.AddWithValue("pre", pre);
                SqlDataAdapter dtadap = new SqlDataAdapter(cmd);
                DataTable datatabla = new DataTable();
                dtadap.Fill(datatabla);

                contador = datatabla.Rows.Count;
 
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien la pregunta: " + ex.ToString());
            }
            finally
            {
                conectar.Close();
            }
            return contador;

        }

        //-----------------------------Verificar Preguntas----------------------------------

        public int VerificarPreguntas2(string pre, string user)
        {

            SqlCommand cmd;
                       

            conectar = conexion.enlace();
            SqlConnection cn = conexion.enlace();
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select a.Respuesta_Pregunta2 from empleado_respuestas a inner join empleados b on a.id_empleado = b.id_empleado where b.usuario_empleado = @user and a.Respuesta_Pregunta2 = @pre", conectar);
                cmd.Parameters.AddWithValue("user", user);
                cmd.Parameters.AddWithValue("pre", pre);
                SqlDataAdapter dtadap = new SqlDataAdapter(cmd);
                DataTable datatabla = new DataTable();
                dtadap.Fill(datatabla);

                contador = datatabla.Rows.Count;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien la pregunta: " + ex.ToString());
            }
            finally
            {
                conectar.Close();
            }
            return contador;
        }

        //----------------------------------------------------------CAMBIAR CONTRASEñA---------------------------------------------------------

        public int ActualizarContraseña(string Contraseña, string user)
        {
            int y = 0;
            SqlCommand cmd;
            conectar = conexion.enlace();
            SqlConnection cn = conexion.enlace();
            {
                cmd = new SqlCommand(string.Format("Update empleados set contraseña_empleado = '" + Contraseña + "' where usuario_empleado = " + user + "   ", Contraseña, user), cn);
                y = cmd.ExecuteNonQuery();
                cn.Close();

            }

            return y;

        }

    }
}
