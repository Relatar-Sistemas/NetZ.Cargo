
namespace NetZ.Cargo.Formulario.Cadastro
{
    partial class FrmFabricanteCadastro
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
            this.pnlCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCampos
            // 
            this.pnlCampos.Controls.Add(this.cmpNome);
            this.pnlCampos.Size = new System.Drawing.Size(314, 66);
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
            // FrmFabricanteCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 121);
            this.Name = "FrmFabricanteCadastro";
            this.Text = "Cadastro de fabricante";
            this.pnlCampos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Componente.Campo.CampoTexto cmpNome;
    }
}