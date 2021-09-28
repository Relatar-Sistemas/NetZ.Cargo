
namespace NetZ.Cargo.Formulario.Cadastro
{
    partial class FrmViagemCadastro
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
            this.cmpOrigem = new NetZ.Cargo.Componente.Campo.CampoTexto();
            this.cmpDestino = new NetZ.Cargo.Componente.Campo.CampoTexto();
            this.cmpSaida = new NetZ.Cargo.Componente.Campo.CampoDataHora();
            this.cmpChegada = new NetZ.Cargo.Componente.Campo.CampoDataHora();
            this.cmpVeiculo = new NetZ.Cargo.Componente.Campo.CampoConsulta();
            this.cmpMotorista = new NetZ.Cargo.Componente.Campo.CampoConsulta();
            this.pnlCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCampos
            // 
            this.pnlCampos.Controls.Add(this.cmpMotorista);
            this.pnlCampos.Controls.Add(this.cmpVeiculo);
            this.pnlCampos.Controls.Add(this.cmpChegada);
            this.pnlCampos.Controls.Add(this.cmpSaida);
            this.pnlCampos.Controls.Add(this.cmpDestino);
            this.pnlCampos.Controls.Add(this.cmpOrigem);
            this.pnlCampos.Size = new System.Drawing.Size(314, 356);
            // 
            // cmpOrigem
            // 
            this.cmpOrigem.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmpOrigem.Location = new System.Drawing.Point(0, 0);
            this.cmpOrigem.Name = "cmpOrigem";
            this.cmpOrigem.Size = new System.Drawing.Size(314, 60);
            this.cmpOrigem.TabIndex = 0;
            this.cmpOrigem.Valor = "";
            this.cmpOrigem.Titulo = "Origem";
            // 
            // cmpDestino
            // 
            this.cmpDestino.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmpDestino.Location = new System.Drawing.Point(0, 60);
            this.cmpDestino.Name = "cmpDestino";
            this.cmpDestino.Size = new System.Drawing.Size(314, 60);
            this.cmpDestino.TabIndex = 1;
            this.cmpDestino.Valor = "";
            this.cmpDestino.Titulo = "Destino";
            // 
            // cmpSaida
            // 
            this.cmpSaida.Valor = new System.DateTime(2021, 9, 28, 12, 52, 40, 336);
            this.cmpSaida.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmpSaida.Location = new System.Drawing.Point(0, 120);
            this.cmpSaida.Name = "cmpSaida";
            this.cmpSaida.Size = new System.Drawing.Size(314, 60);
            this.cmpSaida.TabIndex = 2;
            this.cmpSaida.Titulo = "Saída";
            // 
            // cmpChegada
            // 
            this.cmpChegada.Valor = new System.DateTime(2021, 9, 28, 12, 52, 40, 334);
            this.cmpChegada.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmpChegada.Location = new System.Drawing.Point(0, 180);
            this.cmpChegada.Name = "cmpChegada";
            this.cmpChegada.Size = new System.Drawing.Size(314, 60);
            this.cmpChegada.TabIndex = 3;
            this.cmpChegada.Titulo = "Chegada";
            // 
            // cmpVeiculo
            // 
            this.cmpVeiculo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmpVeiculo.Valor = 0;
            this.cmpVeiculo.Location = new System.Drawing.Point(0, 240);
            this.cmpVeiculo.Name = "cmpVeiculo";
            this.cmpVeiculo.Size = new System.Drawing.Size(314, 60);
            this.cmpVeiculo.TabIndex = 4;
            this.cmpVeiculo.Titulo = "Veículo";
            // 
            // cmpMotorista
            // 
            this.cmpMotorista.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmpMotorista.Valor = 0;
            this.cmpMotorista.Location = new System.Drawing.Point(0, 300);
            this.cmpMotorista.Name = "cmpMotorista";
            this.cmpMotorista.Size = new System.Drawing.Size(314, 60);
            this.cmpMotorista.TabIndex = 5;
            this.cmpMotorista.Titulo = "Motorista";
            // 
            // FrmViagemCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Name = "FrmViagemCadastro";
            this.Text = "Cadastro de viagem";
            this.pnlCampos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Componente.Campo.CampoConsulta cmpMotorista;
        private Componente.Campo.CampoConsulta cmpVeiculo;
        private Componente.Campo.CampoDataHora cmpChegada;
        private Componente.Campo.CampoDataHora cmpSaida;
        private Componente.Campo.CampoTexto cmpDestino;
        private Componente.Campo.CampoTexto cmpOrigem;
    }
}