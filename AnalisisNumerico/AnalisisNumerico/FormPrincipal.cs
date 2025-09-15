using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace U1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonUnidad1_Click(object sender, EventArgs e)
        {
            FormUnidad1 f1 = new FormUnidad1();
            f1.Owner = this;   
            f1.Show();
            this.Hide();
        }

        private void buttonUnidad2_Click(object sender, EventArgs e)
        {
            FormUnidad2 f2 = new FormUnidad2();
            f2.Owner = this;
            f2.Show();
            this.Hide();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
