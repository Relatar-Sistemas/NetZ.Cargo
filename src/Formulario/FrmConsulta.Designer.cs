
namespace NetZ.Cargo.Formulario
{
    partial class FrmConsulta
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
            this.pnlLista = new System.Windows.Forms.Panel();
            this.listBox = new System.Windows.Forms.ListBox();
            this.pnlComando = new System.Windows.Forms.Panel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlLista.SuspendLayout();
            this.pnlComando.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLista
            // 
            this.pnlLista.Controls.Add(this.listBox);
            this.pnlLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLista.Location = new System.Drawing.Point(10, 10);
            this.pnlLista.Name = "pnlLista";
            this.pnlLista.Size = new System.Drawing.Size(780, 395);
            this.pnlLista.TabIndex = 1;
            // 
            // listBox
            // 
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(0, 0);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(780, 395);
            this.listBox.TabIndex = 1;
            this.listBox.DoubleClick += new System.EventHandler(this.listBox_DoubleClick);
            // 
            // pnlComando
            // 
            this.pnlComando.Controls.Add(this.btnAdicionar);
            this.pnlComando.Controls.Add(this.panel1);
            this.pnlComando.Controls.Add(this.btnAlterar);
            this.pnlComando.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlComando.Location = new System.Drawing.Point(10, 405);
            this.pnlComando.Name = "pnlComando";
            this.pnlComando.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnlComando.Size = new System.Drawing.Size(780, 35);
            this.pnlComando.TabIndex = 2;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdicionar.Location = new System.Drawing.Point(620, 5);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 30);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAlterar.Location = new System.Drawing.Point(705, 5);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 30);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Adicionar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(695, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 30);
            this.panel1.TabIndex = 2;
            // 
            // FrmConsulta
            // 
            this.AcceptButton = this.btnAdicionar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlLista);
            this.Controls.Add(this.pnlComando);
            this.Name = "FrmConsulta";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "FrmConsulta";
            this.pnlLista.ResumeLayout(false);
            this.pnlComando.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLista;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Panel pnlComando;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAlterar;
    }
}