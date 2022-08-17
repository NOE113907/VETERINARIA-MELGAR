using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VETERINARIA_MELGAR
{
    class Cliente
    {
        private string nombre;
        private string sexo;
        private int codigo;

        public string Nombre { get { return nombre; } set { nombre = value; } } 
        public string Sexo { get { return sexo; } set { sexo = value; } }
        public int Codigo { get { return codigo; } set { codigo = value; } }    
        
        public Cliente()
        {
            this.nombre = "";
            this.sexo = "";
            this.codigo = 0;
        }
        public override string ToString()
        {
            return codigo + " " + Nombre + "";
        }
    }
}
