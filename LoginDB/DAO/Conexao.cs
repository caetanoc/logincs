using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDB.DAO
{
    
    class Conexao
    {
        private SqlConnection conecta = new SqlConnection();

        public Conexao()
        {
            this.conecta.ConnectionString = @"Data Source=DESKTOP-8B5GH3P;Initial Catalog=DS1AV4;Persist Security Info=True;User ID=sa;Password=etec";
        }

        public SqlConnection Conectar()
        {
            if (conecta.State == System.Data.ConnectionState.Closed) conecta.Open();
            return conecta;
        }

        public void Desconectar()
        {
            if (conecta.State == System.Data.ConnectionState.Open) conecta.Close();
        }

    }
}
