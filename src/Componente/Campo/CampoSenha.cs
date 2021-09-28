namespace NetZ.Cargo.Componente.Campo
{
    public partial class CampoSenha : CampoBase
    {
        public string Valor
        {
            get
            {
                return this.textBox.Text;
            }

            set
            {
                this.textBox.Text = value;
            }
        }

        public CampoSenha()
        {
            InitializeComponent();
        }
    }
}