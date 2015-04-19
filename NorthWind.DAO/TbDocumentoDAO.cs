using NorthWind.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
//

namespace NorthWind.DAO
{
    public class TbDocumentoDAO
    {
        public eEstadoProceso GuardarDocumento(DocumentoBE oDocumento)
        {
            //GUARDA CABECERA
            string codigodocumentogenerado = "";
            var ConnectionString = @"Data Source=.;Initial Catalog=NorthWind;Integrated Security=SSPI";
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("GuardarCab", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@codcliente", SqlDbType.Int).Value = oDocumento.Cabecera.Cliente.CodCliente;
                    cmd.Parameters.Add("@subtotal", SqlDbType.Int).Value = oDocumento.Cabecera.SubTotal;
                    cmd.Parameters.Add("@igv", SqlDbType.Int).Value = oDocumento.Cabecera.IGV;
                    cmd.Parameters.Add("@total", SqlDbType.Int, 50).Value = oDocumento.Cabecera.Total;
                    cmd.Parameters.Add("@fechahora", SqlDbType.SmallDateTime).Value = oDocumento.Cabecera.FechaHora;
                    cmd.Parameters.Add("@tipodocumento", SqlDbType.NVarChar, 50).Value = oDocumento.Cabecera.TipoDocumento.ToString();

                    //cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            codigodocumentogenerado = reader["CodigoGenerado"].ToString();
                        }
                    }
                }

                //GUARDA DETALLE
                foreach (var itemlista in oDocumento.Detalle)
                {

                    using (SqlCommand command = new SqlCommand("GuardarDET", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@coddocumento", SqlDbType.Int).Value = codigodocumentogenerado;
                        command.Parameters.Add("@codproducto", SqlDbType.Int).Value = itemlista.Producto.CodProducto;
                        command.Parameters.Add("@precio", SqlDbType.Int).Value = itemlista.Precio;
                        command.Parameters.Add("@cantidad", SqlDbType.Int).Value = itemlista.Cantidad;
                        command.Parameters.Add("@total", SqlDbType.Decimal).Value = itemlista.Total;

                        command.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }

            //Si todo esta OK se guarda como Correcto
            return eEstadoProceso.Correcto;
        }
    }
}
