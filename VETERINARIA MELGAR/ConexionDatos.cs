using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VETERINARIA_MELGAR
{
    class ConexionDatos
    {
        private SqlConnection conexion;
        public ConexionDatos()
        {
            conexion = new SqlConnection(@"Data Source = NOE\SQLEXPRESS; Initial Catalog = VETERINARIA_MELGAR; Integrated Security = True");
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
        }
        
            
    }
}
