using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_2021_2022_Grupo_1_DAL.Utilities
{
    /// <summary>
    /// Contains all the attributes and methos that are ALWAYS used in the classes that execute DML sentences, Insert, Update, Delete...
    /// </summary>
    public abstract class clsUtilidadDMLDAL : clsUtilityBaseDAL
    {
        //NOT: This class methods don't catch any SqlException as they raise it so the method that calls it handle them

        #region public methods
        /// <summary>
        /// <b>Prototype:</b> public static int executeDMLSentence(String dmlSentence)<br/>
        /// <b>Commentaries:</b> Executes a DML sentence<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> Through las propiedades heredadas y una sentenciaDML, ejecuta dicha sentencia y devolviendo
        /// el numero de filas afectado
        /// </summary>
        /// <param name="dmlSentence"></param>
        /// <returns> int representando el número de filas afectadas por dicha sentenciaDML</returns>
        public static int executeDMLSentence(String dmlSentence)
        {
            MyCommand.CommandText = dmlSentence;
            MyCommand.Connection = MyConnection.Conexion;
            return MyCommand.ExecuteNonQuery();
        }

        /// <summary>
        /// <b>Prototipo:</b> public static int ejecutarSentenciaDMLCondicion(String sentenciaDML, int condicion)<br/>
        /// <b>Comentarios:</b> Ejecuta una sentenciaDML DML con una condición, siendo esta normalmente una PK<br/>
        /// <b>Precondiciones:</b> ninguna<br/>
        /// <b>Postcondiciones:</b> Mediante las propiedades heredadas y una sentenciaDML sql con una condición,
        /// añade dicho parámetro y ejecuta la sentenciaDML completa, al final, devuelve el numero de filas afectado
        /// </summary>
        /// <param name="sentenciaDML"></param>
        /// <param name="condicion"></param>
        /// <returns> int representando el número de filas afectadas por dicha sentenciaDML</returns>
        public static int ejecutarSentenciaDMLCondicion(String sentenciaDML, int condicion)
        {
            MyCommand.Parameters.Add("@param", System.Data.SqlDbType.Int).Value = condicion;
            MyCommand.CommandText = sentenciaDML + "@param";
            MyCommand.Connection = MyConnection.Conexion;
            return MyCommand.ExecuteNonQuery();
        }

        /// /// <summary>
        /// <b>Prototipo:</b> public static int ejecutarProcedimientoAlmacenado(String procedimiento)<br/>
        /// <b>Comentarios:</b> Ejecuta un procedimiento almacenado<br/>
        /// <b>Precondiciones:</b> si el SP tiene variables, estas ya deben haber sido instanciadas en MyCommand<br/>
        /// <b>Postcondiciones:</b> Mediante las propiedades heredadas y un procedimiento pasado por parámetro
        /// ejecuta dicho SP, al final, devuelve el numero de filas afectado
        /// </summary>
        /// <param name="procedimiento"></param>
        /// <returns></returns>
        /// <returns> int representando el número de filas afectadas por dicha sentenciaDML</returns>
        public static int ejecutarProcedimientoAlmacenado(String procedimiento)
        {
            MyCommand.CommandType = System.Data.CommandType.StoredProcedure;
            MyCommand.CommandText = procedimiento;
            MyCommand.Connection = MyConnection.Conexion;
            return MyCommand.ExecuteNonQuery();

        }
        #endregion
    }
}
