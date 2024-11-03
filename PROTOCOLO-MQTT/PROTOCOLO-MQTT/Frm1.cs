using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Julian Manrique Cuervo, Alexander Vargas Mejia, Jonnier Grajales Alzate 
3/11/2024
*/
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace PROTOCOLO_MQTT
{
    public partial class Frm1 : Form
    {
        MqttClient mqttClient;




        public Frm1()
        {
            InitializeComponent();
        }


        private void Mqtt_data(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            var msg = Encoding.UTF8.GetString(e.Message);
            Console.WriteLine(msg);
            lstDataReceived.Invoke((MethodInvoker)(() => lstDataReceived.Items.Add(msg)));


        }



        

        private void btnDataSend_Click(object sender, EventArgs e)
        {

            Task.Run(()=>
            {

                if (mqttClient != null && mqttClient.IsConnected) 
                {
                    mqttClient.Publish("Test", Encoding.UTF8.GetBytes(txtDataSend.Text));
                }
            
            
            });

        }

        private void Frm1_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                mqttClient = new MqttClient("localhost");
                mqttClient.MqttMsgPublishReceived += Mqtt_data;
                mqttClient.Subscribe(new string[] { "Test" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });


                mqttClient.Connect("ClientID_123456");
            });
        }
    }
}
