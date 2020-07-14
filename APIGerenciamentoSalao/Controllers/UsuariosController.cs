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
    public class UsuariosController : ApiController
    {
        public HttpResponseMessage Get()
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositorioUsuario repUsuario = new RepositorioUsuario();
                    return Request.CreateResponse(HttpStatusCode.OK, repUsuario.GetUsuario(), new HttpConfiguration());
                } 
                else
                    return Request.CreateResponse(HttpStatusCode.NotAcceptable, "Falta de informaões.", new HttpConfiguration());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        public HttpResponseMessage Get([FromBody]string usuario, [FromBody] string senha)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    RepositorioUsuario repUsuario = new RepositorioUsuario();
                    return Request.CreateResponse(HttpStatusCode.OK, repUsuario.GetUsuario(usuario, senha), new HttpConfiguration());
                }
                else
                    return Request.CreateResponse(HttpStatusCode.NotAcceptable, "Falta de informações na requisição.", new HttpConfiguration());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        public HttpResponseMessage Post([FromBody]Usuario usuario )
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositorioUsuario repUsuario = new RepositorioUsuario();
                    return Request.CreateResponse(HttpStatusCode.OK, repUsuario.Insert(usuario), new HttpConfiguration());
                }
                else
                    return Request.CreateResponse(HttpStatusCode.NotAcceptable, "Falta de informações.", new HttpConfiguration());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        public HttpResponseMessage Put(int id, [FromBody]Usuario usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositorioUsuario repUsuario = new RepositorioUsuario();
                    return Request.CreateResponse(HttpStatusCode.OK, repUsuario.Update(usuario), new HttpConfiguration());
                }
                else
                    return Request.CreateResponse(HttpStatusCode.NotAcceptable, "Falta de informações.", new HttpConfiguration());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}
