namespace Gestao
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_acess = new System.Windows.Forms.Label();
            this.lbl_acesso = new System.Windows.Forms.Label();
            this.pt_logado = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eNTRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pESSOASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaPessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUÁRIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeTrabalhadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUPORTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_logado)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.lbl_usuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_acess);
            this.panel1.Controls.Add(this.lbl_acesso);
            this.panel1.Controls.Add(this.pt_logado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 26);
            this.panel1.TabIndex = 0;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(161, 9);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(16, 13);
            this.lbl_usuario.TabIndex = 4;
            this.lbl_usuario.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuário:";
            // 
            // lbl_acess
            // 
            this.lbl_acess.AutoSize = true;
            this.lbl_acess.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_acess.Location = new System.Drawing.Point(76, 5);
            this.lbl_acess.Name = "lbl_acess";
            this.lbl_acess.Size = new System.Drawing.Size(16, 20);
            this.lbl_acess.TabIndex = 2;
            this.lbl_acess.Text = "0";
            // 
            // lbl_acesso
            // 
            this.lbl_acesso.AutoSize = true;
            this.lbl_acesso.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_acesso.Location = new System.Drawing.Point(22, 5);
            this.lbl_acesso.Name = "lbl_acesso";
            this.lbl_acesso.Size = new System.Drawing.Size(57, 18);
            this.lbl_acesso.TabIndex = 1;
            this.lbl_acesso.Text = "Acesso:";
            // 
            // pt_logado
            // 
            this.pt_logado.Image = global::Gestao.Properties.Resources.png_transparent_light_emitting_diode_computer_icons_light_camera_lens_light_led_thumbnail;
            this.pt_logado.Location = new System.Drawing.Point(3, 9);
            this.pt_logado.Name = "pt_logado";
            this.pt_logado.Size = new System.Drawing.Size(13, 14);
            this.pt_logado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt_logado.TabIndex = 0;
            this.pt_logado.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGINToolStripMenuItem,
            this.pESSOASToolStripMenuItem,
            this.uSUÁRIOSToolStripMenuItem,
            this.sUPORTEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lOGINToolStripMenuItem
            // 
            this.lOGINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eNTRARToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            this.lOGINToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.lOGINToolStripMenuItem.Text = "LOGIN";
            // 
            // eNTRARToolStripMenuItem
            // 
            this.eNTRARToolStripMenuItem.Name = "eNTRARToolStripMenuItem";
            this.eNTRARToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.eNTRARToolStripMenuItem.Text = "Entrar";
            this.eNTRARToolStripMenuItem.Click += new System.EventHandler(this.eNTRARToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pESSOASToolStripMenuItem
            // 
            this.pESSOASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaPessoaToolStripMenuItem});
            this.pESSOASToolStripMenuItem.Name = "pESSOASToolStripMenuItem";
            this.pESSOASToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.pESSOASToolStripMenuItem.Text = "PESSOAS";
            this.pESSOASToolStripMenuItem.Click += new System.EventHandler(this.pESSOASToolStripMenuItem_Click);
            // 
            // novaPessoaToolStripMenuItem
            // 
            this.novaPessoaToolStripMenuItem.Name = "novaPessoaToolStripMenuItem";
            this.novaPessoaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.novaPessoaToolStripMenuItem.Text = "Nova pessoa";
            this.novaPessoaToolStripMenuItem.Click += new System.EventHandler(this.novaPessoaToolStripMenuItem_Click);
            // 
            // uSUÁRIOSToolStripMenuItem
            // 
            this.uSUÁRIOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestãoDeUsuáriosToolStripMenuItem,
            this.gestãoDeTrabalhadoresToolStripMenuItem,
            this.novoUsuárioToolStripMenuItem});
            this.uSUÁRIOSToolStripMenuItem.Name = "uSUÁRIOSToolStripMenuItem";
            this.uSUÁRIOSToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.uSUÁRIOSToolStripMenuItem.Text = "USUÁRIOS";
            // 
            // gestãoDeUsuáriosToolStripMenuItem
            // 
            this.gestãoDeUsuáriosToolStripMenuItem.Name = "gestãoDeUsuáriosToolStripMenuItem";
            this.gestãoDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.gestãoDeUsuáriosToolStripMenuItem.Text = "Gestão de usuários";
            this.gestãoDeUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeUsuáriosToolStripMenuItem_Click);
            // 
            // gestãoDeTrabalhadoresToolStripMenuItem
            // 
            this.gestãoDeTrabalhadoresToolStripMenuItem.Name = "gestãoDeTrabalhadoresToolStripMenuItem";
            this.gestãoDeTrabalhadoresToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.gestãoDeTrabalhadoresToolStripMenuItem.Text = "Gestão de Trabalhadores";
            this.gestãoDeTrabalhadoresToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeTrabalhadoresToolStripMenuItem_Click);
            // 
            // novoUsuárioToolStripMenuItem
            // 
            this.novoUsuárioToolStripMenuItem.Name = "novoUsuárioToolStripMenuItem";
            this.novoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.novoUsuárioToolStripMenuItem.Text = "Novo usuário";
            this.novoUsuárioToolStripMenuItem.Click += new System.EventHandler(this.novoUsuárioToolStripMenuItem_Click);
            // 
            // sUPORTEToolStripMenuItem
            // 
            this.sUPORTEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bancoDeDadosToolStripMenuItem,
            this.horáriosToolStripMenuItem,
            this.areasToolStripMenuItem});
            this.sUPORTEToolStripMenuItem.Name = "sUPORTEToolStripMenuItem";
            this.sUPORTEToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.sUPORTEToolStripMenuItem.Text = "AJUSTES";
            this.sUPORTEToolStripMenuItem.Click += new System.EventHandler(this.sUPORTEToolStripMenuItem_Click);
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            this.bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            this.bancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bancoDeDadosToolStripMenuItem.Text = "Banco de dados";
            this.bancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.bancoDeDadosToolStripMenuItem_Click);
            // 
            // horáriosToolStripMenuItem
            // 
            this.horáriosToolStripMenuItem.Name = "horáriosToolStripMenuItem";
            this.horáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.horáriosToolStripMenuItem.Text = "Horários";
            this.horáriosToolStripMenuItem.Click += new System.EventHandler(this.horáriosToolStripMenuItem_Click);
            // 
            // areasToolStripMenuItem
            // 
            this.areasToolStripMenuItem.Name = "areasToolStripMenuItem";
            this.areasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.areasToolStripMenuItem.Text = "Áreas";
            this.areasToolStripMenuItem.Click += new System.EventHandler(this.areasToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Q2$\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_logado)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pt_logado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_acesso;
        public System.Windows.Forms.Label lbl_usuario;
        public System.Windows.Forms.Label lbl_acess;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eNTRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pESSOASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaPessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSUÁRIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUPORTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeTrabalhadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areasToolStripMenuItem;
    }
}

