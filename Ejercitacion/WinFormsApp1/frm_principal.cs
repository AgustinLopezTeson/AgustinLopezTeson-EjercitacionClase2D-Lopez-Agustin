using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frm_principal : Form
    {

        private string nombre;
        private string apellido;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public frm_principal()
        {
            InitializeComponent();
        }

        private void btn_Saludar_Click(object sender, EventArgs e)
        {
             Nombre = lb_nombre.Text;
             Apellido = lb_apellido.Text;

            frm_saludo saludo = new frm_saludo();   
            saludo.ShowDialog();
            
        }
    }
}
