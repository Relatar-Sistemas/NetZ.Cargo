using NetZ.Cargo.Formulario.Cadastro;
using NetZ.Cargo.Tabela;

namespace NetZ.Cargo.Controlador
{
    internal class ViagemControlador : ControladorBase
    {
        internal override string getConsultaTitulo()
        {
            return "Consulta de viagens";
        }

        internal override FrmCadastroBase getFrmCadatro()
        {
            return new FrmViagemCadastro();
        }

        internal override TabelaBase getTabela()
        {
            return new TblViagem();
        }
    }
}