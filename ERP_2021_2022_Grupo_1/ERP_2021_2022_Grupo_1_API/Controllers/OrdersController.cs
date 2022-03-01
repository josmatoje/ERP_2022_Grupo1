using ERP_2021_2022_Grupo_1_Entities;
using ERP_2021_2022_Grupo_1_BL.Lists;
using ERP_2021_2022_Grupo_1_BL.Manager;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using FromBodyAttribute = Microsoft.AspNetCore.Mvc.FromBodyAttribute;
using HttpDeleteAttribute = Microsoft.AspNetCore.Mvc.HttpDeleteAttribute;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using HttpPutAttribute = Microsoft.AspNetCore.Mvc.HttpPutAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ERP_2021_2022_Grupo_1_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {

        /// <summary>
        /// <b>GET: api/*OrdersController*</b><br/>
        /// <b>Prototype:</b> public IEnumerable(clsOrder) Get()<br/>
        /// <b>Commentaries:</b> Execute an API call with the GET verb, asking for a list of orders and 
        /// returning list of orders<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> It makes a call to its corresponding method in the DB to collect a list of orders,
        /// if an error occurs during the execution, the user will be prompted with a ServiceUnavaible excepttion and if
        /// the list is empty it will promp a NoContent exception
        /// </summary>
        /// <returns>IEnumerable(clsOrder)</returns>

        [HttpGet]
        public IEnumerable<clsOrder> Get()
        {
            List<clsOrder> orderList = null;
            //ObjectResult result;
            try
            {
                orderList = new clsOrdersListBL().getOrdersListBL();
            }
            catch (Exception) 
            {
                throw;
            }

            return orderList;
        }


        /// <summary>
        /// <b>GET api/*OrdersController*/5</b><br/>
        /// <b>Prototype:</b> public IActionResult Get(int id)<br/>
        /// <b>Commentaries:</b> Execute an API call with the GET verb,asking for a order with id
        /// returning the order<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> It makes a call to its corresponding method in the DB to collect an order with the id parameter,
        /// if an error occurs during the execution, the user will be prompted with a ServiceUnavaible excepttion and if
        /// the list is empty it will promp a NoContent exception
        /// </summary>
        /// <param name="id"></param>
        /// <returns>IActionResult depending on the result of the call</returns>
        [HttpGet("{id}")]
        public clsOrder Get(int id)
        {
            clsOrder oOrder = null;
            try
            {
                oOrder = new clsOrdersListBL().getOrderBL(id);
            }
            catch (Exception) 
            {
                throw;
            }
            return oOrder;
        }

        /// <summary>
        /// <b>GET api/*LastOrderID*/</b><br/>
        /// <b>Prototype:</b> public IActionResult GetlastOrderID()<br/>
        /// <b>Commentaries:</b> Execute an API call with the GET verb,asking for the last inserted order
        /// returning the order id<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> It makes a call to its corresponding method in the DB to collect the last inserted order's id,
        /// if an error occurs during the execution, the user will be prompted with a ServiceUnavaible excepttion and if
        /// the list is empty it will promp a NoContent exception
        /// </summary>
        /// <returns>IActionResult depending on the result of the call</returns>
        [HttpGet("LastOrderID")]
        public int GetLastOrderID()
        {
            int id=0;
            try
            {
                id = new clsOrdersListBL().getLastOrderIDBL();
            }
            catch (Exception) 
            { 
                throw;
            }
            return id;
        }


        /// <summary>
        /// <b>POST api/*OrdersController*</b><br/>
        /// <b>Prototype:</b> public IActionResult Post([FromBody] clsOrder oOrder)<br/>
        /// <b>Commentaries:</b> Execute an API call with the POST verb, inserting an order in the DB and returning the StatusCode
        /// of the result of said insertion<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> It makes a call to its corresponding method in the DB to insert a order in the DB, 
        /// if no error has occurred and the number of rows affected is not 0, it will return a StatusCode 200 Ok(), if no error has 
        /// occurred but the number of rows affected is 0, it will return a TODO, and if an exception has occurred, it will 
        /// return a 400 BadRequest()
        /// </summary>
        /// <param name="oOrder"></param>
        /// <returns>IActionResult depending on the result of the call</returns>
        [HttpPost]
        public IActionResult Post([FromBody] clsOrder oOrder)
        {
            //TODO NO LE LLEGAN BIEN LOS PAPARÁMETROS
            int rowsAffected = 0;
            IActionResult result = Ok();
            try
            {
                rowsAffected = new clsOrderManagerBL().updateOrderBL(oOrder);
                if (rowsAffected == 0)
                {
                    result = NotFound();
                }
            }
            catch (Exception)
            {
                result = BadRequest();
            }

            return result;
        }


        /// <summary>
        /// <b>PUT api/*OrdersController*/5</b><br/>
        /// <b>Prototype:</b> public IActionResult Put(int id, [FromBody] clsOrder oOrder)<br/>
        /// <b>Commentaries:</b> Execute an API call with the PUT verb, updating an order in the DB and returning the StatusCode
        /// of the result of said update<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> It makes a call to its corresponding method in the DB to update a order in the DB, 
        /// if no error has occurred and the number of rows affected is not 0, it will return a StatusCode 200 Ok(), if no error has 
        /// occurred but the number of rows affected is 0, it will return a TODO, and if an exception has occurred, it will 
        /// return a 400 BadRequest()
        /// </summary>
        /// <param name="id"></param>
        /// <param name="oOrder"></param>
        /// <returns>IActionResult depending on the result of the call</returns>
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] clsOrder oOrder)
        {
            int rowsAffected = 0;
            IActionResult result = Ok();
            try
            {
                rowsAffected = new clsOrderManagerBL().updateOrderBL(oOrder);
                if (rowsAffected == 0)
                {
                    result = NotFound();
                }
            }
            catch (Exception)
            {
                result = BadRequest();
            }

            return result;
        }

        /// <summary>
        /// <b>DELETE api/*OrdersController*/5</b><br/>
        /// <b>Prototype:</b> public IActionResult Delete(int id)<br/>
        /// <b>Commentaries:</b> Execute an API call with the DELETE verb, deleting an order in the DB and returning the StatusCode
        /// of the result of said delete<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> It makes a call to its corresponding method in the DB to delete a order in the DB with her id parameter, 
        /// if no error has occurred and the number of rows affected is not 0, it will return a StatusCode 200 Ok(), if no error has 
        /// occurred but the number of rows affected is 0, it will return a TODO, and if an exception has occurred, it will 
        /// return a 400 BadRequest()
        /// </summary>
        /// <param name="id"></param>
        /// <returns>IActionResult depending on the result of the call</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int rowsAffected = 0;
            IActionResult result = Ok();
            try
            {
                rowsAffected = new clsOrderManagerBL().deleteOrderBL(id);
                if (rowsAffected == 0)
                {
                    result = NotFound();
                }
            }
            catch (Exception)
            {
                result = BadRequest();
            }

            return result;
        }
    }
}
