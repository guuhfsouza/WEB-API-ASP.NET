using APIGerenciamentoSalao.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIGerenciamentoSalao.Models
{
    public interface IUserRepositorio
    {
        Users Get(string user, string password);
        Users Insert(Users user);
        Users Update(Users user);
    }
}
