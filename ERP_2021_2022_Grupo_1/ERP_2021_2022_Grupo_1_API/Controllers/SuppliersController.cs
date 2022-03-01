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
    public class SuppliersController : ControllerBase
    {
        // GET: api/<SuppliersController>
        [HttpGet]
        public IEnumerable<clsSupplier> Get()
        {
            List<clsSupplier> suppliersList = null;
            try
            {
                suppliersList = new clsSuppliersListBL().getSuppliersListBL();
            }
            catch (Exception)
            {
                throw;
            }

            return suppliersList;
        }

        // GET api/<SuppliersController>/5
        [HttpGet("{id}")]
        public clsSupplier Get(int id)
        {
            clsSupplier supplier = null;
            try
            {
               
                supplier = new clsSuppliersListBL().getSupplierBL(id);
            }
            catch (Exception) 
            {
                throw;
            }
            return supplier;
        }

        // POST api/<SuppliersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SuppliersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SuppliersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
