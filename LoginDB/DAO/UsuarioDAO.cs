using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDB.DAO
{
    class UsuarioDAO
    {

        public bool temAcesso = false;
        SqlCommand cmd = new SqlCommand();
        Conexao conecta = new Conexao();
        public String mensagem = "";

        public bool VerificarLogin(String email, String senha)
        {
            cmd.CommandText = "select * from usuario where email = '"+email+"' and senha = '"+senha+"'";
            
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
                mensagem =  " inserido com sucesso!";
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
