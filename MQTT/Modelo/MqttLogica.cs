using PROCESO_CRUD.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Windows.Forms;

namespace PROCESO_CRUD.Modelo
{
    public class MqttLogica
    {
        private static readonly string lcCadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        private static MqttLogica instancia = null;
        private M2MqttClientWrapper poMqttClientWrapper;

        //Constructor privado para Singleton y configuración del cliente MQTT
        private MqttLogica()
        {
            poMqttClientWrapper = new M2MqttClientWrapper("127.0.0.1");
            poMqttClientWrapper.Connect("clienteID");
        }

        public static MqttLogica Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new MqttLogica();
                }
                return instancia;
            }
        }
        public bool Guardar(Registro obj)
        {
            bool lRespuesta = true;

            using (SQLiteConnection oConexion = new SQLiteConnection(lcCadena))
            {
                try
                {
                    oConexion.Open();
                    string lcQuery = "insert into Registro (mensaje) values (@mensaje)";
                    SQLiteCommand oCmd = new SQLiteCommand(lcQuery, oConexion);
                    oCmd.Parameters.Add(new SQLiteParameter("@mensaje", obj.pcMensaje));
                    oCmd.CommandType = System.Data.CommandType.Text;

                    if (oCmd.ExecuteNonQuery() >= 1)
                    {
                        poMqttClientWrapper.Publish("mqtt/guardar", obj.pcMensaje);
                    }else
                    {
                        lRespuesta = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar Mensaje MQTT: {ex.Message}");
                    lRespuesta = false;
                }
            }

            return lRespuesta;
        }

        public bool Actualizar(Registro obj)
        {
            bool lRespuesta = true;

            using (SQLiteConnection oConexion = new SQLiteConnection(lcCadena))
            {
                try
                {
                    oConexion.Open();
                    string lcQuery = "update Registro set mensaje=@mensaje where id=@pnId";
                    SQLiteCommand oCmd = new SQLiteCommand(lcQuery, oConexion);
                    oCmd.Parameters.Add(new SQLiteParameter("@pnId", obj.pnId));
                    oCmd.Parameters.Add(new SQLiteParameter("@mensaje", obj.pcMensaje));
                    oCmd.CommandType = System.Data.CommandType.Text;

                    if (oCmd.ExecuteNonQuery() >= 1)
                    {
                        poMqttClientWrapper.Publish("mqtt/actualizar", obj.pcMensaje);
                    }
                    else
                    {
                        lRespuesta = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al actualizar Mensaje MQTT: {ex.Message}");
                    lRespuesta = false;
                }
            }

            return lRespuesta;
        }

        public bool Eliminar(Registro obj)
        {
            bool lRespuesta = true;

            using (SQLiteConnection Oconexion = new SQLiteConnection(lcCadena))
            {
                try
                {
                    Oconexion.Open();
                    string lcQuery = "delete from Registro where id=@pnId";
                    SQLiteCommand oCmd = new SQLiteCommand(lcQuery, Oconexion);
                    oCmd.Parameters.Add(new SQLiteParameter("@pnId", obj.pnId));
                    oCmd.CommandType = System.Data.CommandType.Text;

                    if (oCmd.ExecuteNonQuery() >= 1)
                    {
                        poMqttClientWrapper.Publish("mqtt/eliminar",$"Mensaje con ID {obj.pnId} eliminado.");
                    }
                    else
                    {
                        lRespuesta = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar Mensaje MQTT: {ex.Message}");
                    lRespuesta = false;
                }
            }

            return lRespuesta;
        }

        public List<Registro> Listar()
        {
            List<Registro> oLista = new List<Registro>();

            using (SQLiteConnection Oconexion = new SQLiteConnection(lcCadena))
            {
                try
                {
                    Oconexion.Open();
                    string lcQuery = "SELECT id, mensaje FROM Registro";
                    SQLiteCommand oCmd = new SQLiteCommand(lcQuery, Oconexion);
                    oCmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader oDataReader = oCmd.ExecuteReader())
                    {
                        while (oDataReader.Read())
                        {
                            Registro mqtt = new Registro();
                            mqtt.pnId = oDataReader["id"] != DBNull.Value ? Convert.ToInt32(oDataReader["id"]) : 0;
                            mqtt.pcMensaje = oDataReader["mensaje"] != DBNull.Value ? oDataReader["mensaje"].ToString() : string.Empty;
                            oLista.Add(mqtt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al listar Mensaje MQTT: {ex.Message}");
                }
            }

            return oLista;
        }
    }
}
