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
    public partial class pag_empleados : Form
    {
        //publicDataUser user_actual;
        SQLiteConnection conn;
        //int idusr = 0;
        public pag_empleados()
        {
            InitializeComponent();
            //user_actual = new publicDataUser();
            //idusr = iduser;
            conn = new SQLiteConnection("Data Source=punto_venta.db");
        }

        private void pag_empleados_Load(object sender, EventArgs e)
        {
            //user_actual = getusrdata(idusr);
            llenarTablaEmpleados();
        }
        private void llenarTablaEmpleados()
        {
            string consulta = @"SELECT * FROM usuarios";
            conn.Open();
            var con = new SQLiteCommand(consulta, conn);
            con.ExecuteNonQuery();
            SQLiteDataReader dr = con.ExecuteReader();
            
            while (dr.Read())
            {
                int rowEscribir = dataGridView1.Rows.Count - 1;
                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[rowEscribir].Cells[0].Value = Convert.ToString(dr["id"]);
                dataGridView1.Rows[rowEscribir].Cells[1].Value = Convert.ToString(dr["usuario"]); 
                dataGridView1.Rows[rowEscribir].Cells[2].Value = Convert.ToString(dr["nivel"]);
                dataGridView1.Rows[rowEscribir].Cells[3].Value = Convert.ToString(dr["atencion"]);
            }
        }
        public publicDataUser getusrdata(int usr_id)
        {
            publicDataUser ret = new publicDataUser();
            string sql = @"SELECT usuario, nivel, atencion FROM usuarios WHERE id=" + usr_id;
            conn.Open();
            var con = new SQLiteCommand(sql, conn);
            con.ExecuteNonQuery();
            SQLiteDataReader dr = con.ExecuteReader();

            while (dr.Read())
            {
                ret.id_usr = usr_id;
                ret.usrname = Convert.ToString(dr["usuario"]);
                ret.nivel = Convert.ToInt32(dr["nivel"]);
                ret.atencion = Convert.ToInt32(dr["atencion"]);

                break;
            }


            conn.Close();
            return ret;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            Hide();
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            inventarioAdmin inventarioAdmin = new inventarioAdmin();
            inventarioAdmin.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
