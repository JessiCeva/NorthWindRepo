using NorthWind.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.DAO
{
    public class TbProductoDAO
    {
        public static List<TbProductoBE> SelectAll()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["Northwind"].ToString();
            string sql = "Select CodProducto,Descripcion,Precio, CategoryID from TbProducto";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    List<TbProductoBE> Productos = new List<TbProductoBE>();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TbProductoBE objProd = new TbProductoBE();
                            objProd.CodProducto = Convert.ToString(reader.GetDecimal(0));
                            objProd.Descripcion = reader.GetString(1);
                            objProd.Precio = Convert.ToString(reader.GetDecimal(2));
                            objProd.CategoryID = Convert.ToString(reader.GetInt32(3));
                            Productos.Add(objProd);
                        }
                    }
                    return Productos;
                }
            }
        }
    }
}
