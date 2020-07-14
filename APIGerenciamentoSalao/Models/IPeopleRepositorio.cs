using APIGerenciamentoSalao.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIGerenciamentoSalao.Models
{
    public interface IPeopleRepositorio
    {
        IEnumerable<People> Get();
        List<People> Get(string cpf);
        People Insert(People people);
        People Update(People people);
    }
}
