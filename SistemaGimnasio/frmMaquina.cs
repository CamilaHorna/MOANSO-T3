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
    public partial class frmMaquina : Form
    {
        public frmMaquina()
        {
            InitializeComponent();
            ListarMaquinas();
            ListarCategorias();
            ListarZonas();
        }
        private void ListarMaquinas()
        {
            dgvMaquinas.DataSource = logMaquina.Instancia.ListarMaquina();
        }

        private void ListarCategorias()
        {
            cboCategoriaMaq.DataSource = logCategoria.Instancia.ListarCategoria();
            cboCategoriaMaq.DisplayMember = "nombre";
            cboCategoriaMaq.ValueMember = "idCategoria";
        }

        private void ListarZonas()
        {
            cboZonaMaq.DataSource = logZona.Instancia.ListarZona();
            cboZonaMaq.DisplayMember = "nombre";
            cboZonaMaq.ValueMember = "idZona";
        }

        private void btnAgregarMaq_Click(object sender, EventArgs e)
        {
            entMaquina Maq = new entMaquina();

            Maq.codigo = txtCodigoMaq.Text;
            Maq.nombre = txtNombreMaq.Text;
            Maq.marca = txtMarcaMaq.Text;
            Maq.modelo = txtModeloMaq.Text;
            Maq.idCategoria = Convert.ToInt32(cboCategoriaMaq.SelectedValue);
            Maq.idZona = Convert.ToInt32(cboZonaMaq.SelectedValue);
            Maq.fecAdquisicion = dtpFechaMaq.Value;
            Maq.estMaquina = true;

            logMaquina.Instancia.InsertaMaquina(Maq);

            MessageBox.Show("Máquina agregada correctamente");

            ListarMaquinas();

            txtCodigoMaq.Clear();
            txtNombreMaq.Clear();
            txtMarcaMaq.Clear();
            txtModeloMaq.Clear();
        }

        private void dgvMaquinas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodigoMaq.Text = dgvMaquinas.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
                txtNombreMaq.Text = dgvMaquinas.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                txtMarcaMaq.Text = dgvMaquinas.Rows[e.RowIndex].Cells["marca"].Value?.ToString();
                txtModeloMaq.Text = dgvMaquinas.Rows[e.RowIndex].Cells["modelo"].Value?.ToString();

                cboCategoriaMaq.SelectedValue = dgvMaquinas.Rows[e.RowIndex].Cells["idCategoria"].Value;
                cboZonaMaq.SelectedValue = dgvMaquinas.Rows[e.RowIndex].Cells["idZona"].Value;

                if (dgvMaquinas.Rows[e.RowIndex].Cells["fecAdquisicion"].Value != DBNull.Value)
                {
                    dtpFechaMaq.Value = Convert.ToDateTime(
                        dgvMaquinas.Rows[e.RowIndex].Cells["fecAdquisicion"].Value);
                }
            }
        }

        private void btnModificarMaq_Click(object sender, EventArgs e)
        {
            if (dgvMaquinas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una máquina");
                return;
            }

            entMaquina Maq = new entMaquina();

            Maq.idMaquina = Convert.ToInt32(
                dgvMaquinas.CurrentRow.Cells["idMaquina"].Value);

            Maq.codigo = txtCodigoMaq.Text;
            Maq.nombre = txtNombreMaq.Text;
            Maq.marca = txtMarcaMaq.Text;
            Maq.modelo = txtModeloMaq.Text;
            Maq.idCategoria = Convert.ToInt32(cboCategoriaMaq.SelectedValue);
            Maq.idZona = Convert.ToInt32(cboZonaMaq.SelectedValue);
            Maq.fecAdquisicion = dtpFechaMaq.Value;
            Maq.estMaquina = true;

            logMaquina.Instancia.EditaMaquina(Maq);

            MessageBox.Show("Máquina modificada correctamente");

            ListarMaquinas();

            txtCodigoMaq.Clear();
            txtNombreMaq.Clear();
            txtMarcaMaq.Clear();
            txtModeloMaq.Clear();
        }

        private void btnDesactivarMaq_Click(object sender, EventArgs e)
        {
            if (dgvMaquinas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una máquina");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de desactivar esta máquina?",
                "Confirmar desactivación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                entMaquina Maq = new entMaquina();

                Maq.idMaquina = Convert.ToInt32(
                    dgvMaquinas.CurrentRow.Cells["idMaquina"].Value);

                logMaquina.Instancia.DeshabilitarMaquina(Maq);

                MessageBox.Show("Máquina desactivada correctamente");

                ListarMaquinas();

                txtCodigoMaq.Clear();
                txtNombreMaq.Clear();
                txtMarcaMaq.Clear();
                txtModeloMaq.Clear();
            }
        }
    }
}