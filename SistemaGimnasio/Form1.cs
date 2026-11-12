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
    public partial class Form1 : Form
    {
        private int clienteID = 0;
  
        public Form1()
        {
            InitializeComponent();
<<<<<<< HEAD
=======
            ListarClientes();
>>>>>>> origin/main
            ListarTipoDocumento();

        }
        private void ListarClientes()
        {
            dgvCliente.DataSource = logCliente.Instancia.ListarCliente();
            dgvCliente.Columns["ClienteID"].Visible = false;
            dgvCliente.Columns["TipoDocumentoID"].Visible = false;

            dgvCliente.Columns["Nombre_completo"].HeaderText = "Nombre completo";
            dgvCliente.Columns["Numero_documento"].HeaderText = "Número de documento";
            dgvCliente.Columns["Telefono"].HeaderText = "Teléfono";
            dgvCliente.Columns["TipoDocumento"].HeaderText = "Tipo de documento";

        }

        private void ListarTipoDocumento()
        {
            cboTipoDocumento.DataSource = logCliente.Instancia.ListarTipoDocumento();
            cboTipoDocumento.DisplayMember = "Nombre";
            cboTipoDocumento.ValueMember = "TipoDocumentoID";
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();

                c.Nombre_completo = txtNombre.Text.Trim();
                c.Numero_documento = txtNumeroDocumento.Text.Trim();
                c.Telefono = txtTelefono.Text.Trim();
                c.TipoDocumentoID = Convert.ToInt32(cboTipoDocumento.SelectedValue);

                bool resultado = logCliente.Instancia.InsertarCliente(c);

                if (resultado)
                {
                    MessageBox.Show("Cliente registrado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            ListarClientes();
        
            }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvCliente.Rows[e.RowIndex];

                clienteID = Convert.ToInt32(fila.Cells["ClienteID"].Value);

                txtNombre.Text = fila.Cells["Nombre_completo"].Value.ToString();
                txtNumeroDocumento.Text = fila.Cells["Numero_documento"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value?.ToString();

                cboTipoDocumento.SelectedValue = Convert.ToInt32(
                    fila.Cells["TipoDocumentoID"].Value
                );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (clienteID == 0)
                {
                    MessageBox.Show("Seleccione un cliente para editar.");
                    return;
                }

                entCliente c = new entCliente();

                c.ClienteID = clienteID;
                c.Nombre_completo = txtNombre.Text.Trim();
                c.Numero_documento = txtNumeroDocumento.Text.Trim();
                c.Telefono = txtTelefono.Text.Trim();
                c.TipoDocumentoID = Convert.ToInt32(cboTipoDocumento.SelectedValue);

                bool resultado = logCliente.Instancia.EditarCliente(c);

                if (resultado)
                {
                    MessageBox.Show("Cliente actualizado correctamente.");
                    clienteID = 0;
                    ListarClientes();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
