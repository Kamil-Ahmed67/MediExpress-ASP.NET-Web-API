using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MediExpress.Controllers
{
    public class CustomerController : ApiController
    {
        /*[HttpGet]
        [Route("api/Order")]
        public HttpResponseMessage AddOrder(int id)
        {
            try
            {
                var data = OrderService.AddOrder(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }

        }
        [HttpGet]
        [Route("customers/{uname}")]
        public HttpResponseMessage Get(string uname)
        {
            try
            {
                var data = CustomerService.Get(uname);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }
        [HttpGet]
        [Route("customers/{uname}/address")]
        public HttpResponseMessage CustomerWithAddress(string uname)
        {
            try
            {
                var data = CustomerService.GetWithAddress(uname);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }
        //Get Customer with Orders
        [HttpGet]
        [Route("customers/{uname}/orders")]
        public HttpResponseMessage CustomerWithOrders(string uname)
        {
            try
            {
                var data = CustomerService.GetOrderInfo(uname);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }*/
    }
}
