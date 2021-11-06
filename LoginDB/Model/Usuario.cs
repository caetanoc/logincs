using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDB.Model
{
    class Usuario
    {
        public string Username { get; set; }
        public string Password { get; set; }

        private static string error = "Usuario nao existe!";
        public static void ShowError()
        {
            System.Windows.Forms.MessageBox.Show(error);
        }

        public static bool Comparar(Usuario user1, Usuario user2)
        {
            if (user1 == null || user2 == null) { return false; }

            if (user1.Username != user2.Username)
            {
                error = "Usuário não existe!";
                return false;
            }

            else if (user1.Password != user2.Password)
            {
                error = "Usuário ou senha inválidos";
                return false;
            }

            return true;
        }


    }
}
