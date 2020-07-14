using APIGerenciamentoSalao.DataBase;
using APIGerenciamentoSalao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace APIGerenciamentoSalao.Controllers
{
    [EnableCors(origins:"*", headers:"*", methods:"*"), RoutePrefix("api/Services")]
    public class ServicesController : ApiController
    {
        public HttpResponseMessage Get(string cpfStore)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    RepositorioService repService = new RepositorioService();
                    return Request.CreateResponse(HttpStatusCode.OK, repService.Get(cpfStore), new HttpConfiguration());
                }
                else
                    return Request.CreateResponse(HttpStatusCode.NotAcceptable, "Falta de informações na requisição.", new HttpConfiguration());
            }
            catch (HttpRequestException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [Route("By-Service")]
        public HttpResponseMessage Get(string cpfStore, string service, string status)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositorioService repService = new RepositorioService();
                    return Request.CreateResponse(HttpStatusCode.OK, repService.Get(cpfStore, service, status), new HttpConfiguration());
                }
                else
                    return Request.CreateResponse(HttpStatusCode.NotAcceptable, "Falta de informações na requisição.", new HttpConfiguration());
            }
            catch (HttpRequestException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        public HttpResponseMessage Post([FromBody]Service service)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositorioService repService = new RepositorioService();
                    return Request.CreateResponse(HttpStatusCode.OK, repService.Inset(service), new HttpConfiguration());
                }
                else
                    return Request.CreateResponse(HttpStatusCode.NotAcceptable, "Falta de informações na requisição.", new HttpConfiguration());
            }
            catch (HttpRequestException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        public HttpResponseMessage Put([FromBody]Service service)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositorioService repService = new RepositorioService();
                    return Request.CreateResponse(HttpStatusCode.OK, repService.Update(service), new HttpConfiguration());
                }
                else
                    return Request.CreateResponse(HttpStatusCode.NotAcceptable, "Falta de informações na requisição.", new HttpConfiguration());
            }
            catch (HttpRequestException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}
