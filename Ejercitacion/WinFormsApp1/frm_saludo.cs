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
    public partial class frm_saludo : Form
    {
        public frm_saludo()
        {
            InitializeComponent();
        }

        private void frm_saludo_Load(object sender, EventArgs e)
        {
            //lbl_Mensaje.Hide();

           frm_principal principal = new frm_principal();

            
            lbl_Mensaje.Text =  String.Format("Hola {0} {1}",principal.Nombre,principal.Apellido);
        }
    }
}
