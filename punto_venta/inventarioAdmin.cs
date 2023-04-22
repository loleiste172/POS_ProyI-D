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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void inventarioAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            add_prod add_Prod = new add_prod();
            add_Prod.ShowDialog();
        }

        private void inventarioAdmin_Load(object sender, EventArgs e)
        {
            actualizarTablaProductos();

        }

        //Método para ver los productos en el dataGrid
        private void actualizarTablaProductos()
        {
            Inventario Inventario = new Inventario();
            SQLiteDataReader datos = Inventario.getProducts();
            int rowEscribir;
            while (datos.Read())
            {
                rowEscribir = dgv_productos.Rows.Count;
                dgv_productos.Rows.Add();
                //id, nombre, categoria, precio, cantidad, descripcion, agotado
                dgv_productos.Rows[rowEscribir].Cells[0].Value = Convert.ToString(datos["id"]);
                dgv_productos.Rows[rowEscribir].Cells[1].Value = Convert.ToString(datos["nombre"]);
                dgv_productos.Rows[rowEscribir].Cells[2].Value = Convert.ToString(datos["categoria"]);
                dgv_productos.Rows[rowEscribir].Cells[3].Value = Convert.ToString(datos["precio"]);
                dgv_productos.Rows[rowEscribir].Cells[4].Value = Convert.ToString(datos["cantidad"]);
                dgv_productos.Rows[rowEscribir].Cells[6].Value = Convert.ToString(datos["descripcion"]);
                dgv_productos.Rows[rowEscribir].Cells[7].Value = Convert.ToString(datos["agotado"]);
            }
            Inventario.finish();//Cierra la conexión con la db
        }
    }
}
