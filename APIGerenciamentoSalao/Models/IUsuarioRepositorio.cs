using APIGerenciamentoSalao.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIGerenciamentoSalao.Models
{
    public interface IUsuarioRepositorio
    {
        IEnumerable<Usuario> GetUsuario();
        List<Usuario> GetUsuario(string nome, string senha);
        Usuario Insert(Usuario usuario);
        Usuario Update(Usuario usuario);
    }
}
