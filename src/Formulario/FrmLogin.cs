using System;
using System.Windows.Forms;

namespace NetZ.Cargo.Formulario
{
    public partial class FrmLogin : FrmBase
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.entrar();
        }

        private void entrar()
        {
            var login = this.cmpLogin.Valor;
            var senha = this.cmpSenha.Valor;

            if (login == "admin" && senha == "senha")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Informações de login inválidas.");
            }
        }
    }
}