using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConeccionDB
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-JKNEKG5//SQLEXPRESS; database=pantalla maestra2;integrated security=true");


        private void BtnCrear_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "insert into cliente values("+TxtId.Text+", '"+TxtNom.Text+"', '"+TxtApe.Text+"', '"+TxtCorreo.Text+"', "+txtTel.Text+")";
            SqlCommand Comando = new SqlCommand(consulta,conexion);
            Comando.ExecuteNonQuery();
            MessageBox.Show("Registro agregado");

            conexion.Close();
        }
    }
}
