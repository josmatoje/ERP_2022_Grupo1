using ERP_2021_2022_Grupo_1_BL.Lists;
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
    public class ProductsController : ControllerBase
    {
        /// <summary>
        /// <b>GET: api/*ProductsController*</b><br/>
        /// <b>Prototype:</b> public IEnumerable(clsProduct) Get()<br/>
        /// <b>Commentaries:</b> Execute an API call with the GET verb, asking for a list of products and 
        /// returning list of products<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> It makes a call to its corresponding method in the DB to collect a list of products,
        /// if an error occurs during the execution, it throws a Exception
        /// </summary>
        /// <returns>IEnumerable(clsProduct) list of products or null</returns>
        [HttpGet]
        public IEnumerable<clsProduct> Get()
        {
            List<clsProduct> productList = null;
            try
            {
                productList = new clsProductsListBL().getProductsListBL();
            }
            catch (Exception)
            {
                throw;
            }

            return productList;
        }

        /// <summary>
        /// <b>GET api/*ProductsController*/5</b><br/>
        /// <b>Prototype:</b> public IActionResult Get(int id)<br/>
        /// <b>Commentaries:</b> Execute an API call with the GET verb,asking for a product with id,
        /// returning the product<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> It makes a call to its corresponding method in the DB to collect a product with the id parameter,
        /// if an error occurs during the execution, it throws a Exception
        /// </summary>
        /// <param name="id"></param>
        /// <returns>clsProduct the product from DB or null</returns>
        [HttpGet("{id}")]
        public clsProduct Get(int id)
        {
            clsProduct product = null;
            try
            {
                product = new clsProductsListBL().getProductBL(id);
            }
            catch (Exception) 
            {
                throw;
            }
            return product;
        }

        /// <summary>
        /// <b>GET api/*ProductsController*/Supplier/5</b><br/>
        /// <b>Prototype:</b> public IEnumerable(clsProduct) GetProductListSupplier(int id)<br/>
        /// <b>Commentaries:</b> Execute an API call with the GET verb, asking for a list of products whose supplier has the
        /// id parameter and the returning it<br/>
        /// <b>Preconditions:</b> none<br/>
        /// <b>Postconditions:</b> It makes a call to its corresponding method in the DB to collect a list of products with an id supplier,
        /// if an error occurs during the execution, it throws a Exception
        /// </summary>
        /// <returns>IEnumerable(clsProduct) list products of supplier or null</returns>
        [HttpGet("Supplier/{id}")]
        public IEnumerable<clsProduct> GetProductListSupplier(int id)
        {
            List<clsProduct> productList = null;
            try
            {
                productList = new clsProductsListBL().getProductListSupplierBL(id);
            }
            catch (Exception)
            {
                throw;
            }

            return productList;
        }

    }
}
