namespace Gestao
{
    partial class F_Horarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_H = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_ExcluirH = new System.Windows.Forms.Button();
            this.btn_salvarH = new System.Windows.Forms.Button();
            this.btn_novoHorario = new System.Windows.Forms.Button();
            this.txt_idH = new System.Windows.Forms.TextBox();
            this.mktxt_descH = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_H)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_H
            // 
            this.dgv_H.AllowUserToAddRows = false;
            this.dgv_H.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_H.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_H.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_H.EnableHeadersVisualStyles = false;
            this.dgv_H.Location = new System.Drawing.Point(12, 55);
            this.dgv_H.MultiSelect = false;
            this.dgv_H.Name = "dgv_H";
            this.dgv_H.ReadOnly = true;
            this.dgv_H.RowHeadersVisible = false;
            this.dgv_H.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_H.Size = new System.Drawing.Size(418, 365);
            this.dgv_H.TabIndex = 0;
            this.dgv_H.SelectionChanged += new System.EventHandler(this.dgv_H_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horário";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_ExcluirH);
            this.panel1.Controls.Add(this.btn_salvarH);
            this.panel1.Controls.Add(this.btn_novoHorario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 33);
            this.panel1.TabIndex = 3;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(330, 7);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(100, 23);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_ExcluirH
            // 
            this.btn_ExcluirH.Location = new System.Drawing.Point(224, 7);
            this.btn_ExcluirH.Name = "btn_ExcluirH";
            this.btn_ExcluirH.Size = new System.Drawing.Size(100, 23);
            this.btn_ExcluirH.TabIndex = 2;
            this.btn_ExcluirH.Text = "Excluir Horário";
            this.btn_ExcluirH.UseVisualStyleBackColor = true;
            this.btn_ExcluirH.Click += new System.EventHandler(this.btn_ExcluirH_Click);
            // 
            // btn_salvarH
            // 
            this.btn_salvarH.Location = new System.Drawing.Point(118, 7);
            this.btn_salvarH.Name = "btn_salvarH";
            this.btn_salvarH.Size = new System.Drawing.Size(100, 23);
            this.btn_salvarH.TabIndex = 1;
            this.btn_salvarH.Text = "Salvar Horário";
            this.btn_salvarH.UseVisualStyleBackColor = true;
            this.btn_salvarH.Click += new System.EventHandler(this.btn_salvarH_Click);
            // 
            // btn_novoHorario
            // 
            this.btn_novoHorario.Location = new System.Drawing.Point(12, 7);
            this.btn_novoHorario.Name = "btn_novoHorario";
            this.btn_novoHorario.Size = new System.Drawing.Size(100, 23);
            this.btn_novoHorario.TabIndex = 0;
            this.btn_novoHorario.Text = "Novo Horário";
            this.btn_novoHorario.UseVisualStyleBackColor = true;
            this.btn_novoHorario.Click += new System.EventHandler(this.btn_novoHorario_Click);
            // 
            // txt_idH
            // 
            this.txt_idH.Location = new System.Drawing.Point(12, 29);
            this.txt_idH.Name = "txt_idH";
            this.txt_idH.ReadOnly = true;
            this.txt_idH.Size = new System.Drawing.Size(53, 20);
            this.txt_idH.TabIndex = 4;
            this.txt_idH.TabStop = false;
            // 
            // mktxt_descH
            // 
            this.mktxt_descH.Location = new System.Drawing.Point(71, 29);
            this.mktxt_descH.Mask = "99:99\\ \\até 99:99";
            this.mktxt_descH.Name = "mktxt_descH";
            this.mktxt_descH.Size = new System.Drawing.Size(100, 20);
            this.mktxt_descH.TabIndex = 5;
            // 
            // F_Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 459);
            this.Controls.Add(this.mktxt_descH);
            this.Controls.Add(this.txt_idH);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_H);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Horarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horário";
            this.Load += new System.EventHandler(this.F_Horarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_H)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_H;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_ExcluirH;
        private System.Windows.Forms.Button btn_salvarH;
        private System.Windows.Forms.Button btn_novoHorario;
        private System.Windows.Forms.TextBox txt_idH;
        private System.Windows.Forms.MaskedTextBox mktxt_descH;
    }
}