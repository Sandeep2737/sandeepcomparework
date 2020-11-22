using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using prjcompAPI.Models;
using System.Collections;

namespace prjcompAPI.Controllers
{
    public class CompareProductsController : ApiController
    {
        private DbonlineshoppingEntities db = new DbonlineshoppingEntities();
        static List<Product> compareProducts = new List<Product>();
        [HttpGet]
        public IEnumerable GetProducts() 
        {
            if (compareProducts.Count > 4) compareProducts = compareProducts.Skip(Math.Max(0, compareProducts.Count() - 4)).ToList(); ;
            return compareProducts;
        }
        [HttpGet] 
        [Route("addCompareProduct")] 
        public void AddProducts(int id)
        { 
            if (db.Products.FirstOrDefault(p => p.ProductID == id) is Product p1) if (!compareProducts.Exists(p => p.ProductID == id)) 
                    compareProducts.Add(p1); }
    }
}
