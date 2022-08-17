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
        private int idatencion;

        public DateTime Fecha { get { return fecha; } set { fecha = value; } }  
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }  
        public decimal Importe { get { return importe; } set { importe = value; } }
        public int Idatencion { get { return idatencion; } set { idatencion = value; } }
        public Atencion()
        {
            fecha = DateTime.Now;
            descripcion = "";
            importe = 0;
            idatencion = 0;
        }

        public Atencion(DateTime fecha, string descripcion, decimal importe,int idatencion)
        {
            this.fecha = fecha;
            this.descripcion = descripcion;
            this.importe = importe;
            this.idatencion = idatencion;
        }
        public override string ToString()
        {
            return descripcion;
        }
    }
}
