//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIGerenciamentoSalao.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Agenda
    {
        public int idAgenda { get; set; }
        public int idPessoa { get; set; }
        public int idFuncionario { get; set; }
        public int idServico { get; set; }
        public System.DateTime dataAgendada { get; set; }
        public string horaAgendada { get; set; }
    }
}