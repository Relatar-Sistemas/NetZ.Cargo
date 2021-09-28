using NetZ.Cargo.Controlador;
using NetZ.Cargo.Modelo;

namespace NetZ.Cargo.Formulario.Cadastro
{
    public partial class FrmVeiculoCadastro : FrmCadastroBase
    {
        public FrmVeiculoCadastro()
        {
            InitializeComponent();
        }

        protected override ModeloBase carregarModelo()
        {
            return new Veiculo
            {
                ano = this.cmpAno.Valor,
                fabricanteId = this.cmpFabricante.Valor,
                id = default,
                modelo = this.cmpModelo.Valor,
                placa = this.cmpPlaca.Valor,
            };
        }

        protected override ControladorBase getControlador()
        {
            return new VeiculoControlador();
        }
    }
}