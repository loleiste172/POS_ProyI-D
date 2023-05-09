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
        private Inventario myInventario;
        public inventarioAdmin()
        {
            InitializeComponent();
            myInventario = new Inventario();
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
            myInventario.finish();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            add_prod add_Prod = new add_prod();
            add_Prod.ShowDialog();
            actualizarTablaProductos(myInventario);
        }

        private void inventarioAdmin_Load(object sender, EventArgs e)
        {
            actualizarTablaProductos(myInventario);

        }

        //Método para ver los productos en el dataGrid
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
                dgv_productos.Rows[rowEscribir].Cells[2].Value = Convert.ToString(datos["categoria"]);
                dgv_productos.Rows[rowEscribir].Cells[3].Value = Convert.ToString(datos["precio"]);
                dgv_productos.Rows[rowEscribir].Cells[4].Value = Convert.ToString(datos["cantidad"]);
                dgv_productos.Rows[rowEscribir].Cells[6].Value = Convert.ToString(datos["descripcion"]);
                dgv_productos.Rows[rowEscribir].Cells[7].Value = datos["agotado"].ToString() == "1" ? "Si" : "No";
            }
        }

        private void limpiarVisuzalizarProducto()
        {
            tbNombre.Text = "";
            categoria_cb.SelectedIndex = -1;
            tbPrecio.Text = "";
            tbCantidad.Text = "";
            tbDescripcion.Text = "";
            txtAgotado.Text = "--";
            txtid.Text = "--";
        }

        private void activarBttnGuardarEliminar()
        {
            bttGuardarCambios.Enabled = true;
            bttEliminarProducto.Enabled = true;
        }
        private void desactivarBttnGuardarEliminar()
        {
            bttGuardarCambios.Enabled = false;
            bttEliminarProducto.Enabled = false;
        }

        private void bttRefresh_Click(object sender, EventArgs e)
        {
            actualizarTablaProductos(myInventario);
        }

        private void dgv_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pasamos el elemento seleccionado del dgv al área de visualizar producto
            int FilaSelected = dgv_productos.CurrentRow.Index;
            txtid.Text = dgv_productos.Rows[FilaSelected].Cells[0].Value.ToString();
            tbNombre.Text = dgv_productos.Rows[FilaSelected].Cells[1].Value.ToString();

            switch (dgv_productos.Rows[FilaSelected].Cells[2].Value.ToString())
            {
                case "Alimentos y bebidas":
                    categoria_cb.SelectedIndex = 0;
                    break;
                case "Bimbo":
                    categoria_cb.SelectedIndex = 1;
                    break;
                case "Cosméticos":
                    categoria_cb.SelectedIndex = 2;
                    break;
                case "Dulces":
                    categoria_cb.SelectedIndex = 3;
                    break;
                case "Frituras":
                    categoria_cb.SelectedIndex = 4;
                    break;
                case "Mascotas":
                    categoria_cb.SelectedIndex = 5;
                    break;
                case "Miscelaneo":
                    categoria_cb.SelectedIndex = 6;
                    break;
                case "Productos de limpieza":
                    categoria_cb.SelectedIndex = 7;
                    break;
                default:
                    categoria_cb.SelectedIndex = -1;
                    break;
            }
            tbPrecio.Text = dgv_productos.Rows[FilaSelected].Cells[3].Value.ToString();
            tbCantidad.Text = dgv_productos.Rows[FilaSelected].Cells[4].Value.ToString();
            tbDescripcion.Text = dgv_productos.Rows[FilaSelected].Cells[6].Value.ToString();
            txtAgotado.Text = dgv_productos.Rows[FilaSelected].Cells[7].Value.ToString();

            activarBttnGuardarEliminar();
        }

        private void bttGuardarCambios_Click(object sender, EventArgs e)
        {
            string categoria = categoria_cb.SelectedIndex >= 0 ? categoria_cb.Items[categoria_cb.SelectedIndex].ToString() : "";
            if ((tbNombre.Text != "") && (categoria != "") && (tbPrecio.Text != "") && (tbCantidad.Text != "") && (txtid.Text != "--") )
            {
                string id = txtid.Text;
                string nom = tbNombre.Text;
                string precio = tbPrecio.Text;
                string cantidad = tbCantidad.Text;
                string descrip = tbDescripcion.Text == "" ? "Sin descripción" : tbDescripcion.Text;
                int agotado = Int32.Parse(cantidad) > 0? 0:1;

                Producto produc = new Producto(id, nom, categoria, precio, cantidad, descrip, agotado);
                //Inventario Inventario = new Inventario();
                if (myInventario.updateProduct(produc))
                {
                    MessageBox.Show("Éxito: Producto cambiado");
                    actualizarTablaProductos(myInventario);
                    limpiarVisuzalizarProducto();
                    desactivarBttnGuardarEliminar();

                }
                else
                {
                    MessageBox.Show("Error: Producto no cambiado");
                }
            }
            else
            {
                MessageBox.Show("Por favor llena todos los campos");
            }
        }

        private void bttEliminarProducto_Click(object sender, EventArgs e)
        {
            if(txtid.Text == "--")
            {
                MessageBox.Show("Seleccione un producto");
            }
            else 
            {
                int id = Int32.Parse(txtid.Text);
                Eliminar_producto formEliminar = new Eliminar_producto(id);
                formEliminar.Show();
                limpiarVisuzalizarProducto();
                desactivarBttnGuardarEliminar();

            }
        }

        private void bttBuscar_Click(object sender, EventArgs e)
        {
            if(tbBuscar.Text != "Ingrese nombre, categoría o descripción")
            {
                int rowEscribir;
                dgv_productos.Rows.Clear();
                SQLiteDataReader datos;

                if (rbttVerTodo.Checked)
                {
                    datos = myInventario.getProducts(tbBuscar.Text);
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
                        dgv_productos.Rows[rowEscribir].Cells[7].Value = datos["agotado"].ToString() == "1" ? "Si" : "No";
                    }
                }
                else if (rbttProductExistentes.Checked)
                {
                    datos = myInventario.getProductsNOAgotados(tbBuscar.Text);
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
                        dgv_productos.Rows[rowEscribir].Cells[7].Value = datos["agotado"].ToString() == "1" ? "Si" : "No";
                    }
                }
                else if (rbttProductAgotados.Checked)
                {
                    datos = myInventario.getProductsAgotados(tbBuscar.Text);
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
                        dgv_productos.Rows[rowEscribir].Cells[7].Value = datos["agotado"].ToString() == "1" ? "Si" : "No";
                    }
                }
            }
        }
    }
}
