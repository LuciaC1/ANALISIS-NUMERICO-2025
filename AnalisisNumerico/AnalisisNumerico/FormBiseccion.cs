using Calculus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U1
{
    public partial class FormBiseccion : Form
    {
        public FormBiseccion()
        {
            InitializeComponent();
        }

        MetodoCerrado metodoCerrado = new MetodoCerrado();

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double xiCerrado = Convert.ToDouble(textBox1.Text);
                double xdCerrado = Convert.ToDouble(textBox2.Text);

                int interacciones = Convert.ToInt32(textBox3.Text);
                double tolerancia = Convert.ToDouble(textBox4.Text);
                string funcion = Convert.ToString(textBox5.Text);
                Calculo calculo = new Calculo();
                calculo.Sintaxis(funcion, 'x');

                Respuesta result = metodoCerrado.MetodosCerrados(xiCerrado, xdCerrado, tolerancia, interacciones, calculo, "Biseccion");

                label6.Text = $"{result.Converge}";
                label1.Text = $"La raíz es: {result.raiz}";
                label2.Text = $"Las iteraciones fueron: {result.iteraciones}";
                label3.Text = $"El error relativo es de: {result.error}";


            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese números válidos.");
            }
        }

    }
}

