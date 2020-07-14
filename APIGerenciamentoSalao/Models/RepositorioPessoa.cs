using APIGerenciamentoSalao.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIGerenciamentoSalao.Models
{
    public class RepositorioPessoa : IPessoaRepositorio
    {
        public IEnumerable<Pessoa> Get()
        {
            GerenciamentoSalaoEntities bd = new GerenciamentoSalaoEntities();
            List<Pessoa> listaPessoa = bd.Pessoa.OrderBy(s => s.nm_pessoa).ToList();
            return listaPessoa;
        }

        public List<Pessoa> Get(string CPF)
        {
            if(CPF.Trim() == "")
                throw new NotImplementedException();
            else
            {
                GerenciamentoSalaoEntities bd = new GerenciamentoSalaoEntities();
                List<Pessoa> listaPessoa = bd.Pessoa.Where(s => s.cpf.Contains(CPF)).ToList();
                return listaPessoa;
            }
        }

        public Pessoa Create(Pessoa pessoa)
        {
            if (pessoa == null)
                throw new NotImplementedException();
            else
            {
                bool validacao = CheckSetPessoa(pessoa.cpf);
                if (validacao)
                {
                    GerenciamentoSalaoEntities bd = new GerenciamentoSalaoEntities();
                    bd.Pessoa.Add(pessoa);
                    bd.SaveChanges();
                    return pessoa;
                }
                else
                {
                    return null;
                }
            }
        }

        private bool CheckSetPessoa(string cpf)
        {
            bool retorno = false;
            GerenciamentoSalaoEntities bd = new GerenciamentoSalaoEntities();
            var check = Get(cpf);
            if (check.Count == 0)
                retorno = true;
            return retorno;
        }

        public Pessoa Update(Pessoa pessoa)
        {
            if(pessoa == null)
                throw new NotImplementedException();
            else
            {
                GerenciamentoSalaoEntities bd = new GerenciamentoSalaoEntities();
                Pessoa pessoaUpdate = bd.Pessoa.Single(s => s.cpf == pessoa.cpf);
                pessoaUpdate.cpf = pessoa.cpf;
                pessoaUpdate.funcionario = pessoa.funcionario;
                pessoaUpdate.nm_pessoa = pessoa.nm_pessoa;
                pessoaUpdate.telefone = pessoa.telefone;
                bd.SaveChanges();
                return pessoaUpdate;
            }
        }
    }
}