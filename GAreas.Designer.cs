namespace Gestao
{
    partial class GAreas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_newarea = new System.Windows.Forms.Button();
            this.btn_salvared = new System.Windows.Forms.Button();
            this.btn_editarea = new System.Windows.Forms.Button();
            this.btn_imprimirarea = new System.Windows.Forms.Button();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.dtgv_areas = new System.Windows.Forms.DataGridView();
            this.cb_gerente = new System.Windows.Forms.ComboBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.cb_horarios = new System.Windows.Forms.ComboBox();
            this.nud_max = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_areas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_max)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Fechar);
            this.panel1.Controls.Add(this.btn_imprimirarea);
            this.panel1.Controls.Add(this.btn_editarea);
            this.panel1.Controls.Add(this.btn_salvared);
            this.panel1.Controls.Add(this.btn_newarea);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 429);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 35);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gerente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Máximo de operários";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Satus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Horários";
            // 
            // btn_newarea
            // 
            this.btn_newarea.Location = new System.Drawing.Point(8, 3);
            this.btn_newarea.Name = "btn_newarea";
            this.btn_newarea.Size = new System.Drawing.Size(111, 23);
            this.btn_newarea.TabIndex = 0;
            this.btn_newarea.Text = "Nova Área";
            this.btn_newarea.UseVisualStyleBackColor = true;
            // 
            // btn_salvared
            // 
            this.btn_salvared.Location = new System.Drawing.Point(125, 3);
            this.btn_salvared.Name = "btn_salvared";
            this.btn_salvared.Size = new System.Drawing.Size(111, 23);
            this.btn_salvared.TabIndex = 1;
            this.btn_salvared.Text = "Salvar Edições";
            this.btn_salvared.UseVisualStyleBackColor = true;
            // 
            // btn_editarea
            // 
            this.btn_editarea.Location = new System.Drawing.Point(242, 3);
            this.btn_editarea.Name = "btn_editarea";
            this.btn_editarea.Size = new System.Drawing.Size(111, 23);
            this.btn_editarea.TabIndex = 2;
            this.btn_editarea.Text = "Editar Área";
            this.btn_editarea.UseVisualStyleBackColor = true;
            // 
            // btn_imprimirarea
            // 
            this.btn_imprimirarea.Location = new System.Drawing.Point(359, 3);
            this.btn_imprimirarea.Name = "btn_imprimirarea";
            this.btn_imprimirarea.Size = new System.Drawing.Size(111, 23);
            this.btn_imprimirarea.TabIndex = 3;
            this.btn_imprimirarea.Text = "Imprimir área";
            this.btn_imprimirarea.UseVisualStyleBackColor = true;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Location = new System.Drawing.Point(476, 3);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(111, 23);
            this.btn_Fechar.TabIndex = 4;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            // 
            // dtgv_areas
            // 
            this.dtgv_areas.AllowUserToAddRows = false;
            this.dtgv_areas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_areas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_areas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_areas.EnableHeadersVisualStyles = false;
            this.dtgv_areas.Location = new System.Drawing.Point(12, 13);
            this.dtgv_areas.MultiSelect = false;
            this.dtgv_areas.Name = "dtgv_areas";
            this.dtgv_areas.ReadOnly = true;
            this.dtgv_areas.RowHeadersVisible = false;
            this.dtgv_areas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_areas.Size = new System.Drawing.Size(345, 412);
            this.dtgv_areas.TabIndex = 31;
            // 
            // cb_gerente
            // 
            this.cb_gerente.FormattingEnabled = true;
            this.cb_gerente.Location = new System.Drawing.Point(363, 30);
            this.cb_gerente.Name = "cb_gerente";
            this.cb_gerente.Size = new System.Drawing.Size(228, 21);
            this.cb_gerente.TabIndex = 32;
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(475, 103);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(121, 21);
            this.cb_status.TabIndex = 33;
            // 
            // cb_horarios
            // 
            this.cb_horarios.FormattingEnabled = true;
            this.cb_horarios.Location = new System.Drawing.Point(363, 159);
            this.cb_horarios.Name = "cb_horarios";
            this.cb_horarios.Size = new System.Drawing.Size(233, 21);
            this.cb_horarios.TabIndex = 34;
            // 
            // nud_max
            // 
            this.nud_max.Location = new System.Drawing.Point(364, 103);
            this.nud_max.Name = "nud_max";
            this.nud_max.Size = new System.Drawing.Size(103, 20);
            this.nud_max.TabIndex = 35;
            // 
            // GAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 464);
            this.Controls.Add(this.nud_max);
            this.Controls.Add(this.cb_horarios);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.cb_gerente);
            this.Controls.Add(this.dtgv_areas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GAreas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GAreas";
            this.Load += new System.EventHandler(this.GAreas_Load);
            this.Leave += new System.EventHandler(this.GAreas_Leave);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_areas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_max)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_imprimirarea;
        private System.Windows.Forms.Button btn_editarea;
        private System.Windows.Forms.Button btn_salvared;
        private System.Windows.Forms.Button btn_newarea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgv_areas;
        private System.Windows.Forms.ComboBox cb_gerente;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.ComboBox cb_horarios;
        private System.Windows.Forms.NumericUpDown nud_max;
    }
}