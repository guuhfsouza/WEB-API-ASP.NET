using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APIGerenciamentoSalao.DataBase;

namespace APIGerenciamentoSalao.Models
{
    public class RepositorioPeople : IPeopleRepositorio
    {
        public IEnumerable<People> Get()
        {
            throw new NotImplementedException();
        }

        public List<People> Get(string cpf)
        {
            if (cpf == "")
                throw new NotImplementedException();
            else
            {
                agendaonline1Entities bd = new agendaonline1Entities();
                var people = bd.People.Where(s => s.cpf.Equals(cpf)).ToList();
                if (people.Count > 0)
                    return people;
                else
                    return people;
            }
        }

        public People Insert(People people)
        {
            if(people == null)
                throw new NotImplementedException();
            else
            {

                var valida = this.Get(people.cpf);
                if (valida.Count == 0)
                {
                    agendaonline1Entities bd = new agendaonline1Entities();
                    bd.People.Add(people);
                    bd.SaveChanges();
                    return people;
                }
                else
                    return null;
                
            }
        }

        public People Update(People people)
        {
            if(people == null)
                throw new NotImplementedException();
            else
            {
                agendaonline1Entities bd = new agendaonline1Entities();
                People peopleUpdate = bd.People.Single(s => s.cpf == people.cpf);
                peopleUpdate.city = people.city;
                peopleUpdate.cpf = people.cpf;
                peopleUpdate.email = people.email;
                peopleUpdate.name = people.name;
                peopleUpdate.phone = people.phone;
                peopleUpdate.uf = people.uf;
                bd.SaveChanges();
                return people;
            }
        }
    }
}