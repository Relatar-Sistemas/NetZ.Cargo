using NetZ.Cargo.Formulario.Cadastro;
using NetZ.Cargo.Tabela;

namespace NetZ.Cargo.Controlador
{
    internal class VeiculoControlador : ControladorBase
    {
        internal override string getConsultaTitulo()
        {
            return "Consulta de veículos";
        }

        internal override FrmCadastroBase getFrmCadatro()
        {
            return new FrmVeiculoCadastro();
        }

        internal override TabelaBase getTabela()
        {
            return new TblVeiculo();
        }
    }
}