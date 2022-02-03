using ERP_2021_2022_Grupo_1_DAL.Utilities;
using ERP_2021_2022_Grupo_1_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_2021_2022_Grupo_1_DAL.Managers
{
    public class clsOrderManagerDAL : clsUtilityDMLDAL
    {

        #region constantes
        public const String UPDATE_INSTRUCTION_ORDER = "UPDATE Order SET Total = @Total, OrderDate = @Orderdate, LimitDate = @LimitDate, Notes = @Notes, SupplierID = @SupplierID  WHERE ID = ";
        public const String INSERT_INSTRUCTION_ORDER = "INSERT INTO Order VALUES (@Total, @OrderDate, @LimitDate, @Notes, @Supplierid)";
        public const String DELETE_INSTRUCTION_ORDER = "DELETE FROM Order WHERE ID = @ID";
        #endregion


        /// <summary>
        /// <b>Prototype:</b> public static int createOrderDAL(clsOrder order)<br/>
        /// <b>Commentaries:</b>Connects to the DB to store an order<br/>
        /// <b>Preconditions:</b> order is valid<br/>
        /// <b>Postconditions:</b> Returns  int indicating how many rows were changed (stored)
        /// </summary>
        /// <param name="order">clsOrder</param>
        /// <returns>int rowsChanged</returns>
        public static int createOrderDAL(clsOrder order)
        {
            createCommand(order);
            openConection();
            int resultado = executeDMLSentence(INSERT_INSTRUCTION_ORDER);
            MyConnection.closeConnection();
            return resultado;
        }
        /// <summary>
        /// <b>Prototype:</b> public static int updateOrderDAL(clsOrder order)<br/>
        /// <b>Commentaries:</b>Connects to the DB to update an order<br/>
        /// <b>Preconditions:</b> order is valid<br/>
        /// <b>Postconditions:</b> Returns int indicating how many rows were changed (updated)
        /// </summary>
        /// <param name="order">clsOrder</param>
        /// <returns>int rowsChanged</returns>
        public static int updateOrderDAL(clsOrder order)
        {
            openConection();
            createCommand(order);
            int resultado = order.OrderId == 0 ? executeDMLSentence(INSERT_INSTRUCTION_ORDER) : executeDMLSentence(UPDATE_INSTRUCTION_ORDER);
            MyConnection.closeConnection();
            return resultado;
        }
        /// <summary>
        /// <b>Prototype:</b> public static int deleteOrderDAL(int id)<br/>
        /// <b>Commentaries:</b>Connects to the DB to delete an order<br/>
        /// <b>Preconditions:</b> id exists<br/>
        /// <b>Postconditions:</b> Returns int indicating how many rows were changed (deleted)
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>int rowsChanged</returns>
        public static int deleteOrderDAL(int id)
        {
            openConection();
            int resultado = executeDMLSentence(DELETE_INSTRUCTION_ORDER);
            MyConnection.closeConnection();
            return resultado;
        }

        private static void createCommand(clsOrder order) {
            MyCommand.Parameters.Add("@Total", System.Data.SqlDbType.Int).Value = order.Total;
            MyCommand.Parameters.Add("@OrderDate", System.Data.SqlDbType.Date).Value = order.OrderDate;
            MyCommand.Parameters.Add("@LimitDate", System.Data.SqlDbType.Date).Value = order.LimitOrderDate;
            MyCommand.Parameters.Add("@Notes", System.Data.SqlDbType.NVarChar).Value = order.Notes;
            MyCommand.Parameters.Add("@SupplierID", System.Data.SqlDbType.Int).Value = order.SupplierId;
        }

    }
}
