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
    public class UsersController : ApiController
    {
        // GET: api/Users
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/Users/5
        public HttpResponseMessage Get(string user, string password)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    RepositorioUser repUser = new RepositorioUser();
                    return Request.CreateResponse(HttpStatusCode.OK, repUser.Get(user, password), new HttpConfiguration());
                }
                else
                    return Request.CreateResponse(HttpStatusCode.NotAcceptable, "Falta de dados na requisição.", new HttpConfiguration());
            }
            catch (HttpResponseException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        // POST: api/Users
        public HttpResponseMessage Post([FromBody]Users user )

        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositorioUser repUser = new RepositorioUser();
                    return Request.CreateResponse(HttpStatusCode.OK, repUser.Insert(user), new HttpConfiguration());
                }
                else
                    return Request.CreateResponse(HttpStatusCode.NotAcceptable, "Falta de dados na requisição.", new HttpConfiguration());
            }
            catch (HttpResponseException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }        

        // PUT: api/Users/5
        public HttpResponseMessage Put([FromBody]Users user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositorioUser repUser = new RepositorioUser();
                    return Request.CreateResponse(HttpStatusCode.OK, repUser.Insert(user), new HttpConfiguration());
                }
                else
                    return Request.CreateResponse(HttpStatusCode.NotAcceptable, "Falta de dados na requisição.", new HttpConfiguration());
            }
            catch (HttpResponseException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}
