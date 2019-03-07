using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RECUPERACIONCUENTA : Form
    {
        public RECUPERACIONCUENTA()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            INICIO_SESION inicio = new INICIO_SESION();
            inicio.Show();

        }

        private void btnrecu_Click(object sender, EventArgs e)
        {
            this.Close();
            INICIO_SESION inicio = new INICIO_SESION();
            inicio.Show();
        }

        private void lbltitulorecu_Click(object sender, EventArgs e)
        {

        }
    }
}
