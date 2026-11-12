using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogicaNegocio;

namespace SistemaGimnasio
{
    public partial class frmCategoriaZona : Form
    {
        public frmCategoriaZona()
        {
            InitializeComponent();
            ListarCategorias();
            ListarZonas();
        }

        private void ListarCategorias()
        {
            dgvCategorias.DataSource = logCategoria.Instancia.ListarCategoria();
        }

        private void ListarZonas()
        {
            dgvZonas.DataSource = logZona.Instancia.ListarZona();
        }
        private void frmCategoriaZona_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            entCategoria Cat = new entCategoria();

            Cat.codigo = txtCodigoCat.Text;
            Cat.nombre = txtNombreCat.Text;
            Cat.descripcion = txtDescripcionCat.Text;
            Cat.estCategoria = true;

            logCategoria.Instancia.InsertaCategoria(Cat);

            MessageBox.Show("Categoría agregada correctamente");

            ListarCategorias();

            txtCodigoCat.Clear();
            txtNombreCat.Clear();
            txtDescripcionCat.Clear();
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodigoCat.Text = dgvCategorias.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
                txtNombreCat.Text = dgvCategorias.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                txtDescripcionCat.Text = dgvCategorias.Rows[e.RowIndex].Cells["descripcion"].Value?.ToString();
            }
        }

        private void btnModificarCat_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una categoría");
                return;
            }

            entCategoria Cat = new entCategoria();

            Cat.idCategoria = Convert.ToInt32(
                dgvCategorias.CurrentRow.Cells["idCategoria"].Value);

            Cat.codigo = txtCodigoCat.Text;
            Cat.nombre = txtNombreCat.Text;
            Cat.descripcion = txtDescripcionCat.Text;
            Cat.estCategoria = true;

            logCategoria.Instancia.EditaCategoria(Cat);

            MessageBox.Show("Categoría modificada correctamente");

            ListarCategorias();

            txtCodigoCat.Clear();
            txtNombreCat.Clear();
            txtDescripcionCat.Clear();
        }

        private void btnDesactivarCat_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una categoría");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de desactivar esta categoría?",
                "Confirmar desactivación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                entCategoria Cat = new entCategoria();

                Cat.idCategoria = Convert.ToInt32(
                    dgvCategorias.CurrentRow.Cells["idCategoria"].Value);

                logCategoria.Instancia.DeshabilitarCategoria(Cat);

                MessageBox.Show("Categoría desactivada correctamente");

                ListarCategorias();

                txtCodigoCat.Clear();
                txtNombreCat.Clear();
                txtDescripcionCat.Clear();
            }
        }

        private void btnAgregarZona_Click(object sender, EventArgs e)
        {
            entZona Zon = new entZona();

            Zon.codigo = txtCodigoZona.Text;
            Zon.nombre = txtNombreZona.Text;
            Zon.descripcion = txtDescripcionZona.Text;
            Zon.estZona = true;

            logZona.Instancia.InsertaZona(Zon);

            MessageBox.Show("Zona agregada correctamente");

            ListarZonas();

            txtCodigoZona.Clear();
            txtNombreZona.Clear();
            txtDescripcionZona.Clear();
        }

        private void dgvZonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodigoZona.Text = dgvZonas.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
                txtNombreZona.Text = dgvZonas.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                txtDescripcionZona.Text = dgvZonas.Rows[e.RowIndex].Cells["descripcion"].Value?.ToString();
            }
        }

        private void btnModificarZona_Click(object sender, EventArgs e)
        {
            if (dgvZonas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una zona");
                return;
            }

            entZona Zon = new entZona();

            Zon.idZona = Convert.ToInt32(
                dgvZonas.CurrentRow.Cells["idZona"].Value);

            Zon.codigo = txtCodigoZona.Text;
            Zon.nombre = txtNombreZona.Text;
            Zon.descripcion = txtDescripcionZona.Text;
            Zon.estZona = true;

            logZona.Instancia.EditaZona(Zon);

            MessageBox.Show("Zona modificada correctamente");

            ListarZonas();

            txtCodigoZona.Clear();
            txtNombreZona.Clear();
            txtDescripcionZona.Clear();
        }

        private void btnDesactivarZona_Click(object sender, EventArgs e)
        {
            if (dgvZonas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una zona");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de desactivar esta zona?",
                "Confirmar desactivación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                entZona Zon = new entZona();

                Zon.idZona = Convert.ToInt32(
                    dgvZonas.CurrentRow.Cells["idZona"].Value);

                logZona.Instancia.DeshabilitarZona(Zon);

                MessageBox.Show("Zona desactivada correctamente");

                ListarZonas();

                txtCodigoZona.Clear();
                txtNombreZona.Clear();
                txtDescripcionZona.Clear();
            }
        }
    }
}
