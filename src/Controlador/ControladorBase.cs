using NetZ.Cargo.Formulario.Cadastro;
using NetZ.Cargo.Tabela;

namespace NetZ.Cargo.Controlador
{
    public abstract class ControladorBase
    {
        internal abstract string getConsultaTitulo();

        internal abstract FrmCadastroBase getFrmCadatro();

        internal abstract TabelaBase getTabela();
    }
}