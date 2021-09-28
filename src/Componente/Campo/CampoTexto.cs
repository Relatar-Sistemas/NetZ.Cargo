namespace NetZ.Cargo.Componente.Campo
{
    public partial class CampoTexto : CampoBase
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

        public CampoTexto()
        {
            InitializeComponent();
        }
    }
}