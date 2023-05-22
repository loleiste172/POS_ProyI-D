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
                dgv_productos.Rows[rowEscribir].Cells[4].Value = Convert.ToString(datos["descripcion"]);
            }
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            //inventarioAdmin.Show();
        }
        private void dgv_venta_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
                for (int i = 0; i < dgv_venta.Rows.Count; i++)
                {
                      decimal nuevoprecio = Convert.ToDecimal(dgv_venta.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                      decimal precio = Convert.ToDecimal(dgv_venta.Rows[i].Cells[2].Value);
                      decimal total = precio * nuevoprecio;
                      dgv_venta.Rows[i].Cells[5].Value = total;
                }
             
        }
        private void agregar_Click(object sender, EventArgs e)
        {
             int FilaSelected = dgv_productos.CurrentRow.Index;
            //if (dgv_venta.SelectedRows.Count > 0)
            if (FilaSelected > -1) 
            {
                //Verificamos si elproducto ya existe
                decimal suma = 0,  total_venta, suma2 = 0;
                decimal precio, total;
                decimal precioTotal = 0;
                bool productoExiste = false;
                int rowEscribir = dgv_venta.Rows.Count, cantidadd;
                //int suma_precio;
                foreach (DataGridViewRow fila in dgv_venta.Rows)
                {
                    if (fila.Cells[0].Value.ToString() == dgv_productos.Rows[FilaSelected].Cells[0].Value.ToString())
                    {
                        // Si el ID se repite, aumentar la cantidad en 1
                        int cantidad = int.Parse(fila.Cells[3].Value.ToString());
                        fila.Cells[3].Value = (cantidad + 1).ToString();

                        /* for (int i = 0; i < dgv_venta.Rows.Count; i++)
                         {
                             if (cantidad > 1)
                             {
                                 cantidad = Convert.ToInt32(fila.Cells[3].Value);
                                 decimal precio = Convert.ToDecimal(fila.Cells[2].Value);
                                 precioTotal = cantidad * precio;
                             }
                             // Calcular el precio total

                             decimal suma_precio = Convert.ToDecimal(fila.Cells[2].Value.ToString());
                             suma2 = suma_precio + precioTotal;//solo se suma una vez 
                         }
                         //totallbl2.Text = suma2.ToString();
                         totallbl2.Text = suma2.ToString();

                         */
                        if (cantidad >= 1)
                        {
                            for (int i = 0; i < dgv_venta.Rows.Count; i++)
                            {
                                // Accede al valor de la segunda columna en la fila actual

                                //int nuevoprecio = Convert.ToInt32(dgv_venta.Rows[rowEscribir].Cells[FilaSelected].Value);


                                cantidadd = int.Parse(dgv_venta.Rows[i].Cells[3].Value.ToString());
                                precio = Convert.ToDecimal(dgv_venta.Rows[i].Cells[2].Value);
                                total = precio * cantidadd;
                                dgv_venta.Rows[i].Cells[5].Value = total;
                                //dgv_venta.Rows[i].Cells[5].Value = total;
                                /*
                                if (cantidad > 1)
                                {
                                    suma = cantidad * total_venta;
                                    //suma = precioTotal;
                                   // totallbl2.Text = suma.ToString();
                                }
                                // Si el valor es numérico, lo sumas a la variable 'suma'
                                suma += total_venta;*/


                            }
                        }
                        foreach (DataGridViewRow row in dgv_venta.Rows)
                        {
                            if (row.Cells[5].Value != null)
                            {
                                decimal valor = Convert.ToDecimal(row.Cells[5].Value);
                                precioTotal += valor;
                                totallbl.Text = precioTotal.ToString();
                            }
                        }
                        // Muestra el resultado de la suma en el TextBox
                        //totallbl.Text = precioTotal.ToString();
                        productoExiste = true;
                        break;
                    }
                }

                if (!productoExiste)
                {

                    dgv_venta.Rows.Add();
                    dgv_venta.Rows[rowEscribir].Cells[0].Value = dgv_productos.Rows[FilaSelected].Cells[0].Value.ToString();
                    dgv_venta.Rows[rowEscribir].Cells[1].Value = dgv_productos.Rows[FilaSelected].Cells[1].Value.ToString();
                    dgv_venta.Rows[rowEscribir].Cells[2].Value = dgv_productos.Rows[FilaSelected].Cells[2].Value.ToString();
                    dgv_venta.Rows[rowEscribir].Cells[3].Value = 1;
                    dgv_venta.Rows[rowEscribir].Cells[4].Value = dgv_productos.Rows[FilaSelected].Cells[4].Value.ToString();
                    dgv_venta.Rows[rowEscribir].Cells[5].Value = dgv_productos.Rows[FilaSelected].Cells[2].Value.ToString();

                    for (int i = 0; i < dgv_venta.Rows.Count; i++)
                    {
                        // Accede al valor de la segunda columna en la fila actual

                        //int nuevoprecio = Convert.ToInt32(dgv_venta.Rows[rowEscribir].Cells[FilaSelected].Value);


                        //if (dgv_venta.Rows[i].Cells[2].Value != null && decimal.TryParse(dgv_venta.Rows[i].Cells[2].Value.ToString(), out total_venta))
                        /*{
                            decimal precio = Convert.ToDecimal(dgv_venta.Rows[i].Cells[2].Value);
                            decimal total = precio * cantidad;
                            dgv_venta.Rows[i].Cells[5].Value = total;
                            //dgv_venta.Rows[i].Cells[5].Value = total;
                            /*
                            if (cantidad > 1)
                            {
                                suma = cantidad * total_venta;
                                //suma = precioTotal;
                               // totallbl2.Text = suma.ToString();
                            }
                            // Si el valor es numérico, lo sumas a la variable 'suma'
                            suma += total_venta;
                            */
                        //cantidadd = int.Parse(dgv_venta.Rows[i].Cells[3].Value.ToString());
                            int cantidad = int.Parse(dgv_venta.Rows[i].Cells[3].Value.ToString());
                        if (cantidad == 1)
                        {
                            precio = Convert.ToDecimal(dgv_venta.Rows[i].Cells[2].Value);
                            //total = precio * cantidadd;
                            //dgv_venta.Rows[i].Cells[5].Value = total;
                            suma2 = Convert.ToDecimal(totallbl.Text);
                            suma = precio + suma2;
                            //totallbl.Text = suma2.ToString();
                            totallbl.Text = suma.ToString();
                        }  
                        //}
                        }
                    }
            }

                //total.Text = (String)dgv_venta.Rows[rowEscribir].Cells[2].Value; //tenemos el precio del producto
                //total.Text += (String)dgv_venta.Rows[rowEscribir].Cells[2].Value; //tenemos el precio del producto
                //temp = double.Parse(total.Text);
                //suma = double.Parse(total.Text);

                //total_venta = temp + suma;
                //total.Text = total_venta.ToString();
                //total_venta = suma;
                
                
           
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            decimal resta = 0, total_venta, precioTotal = 0;
            decimal suma = 0, suma2 = 0;
            decimal precio, total;
            bool productoExiste = false;
            int rowEscribir = dgv_venta.Rows.Count, cantidadd;
            if (dgv_venta.SelectedRows.Count > 0)
            {
                int FilaSelected = dgv_venta.CurrentRow.Index;
                //dgv_venta.Rows.RemoveAt(FilaSelected);


                int cantidad = int.Parse(dgv_venta.Rows[FilaSelected].Cells[3].Value.ToString());

                if (cantidad > 1)
                {
                    // Restar uno a la cantidad si es mayor a uno
                    for (int i = 0; i < dgv_venta.Rows.Count; i++)
                    {
                        dgv_venta.Rows[FilaSelected].Cells[3].Value = (cantidad - 1).ToString();
                        
                       //Actualiza el total
                        cantidadd = int.Parse(dgv_venta.Rows[i].Cells[3].Value.ToString());
                        precio = Convert.ToDecimal(dgv_venta.Rows[i].Cells[2].Value);
                        total = precio * cantidadd;
                        dgv_venta.Rows[i].Cells[5].Value = total;

                      /*  
                        precio = Convert.ToDecimal(dgv_venta.Rows[i].Cells[2].Value);//saco el precio
                        //total = precio * cantidadd;
                        //dgv_venta.Rows[i].Cells[5].Value = total;
                        suma2 = Convert.ToDecimal(totallbl.Text); //saco el total que llevamos en el label
                        suma = suma2 - precio;
                        //totallbl.Text = suma2.ToString();
                        totallbl.Text = suma.ToString();*/
                    }

                    foreach (DataGridViewRow row in dgv_venta.Rows)
                    {
                        if (row.Cells[5].Value != null)
                        {
                            decimal valor = Convert.ToDecimal(row.Cells[5].Value);
                            precioTotal += valor;
                            precioTotal = Math.Abs(precioTotal);
                            //totallbl2.Text = precioTotal.ToString();
                            totallbl.Text = precioTotal.ToString();

                        }


                    }
                }
                else
                {
                    /* for (int i = 0; i < dgv_venta.Rows.Count; i++)
                     {
                         // Accede al valor de la segunda columna en la fila actual

                         //if (dgv_venta.Rows[i].Cells[2].Value != null && decimal.TryParse(dgv_venta.Rows[i].Cells[2].Value.ToString(), out total_venta))
                         //{
                         // Si el valor es numérico, lo sumas a la variable 'suma'
                         //  resta -= total_venta;

                         if (cantidad == 1)
                     {
                         //Actualiza el total
                         cantidadd = int.Parse(dgv_venta.Rows[i].Cells[3].Value.ToString());
                         precio = Convert.ToDecimal(dgv_venta.Rows[i].Cells[2].Value);
                         total = precio * cantidadd;
                         dgv_venta.Rows[i].Cells[5].Value = total;
                         precioTotal = Convert.ToDecimal(dgv_venta.Rows[i].Cells[5].Value);

                             //total = precio * cantidadd;
                             //dgv_venta.Rows[i].Cells[5].Value = total;
                             //suma2 = Convert.ToDecimal(totallbl.Text);
                             suma = precioTotal - precio;
                         //totallbl.Text = suma2.ToString();
                         totallbl.Text = suma.ToString();
                     }
                         //}
                     }*/

                    // Muestra el resultado de la suma en el TextBox
                    // totallbl.Text = resta.ToString();
                    //MessageBox.Show("No hay productos agregados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    /*foreach (DataGridViewRow row in dgv_venta.Rows)
                    {
                        if (row.Cells[5].Value != null)
                        {
                            decimal valor = Convert.ToDecimal(row.Cells[5].Value);
                            precioTotal += valor;
                        }
                    }*/
                    // Muestra el resultado de la suma en el TextBox
                    //totallbl.Text = precioTotal.ToString();
                    /*
                    precioTotal = Convert.ToDecimal(totallbl.Text);
                    foreach (DataGridViewRow row in dgv_venta.Rows)
                    {
                    precioTotal = Math.Abs(precioTotal);
                        if (row.Cells[5].Value != null)
                        {
                            decimal valor = Convert.ToDecimal(row.Cells[5].Value);
                            precioTotal -= valor;
                            totallbl.Text = precioTotal.ToString();
                        }
                    }*/
                        dgv_venta.Rows.RemoveAt(FilaSelected);
                    foreach (DataGridViewRow row in dgv_venta.Rows)
                        {
                            if (row.Cells[5].Value != null)
                            {
                                decimal valor = Convert.ToDecimal(row.Cells[5].Value);
                                precioTotal += valor;
                                precioTotal = Math.Abs(precioTotal);
                 //               totallbl3.Text = precioTotal.ToString();
                                totallbl.Text = precioTotal.ToString();
                            }
                        
                    }
                }
                /*

                foreach (DataGridViewRow row in dgv_venta.Rows)
                {
                    if (row.Cells[5].Value != null)
                    {
                        decimal valor = Convert.ToDecimal(row.Cells[5].Value);
                        precioTotal += valor;
                        precioTotal = Math.Abs(precioTotal);
                        totallbl2.Text = precioTotal.ToString();
                        totallbl.Text = precioTotal.ToString();
                        
                    }
                    
                    
                }
                */
                //totallbl2.Text = suma.ToString();
            }

            if (dgv_venta.SelectedRows.Count == 0)
            {
               // totallbl2.Text = suma.ToString();
                totallbl.Text = suma.ToString();
            }
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            decimal total = Convert.ToDecimal(totallbl.Text);
            MessageBox.Show("El total de su compra es: " + total, "Compra exitosa", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            foreach (DataGridViewRow fila in dgv_venta.Rows.Cast<DataGridViewRow>().ToArray())
            {
                dgv_venta.Rows.Remove(fila);
            }
            /*
                for (int i = 0; i < dgv_venta.Rows.Count; i++)
            {
                dgv_venta.Rows.RemoveAt(i);
            }
                */
            totallbl.Text = "0";
        }
    }
}
