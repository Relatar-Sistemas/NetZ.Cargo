using System;

namespace NetZ.Cargo.Componente.Campo
{
    public partial class CampoDataHora : CampoBase
    {
        public DateTime Valor
        {
            get
            {
                return this.dateTimePicker.Value;
            }

            set
            {
                this.dateTimePicker.Value = value;
            }
        }

        public CampoDataHora()
        {
            InitializeComponent();
        }
    }
}