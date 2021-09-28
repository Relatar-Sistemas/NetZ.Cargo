using NetZ.Cargo.Controlador;
using NetZ.Cargo.Modelo;
using System;

namespace NetZ.Cargo.Formulario.Cadastro
{
    public partial class FrmCadastroBase : FrmBase
    {
        private string id;

        public FrmCadastroBase(string id = default)
        {
            this.id = id;
            InitializeComponent();
        }

        protected virtual ModeloBase carregarModelo()
        {
            throw new NotImplementedException();
        }

        protected virtual ControladorBase getControlador()
        {
            throw new NotImplementedException();
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            this.salvar();
        }

        private void salvar()
        {
            var modelo = this.carregarModelo();
            modelo.id = this.id;
            var controlador = this.getControlador();
            var tabela = controlador.getTabela();
            tabela.salvar(modelo);
            this.Close();
        }
    }
}