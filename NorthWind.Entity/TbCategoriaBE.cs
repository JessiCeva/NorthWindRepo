using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;

namespace NorthWind.Entity
{
    public class TbCategoriaBE:EventArgs
    {
        public string codCategoria { get; set; }
        public string Nombre { get; set; }
    }

    public class E_Categoria
    {
        public String codcli { get; set; }
        public String codven { get; set; }
        public String nompro { get; set; }
        public DataTable tablita { get; set; }
    }
    
}
