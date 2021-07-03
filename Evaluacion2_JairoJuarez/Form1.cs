using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion2_JairoJuarez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSaber_Click(object sender, EventArgs e)
        {
            Promedio Datos = new Promedio();
            Datos.Nombre = TxtNombre.Text;
            Datos.Cuenta = Convert.ToInt32(TxtCuenta.Text);
            Datos.Nota1 = Convert.ToInt32(TxtNota1.Text);
            Datos.Nota2 = Convert.ToInt32(TxtNota2.Text);
            Datos.Nota3 = Convert.ToInt32(TxtNota3.Text);
            Datos.Nota4 = Convert.ToInt32(TxtNota4.Text);

            int promedio = Datos.promedio_notas();


            MessageBox.Show(Datos.Nombre);
            MessageBox.Show(Convert.ToString(Datos.Cuenta));

            MessageBox.Show(Convert.ToString(promedio));

            string resultadoAprobar = Datos.aprobrueba_reprueba();
            MessageBox.Show(Convert.ToString(resultadoAprobar));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtCuenta.Clear();
            TxtNombre.Clear();
            TxtNota1.Clear();
            TxtNota2.Clear();
            TxtNota3.Clear();
            TxtNota4.Clear();
        }
    }
    
}
