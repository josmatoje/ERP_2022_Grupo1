using ERP_2021_2022_Grupo_1_Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ERP_2021_2022_Grupo_1_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {

        /// <summary>
        /// <b>GET: api/*OrdersController*</b><br/>
        /// <b>Prototype:</b> public IActionResult Get()<br/>
        /// <b>Commentaries:</b> Execute an API call with the GET verb, asking for a list of orders and 
        /// returning the response of the call<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> It makes a call to its corresponding method in the DB to collect a list of orders, 
        /// if no error has occurred and the list is not empty, it will return a StatusCode 200 Ok(), if no error has 
        /// occurred but the list is empty, it will return a 404 NotFound(), and if an exception has occurred, it will 
        /// return a 400 BadRequest()
        /// </summary>
        /// <returns>IActionResult depending on the result of the call</returns>

        [HttpGet]
        public IActionResult Get()
        {
            return null;//TODO
        }


        /// <summary>
        /// <b>GET api/*OrdersController*/5</b><br/>
        /// <b>Prototype:</b> public IActionResult Get(int id)<br/>
        /// <b>Commentaries:</b> Execute an API call with the GET verb,asking for a order with id
        /// returning the response of the call<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> It makes a call to its corresponding method in the DB to collect a order with the id parameter, 
        /// if no error has occurred and the order is not null, it will return a StatusCode 200 Ok(), if no error has 
        /// occurred but the order is null, it will return a 404 NotFound(), and if an exception has occurred, it will 
        /// return a 400 BadRequest()
        /// </summary>
        /// <param name="id"></param>
        /// <returns>IActionResult depending on the result of the call</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return null;
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
            return null;
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
            return null;
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
            return null;
        }
    }
}
