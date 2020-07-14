using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APIGerenciamentoSalao.DataBase;

namespace APIGerenciamentoSalao.Models
{
    public class RepositorioUsuario : IUsuarioRepositorio
    {
        public IEnumerable<Usuario> GetUsuario()
        {
            throw new NotImplementedException();
        }

        public List<Usuario> GetUsuario(string usuario, string senha)
        {
            throw new NotImplementedException();
        }

        public Usuario Insert(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Usuario Update(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        #region Valida primeiro acesso 
        // Validar uma forma de devolver a informação de senha
        //private void FirstAceess(string usuarios, string senha)
        //{
        //    if (senha == "123456")
        //    {
        //        GerenciamentoSalaoEntities bd = new GerenciamentoSalaoEntities();
        //        Usuario usuario = new Usuario();

        //        string novasenha = Microsoft.VisualBasic.Interaction.InputBox("Digite a senha:", "Nova Senha:"); // validar a funcionalidade


        //        //atualização de senha 
        //        var atualizasenha = bd.Usuario.Where(s => s.usuario1 == usuarios && s.senha == senha).ToList();
        //        foreach (var list in atualizasenha)
        //        {
        //            atualizasenha = bd.Usuario.Where(s => s.idUsuario == list.idUsuario).ToList();
        //            list.senha = novasenha;
        //        }
        //        bd.SaveChanges();

        //        //valida a senha com o usuário no banco
        //        getUsuario(user, novasenha);
        //    }
        //}
        #endregion 
    }
}