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
    public partial class Form1 : Form
    {
        SQLiteConnection conn;
        int id_user = 0;
        //el userID proveera el nivel de acceso del usuario
        public Form1(int usr_id)
        {
            id_user = usr_id;
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=punto_venta.db");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //comprobacion, recordar que los valores se interpretan de la siguiente manera: 
            // 0 es un valor por defecto, debe tirar error si algun usuario por alguna razon tiene nivel de autorizacion 0
            // 1 es admin
            // 2 es empleado
            if (id_user == 0)
            {
                MessageBox.Show("El perfil seleccionado tiene un error, se ha notificado al administrador y se tomaran las acciones correspondientes", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            Hide();
            
        }
        private void getuserinfo(int iduser)
        {

        }
    }
}
