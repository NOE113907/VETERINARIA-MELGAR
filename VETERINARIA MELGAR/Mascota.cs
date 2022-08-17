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
        private int codigo;
        private int edad;
        private Tipo tipo;
        private Atencion atencion;

        public string Nombre { get { return nombre; } set { nombre = value; } } 
        public int Codigo { get { return codigo; } set { codigo = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public Tipo Tipo { get { return tipo; } set { tipo = value; } }
        public Atencion Atencion { get { return atencion; } set { atencion = value; } }


        public Mascota():base()
        {   this.nombre = "";
            this.codigo = 0;
            this.edad = 0; 
            this.Tipo = tipo;  
            this.Atencion = atencion;
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
