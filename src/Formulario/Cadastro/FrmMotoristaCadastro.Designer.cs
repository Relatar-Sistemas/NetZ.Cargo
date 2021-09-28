
namespace NetZ.Cargo.Formulario.Cadastro
{
    partial class FrmMotoristaCadastro
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
            this.cmpNome = new NetZ.Cargo.Componente.Campo.CampoTexto();
            this.cmpCnh = new NetZ.Cargo.Componente.Campo.CampoTexto();
            this.pnlCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCampos
            // 
            this.pnlCampos.Controls.Add(this.cmpCnh);
            this.pnlCampos.Controls.Add(this.cmpNome);
            this.pnlCampos.Size = new System.Drawing.Size(314, 126);
            // 
            // cmpNome
            // 
            this.cmpNome.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmpNome.Location = new System.Drawing.Point(0, 0);
            this.cmpNome.Name = "cmpNome";
            this.cmpNome.Size = new System.Drawing.Size(314, 60);
            this.cmpNome.TabIndex = 0;
            this.cmpNome.Valor = "";
            this.cmpNome.Titulo = "Nome";
            // 
            // cmpCnh
            // 
            this.cmpCnh.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmpCnh.Location = new System.Drawing.Point(0, 60);
            this.cmpCnh.Name = "cmpCnh";
            this.cmpCnh.Size = new System.Drawing.Size(314, 60);
            this.cmpCnh.TabIndex = 1;
            this.cmpCnh.Valor = "";
            this.cmpCnh.Titulo = "CNH";
            // 
            // FrmMotoristaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 181);
            this.Name = "FrmMotoristaCadastro";
            this.Text = "Cadastro de motorista";
            this.pnlCampos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Componente.Campo.CampoTexto cmpCnh;
        private Componente.Campo.CampoTexto cmpNome;
    }
}