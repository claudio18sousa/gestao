using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao
{
    public partial class F_Horarios : Form
    {
        public F_Horarios()
        {
            InitializeComponent();
        }

        private void F_Horarios_Load(object sender, EventArgs e)
        {
            string vquery = @"
            Select 
               id_horario as 'ID',
               desc_horario as 'Horário'
            FROM
                horarios
            ORDER BY
                 desc_horario
                ";
            dgv_H.DataSource = Banco.dql(vquery);
            dgv_H.Columns[0].Width = 60;
            dgv_H.Columns[1].Width = 170;


        }

        private void dgv_H_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int countLinhas = dgv.SelectedRows.Count;

            if (countLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                select
                       *
                from
                       horarios
                where
                      id_horario ="+ vid;

                dt = Banco.dql(vquery);
                txt_idH.Text = dt.Rows[0].Field<Int64>("id_horario").ToString();
                mktxt_descH.Text = dt.Rows[0].Field<String>("desc_horario");

            }
        }

        private void btn_novoHorario_Click(object sender, EventArgs e)
        {
            txt_idH.Clear();
            mktxt_descH.Clear();
            mktxt_descH.Focus();
        }

        private void btn_salvarH_Click(object sender, EventArgs e)
        {
            string vquery;
            if (txt_idH.Text == "")
            {
                vquery = "INSERT INTO horarios (desc_horario) VALUES ('" + mktxt_descH.Text + "')";
            }
            else
            {
                vquery = "UPDATE horarios   SET desc_horario='" + mktxt_descH.Text + "' WHERE id_horario="+txt_idH.Text;
            }
            Banco.dml(vquery);
             vquery = @"
            Select 
               id_horario as 'ID',
               desc_horario as 'Horário'
            FR
                horarios
            ORDER BY
                 desc_horario
                ";
            dgv_H.DataSource = Banco.dql(vquery);
        }

        private void btn_ExcluirH_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma a exclusão deste horário?", "Excluir", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM horarios WHERE id_horario=" + txt_idH.Text;
                Banco.dml(vquery);
                dgv_H.Rows.Remove(dgv_H.CurrentRow);
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    }

