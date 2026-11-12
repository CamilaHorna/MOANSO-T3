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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCategoriaZona_Click(object sender, EventArgs e)
        {
            frmCategoriaZona frm = new frmCategoriaZona();
            frm.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void btnMaquina_Click(object sender, EventArgs e)
        {
            frmMaquina frm = new frmMaquina();
            frm.ShowDialog();
        }

<<<<<<< HEAD
        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
     
        private void BTNDESCUENTO_Click_1(object sender, EventArgs e)
        {
            FrmDescuento frm = new FrmDescuento();
            frm.ShowDialog();
        }

        private void BTNMENBRESIA_Click_1(object sender, EventArgs e)
        {
            FrmMenbresia frm = new FrmMenbresia();
=======
        private void button1_Click(object sender, EventArgs e)
        {
            frmEntrenadores frm = new frmEntrenadores();
>>>>>>> origin/main
            frm.ShowDialog();
        }
    }
}
