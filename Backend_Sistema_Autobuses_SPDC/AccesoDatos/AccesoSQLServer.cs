using Dapper;
using Entidades;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace AccesoDatos
{
    public class AccesoSQLServer
    {

        #region Usuario

        public static List<Usuario> ConsultarUsuariosXNombre(Usuario P_Usuario)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Nombre_Usuario", P_Usuario.Nombre_Usuario, DbType.String, ParameterDirection.Input, 80);
            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return (List<Usuario>)conexionSQLServer.Query<Usuario>("PA_ConsultarUsuariosPorNombre", parametros, commandType: CommandType.StoredProcedure);
            }
        }

        public static List<Usuario> ConsultarUsuariosXEstado(Usuario P_Usuario)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Estado", P_Usuario.ID_Estado, DbType.String, ParameterDirection.Input, 5);
            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return (List<Usuario>)conexionSQLServer.Query<Usuario>("PA_ConsultarUsuariosPorEstado", parametros, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion

        #region Chofer

        public static bool AgregarChofer(Chofer P_Chofer)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Cedula", P_Chofer.Cedula, DbType.String, ParameterDirection.Input, 25);
            parametros.Add("@Nombre_Chofer", P_Chofer.Nombre_Chofer, DbType.String, ParameterDirection.Input, 80);
            parametros.Add("@Licencia", P_Chofer.Licencia, DbType.String, ParameterDirection.Input, 20);
            parametros.Add("@ID_Estado", P_Chofer.ID_Estado, DbType.String, ParameterDirection.Input, 5);

            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return conexionSQLServer.Execute("PA_AgregarChofer", parametros, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public static bool ModificarChofer(Chofer P_Chofer)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Cedula", P_Chofer.Cedula, DbType.String, ParameterDirection.Input, 25);
            parametros.Add("@Nombre_Chofer", P_Chofer.Nombre_Chofer, DbType.String, ParameterDirection.Input, 80);
            parametros.Add("@Licencia", P_Chofer.Licencia, DbType.String, ParameterDirection.Input, 20);
            parametros.Add("@ID_Estado", P_Chofer.ID_Estado, DbType.String, ParameterDirection.Input, 5);

            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return conexionSQLServer.Execute("PA_ModificarChofer", parametros, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public static bool EliminarChofer(Chofer P_Chofer)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Cedula", P_Chofer.Cedula, DbType.String, ParameterDirection.Input, 25);

            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return conexionSQLServer.Execute("PA_EliminarChofer", parametros, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public static List<Chofer> ConsultarChoferes()
        {
            DynamicParameters parametros = new DynamicParameters();

            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return (List<Chofer>)conexionSQLServer.Query<Chofer>("PA_ConsultarChoferes", parametros, commandType: CommandType.StoredProcedure);
            }
        }

        public static List<Chofer> ConsultarChoferesXEstado(Chofer P_Chofer)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@ID_Estado", P_Chofer.ID_Estado, DbType.String, ParameterDirection.Input, 5);
            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return (List<Chofer>)conexionSQLServer.Query<Chofer>("PA_ConsultarChoferesPorEstado", parametros, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion

        #region Estado

        public static List<Estado> ConsultarEstados()
        {
            DynamicParameters parametros = new DynamicParameters();

            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return (List<Estado>)conexionSQLServer.Query<Estado>("PA_ConsultarEstados", parametros, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion

        #region Parada

        public static bool AgregarParada(Parada P_Parada)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Nombre_Parada", P_Parada.Nombre_Parada, DbType.String, ParameterDirection.Input, 80);
            parametros.Add("@Provincia", P_Parada.Provincia, DbType.String, ParameterDirection.Input, 20);
            parametros.Add("@Canton", P_Parada.Canton, DbType.String, ParameterDirection.Input, 20);
            parametros.Add("@Distrito", P_Parada.Distrito, DbType.String, ParameterDirection.Input, 30);
            parametros.Add("@Ubicacion", P_Parada.Ubicacion, DbType.String, ParameterDirection.Input, 60);

            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return conexionSQLServer.Execute("PA_AgregarParada", parametros, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public static bool ModificarParada(Parada P_Parada)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Nombre_Parada", P_Parada.Nombre_Parada, DbType.String, ParameterDirection.Input, 80);
            parametros.Add("@Provincia", P_Parada.Provincia, DbType.String, ParameterDirection.Input, 20);
            parametros.Add("@Canton", P_Parada.Canton, DbType.String, ParameterDirection.Input, 20);
            parametros.Add("@Distrito", P_Parada.Distrito, DbType.String, ParameterDirection.Input, 30);
            parametros.Add("@Ubicacion", P_Parada.Ubicacion, DbType.String, ParameterDirection.Input, 60);

            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return conexionSQLServer.Execute("PA_ModificarParada", parametros, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public static bool EliminarParada(Parada P_Parada)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Nombre_Parada", P_Parada.Nombre_Parada, DbType.String, ParameterDirection.Input, 80);

            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return conexionSQLServer.Execute("PA_EliminarParada", parametros, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public static List<Parada> ConsultarParadas()
        {
            DynamicParameters parametros = new DynamicParameters();

            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return (List<Parada>)conexionSQLServer.Query<Parada>("PA_ConsultarParadas", parametros, commandType: CommandType.StoredProcedure);
            }
        }

        public static List<Parada> ConsultarParadasXProvincia(Parada P_Parada)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Provincia", P_Parada.Provincia, DbType.String, ParameterDirection.Input, 20); 
            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return (List<Parada>)conexionSQLServer.Query<Parada>("PA_ConsultarParadasPorProvincia", parametros, commandType: CommandType.StoredProcedure);
            }
        }

        public static List<Parada> ConsultarParadasXCanton(Parada P_Parada)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Canton", P_Parada.Canton, DbType.String, ParameterDirection.Input, 20); 
            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return (List<Parada>)conexionSQLServer.Query<Parada>("PA_ConsultarParadasPorCanton", parametros, commandType: CommandType.StoredProcedure);
            }
        }

        public static List<Parada> ConsultarParadasXDistrito(Parada P_Parada)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Distrito", P_Parada.Distrito, DbType.String, ParameterDirection.Input, 30); 
            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return (List<Parada>)conexionSQLServer.Query<Parada>("PA_ConsultarParadasPorDistrito", parametros, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion

        #region Ruta

        public static bool AgregarRuta(Ruta P_Ruta)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Nombre_Ruta", P_Ruta.Nombre_Ruta, DbType.String, ParameterDirection.Input, 50);
            parametros.Add("@Provincia_inicio", P_Ruta.Provincia_inicio, DbType.String, ParameterDirection.Input, 20);
            parametros.Add("@Provincia_fin", P_Ruta.Provincia_fin, DbType.String, ParameterDirection.Input, 20);
            parametros.Add("@Canton_inicio", P_Ruta.Canton_inicio, DbType.String, ParameterDirection.Input, 20);
            parametros.Add("@Canton_fin", P_Ruta.Canton_fin, DbType.String, ParameterDirection.Input, 20);
            parametros.Add("@Distrito_inicio", P_Ruta.Distrito_inicio, DbType.String, ParameterDirection.Input, 30);
            parametros.Add("@Distrito_fin", P_Ruta.Distrito_fin, DbType.String, ParameterDirection.Input, 30);
            parametros.Add("@Distancia", P_Ruta.Distancia, DbType.String, ParameterDirection.Input, 10);
            parametros.Add("@Precio", P_Ruta.Precio, DbType.String, ParameterDirection.Input, 4);

            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return conexionSQLServer.Execute("PA_AgregarRuta", parametros, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public static bool ModificarRuta(Ruta P_Ruta)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Nombre_Ruta", P_Ruta.Nombre_Ruta, DbType.String, ParameterDirection.Input, 50);
            parametros.Add("@Provincia_inicio", P_Ruta.Provincia_inicio, DbType.String, ParameterDirection.Input, 20);
            parametros.Add("@Provincia_fin", P_Ruta.Provincia_fin, DbType.String, ParameterDirection.Input, 20);
            parametros.Add("@Canton_inicio", P_Ruta.Canton_inicio, DbType.String, ParameterDirection.Input, 20);
            parametros.Add("@Canton_fin", P_Ruta.Canton_fin, DbType.String, ParameterDirection.Input, 20);
            parametros.Add("@Distrito_inicio", P_Ruta.Distrito_inicio, DbType.String, ParameterDirection.Input, 30);
            parametros.Add("@Distrito_fin", P_Ruta.Distrito_fin, DbType.String, ParameterDirection.Input, 30);
            parametros.Add("@Distancia", P_Ruta.Distancia, DbType.String, ParameterDirection.Input, 10);
            parametros.Add("@Precio", P_Ruta.Precio, DbType.String, ParameterDirection.Input, 4);

            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return conexionSQLServer.Execute("PA_ModificarRuta", parametros, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public static bool EliminarRuta(Ruta P_Ruta)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Nombre_Ruta", P_Ruta.Nombre_Ruta, DbType.String, ParameterDirection.Input, 50);
            
            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return conexionSQLServer.Execute("PA_EliminarRuta", parametros, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public static List<Ruta> ConsultarRutas()
        {
            DynamicParameters parametros = new DynamicParameters();

            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return (List<Ruta>)conexionSQLServer.Query<Ruta>("PA_ConsultarRutas", parametros, commandType: CommandType.StoredProcedure);
            }
        }

        public static List<Ruta> ConsultarRutasXDistrito_Inicio(Ruta P_Ruta)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Distrito_inicio", P_Ruta.Distrito_inicio, DbType.String, ParameterDirection.Input, 30);
            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return (List<Ruta>)conexionSQLServer.Query<Ruta>("PA_ConsultarRutasPorDistrito_Inicio", parametros, commandType: CommandType.StoredProcedure);
            }
        }

        public static List<Ruta> ConsultarRutasXDistrito_Fin(Ruta P_Ruta)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Distrito_fin", P_Ruta.Distrito_fin, DbType.String, ParameterDirection.Input, 30);
            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return (List<Ruta>)conexionSQLServer.Query<Ruta>("PA_ConsultarRutasPorDistrito_Fin", parametros, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion

        #region Bus

        public static bool AgregarBus(Bus P_Bus)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@ID_Bus", P_Bus.ID_Bus, DbType.String, ParameterDirection.Input, 10);
            parametros.Add("@Modelo", P_Bus.Modelo, DbType.String, ParameterDirection.Input, 20);
            parametros.Add("@Marca", P_Bus.Marca, DbType.String, ParameterDirection.Input, 20);
            parametros.Add("@Año", P_Bus.Año, DbType.String, ParameterDirection.Input, 4);
            parametros.Add("@Capacidad", P_Bus.Capacidad, DbType.String, ParameterDirection.Input, 2);
            parametros.Add("@ID_Estado", P_Bus.ID_Estado, DbType.String, ParameterDirection.Input, 5);
            
            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return conexionSQLServer.Execute("PA_AgregarBus", parametros, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public static bool ModificarBus(Bus P_Bus)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@ID_Bus", P_Bus.ID_Bus, DbType.String, ParameterDirection.Input, 10);
            parametros.Add("@Modelo", P_Bus.Modelo, DbType.String, ParameterDirection.Input, 20);
            parametros.Add("@Marca", P_Bus.Marca, DbType.String, ParameterDirection.Input, 20);
            parametros.Add("@Año", P_Bus.Año, DbType.String, ParameterDirection.Input, 4);
            parametros.Add("@Capacidad", P_Bus.Capacidad, DbType.String, ParameterDirection.Input, 2);
            parametros.Add("@ID_Estado", P_Bus.ID_Estado, DbType.String, ParameterDirection.Input, 5);

            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return conexionSQLServer.Execute("PA_ModificarBus", parametros, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public static bool EliminarBus(Bus P_Bus)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@ID_Bus", P_Bus.ID_Bus, DbType.String, ParameterDirection.Input, 10);
            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return conexionSQLServer.Execute("PA_EliminarBus", parametros, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public static List<Bus> ConsultarBuses()
        {
            DynamicParameters parametros = new DynamicParameters();

            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return (List<Bus>)conexionSQLServer.Query<Bus>("PA_ConsultarBuses", parametros, commandType: CommandType.StoredProcedure);
            }
        }

        public static List<Bus> ConsultarBusesXEstado(Bus P_Bus)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@ID_Estado", P_Bus.ID_Estado, DbType.String, ParameterDirection.Input, 5);
            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return (List<Bus>)conexionSQLServer.Query<Bus>("PA_ConsultarBusesPorEstado", parametros, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion

        #region Itinerario

        public static bool AgregarItinerario(Itinerario P_Itinerario)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@ID_Itinerario", P_Itinerario.ID_Itinerario, DbType.Int32, ParameterDirection.Input, 50);
            parametros.Add("@Fecha", P_Itinerario.Fecha, DbType.DateTime, ParameterDirection.Input, 20);
            parametros.Add("@Nombre_Ruta", P_Itinerario.Nombre_Ruta, DbType.String, ParameterDirection.Input, 20);
            parametros.Add("@Nombre_Chofer", P_Itinerario.Nombre_Chofer, DbType.String, ParameterDirection.Input, 20);
            parametros.Add("@ID_Bus", P_Itinerario.ID_Bus, DbType.String, ParameterDirection.Input, 20);
            parametros.Add("@Estado_Salida", P_Itinerario.Estado_Salida, DbType.String, ParameterDirection.Input, 30);
            parametros.Add("@Estado_Regreso", P_Itinerario.Estado_Regreso, DbType.String, ParameterDirection.Input, 30);
            parametros.Add("@Recaudacion_Proyectada", P_Itinerario.Recaudacion_Proyectada, DbType.Int32, ParameterDirection.Input, 10);
            parametros.Add("@Recaudacion_Final", P_Itinerario.Recaudacion_Final, DbType.Int32, ParameterDirection.Input, 4);

            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return conexionSQLServer.Execute("PA_AgregarItinerario", parametros, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public static bool ModificarItinerario(Itinerario P_Itinerario)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@ID_Itinerario", P_Itinerario.ID_Itinerario, DbType.Int32, ParameterDirection.Input, 50);
            parametros.Add("@Fecha", P_Itinerario.Fecha, DbType.DateTime, ParameterDirection.Input, 20);
            parametros.Add("@Nombre_Ruta", P_Itinerario.Nombre_Ruta, DbType.String, ParameterDirection.Input, 20);
            parametros.Add("@Nombre_Chofer", P_Itinerario.Nombre_Chofer, DbType.String, ParameterDirection.Input, 20);
            parametros.Add("@ID_Bus", P_Itinerario.ID_Bus, DbType.String, ParameterDirection.Input, 20);
            parametros.Add("@Estado_Salida", P_Itinerario.Estado_Salida, DbType.String, ParameterDirection.Input, 30);
            parametros.Add("@Estado_Regreso", P_Itinerario.Estado_Regreso, DbType.String, ParameterDirection.Input, 30);
            parametros.Add("@Recaudacion_Proyectada", P_Itinerario.Recaudacion_Proyectada, DbType.Int32, ParameterDirection.Input, 10);
            parametros.Add("@Recaudacion_Final", P_Itinerario.Recaudacion_Final, DbType.Int32, ParameterDirection.Input, 4);

            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return conexionSQLServer.Execute("PA_ModificarItinerario", parametros, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public static bool EliminarItinerario(Itinerario P_Itinerario)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@ID_Itinerario", P_Itinerario.ID_Itinerario, DbType.Int32, ParameterDirection.Input, 50);

            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return conexionSQLServer.Execute("PA_EliminarItinerario", parametros, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public static List<Itinerario> ConsultarItinerarios()
        {
            DynamicParameters parametros = new DynamicParameters();

            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return (List<Itinerario>)conexionSQLServer.Query<Itinerario>("PA_ConsultarItinerarios", parametros, commandType: CommandType.StoredProcedure);
            }
        }
            
        public static List<Itinerario> ConsultarItinerariosXFecha(Itinerario P_Itinerario)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Fecha", P_Itinerario.Fecha, DbType.DateTime, ParameterDirection.Input, 20);
            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return (List<Itinerario>)conexionSQLServer.Query<Itinerario>("PA_ConsultarItinerariosPorFecha", parametros, commandType: CommandType.StoredProcedure);
            }
        }

        public static List<Itinerario> ConsultarItinerariosXRuta(Itinerario P_Itinerario)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Ruta", P_Itinerario.Nombre_Ruta, DbType.String, ParameterDirection.Input, 20); 
            using (var conexionSQLServer = new SqlConnection(@"Server=tcp:proyecto2buses.database.windows.net,1433;Initial Catalog=Proyecto2Buses;Persist Security Info=False;User ID=administrador;Password={Neovvl0891*};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                return (List<Itinerario>)conexionSQLServer.Query<Itinerario>("PA_ConsultarItinerariosPorRuta", parametros, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion

    }
}
