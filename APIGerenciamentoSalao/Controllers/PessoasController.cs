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
    public class PessoasController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Get()
        {
            if(ModelState.IsValid)
            {
                RepositorioPessoa repPessoa = new RepositorioPessoa();
                return Request.CreateResponse(HttpStatusCode.OK, repPessoa.Get(), new HttpConfiguration());
            }
            else
                return Request.CreateResponse(HttpStatusCode.OK, "Falta de Informações na request.", new HttpConfiguration());
        }

        public HttpResponseMessage Get([FromUri]string cpf)
        {
            if (ModelState.IsValid)
            {
                RepositorioPessoa repPessoa = new RepositorioPessoa();
                return Request.CreateResponse(HttpStatusCode.OK, repPessoa.Get(cpf), new HttpConfiguration());
            }
            else
                return Request.CreateResponse(HttpStatusCode.OK, "Falta de Informações na request.", new HttpConfiguration());
        }

        [HttpPost]
        public HttpResponseMessage Create([FromBody]Pessoa pessoa)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositorioPessoa repoPessoa = new RepositorioPessoa();
                    return Request.CreateResponse(HttpStatusCode.OK, repoPessoa.Create(pessoa), new HttpConfiguration());
                }
                else
                    return Request.CreateResponse(HttpStatusCode.NotAcceptable, "Falta de Informações na request.", new HttpConfiguration());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotAcceptable, ex);
            }
        }

        [HttpPut]
        public HttpResponseMessage Put(int id, [FromBody]Pessoa pessoa)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositorioPessoa repPessoa = new RepositorioPessoa();
                    return Request.CreateResponse(HttpStatusCode.OK, repPessoa.Update(pessoa), new HttpConfiguration());
                }
                else
                    return Request.CreateResponse(HttpStatusCode.NotAcceptable, "Falta de informações na request.", new HttpConfiguration());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}
