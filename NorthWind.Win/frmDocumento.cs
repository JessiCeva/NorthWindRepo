using NorthWind.DAO;
using NorthWind.Entity;
using NorthWind.Win.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWind.Win
{
    public partial class frmDocumento : Form
    {

        Validacion v = new Validacion();
        public frmDocumento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Boton Seleccionar Cliente
            frmCliente oFrmCliente = new frmCliente();
            oFrmCliente.onClienteSeleccionado += new EventHandler<TbClienteBE>(
                oFrmCliente_OnClienteSeleccionado);
            oFrmCliente.Show();
        }

        TbClienteBE otmpCliente;
        void oFrmCliente_OnClienteSeleccionado(object sender, TbClienteBE e)
        {
            txtcliente.Text = e.Nombre;
            txtruc.Text = e.Ruc;
            otmpCliente = e;
        }

        private void frmDocumento_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Boton Seleccionar Producto
            frmProducto oFrmProducto = new frmProducto();
            oFrmProducto.onProductoSeleccionado += new EventHandler<TbProductoBE>(
                oFrmProducto_OnProductoSeleccionado);
            oFrmProducto.Show();
        }
        TbProductoBE otmpProducto;
        void oFrmProducto_OnProductoSeleccionado(object sender, TbProductoBE e)
        {
            txtproducto.Text = e.Descripcion;
            txtprecio.Text = e.Precio;
            otmpProducto = e;
        }

        DocumentoBL oFacturaBL = new DocumentoBL();
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtcantidad.Text == "" )
            {

                MessageBox.Show("Este campo esta vacio");
            }
            else
            {
                MessageBox.Show("Ok");
            }

            
            //Boton agregar Factura

            try
            {
                oFacturaBL.AgregarDetalle(new ItemBE()
                {
                    Cantidad = Convert.ToInt32(txtcantidad.Text),
                    Precio = Convert.ToDecimal(txtprecio.Text),
                    Producto = otmpProducto
                });

                //Actualizar DataGrid
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = oFacturaBL.GetDetalle();

                txtsubtotal.Text = oFacturaBL.SubTotal.ToString();
                txtigv.Text = oFacturaBL.IGV.ToString();
                txttotal.Text = oFacturaBL.Total.ToString();
            }
            catch (Exception ex)
            {

            }
            
        }
            
        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //Guardar Documento en la Base de Datos
            DocumentoBE oDocumento = new DocumentoBE();
            //Guardar la cabecera
            CabDocumentoBE oCabecera = new CabDocumentoBE();
            oCabecera.Cliente = otmpCliente;
            oCabecera.FechaHora = DateTime.Now;
            oCabecera.IGV = oFacturaBL.IGV;
            oCabecera.SubTotal = oFacturaBL.SubTotal;
            oCabecera.Total = oFacturaBL.Total;

            //Agregamos la cabecera al documento
            oDocumento.Cabecera = oCabecera;
            //Agregamos el detalle al documento
            oDocumento.Detalle = oFacturaBL.GetDetalle();
            //Guardar en la Base de Datos
            TbDocumentoDAO documento = new TbDocumentoDAO();
            if(documento.GuardarDocumento(oDocumento)==eEstadoProceso.Correcto)
            {
                MessageBox.Show("Documento Guardado");
            }
            
        }
    }
}
