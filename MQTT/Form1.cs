using PROCESO_CRUD.Logica;
using PROCESO_CRUD.Modelo;
using System;
using System.Windows.Forms;

/*Jonnier Grajales Alzate, Alexander Vargas Mejía, Julian Manrique Cuervo
 06/11/2024
Protocolo MQTT
 */


namespace PROCESO_CRUD
{
    public partial class fmr_Panel : Form
    {
        public fmr_Panel()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Mqtt oMensaje = new Mqtt()
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
            txtId.Text = "";
            txtMensaje.Text = ""; 
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
                Name = "pcMensaje",
                HeaderText = "Mensaje",
                DataPropertyName = "pcMensaje"
            }); 

            mostrar_mensajes();
        }

         

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Mqtt oMensaje = new Mqtt()
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
            Mqtt oMensaje = new Mqtt()
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
