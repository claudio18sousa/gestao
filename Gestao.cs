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
    public partial class Gestao : Form
    {
        public Gestao()
        {
            InitializeComponent();
        }

        private void Gestao_Load(object sender, EventArgs e)
        {
            dtgv_usuarios.DataSource = Banco.ObterUsuariosIdNome();
            dtgv_usuarios.Columns[0].Width = 85;
            dtgv_usuarios.Columns[0].Width = 190;
        }

        private void dtgv_usuarios_SelectionChanged(object sender, EventArgs e)
        {
           
            DataGridView dgv = (DataGridView) sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {

                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt=Banco.ObterDadosUsuarios(vid);
                txt_id.Text = dt.Rows[0].Field<Int64>("id").ToString();
                txt_nome.Text = dt.Rows[0].Field<String>("nome").ToString();
                txt_username.Text = dt.Rows[0].Field<String>("username").ToString();
                txt_senha.Text = dt.Rows[0].Field<String>("senha").ToString();
                cb_status.Text = dt.Rows[0].Field<String>("status").ToString();
               numUp_nivel.Value = dt.Rows[0].Field<Int64>("nivel");

            }
           
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            Fo_NovoUsuario f_NovoUsuario = new Fo_NovoUsuario();
            f_NovoUsuario.ShowDialog();
            dtgv_usuarios.DataSource = Banco.ObterUsuariosIdNome();

        }

        private void btn_salvarAlt_Click(object sender, EventArgs e)
        {
            int linha = dtgv_usuarios.SelectedRows[0].Index;
            Usuario u = new Usuario();
            u.id =Convert.ToInt32( txt_id.Text);
            u.nome = txt_nome.Text;
            u.username = txt_username.Text;
            u.senha = txt_senha.Text;
            u.status = cb_status.Text;
            u.nivel =Convert.ToInt32( Math.Round( numUp_nivel.Value,0));
            Banco.AtualizarUsuario(u);
            //dtgv_usuarios.DataSource = Banco.ObterUsuariosIdNome();
            //dtgv_usuarios.CurrentCell = dtgv_usuarios[0,linha];
            dtgv_usuarios[0, linha].Value = txt_id.Text ;
            dtgv_usuarios[1, linha].Value = txt_nome.Text;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja realmente excluir?", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Banco.Exluir(txt_id.Text);
                dtgv_usuarios.Rows.Remove(dtgv_usuarios.CurrentRow);
            }
        }
    }
}
