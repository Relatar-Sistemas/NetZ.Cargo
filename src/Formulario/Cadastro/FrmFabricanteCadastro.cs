using NetZ.Cargo.Controlador;
using NetZ.Cargo.Modelo;

namespace NetZ.Cargo.Formulario.Cadastro
{
    public partial class FrmFabricanteCadastro : FrmCadastroBase
    {
        public FrmFabricanteCadastro()
        {
            InitializeComponent();
        }

        protected override ModeloBase carregarModelo()
        {
            return new Fabricante
            {
                id = default,
                nome = this.cmpNome.Valor,
            };
        }

        protected override ControladorBase getControlador()
        {
            return new FabricanteControlador();
        }
    }
}