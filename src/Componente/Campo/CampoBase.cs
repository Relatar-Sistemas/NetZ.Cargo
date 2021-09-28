namespace NetZ.Cargo.Componente.Campo
{
    public partial class CampoBase : ComponenteBase
    {
        public string Titulo
        {
            get
            {
                return this.lblTitulo.Text;
            }

            set
            {
                this.lblTitulo.Text = value;
            }
        }

        public CampoBase()
        {
            InitializeComponent();
        }
    }
}