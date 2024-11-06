using PROCESO_CRUD.Vista;
using PROCESO_CRUD.Modelo;
using System;
using System.Windows.Forms;

/*Jonnier Grajales Alzate, Alexander Vargas Mejía, Julian Manrique Cuervo
 06/11/2024
Protocolo MQTT
 */


namespace PROCESO_CRUD
{
    public partial class frm_CRUD : Form
    {
        public frm_CRUD()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Registro oMensaje = new Registro()
            { 
                pcMensaje = txtMensaje.Text, 
            };

            bool llRespuesta = MqttLogica.Instancia.Guardar(oMensaje);

            if (llRespuesta)
            {
                limpiar();
                mostrar_mensajes();
            }

        }

        public void mostrar_mensajes() {
            dgvMensajes.DataSource = null;
            dgvMensajes.DataSource = MqttLogica.Instancia.Listar();
        }

        public void limpiar()
        {
            txtId.Clear();
            txtMensaje.Clear(); 
            txtMensaje.Focus();
        }

        private void fmr_Panel_Load(object sender, EventArgs e)
        {
            dgvMensajes.AutoGenerateColumns = false; 
            dgvMensajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "pnId",          
                HeaderText = "id",       
                DataPropertyName = "pnId" 
            });
            dgvMensajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "pcClienteID",
                HeaderText = "Cliente ID",
                DataPropertyName = "pcClienteID"
            });
            dgvMensajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "pcTema",
                HeaderText = "Tema",
                DataPropertyName = "pcTema"
            });

            dgvMensajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "pcMensaje",
                HeaderText = "Mensaje",
                DataPropertyName = "pcMensaje"
            }); 

            mostrar_mensajes();
        }

         

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Registro oMensaje = new Registro()
            {
                pnId = int.Parse(txtId.Text) 
            };

            bool llRespuesta = MqttLogica.Instancia.Eliminar(oMensaje);

            if (llRespuesta)
            {
                limpiar();
                mostrar_mensajes();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Registro oMensaje = new Registro()
            {
                pnId = int.Parse(txtId.Text),
                pcMensaje = txtMensaje.Text, 
            };

            bool llRespuesta = MqttLogica.Instancia.Actualizar(oMensaje);

            if (llRespuesta)
            {
                limpiar();
                mostrar_mensajes();
            }
        }
    }
}
