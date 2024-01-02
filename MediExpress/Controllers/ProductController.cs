using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MediExpress.Controllers
{
    public class ProductController : ApiController
    {
        [HttpGet]
        [Route("api/products")]
        public HttpResponseMessage Products()
        {
           try
            {
                var data = ProductService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex) 
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
             
        }

        [HttpGet]
        [Route("api/products/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = ProductService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }
        //Get Product with Reviews
        [HttpGet]
        [Route("products/{id}/reviews")]
        public HttpResponseMessage ProductsWithReview(int ProductID)
        {
            try
            {
                var data = ProductService.GetProductWithReview(ProductID);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/reviews")]
        public HttpResponseMessage ProductReview()
        {
            try
            {
                var data = ProductReviewService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }

        }
    }
}
