using System;

namespace NetZ.Cargo.Componente.Campo
{
    public partial class CampoConsulta : CampoBase
    {
        public int Valor
        {
            get
            {
                return Convert.ToInt32(this.comboBox.SelectedValue);
            }

            set
            {
                this.comboBox.SelectedValue = value;
            }
        }

        public CampoConsulta()
        {
            InitializeComponent();
        }
    }
}