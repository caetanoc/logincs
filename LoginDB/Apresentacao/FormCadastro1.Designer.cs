
namespace LoginDB.Apresentacao
{
    partial class FormCadastro1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuarioCad = new System.Windows.Forms.TextBox();
            this.txtSenha1 = new System.Windows.Forms.TextBox();
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(257, 269);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(161, 123);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 13);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirmar Senha";
            // 
            // txtUsuarioCad
            // 
            this.txtUsuarioCad.Location = new System.Drawing.Point(257, 123);
            this.txtUsuarioCad.Name = "txtUsuarioCad";
            this.txtUsuarioCad.Size = new System.Drawing.Size(239, 20);
            this.txtUsuarioCad.TabIndex = 4;
            // 
            // txtSenha1
            // 
            this.txtSenha1.Location = new System.Drawing.Point(257, 170);
            this.txtSenha1.Name = "txtSenha1";
            this.txtSenha1.PasswordChar = '*';
            this.txtSenha1.Size = new System.Drawing.Size(239, 20);
            this.txtSenha1.TabIndex = 5;
            // 
            // txtSenha2
            // 
            this.txtSenha2.Location = new System.Drawing.Point(257, 211);
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.PasswordChar = '*';
            this.txtSenha2.Size = new System.Drawing.Size(239, 20);
            this.txtSenha2.TabIndex = 6;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(438, 268);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 7;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // FormCadastro1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.txtSenha2);
            this.Controls.Add(this.txtSenha1);
            this.Controls.Add(this.txtUsuarioCad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "FormCadastro1";
            this.Text = "FormCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuarioCad;
        private System.Windows.Forms.TextBox txtSenha1;
        private System.Windows.Forms.TextBox txtSenha2;
        private System.Windows.Forms.Button btnRemover;
    }
}