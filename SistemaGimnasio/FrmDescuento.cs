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
    public partial class FrmDescuento : Form
    {
        public FrmDescuento()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                entDescuento d = new entDescuento();
                d.Codigo = txtcodigo.Text.Trim();
                d.Porcentaje = decimal.Parse(txtporcentaje.Text.Trim());
                d.Estado = cbkestado.Checked;

                logDescuento.Instancia.InsertaDescuento(d);
                MessageBox.Show("Descuento registrado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }

            LimpiarVariables();
            groupBoxdatos.Enabled = false;
            listarDescuento();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvdescuentos.Rows[e.RowIndex];

            txtid.Text = filaActual.Cells[0].Value.ToString();
            txtcodigo.Text = filaActual.Cells[1].Value.ToString();
            txtporcentaje.Text = filaActual.Cells[2].Value.ToString();
            cbkestado.Checked = Convert.ToBoolean(filaActual.Cells[3].Value);

            groupBoxdatos.Enabled = true;
            btnguardar.Visible = false;
        }
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void FrmDescuento_Load(object sender, EventArgs e)

            {
                InitializeComponent();
                listarDescuento();
                groupBoxdatos.Enabled = false; 
            }

            public void listarDescuento()
            {
                dgvdescuentos.DataSource = logDescuento.Instancia.ListarDescuento();
            }
            private void LimpiarVariables()
            {
                txtid.Text = "";
                txtcodigo.Text = "";
                txtporcentaje.Text = "";
                cbkestado.Checked = false;
            }
        
         private void btnsalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnnuevo_Click_1(object sender, EventArgs e)
        {
            groupBoxdatos.Enabled = true;
            btnguardar.Visible = true;
            LimpiarVariables();
            txtcodigo.Focus();
        }
    }
}
