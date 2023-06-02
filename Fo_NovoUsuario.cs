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
    public partial class Fo_NovoUsuario : Form
    {
        public Fo_NovoUsuario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.nome = txt_nome.Text;
            usuario.username = txt_username.Text;
            usuario.senha = txt_senha.Text;
            usuario.status = cb_status.Text;
            usuario.nivel =Convert.ToInt32(Math.Round( numUp_nivel.Value,0));
            Banco.NovoUsuario(usuario);

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_senha.Clear();
            txt_username.Clear();
            cb_status.Text = "";
            numUp_nivel.Value =1;
            txt_nome.Focus();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_senha.Clear();
            txt_username.Clear();
            cb_status.Text = "";
            numUp_nivel.Value = 1;
            txt_nome.Focus();
        }
    }
}
