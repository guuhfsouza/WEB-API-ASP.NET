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
    
    public partial class Produto
    {
        public int idProduto { get; set; }
        public string nm_produto { get; set; }
        public string categoria { get; set; }
        public double quantAntiga { get; set; }
        public double quantAtual { get; set; }
        public double valorAntigo { get; set; }
        public double valorAtual { get; set; }
        public string ativo { get; set; }
    }
}