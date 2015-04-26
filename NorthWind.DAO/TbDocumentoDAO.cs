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
                oDocumento.Cabecera.CodDocumento = "22";
                var headers = new DataTable();
                headers.Columns.Add("coddocumento", typeof(string));
                headers.Columns.Add("codcliente", typeof(string));
                headers.Columns.Add("subtotal", typeof(decimal));
                headers.Columns.Add("igv", typeof(decimal));
                headers.Columns.Add("total", typeof(decimal));
                headers.Columns.Add("fechahora", typeof(DateTime));
                headers.Columns.Add("tipodocumento", typeof(string));

                var details = new DataTable();
                details.Columns.Add("coddocumento", typeof(string));
                details.Columns.Add("codproducto", typeof(string));
                details.Columns.Add("precio", typeof(decimal));
                details.Columns.Add("cantidad", typeof(int));
                details.Columns.Add("total", typeof(decimal));

                headers.Rows.Add(new object[] 
                { 
                   oDocumento.Cabecera.CodDocumento,
                   oDocumento.Cabecera.Cliente.CodCliente,
                   oDocumento.Cabecera.SubTotal,
                   oDocumento.Cabecera.IGV,
                   oDocumento.Cabecera.Total,
                   oDocumento.Cabecera.FechaHora,
                   oDocumento.Cabecera.TipoDocumento
                });

                foreach (ItemBE item in oDocumento.Detalle)
                {
                    details.Rows.Add(new object[] 
                    { 
                        item.Producto.CodProducto,
                        item.Precio,
                        item.Cantidad,
                        item.Total,
                    });
                }

                var ConnectionString = @"Data Source=.;Initial Catalog=NorthWind;Integrated Security=SSPI";
                using (var conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("InsertaDocumento", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        var headersParam = cmd.Parameters.AddWithValue("@Cabecera", headers);
                        var detailsParam = cmd.Parameters.AddWithValue("@Detalle", details);

                        headersParam.SqlDbType = SqlDbType.Structured;
                        detailsParam.SqlDbType = SqlDbType.Structured;
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            //Si todo esta OK se guarda como Correcto
            return eEstadoProceso.Correcto;
        }
    }
}
