using NetZ.Cargo.Controlador;
using NetZ.Cargo.Modelo;

namespace NetZ.Cargo.Formulario.Cadastro
{
    public partial class FrmUsuarioCadastro : FrmCadastroBase
    {
        public FrmUsuarioCadastro()
        {
            InitializeComponent();
        }

        protected override ModeloBase carregarModelo()
        {
            return new Usuario
            {
                id = default,
                login = this.cmpLogin.Valor,
                senha = this.cmpSenha.Valor,
            };
        }

        protected override ControladorBase getControlador()
        {
            return new UsuarioControlador();
        }
    }
}