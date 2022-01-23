using ERP_2021_2022_Grupo_1_DAL.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ERP_2021_2022_Grupo_1_DAL.Utilidades
{
    /// <summary>
    /// Has all the attributes and methods that are used when we are working with data from the DAL layer,
    /// like the conection, the command and opening that conection
    /// </summary>
    public abstract class clsUtilidadBaseDAL
    {
        #region propiedades publicas
        public static clsMyConnection MiConexion { get; set; }
        public static SqlCommand MiComando { get; set; }
        #endregion
        #region metodos publicos
        /// <summary>
        /// <b>Prototype:</b> public static void openConection()<br/>
        /// <b>Commentaries:</b> Method for opening a conection to a DB<br/>
        /// <b>Preconditions:</b> None<br/>
        /// <b>Postconditions:</b> Los atributos MiConexion y MiCommando son instanciados,luego, se abre una conexión a la BD guardada en los atributos
        /// del objeto tipo MiConexion
        /// </summary>
        public static void instanciarConexion()
        {
            MiConexion = new clsMyConnection();
            MiComando = new SqlCommand();
            MiConexion.getConnection();
        }
        #endregion
    }
}
