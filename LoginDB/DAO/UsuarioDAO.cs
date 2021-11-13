using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginDB.Model;

namespace LoginDB.DAO
{
    class UsuarioDAO
    {

        public bool temAcesso = false;
        SqlCommand cmd = new SqlCommand();
        Conexao conecta = new Conexao();
        public String mensagem = "";


        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "XBYdh465vhnBfrFPZJqUUTVWIL6PsF5Rl8cFRBUd",
            BasePath = "https://fireapp-d4454-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        public string CadastrarLoginFire(string login, string senha)
        {

            try
            {
                client = new FireSharp.FirebaseClient(ifc);

                Usuario user = new Usuario()
                {
                    Username = login,
                    Password = senha
                };

                SetResponse set = client.Set(@"Users/" + login, user);

                mensagem = "Cadastrad@ com sucesso!";
            }

            catch (Exception e)
            {
                mensagem = "Sem conexão com internet! " + e.Message;
            }

            return mensagem;
        }

        public bool VerificarLoginFire(String login, String senha)
        {

            try
            {
                client = new FireSharp.FirebaseClient(ifc);

                Usuario userForm = new Usuario()
                {
                    Username = login,
                    Password = senha
                };

                FirebaseResponse res = client.Get(@"Users/" + login);
                Usuario userNuvem = res.ResultAs<Usuario>();

                return (Usuario.Comparar(userNuvem, userForm));

            }

            catch (Exception e)
            {
                mensagem = "Sem conexão com internet! " + e.Message;
                return false;
            }

        }

        internal string RemoverLoginFire(string login)
        {

            try
            {
                client = new FireSharp.FirebaseClient(ifc);
                client.Delete(@"Users/" + login);

                mensagem = "Removid@ com sucesso!";
            }

            catch (Exception e)
            {
                mensagem = "Erro ao acessar Firebase! " + e.Message;
            }

            return mensagem;
        }



            public bool VerificarLogin(String email, String senha)
        {
            cmd.CommandText = "select * from usuario where email = '" + email + "' and senha = '" + senha + "'";

            try
            {
                cmd.Connection = conecta.Conectar();
                SqlDataReader dados = cmd.ExecuteReader();
                temAcesso = dados.HasRows;
            }
            catch (SqlException e)
            {
                mensagem = e.Message + " LoginDB.DAO.VerificarLogin()";
            }
            finally
            {
                conecta.Desconectar();
            }

            return temAcesso;
        }

        internal string RemoverLogin(string login)
        {
            cmd.CommandText = "delete from dbo.usuario where email = '" + login + "';";
            cmd.Connection = conecta.Conectar();
            try
            {
                int linhas = cmd.ExecuteNonQuery();
                mensagem = " removido com sucesso!";
            }
            catch (SqlException e)
            {
                mensagem = e.Message;
                //throw new Exception(e.Message);
            }
            finally
            {
                conecta.Desconectar();
            }

            return mensagem;
        }

        internal string CadastrarLogin(string login, string senha)
        {
            cmd.CommandText = "insert into dbo.usuario (email,senha) values ('" + login + "' , '" + senha + "');";
            cmd.Connection = conecta.Conectar();
            try
            {
                int linhas = cmd.ExecuteNonQuery();
                mensagem = " inserido com sucesso!";
            }
            catch (SqlException e)
            {
                mensagem = e.Message;
                //throw new Exception(e.Message);
            }
            finally
            {
                conecta.Desconectar();
            }

            return mensagem;
        }

    }
}
