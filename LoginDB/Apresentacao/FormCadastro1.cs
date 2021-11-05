using LoginDB.Controle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginDB.Apresentacao
{
    public partial class FormCadastro1 : Form
    {

        private Controle1 ctl;

        public FormCadastro1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtSenha1.Text != txtSenha2.Text)
            {
                MessageBox.Show("As senhas não conferem!");
                return;
            }

            ctl = new Controle1();
            string mensagem = ctl.Cadastrar(txtUsuarioCad.Text, txtSenha1.Text);

            MessageBox.Show(mensagem);
            this.Close();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            ctl = new Controle1();
            string mensagem = ctl.Remover(txtUsuarioCad.Text);

            MessageBox.Show(mensagem);
            this.Close();


        }
    }
}
