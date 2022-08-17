using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VETERINARIA_MELGAR
{
    class Mascota:Tipo
    {
        private string nombre;
        private int edad;
        private Tipo tipo;

        public string Nombre { get { return nombre; } set { nombre = value; } } 
        public int Edad { get { return edad; } set { edad = value; } }
        public Tipo Tipo { get { return tipo; } set { tipo = value; } }

        public Mascota():base()
        {   this.nombre = "";
            this.edad = 0; 
            this.Tipo = tipo;  
        }
        public Mascota(string nombre, int edad, Tipo tipo)
        {
            this.nombre = nombre; 
            this.edad = edad; 
            this.Tipo = tipo;
        }
        public override string ToString()
        {
            return "se llama"+" "+nombre+"y es un "+tipo;
        }
    }
}
