using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace punto_venta
{
    public partial class Form4 : Form
    {
        private Inventario myInventario;
        public Form4()
        {
            InitializeComponent();
            myInventario = new Inventario();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            actualizarTablaProductos(myInventario);
        }
        private void actualizarTablaProductos(Inventario inventario)
        {
            SQLiteDataReader datos = inventario.getProducts();
            int rowEscribir;
            dgv_productos.Rows.Clear();
            while (datos.Read())
            {
                rowEscribir = dgv_productos.Rows.Count;
                dgv_productos.Rows.Add();
                //id, nombre, categoria, precio, cantidad, descripcion, agotado
                dgv_productos.Rows[rowEscribir].Cells[0].Value = Convert.ToString(datos["id"]);
                dgv_productos.Rows[rowEscribir].Cells[1].Value = Convert.ToString(datos["nombre"]);
                dgv_productos.Rows[rowEscribir].Cells[2].Value = Convert.ToString(datos["precio"]);
                dgv_productos.Rows[rowEscribir].Cells[3].Value = Convert.ToString(datos["cantidad"]);
            }
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            //inventarioAdmin.Show();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            int FilaSelected = dgv_productos.CurrentRow.Index;
            if (FilaSelected > -1)
            {
                //Verificamos si elproducto ya existe
                bool productoExiste = false;
                int rowEscribir = dgv_venta.Rows.Count;
                int filaProductoExiste;
                for (int i = 0; i<rowEscribir; i++)
                {
                    if (dgv_venta.Rows[i].Cells[0].Value == dgv_productos.Rows[FilaSelected].Cells[0].Value)
                    {
                        productoExiste = true;
                        int aux = i;
                        filaProductoExiste = aux;
                    }

                }


                if (productoExiste)
                {
                    string cantidad = dgv_venta.Rows[filaProductoExiste].Cells[3].Value.ToString();
                    cantidad++;
                    dgv_venta.Rows[filaProductoExiste].Cells[3].Value = cantidad;
                }
                else
                {
                    dgv_venta.Rows.Add();
                    dgv_venta.Rows[rowEscribir].Cells[0].Value = dgv_productos.Rows[FilaSelected].Cells[0].Value.ToString();
                    dgv_venta.Rows[rowEscribir].Cells[1].Value = dgv_productos.Rows[FilaSelected].Cells[1].Value.ToString();
                    dgv_venta.Rows[rowEscribir].Cells[2].Value = dgv_productos.Rows[FilaSelected].Cells[2].Value.ToString();
                    dgv_venta.Rows[rowEscribir].Cells[3].Value = 1;
                }
            }
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_venta.CurrentRow.Index > -1)
            {
                int FilaSelected = dgv_venta.CurrentRow.Index;
                dgv_venta.Rows.RemoveAt(FilaSelected);
            }
        }
    }
}
