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
    [RoutePrefix("api/Schedules")]
    public class SchedulesController : ApiController
    {
        [Route("All")]
        public HttpResponseMessage Get()
        {
            return null;
        }

        [Route("Agenda-Dia")]
        public HttpResponseMessage Get(string var, string data)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositorioSchedule repSchedule = new RepositorioSchedule();
                    return Request.CreateResponse(HttpStatusCode.OK, repSchedule.Get(var, data), new HttpConfiguration());
                }
                else
                    return Request.CreateResponse(HttpStatusCode.NotAcceptable, "Falta de dados na requisição", new HttpConfiguration());
            }
            catch (HttpRequestException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        
        public HttpResponseMessage Post([FromBody]Schedule schedule)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositorioSchedule repSchedule = new RepositorioSchedule();
                    return Request.CreateResponse(HttpStatusCode.OK, repSchedule.Insert(schedule), new HttpConfiguration());
                }
                else
                    return Request.CreateResponse(HttpStatusCode.NotAcceptable, "Falta de dados na requisição.", new HttpConfiguration());
            }
            catch (HttpRequestException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        
        public HttpResponseMessage Put([FromBody]Schedule schedule)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositorioSchedule repSchedule = new RepositorioSchedule();
                    return Request.CreateResponse(HttpStatusCode.OK, repSchedule.Update(schedule), new HttpConfiguration());
                }
                else
                    return Request.CreateResponse(HttpStatusCode.NotAcceptable, "Falta de dados na requisição.", new HttpConfiguration());
            }
            catch (HttpRequestException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [Route("Encerrar")]
        public HttpResponseMessage Put(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositorioSchedule repSchedule = new RepositorioSchedule();
                    return Request.CreateResponse(HttpStatusCode.OK, repSchedule.UpdateStatus(id), new HttpConfiguration());
                }
                else
                    return Request.CreateResponse(HttpStatusCode.NotAcceptable, "Falta de dados na requisição.", new HttpConfiguration());
            }
            catch (HttpRequestException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}
