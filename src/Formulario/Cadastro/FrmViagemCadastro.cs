using NetZ.Cargo.Controlador;
using NetZ.Cargo.Modelo;

namespace NetZ.Cargo.Formulario.Cadastro
{
    public partial class FrmViagemCadastro : FrmCadastroBase
    {
        public FrmViagemCadastro()
        {
            InitializeComponent();
        }

        protected override ModeloBase carregarModelo()
        {
            return new Viagem
            {
                chegada = this.cmpChegada.Valor,
                destino = this.cmpDestino.Valor,
                id = default,
                motoristaId = this.cmpMotorista.Valor,
                origem = this.cmpOrigem.Valor,
                saida = this.cmpSaida.Valor,
                veiculoId = this.cmpVeiculo.Valor,
            };
        }

        protected override ControladorBase getControlador()
        {
            return new ViagemControlador();
        }
    }
}