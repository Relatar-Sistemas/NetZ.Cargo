using System;

namespace NetZ.Cargo.Componente.Campo
{
    public partial class CampoNumerico : CampoBase
    {
        public int Valor
        {
            get
            {
                return Convert.ToInt32(this.textBox.Text);
            }

            set
            {
                this.textBox.Text = value.ToString();
            }
        }

        public CampoNumerico()
        {
            InitializeComponent();
        }
    }
}