using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace U1
{
    public partial class FormPrincipal : Form
    {
        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonUnidad1_Click(object sender, EventArgs e)
        {

        }

        private void buttonUnidad2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnAbrirForm1_Click(object sender, EventArgs e)
        {
            FormUnidad1 f1 = new FormUnidad1(this);
            f1.Show();
            this.Hide();
        }

        private void btnAbrirForm2_Click(object sender, EventArgs e)
        {
            FormUnidad2 f2 = new FormUnidad2(this); 
            f2.Show();
            this.Hide();
        }
    }
}
