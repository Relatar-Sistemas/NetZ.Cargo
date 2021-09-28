
namespace NetZ.Cargo.Formulario.Cadastro
{
    partial class FrmVeiculoCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmpModelo = new NetZ.Cargo.Componente.Campo.CampoTexto();
            this.cmpPlaca = new NetZ.Cargo.Componente.Campo.CampoTexto();
            this.cmpAno = new NetZ.Cargo.Componente.Campo.CampoNumerico();
            this.cmpFabricante = new NetZ.Cargo.Componente.Campo.CampoConsulta();
            this.pnlCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCampos
            // 
            this.pnlCampos.Controls.Add(this.cmpFabricante);
            this.pnlCampos.Controls.Add(this.cmpAno);
            this.pnlCampos.Controls.Add(this.cmpPlaca);
            this.pnlCampos.Controls.Add(this.cmpModelo);
            this.pnlCampos.Size = new System.Drawing.Size(314, 256);
            // 
            // cmpModelo
            // 
            this.cmpModelo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmpModelo.Location = new System.Drawing.Point(0, 0);
            this.cmpModelo.Name = "cmpModelo";
            this.cmpModelo.Size = new System.Drawing.Size(314, 60);
            this.cmpModelo.TabIndex = 0;
            this.cmpModelo.Titulo = "Modelo";
            this.cmpModelo.Valor = "";
            // 
            // cmpPlaca
            // 
            this.cmpPlaca.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmpPlaca.Location = new System.Drawing.Point(0, 60);
            this.cmpPlaca.Name = "cmpPlaca";
            this.cmpPlaca.Size = new System.Drawing.Size(314, 60);
            this.cmpPlaca.TabIndex = 1;
            this.cmpPlaca.Titulo = "Placa";
            this.cmpPlaca.Valor = "";
            // 
            // cmpAno
            // 
            this.cmpAno.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmpAno.Location = new System.Drawing.Point(0, 120);
            this.cmpAno.Name = "cmpAno";
            this.cmpAno.Size = new System.Drawing.Size(314, 60);
            this.cmpAno.TabIndex = 2;
            this.cmpAno.Titulo = "Ano";
            // 
            // cmpFabricante
            // 
            this.cmpFabricante.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmpFabricante.Location = new System.Drawing.Point(0, 180);
            this.cmpFabricante.Name = "cmpFabricante";
            this.cmpFabricante.Size = new System.Drawing.Size(314, 60);
            this.cmpFabricante.TabIndex = 3;
            this.cmpFabricante.Titulo = "Fabricante";
            this.cmpFabricante.Valor = 0;
            // 
            // FrmVeiculoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Name = "FrmVeiculoCadastro";
            this.Text = "Cadastro de veículo";
            this.pnlCampos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Componente.Campo.CampoConsulta cmpFabricante;
        private Componente.Campo.CampoNumerico cmpAno;
        private Componente.Campo.CampoTexto cmpPlaca;
        private Componente.Campo.CampoTexto cmpModelo;
    }
}