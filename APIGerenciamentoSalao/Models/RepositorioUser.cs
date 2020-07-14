using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APIGerenciamentoSalao.DataBase;

namespace APIGerenciamentoSalao.Models
{
    public class RepositorioUser : IUserRepositorio
    {
        public Users Get(string user, string password)
        {
            if(user == "" && password == "")
                throw new NotImplementedException();
            else
            {
                agendaonline1Entities bd = new agendaonline1Entities();
                var aut = bd.Users.FirstOrDefault(s => s.email == user && s.password == password);
                return aut;
            }
        }

        public Users Insert(Users user)
        {
            DateTime date = Convert.ToDateTime(user.created_At);
            if(user == null)
                throw new NotImplementedException();
            else
            {
                agendaonline1Entities bd = new agendaonline1Entities();
                user.created_At = date;

                try
                {
                    bd.Users.Add(user);
                    bd.SaveChanges();
                    return user;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public Users Update(Users user)
        {
            throw new NotImplementedException();
        }
    }
}