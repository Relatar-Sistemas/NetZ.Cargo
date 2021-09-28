
namespace NetZ.Cargo.Formulario
{
    partial class FrmLogin
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
            this.pnlCampos = new System.Windows.Forms.Panel();
            this.cmpSenha = new NetZ.Cargo.Componente.Campo.CampoSenha();
            this.cmpLogin = new NetZ.Cargo.Componente.Campo.CampoTexto();
            this.label = new System.Windows.Forms.Label();
            this.pnlComandos = new System.Windows.Forms.Panel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.pnlCampos.SuspendLayout();
            this.pnlComandos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCampos
            // 
            this.pnlCampos.Controls.Add(this.cmpSenha);
            this.pnlCampos.Controls.Add(this.cmpLogin);
            this.pnlCampos.Controls.Add(this.label);
            this.pnlCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCampos.Location = new System.Drawing.Point(10, 10);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(314, 191);
            this.pnlCampos.TabIndex = 1;
            // 
            // cmpSenha
            // 
            this.cmpSenha.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmpSenha.Location = new System.Drawing.Point(0, 110);
            this.cmpSenha.Name = "cmpSenha";
            this.cmpSenha.Valor = "";
            this.cmpSenha.Size = new System.Drawing.Size(314, 60);
            this.cmpSenha.TabIndex = 7;
            this.cmpSenha.Titulo = "Senha";
            // 
            // cmpLogin
            // 
            this.cmpLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmpLogin.Location = new System.Drawing.Point(0, 50);
            this.cmpLogin.Name = "cmpLogin";
            this.cmpLogin.Size = new System.Drawing.Size(314, 60);
            this.cmpLogin.TabIndex = 6;
            this.cmpLogin.Valor = "";
            this.cmpLogin.Titulo = "Login";
            // 
            // label
            // 
            this.label.Dock = System.Windows.Forms.DockStyle.Top;
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(314, 50);
            this.label.TabIndex = 5;
            this.label.Text = "Informe as informações de login para entrar";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlComandos
            // 
            this.pnlComandos.Controls.Add(this.btnEntrar);
            this.pnlComandos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlComandos.Location = new System.Drawing.Point(10, 201);
            this.pnlComandos.Name = "pnlComandos";
            this.pnlComandos.Size = new System.Drawing.Size(314, 30);
            this.pnlComandos.TabIndex = 2;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEntrar.Location = new System.Drawing.Point(239, 0);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 30);
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnEntrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 241);
            this.Controls.Add(this.pnlCampos);
            this.Controls.Add(this.pnlComandos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Login";
            this.pnlCampos.ResumeLayout(false);
            this.pnlComandos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.Panel pnlComandos;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label label;
        private Componente.Campo.CampoSenha cmpSenha;
        private Componente.Campo.CampoTexto cmpLogin;
    }
}