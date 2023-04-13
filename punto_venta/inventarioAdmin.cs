using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto_venta
{
    public partial class inventarioAdmin : Form
    {
        public inventarioAdmin()
        {
            InitializeComponent();
        }

        private void tbBuscar_enter(object sender, EventArgs e)
        {
            if (tbBuscar.Text == "Ingrese nombre, categoría o descripción")
            {
                tbBuscar.Text = "";
                tbBuscar.ForeColor = Color.Black;
            }
        }

        private void tbBuscar_leave(object sender, EventArgs e)
        {
            if (tbBuscar.Text == "")
            {
                tbBuscar.Text = "Ingrese nombre, categoría o descripción";
                tbBuscar.ForeColor = Color.Silver;
            }
        }
   
    }
}
