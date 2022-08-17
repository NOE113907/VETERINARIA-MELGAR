using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VETERINARIA_MELGAR
{
    class Atencion
    {
        private DateTime fecha;
        private string descripcion;
        private decimal importe;

        public DateTime Fecha { get { return fecha; } set { fecha = value; } }  
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }  
        private decimal Importe { get { return importe; } set { importe = value; } }
        
        public Atencion()
        {
            fecha = DateTime.Now;
            descripcion = "";
            importe = 0;
        }

        public Atencion(DateTime fecha, string descripcion, decimal importe)
        {
            this.fecha = fecha;
            this.descripcion = descripcion;
            this.importe = importe;
        }

    }
}
