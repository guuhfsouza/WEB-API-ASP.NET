﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GerenciamentoSalaoEntities : DbContext
    {
        public GerenciamentoSalaoEntities()
            : base("name=GerenciamentoSalaoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Agenda> Agenda { get; set; }
        public virtual DbSet<Caixa> Caixa { get; set; }
        public virtual DbSet<Comissao> Comissao { get; set; }
        public virtual DbSet<ConfigSis> ConfigSis { get; set; }
        public virtual DbSet<Corte> Corte { get; set; }
        public virtual DbSet<ItemVenda> ItemVenda { get; set; }
        public virtual DbSet<Lancamentos> Lancamentos { get; set; }
        public virtual DbSet<LogEventos> LogEventos { get; set; }
        public virtual DbSet<NotificaPagamento> NotificaPagamento { get; set; }
        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Venda> Venda { get; set; }
    }
}