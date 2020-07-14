using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using APIGerenciamentoSalao.DataBase;

namespace APIGerenciamentoSalao.Models
{
    public class RepositorioService : IServiceRepositorio
    {
        public IEnumerable<Service> Get(string cpfStore)
        {
            if(cpfStore == "")
                throw new NotImplementedException();
            else
            {
                agendaonline1Entities bd = new agendaonline1Entities();
                var servicesList = bd.Service.Where(s => s.cpfStore == cpfStore).ToList();
                return servicesList;
            }
        }

        public List<Service> Get(string cpfStore, string service, string status)
        {
            if ((cpfStore == "" && service == "") || (cpfStore == "" && status == ""))
                throw new NotImplementedException();
            else
            {
                agendaonline1Entities bd = new agendaonline1Entities();
                var servicesList = bd.Service.Where(s => s.cpfStore == cpfStore && s.service1 == service ||
                s.cpfStore == cpfStore && s.ative.Trim() == status.Trim()).ToList();
                return servicesList;
            }
        }

        public Service Inset(Service service)
        {
            if(service == null)
                throw new NotImplementedException();
            else
            {
                try
                {
                    service.ative = service.ative.Trim();

                    agendaonline1Entities bd = new agendaonline1Entities();
                    bd.Service.Add(service);
                    bd.SaveChanges();
                    return service;
                }
                catch( Exception ex)
                {
                    throw ex;
                }
            }
        }

        public Service Update(Service service)
        {
            if (service == null)
                throw new NotImplementedException();
            else
            {M
                try
                {
                    agendaonline1Entities bd = new agendaonline1Entities();
                    var serviceUpdate = bd.Service.Single(s => s.idService == service.idService);
                    serviceUpdate.ative = service.ative;
                    serviceUpdate.cpfStore = service.cpfStore;
                    serviceUpdate.price = service.price;
                    serviceUpdate.service1 = service.service1;
                    bd.SaveChanges();
                    return service;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}