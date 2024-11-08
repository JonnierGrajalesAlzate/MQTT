using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROCESO_CRUD.Vista;

namespace PROCESO_CRUD.Vista
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnMQTTClient_Click(object sender, EventArgs e)
        {
            frmMQTTCliente po_frmMQTTCliente = new frmMQTTCliente();
            this.SuspendLayout();
            this.Hide();
            po_frmMQTTCliente.Show();
        }

        private void bntCRUD_Click(object sender, EventArgs e)
        {
            frmCRUD po_frm_CRUD = new frmCRUD();
            this.SuspendLayout();
            this.Hide();
            po_frm_CRUD.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
