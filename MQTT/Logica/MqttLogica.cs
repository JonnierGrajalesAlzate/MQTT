using PROCESO_CRUD.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Windows.Forms;

namespace PROCESO_CRUD.Logica
{
    public class MqttLogica
    {
        private static string lcCadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        private static MqttLogica instancia = null;
        private MqttLogica() { }

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

        public bool Guardar(Mqtt obj)
        {
            bool llRespuesta = true;

            using (SQLiteConnection Oconexion = new SQLiteConnection(lcCadena))
            {
                try
                {
                    Oconexion.Open();
                    string lcQuery = "insert into mqtt (mensaje) values (@mensaje)";
                    SQLiteCommand Ocmd = new SQLiteCommand(lcQuery, Oconexion);
                    Ocmd.Parameters.Add(new SQLiteParameter("@mensaje", obj.pcMensaje));
                    Ocmd.CommandType = System.Data.CommandType.Text;

                    if (Ocmd.ExecuteNonQuery() < 1)
                    {
                        llRespuesta = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar Mensaje MQTT: {ex.Message}");
                    llRespuesta = false;
                }
            }

            return llRespuesta;
        }

        public bool Actualizar(Mqtt obj)
        {
            bool llRespuesta = true;

            using (SQLiteConnection Oconexion = new SQLiteConnection(lcCadena))
            {
                try
                {
                    Oconexion.Open();
                    string lcQuery = "update mqtt set mensaje=@mensaje where id=@pnId";
                    SQLiteCommand Ocmd = new SQLiteCommand(lcQuery, Oconexion);
                    Ocmd.Parameters.Add(new SQLiteParameter("@pnId", obj.pnId));
                    Ocmd.Parameters.Add(new SQLiteParameter("@mensaje", obj.pcMensaje));
                    Ocmd.CommandType = System.Data.CommandType.Text;

                    if (Ocmd.ExecuteNonQuery() < 1)
                    {
                        llRespuesta = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al actualizar Mensaje MQTT: {ex.Message}");
                    llRespuesta = false;
                }
            }

            return llRespuesta;
        }

        public bool Eliminar(Mqtt obj)
        {
            bool llRespuesta = true;

            using (SQLiteConnection Oconexion = new SQLiteConnection(lcCadena))
            {
                try
                {
                    Oconexion.Open();
                    string lcQuery = "delete from mqtt where id=@pnId";
                    SQLiteCommand Ocmd = new SQLiteCommand(lcQuery, Oconexion);
                    Ocmd.Parameters.Add(new SQLiteParameter("@pnId", obj.pnId));
                    Ocmd.CommandType = System.Data.CommandType.Text;

                    if (Ocmd.ExecuteNonQuery() < 1)
                    {
                        llRespuesta = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar Mensaje MQTT: {ex.Message}");
                    llRespuesta = false;
                }
            }

            return llRespuesta;
        }

        public List<Mqtt> Listar()
        {
            List<Mqtt> oLista = new List<Mqtt>();

            using (SQLiteConnection Oconexion = new SQLiteConnection(lcCadena))
            {
                try
                {
                    Oconexion.Open();
                    string lcQuery = "SELECT id, mensaje FROM mqtt";
                    SQLiteCommand Ocmd = new SQLiteCommand(lcQuery, Oconexion);
                    Ocmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = Ocmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Mqtt mqtt = new Mqtt();
                            mqtt.pnId = dr["id"] != DBNull.Value ? Convert.ToInt32(dr["id"]) : 0;
                            mqtt.pcMensaje = dr["mensaje"] != DBNull.Value ? dr["mensaje"].ToString() : string.Empty;
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
