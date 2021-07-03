using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion2_JairoJuarez
{
    public class Promedio
    {
        public string Nombre { get; set; }
        public int Cuenta { get; set; }
        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }
        public int Nota4 { get; set; }

        private string nombre;
        private int cuenta;


        public Promedio(string _nombre, int _cuenta, int _nota1, int _nota2, int _nota3, int _nota4)
        {
            Nombre = _nombre;
            Cuenta = _cuenta;
            Nota1 = _nota1;
            Nota2 = _nota2;
            Nota3 = _nota3;
            Nota4 = _nota4;
        }

        public Promedio()
        {
        }

        public string Nombre_cuenta()
        {
            return (nombre + " " + cuenta);
        }

        public int promedio_notas()
        {

            return ((Nota1 + Nota2 + Nota3 + Nota4) / 4);

        }

        public string aprobrueba_reprueba()
        {
            string ap;
            var resultado = ((Nota1 + Nota2 + Nota3 + Nota4) / 4);
            if (resultado <= 69)
            {
                ap = ("Reprobado");
            }
            else
            {
                ap = ("Aprobado");
            }


            return ap;
        }


    }
}