using NetZ.Cargo.Controlador;
using System;

namespace NetZ.Cargo.Formulario
{
    public partial class FrmPrincipal : FrmBase
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void abrirConsulta(ControladorBase controlador)
        {
            var frmConsulta = new FrmConsulta(controlador);
            frmConsulta.ShowDialog();
        }

        private void fabricantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.abrirConsulta(new FabricanteControlador());
        }

        private void motoristasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.abrirConsulta(new MotoristaControlador());
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sobreOSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Abrir o formulário sobre o sistema.
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.abrirConsulta(new UsuarioControlador());
        }

        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.abrirConsulta(new VeiculoControlador());
        }

        private void viagensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.abrirConsulta(new ViagemControlador());
        }
    }
}