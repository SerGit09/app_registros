using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using App_Registros.DTO;


namespace App_Registros.DAO
{
    internal class ClienteDAO:ConexionBD
    {
        SqlDataReader LeerFilas;
        SqlCommand comando = new SqlCommand();
        //METODOS CRUD
        public List<ClienteDto> VerRegistros(string Condicion)
        {
            comando.Connection = Conexion;
            comando.CommandText = "VerRegistros";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@Condicion", Condicion);

            Conexion.Open();
            LeerFilas = comando.ExecuteReader();

            List<ClienteDto> ListaGenerica = new List<ClienteDto>();
            while (LeerFilas.Read())
            {
                ListaGenerica.Add(new ClienteDto
                {
                    Id = LeerFilas.GetInt32(0),
                    Nombre = LeerFilas.GetString(1),
                    Apellido = LeerFilas.GetString(2),
                    Direccion = LeerFilas.GetString(3),
                    Ciudad = LeerFilas.GetString(4),
                    Email = LeerFilas.GetString(5),
                    Telefono = LeerFilas.GetString(6),
                    Ocupacion = LeerFilas.GetString(7),
                });
            }

            LeerFilas.Close();
            Conexion.Close();
            return ListaGenerica;
        }

        public void Insert()
        {

        }

        public void Edit()
        {

        }

        public void Delete()
        {

        }
    }
}
