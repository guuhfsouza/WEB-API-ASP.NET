using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APIGerenciamentoSalao.DataBase;

namespace APIGerenciamentoSalao.Models
{
    public class RepositorioSchedule : IScheduleRepositorio
    {

        public IEnumerable<Schedule> Get()
        {
            throw new NotImplementedException();
        }

        public List<Schedule> Get(string var, string data)
        {
            if(var == "")
                throw new NotImplementedException();
            else
            {
                DateTime date = DateTime.Parse(data);
                agendaonline1Entities bd = new agendaonline1Entities();
                var schedule = (from p in bd.People
                                join s in bd.Schedule on p.idPeople equals s.idPeople
                                where (p.cpf == var || p.name.Contains(var))// && s.date == date
                                select new
                                {
                                    s
                                }).ToList();

                List<Schedule> schedulesFinal = new List<Schedule>();

                foreach(var list in schedule)
                {
                    Schedule s = new Schedule();
                    s.client = list.s.client;
                    s.date = list.s.date;
                    s.idPeople = list.s.idPeople;
                    s.idSchedule = list.s.idSchedule;
                    s.idService = list.s.idService;
                    s.status = list.s.status;
                    schedulesFinal.Add(s);
                }

                return schedulesFinal;
            }
        }

        public Schedule Insert(Schedule schedule)
        {
            if(schedule == null)
                throw new NotImplementedException();
            else
            {
                agendaonline1Entities bd = new agendaonline1Entities();
                bd.Schedule.Add(schedule);
                bd.SaveChanges();
                return schedule;
            }
        }

        public Schedule Update(Schedule schedule)
        {
            if (schedule == null)
                throw new NotImplementedException();
            else
            {
                agendaonline1Entities bd = new agendaonline1Entities();
                var scheduleUpdate = bd.Schedule.Single(s => s.idSchedule == schedule.idSchedule);
                scheduleUpdate = schedule;
                bd.SaveChanges();
                return schedule;
            }
        }

        public Schedule UpdateStatus(int id)
        {
            if (id <= 0)
                throw new NotImplementedException();
            else
            {
                agendaonline1Entities bd = new agendaonline1Entities();
                var scheduleUpdate = bd.Schedule.SingleOrDefault(s => s.idSchedule == id);
                if (scheduleUpdate != null)
                {
                    scheduleUpdate.status = "Fechado";
                    bd.SaveChanges();
                    return scheduleUpdate;
                }
                else
                    return null;
            }
        }

    }
}