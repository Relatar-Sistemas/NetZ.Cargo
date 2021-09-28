
namespace NetZ.Cargo.Formulario.Cadastro
{
    partial class FrmUsuarioCadastro
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
            this.cmpLogin = new NetZ.Cargo.Componente.Campo.CampoTexto();
            this.cmpSenha = new NetZ.Cargo.Componente.Campo.CampoSenha();
            this.pnlCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCampos
            // 
            this.pnlCampos.Controls.Add(this.cmpSenha);
            this.pnlCampos.Controls.Add(this.cmpLogin);
            this.pnlCampos.Size = new System.Drawing.Size(314, 126);
            // 
            // cmpLogin
            // 
            this.cmpLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmpLogin.Location = new System.Drawing.Point(0, 0);
            this.cmpLogin.Name = "cmpLogin";
            this.cmpLogin.Size = new System.Drawing.Size(314, 60);
            this.cmpLogin.TabIndex = 0;
            this.cmpLogin.Valor = "";
            this.cmpLogin.Titulo = "Login";
            // 
            // cmpSenha
            // 
            this.cmpSenha.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmpSenha.Location = new System.Drawing.Point(0, 60);
            this.cmpSenha.Name = "cmpSenha";
            this.cmpSenha.Valor = "";
            this.cmpSenha.Size = new System.Drawing.Size(314, 60);
            this.cmpSenha.TabIndex = 1;
            this.cmpSenha.Titulo = "Senha";
            // 
            // FrmUsuarioCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 181);
            this.Name = "FrmUsuarioCadastro";
            this.Text = "Cadastro de usuário";
            this.pnlCampos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Componente.Campo.CampoTexto cmpLogin;
        private Componente.Campo.CampoSenha cmpSenha;
    }
}