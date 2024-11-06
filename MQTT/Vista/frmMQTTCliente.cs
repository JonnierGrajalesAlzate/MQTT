using System;
using System.Windows.Forms;
using PROCESO_CRUD.Modelo;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace PROCESO_CRUD.Vista
{
    public partial class frmMQTTCliente : Form
    {
        private MqttLogica o_mqttLogica;
        private M2MqttClientWrapper o_mqttClient;

        public frmMQTTCliente()
        {
            InitializeComponent();
            o_mqttLogica = MqttLogica.Instancia; // Inicializa la lógica de base de datos
            o_mqttClient = new M2MqttClientWrapper("localhost"); // Broker MQTT local
        }

        // Método que maneja el evento MqttMsgPublishReceived con la firma correcta
        void Client_MqttMsgPublishEventHandler(object sender, MqttMsgPublishEventArgs e)
        {
            // Convierte el mensaje a texto y lo muestra en lstDataReceived
            string message = System.Text.Encoding.UTF8.GetString(e.Message);
            Invoke(new Action(() =>
            {
                lstDataReceived.Items.Add($"Tema: {e.Topic} - Mensaje: {message}");
            }));
        } 

        private void btnDataSend_Click(object sender, EventArgs e)
        {
            string tema = txtTema.Text;
            string mensaje = txtDataSend.Text;

            if (!string.IsNullOrWhiteSpace(tema) && !string.IsNullOrWhiteSpace(mensaje))
            {
                o_mqttClient.Publish(tema, mensaje);

                Registro mqttMensaje = new Registro
                {
                    pcMensaje = mensaje,
                    pcTema = tema
                };

                bool respuesta = o_mqttLogica.Guardar(mqttMensaje);

                if (respuesta)
                {
                    MessageBox.Show("Mensaje enviado y guardado correctamente.");
                    txtDataSend.Clear();
                }
                else
                {
                    MessageBox.Show("Error al guardar el mensaje en la base de datos.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un tema y un mensaje.");
            }

        }

        private void frmMQTTCliente_Load(object sender, EventArgs e)
        {
            o_mqttClient.Connect("cliente_" + Guid.NewGuid().ToString());
            o_mqttClient.Subscribe("mqtt/cliente");

            // Nos suscribimos al evento usando la firma correcta
            o_mqttClient.MqttMsgPublishReceived += Client_MqttMsgPublishEventHandler;
        }

        private void frmMQTTCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            o_mqttClient.Disconnect();
        }
    }
}

