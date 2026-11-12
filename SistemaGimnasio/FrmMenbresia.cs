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
    public partial class FrmMenbresia : Form
    {
        public FrmMenbresia()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void FrmMenbresia_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            listarMembresia();
            grupBoxDatosMembresia.Enabled = false;
        }
        public void listarMembresia()
        {
            datamebresia.DataSource = logMembresia.Instancia.ListarMembresia();
        }
        private void LimpiarVariablesM()
        {
            txtidemenbresia.Text = "";
            txtnombreee.Text = "";
            txtdescripcion.Text = "";
            txtprecio.Text = "";
            txtduracion.Text = "";
            cbactivo.Checked = false;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            grupBoxDatosMembresia.Enabled = true;
            btnguardar.Visible = true;
            LimpiarVariablesM();
            txtnombreee.Focus();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                entMembresia m = new entMembresia();
                m.Nombre = txtnombreee.Text.Trim();
                m.Descripcion = txtduracion.Text.Trim();
                m.Precio = decimal.Parse(txtprecio.Text.Trim());
                m.DuracionDias = int.Parse(txtduracion.Text.Trim());
                m.Estado = cbactivo.Checked;

                logMembresia.Instancia.InsertaMembresia(m);
                MessageBox.Show("Membresía registrada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }


            LimpiarVariablesM();
            grupBoxDatosMembresia.Enabled = false;
            listarMembresia();
        }

        private void datamebresia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = datamebresia.Rows[e.RowIndex];

            txtidemenbresia.Text = filaActual.Cells[0].Value.ToString();
            txtnombreee.Text = filaActual.Cells[1].Value.ToString();
            txtdescripcion.Text = filaActual.Cells[2].Value.ToString();
            txtprecio.Text = filaActual.Cells[3].Value.ToString();
            txtduracion.Text = filaActual.Cells[4].Value.ToString();
            cbactivo.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);

            grupBoxDatosMembresia.Enabled = true;
            btnguardar.Visible = false;
        }

        private void btnsalirr_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

