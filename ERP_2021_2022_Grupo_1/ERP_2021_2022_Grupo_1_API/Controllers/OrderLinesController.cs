using ERP_2021_2022_Grupo_1_BL.Lists;
using ERP_2021_2022_Grupo_1_BL.Manager;
using ERP_2021_2022_Grupo_1_Entities;
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
    public class OrderLinesController : ControllerBase
    {
        /// <summary>
        /// <b>GET: api/*OrderLinesController*</b><br/>
        /// <b>Prototype:</b> public IActionResult Get()<br/>
        /// <b>Commentaries:</b> Execute an API call with the GET verb, asking for a list of ordersLines and 
        /// returning the response of the call<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> It makes a call to its corresponding method in the DB to collect a list of ordersLines, 
        /// if no error has occurred and the list is not empty, it will return a StatusCode 200 Ok(), if no error has 
        /// occurred but the list is empty, it will return a 404 NotFound(), and if an exception has occurred, it will 
        /// return a 400 BadRequest()
        /// </summary>
        /// <returns>IActionResult depending on the result of the call</returns>
        [HttpGet]
        public IEnumerable<clsOrderLine> Get()
        {

            List<clsOrderLine> oOrderLinesList = null;
            try
            {
                oOrderLinesList = new clsOrderLinesListBL().getOrderLineListBL();
            }
            catch (Exception)
            {
                throw;
            }

            return oOrderLinesList;
        }

        
        /// <summary>
        /// <b>GET api/*OrderLinesController*/5</b><br/>
        /// <b>Prototype:</b> public IActionResult Get(int id)<br/>
        /// <b>Commentaries:</b> Execute an API call with the GET verb,asking for a orderLines with id
        /// returning the response of the call<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> It makes a call to its corresponding method in the DB to collect a orderLines with the id parameter, 
        /// if no error has occurred and the orderLines is not null, it will return a StatusCode 200 Ok(), if no error has 
        /// occurred but the orderLines is null, it will return a 404 NotFound(), and if an exception has occurred, it will 
        /// return a 400 BadRequest()
        /// </summary>
        /// <param name="id"></param>
        /// <returns>IActionResult depending on the result of the call</returns>
        [HttpGet("{id}")]
        public clsOrderLine Get(int id)
        {
            clsOrderLine oOrderLine = null;
            try
            {
                oOrderLine = new clsOrderLinesListBL().getOrderLineBL(id);
            }
            catch (Exception)
            {
                throw;
            }

            return oOrderLine;
        }

        /// <summary>
        /// <b>POST api/*OrderLinesController*</b><br/>
        /// <b>Prototype:</b> public IActionResult Post([FromBody] clsOrderLine oOrderLine)<br/>
        /// <b>Commentaries:</b> Execute an API call with the POST verb, inserting an orderLine in the DB and returning the StatusCode
        /// of the result of said insertion<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> It makes a call to its corresponding method in the DB to insert a order in the DB, 
        /// if no error has occurred and the number of rows affected is not 0, it will return a StatusCode 200 Ok(), if no error has 
        /// occurred but the number of rows affected is 0, it will return a TODO, and if an exception has occurred, it will 
        /// return a 400 BadRequest()
        /// </summary>
        /// <param name="oOrderLine"></param>
        /// <returns>IActionResult depending on the result of the call</returns>
        [HttpPost]
        public IActionResult Post([FromBody] clsOrderLine oOrderLine)
        {
            int rowsAffected = 0;
            IActionResult result;
            try
            {
                rowsAffected = new clsOrderLineManagerBL().updateOrderLineBL(oOrderLine);
                if (rowsAffected == 0)
                {
                    result = NotFound("NotFound");
                }
                else
                {
                    result = Ok(rowsAffected);
                }
            }
            catch (Exception)
            {
                result = BadRequest("BadRequest");
            }
            return result;
        }

        /// <summary>
        /// <b>PUT api/*OrderLinesController*/5</b><br/>
        /// <b>Prototype:</b> public IActionResult Put(int id, [FromBody] clsOrderLine oOrderLine)<br/>
        /// <b>Commentaries:</b> Execute an API call with the PUT verb, updating an orderLine in the DB and returning the StatusCode
        /// of the result of said update<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> It makes a call to its corresponding method in the DB to update a orderLine in the DB, 
        /// if no error has occurred and the number of rows affected is not 0, it will return a StatusCode 200 Ok(), if no error has 
        /// occurred but the number of rows affected is 0, it will return a TODO, and if an exception has occurred, it will 
        /// return a 400 BadRequest()
        /// </summary>
        /// <param name="id"></param>
        /// <param name="oOrderLine"></param>
        /// <returns>IActionResult depending on the result of the call</returns>
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] clsOrderLine oOrderLine)
        {
            int rowsAffected = 0;
            IActionResult result;
            try
            {
                rowsAffected = new clsOrderLineManagerBL().updateOrderLineBL(oOrderLine);
                if (rowsAffected == 0)
                {
                    result = NotFound("NotFound");
                }
                else
                {
                    result = Ok(rowsAffected);
                }
            }
            catch (Exception)
            {
                result = BadRequest("BadRequest");
            }

            return result;
        }

        /// <summary>
        /// <b>DELETE api/*OrderLinesController*/5</b><br/>
        /// <b>Prototype:</b> public IActionResult Delete(int id)<br/>
        /// <b>Commentaries:</b> Execute an API call with the DELETE verb, deleting an orderLine in the DB and returning the StatusCode
        /// of the result of said delete<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> It makes a call to its corresponding method in the DB to delete a orderLine in the DB with her id parameter, 
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
            IActionResult result;
            try
            {
                rowsAffected = new clsOrderLineManagerBL().deleteOrderLineBL(id);
                if (rowsAffected == 0)
                {
                    result = NotFound("NotFound");
                }
                else
                {
                    result = Ok(rowsAffected);
                }
            }
            catch (Exception)
            {
                result = BadRequest("BadRequest");
            }

            return result;
        }
    }
}
