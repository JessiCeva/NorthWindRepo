using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using NorthWind.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace NorthWind.DAO
{
    public class TbCategoriaDAO
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public static List<TbCategoriaBE> SelectAll()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["Northwind"].ToString();
            string sql = "Select codCategoria,Nombre,Descripcion from TbCategoria";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    List<TbCategoriaBE> Categorias = new List<TbCategoriaBE>();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TbCategoriaBE objcateg = new TbCategoriaBE();
                            objcateg.codCategoria = Convert.ToString(reader.GetInt32(0));
                            objcateg.Nombre = reader.GetString(1);
                            Categorias.Add(objcateg);
                        }
                    }
                    return Categorias;
                }
            }
        }

        public DataTable D_lista_categoria(E_Categoria objen)
        {
            SqlCommand cmd = new SqlCommand("sp_lista_categoria", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", objen.nompro);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
