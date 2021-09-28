using NetZ.Cargo.Formulario.Cadastro;
using NetZ.Cargo.Tabela;

namespace NetZ.Cargo.Controlador
{
    internal class MotoristaControlador : ControladorBase
    {
        internal override string getConsultaTitulo()
        {
            return "Consulta de motoristas";
        }

        internal override FrmCadastroBase getFrmCadatro()
        {
            return new FrmMotoristaCadastro();
        }

        internal override TabelaBase getTabela()
        {
            return new TblMotorista();
        }
    }
}