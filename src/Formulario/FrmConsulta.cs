using NetZ.Cargo.Controlador;
using System;

namespace NetZ.Cargo.Formulario
{
    public partial class FrmConsulta : FrmBase
    {
        private readonly ControladorBase controlador;

        public FrmConsulta(ControladorBase controlador)
        {
            this.controlador = controlador;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            this.Text = this.controlador.getConsultaTitulo();
            this.carregarLista();
        }

        private void abrirCadastro()
        {
            var frmCadastro = this.controlador.getFrmCadatro();
            frmCadastro.ShowDialog();
        }

        private void alterar()
        {
            throw new NotImplementedException();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            this.abrirCadastro();
            this.carregarLista();
        }

        private void carregarLista()
        {
            this.listBox.Items.Clear();
            var tabela = this.controlador.getTabela();
            var lista = tabela.getLista();

            if (lista == null)
            {
                return;
            }

            foreach (var item in lista)
            {
                this.listBox.Items.Add(item);
            }
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            this.alterar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.alterar();
        }
    }
}