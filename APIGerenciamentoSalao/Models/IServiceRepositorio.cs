using APIGerenciamentoSalao.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIGerenciamentoSalao.Models
{
    public interface IServiceRepositorio
    {
        IEnumerable<Service> Get(string cpfStore);
        List<Service> Get(string cpfStore, string service, string status);
        Service Inset(Service service);
        Service Update(Service service);
    }
}
