using NetZ.Cargo.Formulario.Cadastro;
using NetZ.Cargo.Tabela;

namespace NetZ.Cargo.Controlador
{
    internal class FabricanteControlador : ControladorBase
    {
        internal override string getConsultaTitulo()
        {
            return "Consulta de fabricantes";
        }

        internal override FrmCadastroBase getFrmCadatro()
        {
            return new FrmFabricanteCadastro();
        }

        internal override TabelaBase getTabela()
        {
            return new TblFabricante();
        }
    }
}