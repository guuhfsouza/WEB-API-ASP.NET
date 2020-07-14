using APIGerenciamentoSalao.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace APIGerenciamentoSalao.Models
{
    public interface IScheduleRepositorio
    {
        IEnumerable<Schedule> Get();
        List<Schedule> Get(string var, string data);
        Schedule Insert(Schedule schedule);
        Schedule Update(Schedule schedule);
    }
}
