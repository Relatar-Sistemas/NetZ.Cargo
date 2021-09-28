using NetZ.Cargo.Formulario.Cadastro;
using NetZ.Cargo.Tabela;

namespace NetZ.Cargo.Controlador
{
    internal class UsuarioControlador : ControladorBase
    {
        internal override string getConsultaTitulo()
        {
            return "Consulta de usuários";
        }

        internal override FrmCadastroBase getFrmCadatro()
        {
            return new FrmUsuarioCadastro();
        }

        internal override TabelaBase getTabela()
        {
            return new TblUsuario();
        }
    }
}