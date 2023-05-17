﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto_venta
{
    public partial class add_prod : Form
    {
        public add_prod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            //Obtenemos la categoria del producto, lo hacemos primero para simplificar el if siguiente
            string categoria = categoria_cb.SelectedIndex >= 0? categoria_cb.Items[categoria_cb.SelectedIndex].ToString():"";
            
            if ( (nombre_tb.Text != "") && (categoria != "") && (precio_tb.Text != "") && (cantidad_tb.Text != ""))
            {
                string nom = nombre_tb.Text;
                string precio = precio_tb.Text;
                string cantidad = cantidad_tb.Text;
                string descrip = descripcion_tb.Text == "" ? "Sin descripción" : descripcion_tb.Text;

                Producto produc = new Producto(nom, categoria, precio, cantidad, descrip);
                Inventario Inventario = new Inventario();
                if (Inventario.addProduct(produc))
                {
                    MessageBox.Show("Éxito: Producto agregado");
                }
                else
                {
                    MessageBox.Show("Error: Producto no agregado");
                }
                Inventario.finish();
                Hide();
            }
            else
            {
                MessageBox.Show("Por favor llena todos los campos");
            }
            
        }
        
    }
}
