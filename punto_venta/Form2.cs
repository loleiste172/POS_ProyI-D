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
using System.Security.Cryptography;

namespace punto_venta
{
    public partial class Form2 : Form
    {
        SQLiteConnection conn;
        public Form2()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=punto_venta.db");
        }
       
       
      
        private void Form2_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 form2 = new Form1();
            //form2.Show();
            //Hide();
            //AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
            if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0)
            {
                MessageBox.Show("Llena los campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Application.Exit();
            }
            else
            {
                string contra = MD5Hash.Hash.GetMD5(textBox2.Text); // Encriptar lo que tenga el campo de textBox2.Text
                string query = @"SELECT * FROM usuarios WHERE usuario= '" + textBox1.Text + "' AND contrasena= '" + contra + "'";
                conn.Open();
                var con = new SQLiteCommand(query, conn);
                con.ExecuteNonQuery();
                SQLiteDataReader dr = con.ExecuteReader();
                //MessageBox.Show("Success");

                int count = 0;
                int usrid = 0;
                
                while (dr.Read())
                {
                    //usrid = (int)dr["id"];
                    var iid= dr["id"];
                    usrid = Convert.ToInt32(iid);
                    count++;
                }
                if (count == 1){
                    //MessageBox.Show("Success", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    Form1 frm = new Form1(usrid);
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres cerrrar la aplicación?", "Cerrar aplicación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
