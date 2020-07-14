using APIGerenciamentoSalao.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIGerenciamentoSalao.Models
{
    public interface IPessoaRepositorio
    {
        IEnumerable<Pessoa> Get();
        List<Pessoa> Get(string CPF);
        Pessoa Create(Pessoa pessoa);
        Pessoa Update(Pessoa pessoa);
    }
}