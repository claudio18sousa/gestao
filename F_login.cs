using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;


namespace Gestao
{
    public partial class F_login : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();
        public F_login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void F_login_Load(object sender, EventArgs e)
        {

        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string senha = txt_senha.Text;

            if(username=="" || senha == "")
            {
                MessageBox.Show("Usuário ou senha errados");
                txt_username.Focus();
                return;
            }

            string sql = "SELECT * FROM usuarios where username='" + username+"' AND senha='"+senha+"'";
            dt = Banco.dql(sql);
            if (dt.Rows.Count == 1)
            {
                form1.lbl_acess.Text = dt.Rows[0].ItemArray[5].ToString();
                form1.lbl_usuario.Text = dt.Rows[0].ItemArray[2].ToString();
                form1.pt_logado.Image = Properties.Resources.png_transparent_green_font_design_led_art_circle_thumbnail;
                Globais.nivel=int.Parse( dt.Rows[0].ItemArray[5].ToString());
                Globais.logado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
