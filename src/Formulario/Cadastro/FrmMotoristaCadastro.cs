using NetZ.Cargo.Controlador;
using NetZ.Cargo.Modelo;

namespace NetZ.Cargo.Formulario.Cadastro
{
    public partial class FrmMotoristaCadastro : FrmCadastroBase
    {
        public FrmMotoristaCadastro()
        {
            InitializeComponent();
        }

        protected override ModeloBase carregarModelo()
        {
            return new Motorista
            {
                cnh = this.cmpCnh.Valor,
                id = default,
                nome = this.cmpNome.Valor,
            };
        }

        protected override ControladorBase getControlador()
        {
            return new MotoristaControlador();
        }
    }
}