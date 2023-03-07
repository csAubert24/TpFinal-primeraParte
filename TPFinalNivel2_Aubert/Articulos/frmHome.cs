using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Articulos
{
    public partial class frmHome : Form
    {
        private List<Articulo> listaArticulo;

        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            ArticuloNegocio neg = new ArticuloNegocio();
            listaArticulo = neg.listar();
            dgvArticuos.DataSource = listaArticulo;
            try
            {
                pbArt.Load(listaArticulo[0].Imagen);
            }
            catch (Exception)
            {

               pbArt.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png");
                
            }
            
        }

        private void dgvArticuos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo sel = (Articulo)dgvArticuos.CurrentRow.DataBoundItem;
            cargarImagen(sel.Imagen);

        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbArt.Load(imagen);
            }
            catch (Exception)
            {

                pbArt.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png");
            }
        }
    }
}
