# Tienda-Hardware
Udistrital 

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
    public partial class FrmIntro : Form
    {
        public FrmIntro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Dispose(true);
            Form acceso;
            acceso = new FrmAcces();
            acceso.ShowDialog();
        }
    
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
