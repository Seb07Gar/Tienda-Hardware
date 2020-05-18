using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaVirtualHardware
{
    public partial class FrmAcces : Form
    {

        private const string usuario = "entrada";
        private const short contraseña = 12345;
        private short intentos;
        public FrmAcces()
        {
            InitializeComponent();
            intentos = 3;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCan_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAce_Click(object sender, EventArgs e)
        {
            if (usuario == TxtUs.Text && contraseña == short.Parse(TxtCon.Text))
            {
                MessageBox.Show("Acceso concedido, Bienvenido!", "MENSAJE DE CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose(true);

            }else if (intentos == 1)
            {
                MessageBox.Show("Excedio el limite de intentos, saliendo del programa", "MENSAJE DE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                intentos--;
                MessageBox.Show("Usuario o contraseña incorrectos, intentos restantes " +intentos.ToString(), "MENSAJE DE ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
                TxtUs.Text = "";
                TxtCon.Text = "";
            }
        }
    }
}
