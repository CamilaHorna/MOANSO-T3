using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGimnasio
{
    public partial class frmEntrenadores : Form
    {
        private int entrenadorID = 0;

        public frmEntrenadores()
        {
           InitializeComponent();

            ListarTipoDocumento();
            ListarEspecialidad();
            ListarEntrenadores();
        }
        private void ListarTipoDocumento()
        {
            cboTipoDocumento.DataSource =
                logEntrenador.Instancia.ListarTipoDocumento();

            cboTipoDocumento.DisplayMember = "Nombre";
            cboTipoDocumento.ValueMember = "TipoDocumentoID";
        }

        private void ListarEspecialidad()
        {
            cboEspecialidad.DataSource =
                logEntrenador.Instancia.ListarEspecialidad();

            cboEspecialidad.DisplayMember = "Nombre";
            cboEspecialidad.ValueMember = "EspecialidadID";
        }

        private void ListarEntrenadores()
        {
            dgvEntrenador.DataSource =
                logEntrenador.Instancia.ListarEntrenadores();

            dgvEntrenador.Columns["EntrenadorID"].Visible = false;
            dgvEntrenador.Columns["Estado"].Visible = false;
            dgvEntrenador.Columns["TipoDocumentoID"].Visible = false;
            dgvEntrenador.Columns["EspecialidadID"].Visible = false;

            dgvEntrenador.Columns["Nombre_completo"].HeaderText = "Nombre completo";
            dgvEntrenador.Columns["Numero_documento"].HeaderText = "Número de documento";
            dgvEntrenador.Columns["TipoDocumento"].HeaderText = "Tipo de documento";
            dgvEntrenador.Columns["Especialidad"].HeaderText = "Especialidad";
            dgvEntrenador.Columns["EstadoTexto"].HeaderText = "Estado";
        }
        private void frmEntrenadores_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text) ||
                    string.IsNullOrWhiteSpace(txtNumeroDocumento.Text))
                {
                    MessageBox.Show("Complete todos los campos obligatorios.");
                    return;
                }

                entEntrenador ent = new entEntrenador();

                ent.Nombre_completo = txtNombreCompleto.Text.Trim();
                ent.Numero_documento = txtNumeroDocumento.Text.Trim();
                ent.TipoDocumentoID = Convert.ToInt32(cboTipoDocumento.SelectedValue);
                ent.EspecialidadID = Convert.ToInt32(cboEspecialidad.SelectedValue);

                bool resultado = logEntrenador.Instancia.RegistrarEntrenador(ent);

                if (resultado)
                {
                    MessageBox.Show("Entrenador registrado correctamente.");
                    ListarEntrenadores();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el entrenador.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvEntrenador_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvEntrenador.Rows[e.RowIndex];

                entrenadorID =
                    Convert.ToInt32(fila.Cells["EntrenadorID"].Value);

                txtNombreCompleto.Text =
                    fila.Cells["Nombre_completo"].Value.ToString();

                txtNumeroDocumento.Text =
                    fila.Cells["Numero_documento"].Value.ToString();

                cboTipoDocumento.SelectedValue =
                    Convert.ToInt32(fila.Cells["TipoDocumentoID"].Value);

                cboEspecialidad.SelectedValue =
                    Convert.ToInt32(fila.Cells["EspecialidadID"].Value);

                chkEstado.Checked =
                    Convert.ToBoolean(fila.Cells["Estado"].Value);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (entrenadorID == 0)
                {
                    MessageBox.Show("Seleccione un entrenador para editar.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text) ||
                    string.IsNullOrWhiteSpace(txtNumeroDocumento.Text))
                {
                    MessageBox.Show("Complete los campos obligatorios.");
                    return;
                }

                entEntrenador ent = new entEntrenador();

                ent.EntrenadorID = entrenadorID;
                ent.Nombre_completo = txtNombreCompleto.Text.Trim();
                ent.Numero_documento = txtNumeroDocumento.Text.Trim();
                ent.TipoDocumentoID = Convert.ToInt32(cboTipoDocumento.SelectedValue);
                ent.EspecialidadID = Convert.ToInt32(cboEspecialidad.SelectedValue);

                bool resultado =
                    logEntrenador.Instancia.EditarEntrenador(ent);

                if (resultado)
                {
                    MessageBox.Show("Entrenador actualizado correctamente.");

                    ListarEntrenadores();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el entrenador.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (entrenadorID == 0)
                {
                    MessageBox.Show("Seleccione un entrenador para desactivar.");
                    return;
                }

                if (!chkEstado.Checked)
                {
                    MessageBox.Show("El entrenador ya se encuentra inactivo.");
                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de desactivar este entrenador?",
                    "Confirmar desactivación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.Yes)
                {
                    bool resultado =
                        logEntrenador.Instancia.DesactivarEntrenador(entrenadorID);

                    if (resultado)
                    {
                        MessageBox.Show("Entrenador desactivado correctamente.");

                        ListarEntrenadores();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo desactivar el entrenador.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        
           
       

        private void LimpiarCampos()
        {
            entrenadorID = 0;

            txtNombreCompleto.Clear();
            txtNumeroDocumento.Clear();

            if (cboTipoDocumento.Items.Count > 0)
                cboTipoDocumento.SelectedIndex = 0;

            if (cboEspecialidad.Items.Count > 0)
                cboEspecialidad.SelectedIndex = 0;

            chkEstado.Checked = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }

}

