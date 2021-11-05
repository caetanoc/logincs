using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginDB.Apresentacao;
using LoginDB.Controle;

namespace LoginDB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //ir ate o banco de dados.
            // checar se usuario e senha estão válidos.
            // se sim =>  apresentar tela de boas vindas/ perfil
            // se não =>  mostrar mensagem de erro.

            // vamos fazer mockado.  mock

            Controle1 ctl = new Controle1();
            

            if (ctl.Acessar(txtUsuario.Text, txtSenha.Text))
            {
                // MessageBox.Show("Bem vind@" + txtUsuario.Text);

                FormPrincipal formPrincipal = new FormPrincipal();
                formPrincipal.Show();
            }
            else MessageBox.Show("Acesso negado. Usuario ou senha invalid@ " + ctl.mensagem);


        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            FormCadastro1 cadastro = new FormCadastro1();
            cadastro.Show();
        }
    }
}
