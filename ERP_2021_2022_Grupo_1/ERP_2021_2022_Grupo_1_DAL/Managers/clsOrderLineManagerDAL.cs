using ERP_2021_2022_Grupo_1_Entities;
using System;
using System.Collections.Generic;
using System.Text;
using ERP_2021_2022_Grupo_1_DAL.Utilities;

namespace ERP_2021_2022_Grupo_1_DAL.Managers
{
    public class clsOrderLineManagerDAL : clsUtilidadDMLDAL
    {
        #region constantes
        public const String UPDATE_INSTRUCTION_ORDER_LINE = "UPDATE OrderLines SET OrderID = @OrderID, ProductID = @ProductID, Quantity = @Quantity, UnitPriceAtTime = @UnitPriceAtTime WHERE ID = ";
        public const String INSERT_INSTRUCTION_ORDER_LINE = "INSERT INTO OrderLines VALUES (@OrderID, @ProductID, @Quantity, @UnitPriceAtTime)";
        public const String DELETE_INSTRUCTION_ORDER_LINE = "DELETE FROM OrderLines WHERE ID = @ID";
        #endregion
        /// <summary>
        /// <b>Prototype:</b> public static int createOrderLineDAL(clsOrderLine orderLine)<br/>
        /// <b>Commentaries:</b>Connects to the DB to store an order line<br/>
        /// <b>Preconditions:</b> order line is valid<br/>
        /// <b>Postconditions:</b> Returns int indicating how many rows were changed (stored)
        /// </summary>
        /// <param name="orderLine">clsOrderLine</param>
        /// <returns>int rowsChanged</returns>
        public static void createOrderLineDAL(clsOrderLine orderLine)
        {
            //ID es identity, el subtotal no se pone porque es calculado y faltan en la clase las FK orderID, productID
            //MyCommand.Parameters.Add("@OrderID", System.Data.SqlDbType.Int).Value = 
            //MyCommand.Parameters.Add("@ProductID", System.Data.SqlDbType.Int).Value = 
            MyCommand.Parameters.Add("@Quantity", System.Data.SqlDbType.Int).Value = orderLine.Quantity;
            MyCommand.Parameters.Add("@UnitPriceAtTime", System.Data.SqlDbType.Money).Value = orderLine.CurrentUnitPrice;

        }
        /// <summary>
        /// <b>Prototype:</b> public static int updateOrderLineDAL(clsOrderLine orderLine)<br/>
        /// <b>Commentaries:</b>Connects to the DB to update an order line<br/>
        /// <b>Preconditions:</b> order line is valid<br/>
        /// <b>Postconditions:</b> Returns int indicating how many rows were changed (updated)
        /// </summary>
        /// <param name="orderLine">clsOrderLine</param>
        /// <returns>int rowsChanged</returns>
        public static int updateOrderLineDAL(clsOrderLine orderLine)
        {
            openConection();
            int resultado = orderLine.Id == 0 ? executeDMLSentence(INSERT_INSTRUCTION_ORDER_LINE) : executeDMLSentence(UPDATE_INSTRUCTION_ORDER_LINE);
            MyConnection.closeConnection();
            return resultado;
        }
        /// <summary>
        /// <b>Prototype:</b> public static int deleteOrderLineDAL(int id)<br/>
        /// <b>Commentaries:</b>Connects to the DB to delete an order line<br/>
        /// <b>Preconditions:</b> id exists<br/>
        /// <b>Postconditions:</b> Returns int indicating how many rows were changed (deleted)
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>int rowsChanged</returns>
        public static int deleteOrderLineDAL(int id)
        {
            int resultado = 0;
            openConection();
            resultado = executeDMLSentenceCondition(DELETE_INSTRUCTION_ORDER_LINE, id);
            return 0;
        }

    }
}
