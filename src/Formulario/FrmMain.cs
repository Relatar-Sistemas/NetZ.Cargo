using System;
using System.Windows.Forms;

namespace NetZ.Cargo.Formulario
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            this.Visible = false;

            var frmSplash = new FrmSplash();
            frmSplash.ShowDialog();

            var frmLogin = new FrmLogin();
            var resultado = frmLogin.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                var frmPrincipal = new FrmPrincipal();
                frmPrincipal.ShowDialog();
            }

            this.Close();
        }
    }
}