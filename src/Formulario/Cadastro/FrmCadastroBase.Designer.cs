
namespace NetZ.Cargo.Formulario.Cadastro
{
    partial class FrmCadastroBase
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
            this.pnlComandos = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlComandos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCampos
            // 
            this.pnlCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCampos.Location = new System.Drawing.Point(10, 10);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(780, 395);
            this.pnlCampos.TabIndex = 0;
            // 
            // pnlComandos
            // 
            this.pnlComandos.Controls.Add(this.btnSalvar);
            this.pnlComandos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlComandos.Location = new System.Drawing.Point(10, 405);
            this.pnlComandos.Name = "pnlComandos";
            this.pnlComandos.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnlComandos.Size = new System.Drawing.Size(780, 35);
            this.pnlComandos.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalvar.Location = new System.Drawing.Point(705, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 30);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // FrmCadastroBase
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCampos);
            this.Controls.Add(this.pnlComandos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroBase";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "FrmCadastroBase";
            this.pnlComandos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlComandos;
        private System.Windows.Forms.Button btnSalvar;
        protected System.Windows.Forms.Panel pnlCampos;
    }
}