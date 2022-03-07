using ERP_2021_2022_Grupo_1_DAL.Utilities;
using ERP_2021_2022_Grupo_1_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_2021_2022_Grupo_1_DAL.Managers
{
    public class clsOrderManagerDAL : clsUtilityDMLDAL
    {

        #region constants
        public const String UPDATE_INSTRUCTION_ORDER = "UPDATE Orders SET Total = @Total, OrderDate = @Orderdate, LimitDate = @LimitDate, Notes = @Notes, SupplierID = @SupplierID  WHERE ID = @param";
        public const String INSERT_INSTRUCTION_ORDER = "INSERT INTO Orders VALUES (@Total, @OrderDate, @LimitDate, @Notes, @Supplierid)";
        public const String DELETE_INSTRUCTION_ORDER = "DELETE FROM Orders WHERE ID = @param";
        #endregion
        #region methods
      
        /// <summary>
        /// <b>Prototype:</b> public int updateOrderDAL(clsOrder order)<br/>
        /// <b>Commentaries:</b>Connects to the DB to update an order<br/>
        /// <b>Preconditions:</b> order is valid<br/>
        /// <b>Postconditions:</b> Returns int indicating how many rows were changed (updated)
        /// </summary>
        /// <param name="order">clsOrder</param>
        /// <returns>int rowsChanged</returns>
        public int updateOrderDAL(clsOrder order)
        {
            openConection();
            createCommand(order);
            int resultado = order.OrderId == 0 ? executeDMLSentence(INSERT_INSTRUCTION_ORDER) : executeDMLSentenceCondition(UPDATE_INSTRUCTION_ORDER, order.OrderId);
            MyConnection.closeConnection();
            return resultado;
        }
        /// <summary>
        /// <b>Prototype:</b> public int deleteOrderDAL(int id)<br/>
        /// <b>Commentaries:</b>Connects to the DB to delete an order<br/>
        /// <b>Preconditions:</b> id exists<br/>
        /// <b>Postconditions:</b> Returns int indicating how many rows were changed (deleted)
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>int rowsChanged</returns>
        public int deleteOrderDAL(int id)
        {
            openConection();
            int resultado = executeDMLSentenceCondition(DELETE_INSTRUCTION_ORDER, id);
            MyConnection.closeConnection();
            return resultado;
        }


        /// <summary>
        /// <b>Prototype:</b> private void createCommand(clsOrderLine orderLine) <br/>
        /// <b>Commentaries:</b>Create a command with order atributes<br/>
        /// <b>Preconditions:</b> order not null<br/>
        /// <b>Postconditions:</b> nothing
        /// </summary>
        /// <param name="order"></param>

        private void createCommand(clsOrder order) {
            MyCommand.Parameters.Add("@Total", System.Data.SqlDbType.Money).Value = order.Total;
            MyCommand.Parameters.Add("@OrderDate", System.Data.SqlDbType.Date).Value = order.OrderDate;
            MyCommand.Parameters.Add("@LimitDate", System.Data.SqlDbType.Date).Value = order.LimitOrderDate;
            MyCommand.Parameters.Add("@Notes", System.Data.SqlDbType.NVarChar).Value = order.Notes;
            MyCommand.Parameters.Add("@SupplierID", System.Data.SqlDbType.Int).Value = order.SupplierId;
        }

    }
}
#endregion