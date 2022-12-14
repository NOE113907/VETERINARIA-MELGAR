using System;
using System.Collections.Generic;
using System.Data;
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
        }

           public DataTable EjecutarQuery(string query)
        {
            DataTable table = new DataTable();
            conexion.Open();
            SqlCommand cmd = new SqlCommand(query, conexion);
            table.Load(cmd.ExecuteReader());
            conexion.Close();
            return table;
        }
          
          
        public int EjecutarInsert(string sql, Cliente oCliente, Mascota oMascota)
        {
            int filas;
            conexion.Open();
            SqlCommand cmd = new SqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@codigo", oCliente.Codigo);
            cmd.Parameters.AddWithValue("@nombre_dueño", oCliente.Nombre);
            cmd.Parameters.AddWithValue("@SEXO", oCliente.Sexo);
            cmd.Parameters.AddWithValue("@nombre_mascota", oMascota.Nombre);
            cmd.Parameters.AddWithValue("@edad_mascota", oMascota.Edad);
            cmd.Parameters.AddWithValue("@codigo_mascota", oMascota.Codigo);
            cmd.Parameters.AddWithValue("@id_tipo", oMascota.Tipo.IdTipo);
            cmd.Parameters.AddWithValue("@id_atencion",oMascota.Atencion.Idatencion);
            cmd.Parameters.AddWithValue("@fecha", oMascota.Atencion.Fecha);
            cmd.Parameters.AddWithValue("@descripcion", oMascota.Atencion.Descripcion);
            cmd.Parameters.AddWithValue("@importe", oMascota.Atencion.Importe);


            /*
             *  values (@codigo,@nombre_dueño,@SEXO)" +
                values (@id_atencion, @fecha, @descripcion, @importe)" +
                values (@codigo_mascota,@nombre_mascota,@edad_mascota,@id_tipo,@id_atencion)"
             */

            filas = cmd.ExecuteNonQuery();
            conexion.Close();
            return filas;
        }
        



        /*
        public String listarTipos()
        {
            conexion = new SqlConnection(@"Data Source = NOE\SQLEXPRESS; Initial Catalog = VETERINARIA_MELGAR; Integrated Security = True");
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SP_NUEVO_TIPO", conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter("@tipo_nuevo", System.Data.SqlDbType.Int);
            param.Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();
            string tipo_nuevo = Convert.ToString(param.Value);
            conexion.Close();

            return tipo_nuevo;
        }*/


    }
}
