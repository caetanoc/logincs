using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginDB.DAO;

namespace LoginDB.Controle
{
    class Controle1
    {
        private bool temAcesso = false;
        public String mensagem = ""; 


        public bool Acessar(String email, String senha)
        {
            UsuarioDAO usuario = new UsuarioDAO();
            temAcesso = usuario.VerificarLogin(email, senha);

            if (!usuario.mensagem.Equals("")) mensagem = usuario.mensagem;

            return temAcesso;
           
        }


    }
}
