using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
   public class conexionRegistroMensual
    {
        List<RegistroMensual> listaRegistro;
        public List<RegistroMensual> ListarRegistroOctubre()
        {
            List<RegistroMensual> lista = new List<RegistroMensual>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "Server=.\\SQLEXPRESS;Database=PLANILLAFRANCOS_DB;Integrated Security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM registro_octubre_2025";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    RegistroMensual reg = new RegistroMensual();
                    reg.IdEmpleado = (int)lector["id_persona"];
                    reg.NombreCompleto = (string)lector["nombre"];

                    for (int i = 1; i <= 31; i++)
                    {
                        string nombreColumna = $"dia_{i:D2}";
                        string valor = lector[nombreColumna]?.ToString() ?? "Trabaja";
                        typeof(RegistroMensual)
                            .GetProperty($"Dia_{i:D2}")
                            .SetValue(reg, RegistroMensual.InterpretarTipo(valor));

                    }

                    lista.Add(reg);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void insertarEnfermero( string nombre)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.primeraConexion();
            datos.setearConsulta("INSERT INTO registro_octubre_2025 (nombre) VALUES (@nombre)");
            datos.seterarParametros("@nombre",nombre);
            datos.ejecutarAccion();
            
        }
    }
}
