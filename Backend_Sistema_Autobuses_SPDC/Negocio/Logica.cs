using AccesoDatos;
using Entidades;
using System.Collections.Generic;

namespace Negocio
{
    public class Logica
    {

        #region MONGODB
        public static string AgregarAccion(Bitacora P_Accion)
        {
            string resultado = "Accion registrada correctamente";

            //Regla de negocio - Verificar si el ID de la accion ya existe, en caso de ser asi indicarlo como resultado
            Bitacora encontrado = AccesoMongoDB.ConsultarAcciones(P_Accion);
            if (encontrado == null)//Si no encuentra resultados en la coleccion, significa que puede agregarse a la misma
            {
                AccesoMongoDB.AgregarAccion(P_Accion); // Se envia a registrar la accion
            }
            else resultado = "Accion a registrar con el ID de: " + P_Accion.ID + " ya existe en base de datos";
            return resultado;
        }

        public static Bitacora ConsultarAccionPorFiltro(Bitacora P_Accion)
        {
            return AccesoMongoDB.ConsultarAcciones(P_Accion);
        }

        #endregion

        #region SQL

        #region Usuario

        public static List<Usuario> ConsultarUsuariosXNombre(Usuario P_Usuario)
        {
            return AccesoSQLServer.ConsultarUsuariosXNombre(P_Usuario);
        }

        public static List<Usuario> ConsultarUsuariosXEstado(Usuario P_Usuario)
        {
            return AccesoSQLServer.ConsultarUsuariosXEstado(P_Usuario);
        }

        #endregion

        #region Chofer

        public static bool AgregarChofer(Chofer P_Chofer)
        {
            return AccesoSQLServer.AgregarChofer(P_Chofer);
        }

        public static bool ModificarChofer(Chofer P_Chofer)
        {
            return AccesoSQLServer.ModificarChofer(P_Chofer);
        }
        public static bool EliminarChofer(Chofer P_Chofer)
        {
            return AccesoSQLServer.EliminarChofer(P_Chofer);
        }
        public static List<Chofer> ConsultarChoferes()
        {
            return AccesoSQLServer.ConsultarChoferes();
        }

        public static List<Chofer> ConsultarChoferesXEstado(Chofer P_Chofer)
        {
            return AccesoSQLServer.ConsultarChoferesXEstado(P_Chofer);
        }

        #endregion

        #region Estado

        public static List<Estado> ConsultarEstados()
        {
            return AccesoSQLServer.ConsultarEstados();
        }

        #endregion

        #region Parada

        public static bool AgregarParada(Parada P_Parada)
        {
            return AccesoSQLServer.AgregarParada(P_Parada);
        }

        public static bool ModificarParada(Parada P_Parada)
        {
            return AccesoSQLServer.ModificarParada(P_Parada);
        }
        public static bool EliminarParada(Parada P_Parada)
        {
            return AccesoSQLServer.EliminarParada(P_Parada);
        }
        public static List<Parada> ConsultarParadas()
        {
            return AccesoSQLServer.ConsultarParadas();
        }

        public static List<Parada> ConsultarParadasXProvincia(Parada P_Parada)
        {
            return AccesoSQLServer.ConsultarParadasXProvincia(P_Parada);
        }

        public static List<Parada> ConsultarParadasXCanton(Parada P_Parada)
        {
            return AccesoSQLServer.ConsultarParadasXCanton(P_Parada);
        }

        public static List<Parada> ConsultarParadasXDistrito(Parada P_Parada)
        {
            return AccesoSQLServer.ConsultarParadasXDistrito(P_Parada);
        }

        #endregion

        #region Ruta

        public static bool AgregarRuta(Ruta P_Ruta)
        {
            return AccesoSQLServer.AgregarRuta(P_Ruta);
        }

        public static bool ModificarRuta(Ruta P_Ruta)
        {
            return AccesoSQLServer.ModificarRuta(P_Ruta);
        }
        public static bool EliminarRuta(Ruta P_Ruta)
        {
            return AccesoSQLServer.EliminarRuta(P_Ruta);
        }
        public static List<Ruta> ConsultarRutas()
        {
            return AccesoSQLServer.ConsultarRutas();
        }

        public static List<Ruta> ConsultarRutasXDistrito_Inicio(Ruta P_Ruta)
        {
            return AccesoSQLServer.ConsultarRutasXDistrito_Inicio(P_Ruta);
        }

        public static List<Ruta> ConsultarRutasXDistrito_Fin(Ruta P_Ruta)
        {
            return AccesoSQLServer.ConsultarRutasXDistrito_Fin(P_Ruta);
        }

        #endregion

        #region Bus

        public static bool AgregarBus(Bus P_Bus)
        {
            return AccesoSQLServer.AgregarBus(P_Bus);
        }

        public static bool ModificarBus(Bus P_Bus)
        {
            return AccesoSQLServer.ModificarBus(P_Bus);
        }
        public static bool EliminarBus(Bus P_Bus)
        {
            return AccesoSQLServer.EliminarBus(P_Bus);
        }
        public static List<Bus> ConsultarBuses()
        {
            return AccesoSQLServer.ConsultarBuses();
        }

        public static List<Bus> ConsultarBusesXEstado(Bus P_Bus)
        {
            return AccesoSQLServer.ConsultarBusesXEstado(P_Bus);
        }

        #endregion

        #region Itinerario

        public static bool AgregarItinerario(Itinerario P_Itinerario)
        {
            return AccesoSQLServer.AgregarItinerario(P_Itinerario);
        }

        public static bool ModificarItinerario(Itinerario P_Itinerario)
        {
            return AccesoSQLServer.ModificarItinerario(P_Itinerario);
        }
        public static bool EliminarItinerario(Itinerario P_Itinerario)
        {
            return AccesoSQLServer.EliminarItinerario(P_Itinerario);
        }
        public static List<Itinerario> ConsultarItinerarios()
        {
            return AccesoSQLServer.ConsultarItinerarios();
        }

        public static List<Itinerario> ConsultarItinerariosXFecha(Itinerario P_Itinerario)
        {
            return AccesoSQLServer.ConsultarItinerariosXFecha(P_Itinerario);
        }

        public static List<Itinerario> ConsultarItinerariosXRuta(Itinerario P_Itinerario)
        {
            return AccesoSQLServer.ConsultarItinerariosXRuta(P_Itinerario);
        }

        #endregion

        #endregion

    }
}
