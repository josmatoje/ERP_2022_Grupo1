using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ERP_2021_2022_Grupo_1_DAL.Utilidades
{
    /// <summary>
    /// This class will have all the properties and methods that we will be using in a class that executes SELECT instructions
    /// </summary>
    public abstract class clsUtilidadSelectDAL : clsUtilityBaseDal
    {
        //NOTE: The methods in this class don't manage any SqlException as the raises it so the method that calls it handle them 
        #region public properties
        public static SqlDataReader MyReader { get; set; }
        #endregion
        #region constants
        public const string ID_PARAMETER = "@id";
        #endregion
        #region public methods
        /// <summary>
        /// <b>Prototipo:</b> public static SqlDataReader ejecutarSelectCondicion(String instruccionSelect, int condicion)<br/>
        /// <b>Comentarios:</b> Ejecuta una instrucción Select con condición, normalmente esta será una PK<br/>
        /// <b>Precondiciones:</b> ninguna<br/>
        /// <b>Postcondiciones:</b> Dado las propiedades heredadas, una instrucción select y una condición, ejecuta una instrucción Select con un parámetro condición,
        /// devolviendo el resultado correspondiente 
        /// </summary>
        /// <param name="instruccionSelect"></param>
        /// <param name="condicion"></param>
        /// <returns> SqlDataReader flujo de filas de solo avance resultante de la instrucción</returns>
        public static SqlDataReader ejecutarSelectCondicion(String instruccionSelect, int condicion)
        {
            MyCommand.Parameters.Add(ID_PARAMETRO, System.Data.SqlDbType.Int).Value = condicion;
            MyCommand.Connection = MiConexion.Conexion;
            MyCommand.CommandText = instruccionSelect + ID_PARAMETRO;
            return MyCommand.ExecuteReader();
        }

        /// <summary>
        /// <b>Prototipo:</b> public static SqlDataReader ejecutarSelectCondicion(String instruccionSelect, String condicion)<br/>
        /// <b>Comentarios:</b> Ejecuta una instrucción Select con condición, normalmente esta será una PK<br/>
        /// <b>Precondiciones:</b> ninguna<br/>
        /// <b>Postcondiciones:</b> Dado las propiedades heredadas, una instrucción select y una condición, ejecuta una instrucción Select con un parámetro condición,
        /// devolviendo el resultado correspondiente 
        /// </summary>
        /// <param name="instruccionSelect"></param>
        /// <param name="condicion"></param>
        /// <returns> SqlDataReader flujo de filas de solo avance resultante de la instrucción</returns>
        public static SqlDataReader ejecutarSelectCondicion(String instruccionSelect, String condicion)
        {
            MyCommand.Parameters.Add(ID_PARAMETRO, System.Data.SqlDbType.VarChar).Value = condicion;
            MyCommand.Connection = MiConexion.Conexion;
            MyCommand.CommandText = instruccionSelect + ID_PARAMETRO;
            return MyCommand.ExecuteReader();
        }

        /// <summary>
        /// <b>Prototipo:</b> public static SqlDataReader ejecutarSelect(String instruccionSelect)<br/>
        /// <b>Comentarios:</b> Ejecuta una instrucción Select y la devuelve<br/>
        /// <b>Precondiciones:</b> ninguna<br/>
        /// <b>Postcondiciones:</b> Dado las propiedades heredadas y una instrucción select ejecuta dicha instrucción Select, luego,
        /// devuelve el resultado correspondiente
        /// </summary>
        /// <param name="instruccionSelect"></param>
        /// <returns> SqlDataReader flujo de filas de solo avance resultante de la instrucción</returns>
        public static SqlDataReader ejecutarSelect(String instruccionSelect)
        {
            MyCommand.CommandText = instruccionSelect;
            MyCommand.Connection = MiConexion.Conexion;
            return MyCommand.ExecuteReader();
        }

        /// <summary>
        /// <b>Prototipo:</b> public static void cerrarFlujos()<br/>
        /// <b>Comentarios:</b> Cierra los flujos de conexión tantos de esta clase como los heredados<br/>
        /// <b>Precondiciones:</b> ninguna<br/>
        /// <b>Postcondiciones: </b>Cierra el flujo de conexión tanto del objeto tipo MiConexion como el tipo MiLector 
        /// </summary>
        public static void cerrarFlujos()
        {
            MiConexion.closeConnection();
            MiLector.Close();
        }
        #endregion
    }
}
