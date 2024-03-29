﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ERP_2021_2022_Grupo_1_DAL.Conexion
{
    public class clsMyConnection
    {
        #region public properties
        public String Server { get; set; }
        public String DataBase { get; set; }
        public String User { get; set; }
        public String Pass { get; set; }
        public SqlConnection Conexion { get; set; }
        #endregion

        #region constructors
        public clsMyConnection()
        {
            Server = "nadine.database.windows.net";
            DataBase = "BBDDNadine";
            User = "saboresdelatierra";
            Pass = "#Mitesoro";
    }
        //Con parámetros por si quisiera cambiar las conexiones
        public clsMyConnection(String server, String database, String user, String pass)
        {
            Server = server;
            DataBase = database;
            User = user;
            Pass = pass;
        }
        #endregion

        #region public methods
        /// <summary>
        /// Método que abre una conexión con la base de datos
        /// </summary>
        /// <pre>Nada.</pre>
        /// <returns>Una conexión abierta con la base de datos</returns>
        public void getConnection()
        {
            try
            {
                Conexion = new SqlConnection();
                Conexion.ConnectionString = $"server={Server};database={DataBase};uid={User};pwd={Pass};";
                Conexion.Open();
            }
            catch (SqlException)
            {
                throw;
            }
        }

        /// <summary>
        /// Este metodo cierra una conexión con la Base de datos
        /// </summary>
        /// <post>La conexion es cerrada</post>
        /// <param name="connection">SqlConnection pr referencia. Conexion a cerrar
        /// </param>
        public void closeConnection()
        {
            try
            {
                Conexion.Close();
            }
            catch (SqlException)
            {
                throw;
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }

}
