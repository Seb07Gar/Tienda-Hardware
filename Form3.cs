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
    public partial class FrmCompra : Form
    {
        public FrmCompra()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            Form inicio;
            inicio= new FrmIntro();
            inicio.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CmbDisco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbDisco.SelectedIndex == 0)
                PctDisco.Image = Image.FromFile("DDVM.png");
            if (CmbDisco.SelectedIndex == 1)
                PctDisco.Image = Image.FromFile("TCB.jpg");
            if (CmbDisco.SelectedIndex == 2)
                PctDisco.Image = Image.FromFile("AHD.jpg");


        }

        private void CmbProc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbProc.SelectedIndex == 0)
                pictureBox1.Image = Image.FromFile("RYZ3.jpg");
            if (CmbProc.SelectedIndex == 1)
                pictureBox1.Image = Image.FromFile("COR5.jpg");
            if (CmbProc.SelectedIndex == 2)
                pictureBox1.Image = Image.FromFile("RYZ5.jpg");
        }

        private void CmbPlaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbPlaca.SelectedIndex == 0)
                pictureBox2.Image = Image.FromFile("MSI.jpg");
            if (CmbPlaca.SelectedIndex == 1)
                pictureBox2.Image = Image.FromFile("ASR.jpg");
            if (CmbPlaca.SelectedIndex == 2)
                pictureBox2.Image = Image.FromFile("ASUS.png");

        }

        private void CmbGraf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbGraf.SelectedIndex == 0)
                pictureBox3.Image = Image.FromFile("RAD.jpg");
            if (CmbGraf.SelectedIndex == 1)
                pictureBox3.Image = Image.FromFile("SAPP.jpg");
            if (CmbGraf.SelectedIndex == 2)
                pictureBox3.Image = Image.FromFile("NVIDIA.jpg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CmbProc.Text = "Elija una opcion";
            CmbDisco.Text = "Elija una opcion";
            CmbPlaca.Text = "Elija una opcion";
            CmbGraf.Text = "Elija una opcion";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
