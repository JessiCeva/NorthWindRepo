using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using NorthWind.Entity;
using NorthWind.DAO;

namespace NorthWind.Win
{
    public partial class FrmCategorias : Form
    {
        #region declaracion de variables globales
        TbCategoriaBE objenti = new TbCategoriaBE();
        #endregion

        #region procedimientos
        void p_listado(String descripcion)
        {
            objenti.codCategoria = descripcion;
            DataTable dt = objenti.D_lista_categoria(objenti);
            dgvcategoria.DataSource = dt;
        }
        public event EventHandler<TbCategoriaBE> onCategoriaSeleccionado;

        List<TbCategoriaBE> Lista = new List<TbCategoriaBE>();
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            Lista = TbCategoriaDAO.SelectAll();
            this.tbCategoriaBEBindingSource.DataSource = Lista;
            this.dgvcategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        //private void AgregarCategoriaaFactura()
        //{
        //    int c = dgvcategoria.CurrentRow.Index;
        //    string codigocategoria = dgvcategoria.Rows[c].Cells[0].Value.ToString();
        //    TbCategoriaBE oCategoria = (from item in Lista.ToArray()
        //                                where item.codCategoria == codigocategoria
        //                                select item).Single();
        //    onCategoriaSeleccionado(new object(), oCategoria);
        //    this.Close();
        //}
    }
}
