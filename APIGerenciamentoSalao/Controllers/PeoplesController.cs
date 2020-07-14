using APIGerenciamentoSalao.DataBase;
using APIGerenciamentoSalao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIGerenciamentoSalao.Controllers
{

    [RoutePrefix("api/Peoples")]
    public class PeoplesController : ApiController
    {
        // GET: api/Peoples
        public IEnumerable<People> Get()
        {
            return null;
        }

        [Route("By-CPF")]
        public HttpResponseMessage Get(string cpf)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositorioPeople repPeople = new RepositorioPeople();
                    return Request.CreateResponse(HttpStatusCode.OK, repPeople.Get(cpf), new HttpConfiguration());
                }
                else
                    return Request.CreateResponse(HttpStatusCode.NotAcceptable, "Falta de dados na requisição.", new HttpConfiguration());

            }
            catch (HttpRequestException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        // POST: api/Peoples
        public HttpResponseMessage Post([FromBody]People people)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    RepositorioPeople repPeople = new RepositorioPeople();
                    var retorno = Request.CreateResponse(HttpStatusCode.OK, repPeople.Insert(people), new HttpConfiguration());
                    if (retorno == null)
                        return Request.CreateResponse(HttpStatusCode.NotAcceptable, "CPF já cadastrado.", new HttpConfiguration());
                    else
                        return retorno;
                }
                else
                    return Request.CreateResponse(HttpStatusCode.NotAcceptable
                        , "Falta de dados na requisição.", new HttpConfiguration());
            }
            catch (HttpResponseException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        // PUT: api/Peoples/5
        public HttpResponseMessage Put([FromBody]People people)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositorioPeople repPeople = new RepositorioPeople();
                    return Request.CreateResponse(HttpStatusCode.OK, repPeople.Update(people), new HttpConfiguration());
                }
                else
                    return Request.CreateResponse(HttpStatusCode.NotAcceptable
                        , "Falta de dados na requisição.", new HttpConfiguration());
            }
            catch (HttpResponseException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

    }
}
