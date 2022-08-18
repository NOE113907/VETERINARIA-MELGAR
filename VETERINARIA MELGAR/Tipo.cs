using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VETERINARIA_MELGAR
{
     class Tipo
    {
        private int idTipo;
        private string nombre;

        public int IdTipo { get { return idTipo; } set { idTipo = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }  

        public Tipo()
        {
            this.nombre = "";
        }
    }
}
