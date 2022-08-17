using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VETERINARIA_MELGAR
{
     class Tipo
    {
        private string nombre;

        public string Nombre { get { return nombre; } set { nombre = value; } }  

        public Tipo()
        {
            this.nombre = "";
        }
    }
}
