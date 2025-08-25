using Calculus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad1;

namespace U1
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string funcionStr = txtFuncion.Text;
                string metodo = cmbMetodo.Text;
                double xi = double.Parse(txtXi.Text);
                double xd = double.Parse(txtXd.Text);
                int iteraciones = int.Parse(txtIteraciones.Text);
                double tol = double.Parse(txtTolerancia.Text);

                Calculo funcion = new Calculo();
                MetodoAbierto metodoAbierto = new MetodoAbierto();
                Respuesta resultado = metodoAbierto.MetodosAbiertos(xi, xd, tol, iteraciones, funcion, metodo);

                txtResFuncion.Text = funcionStr;
                txtResMetodo.Text = metodo;
                txtResIteraciones.Text = resultado.iteraciones.ToString();
                txtResTolerancia.Text = tol.ToString();
                txtResConverge.Text = resultado.Converge;
                txtResRaiz.Text = resultado.raiz.ToString("G10");
                txtResError.Text = resultado.error.ToString("G10");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
