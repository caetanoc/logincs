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


    }
}
