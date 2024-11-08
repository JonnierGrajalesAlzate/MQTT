using Microsoft.Win32;
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
        private static string lcCadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        private static MqttLogica instancia = null;
        private M2MqttClientWrapper poMqttClientWrapper;
        
        //Constructor privado para Singleton y configuración del cliente MQTT
        private MqttLogica()
        {
            poMqttClientWrapper = new M2MqttClientWrapper("127.0.0.1");
            
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
        public bool Guardar( Mqtt obj)
        {
            bool lRespuesta = true;

            using (SQLiteConnection oConexion = new SQLiteConnection(lcCadena))
            {
                try
                {
                    oConexion.Open();
                    string lcQuery = "insert into mqtt (ClienteID,Tema,Mensaje) values (@clienteID,@tema,@mensaje)";
                    SQLiteCommand oCmd = new SQLiteCommand(lcQuery, oConexion);
                    oCmd.Parameters.Add(new SQLiteParameter("@clienteID", obj.pcClienteID));
                    oCmd.Parameters.Add(new SQLiteParameter("@tema", obj.pcTema));
                    oCmd.Parameters.Add(new SQLiteParameter("@mensaje", obj.pcMensaje));
                    oCmd.CommandType = System.Data.CommandType.Text;

                    if (oCmd.ExecuteNonQuery() >= 1)
                    {
                        poMqttClientWrapper.Publish("mqtt/guardar", obj.pcMensaje);
                    }
                    else
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

        public bool Actualizar(Mqtt obj)
        {
            bool lRespuesta = true;

            using (SQLiteConnection oConexion = new SQLiteConnection(lcCadena))
            {
                try
                {
                    oConexion.Open();
                    string lcQuery = "update mqtt set mensaje=@mensaje where id=@pnId";
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

        public bool Eliminar(Mqtt obj)
        {
            bool lRespuesta = true;

            using (SQLiteConnection Oconexion = new SQLiteConnection(lcCadena))
            {
                try
                {
                    Oconexion.Open();
                    string lcQuery = "delete from mqtt where id=@pnId";
                    SQLiteCommand oCmd = new SQLiteCommand(lcQuery, Oconexion);
                    oCmd.Parameters.Add(new SQLiteParameter("@pnId", obj.pnId));
                    oCmd.CommandType = System.Data.CommandType.Text;

                    if (oCmd.ExecuteNonQuery() >= 1)
                    {
                        poMqttClientWrapper.Publish("mqtt/eliminar", $"Mensaje con ID {obj.pnId} eliminado.");
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

        public List<Mqtt> Listar()
        {
            List<Mqtt> oLista = new List<Mqtt>();

            using (SQLiteConnection Oconexion = new SQLiteConnection(lcCadena))
            {
                try
                {
                    Oconexion.Open();
                    string lcQuery = "SELECT ID, ClienteID, Tema, Mensaje FROM mqtt";
                    SQLiteCommand oCmd = new SQLiteCommand(lcQuery, Oconexion);
                    oCmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader oDataReader = oCmd.ExecuteReader())
                    {
                        while (oDataReader.Read())
                        {
                            Mqtt oRegistro = new Mqtt();
                            oRegistro.pnId = oDataReader["ID"] != DBNull.Value ? Convert.ToInt32(oDataReader["ID"]) : 0;
                            oRegistro.pcMensaje = oDataReader["ClienteID"] != DBNull.Value ? oDataReader["ClienteID"].ToString() : string.Empty;
                            oRegistro.pcMensaje = oDataReader["Tema"] != DBNull.Value ? oDataReader["Tema"].ToString() : string.Empty;
                            oRegistro.pcMensaje = oDataReader["Mensaje"] != DBNull.Value ? oDataReader["Mensaje"].ToString() : string.Empty;
                            oLista.Add(oRegistro);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al listar Mensajes MQTT: {ex.Message}");
                }
            }

            return oLista;
        }
    }
}
