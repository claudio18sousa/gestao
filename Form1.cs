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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_login f_login = new F_login(this);
            f_login.ShowDialog();
        }

        private void abreform(int nivel, Form f)
        {
            if (Globais.logado == true)
            {
                if (Globais.nivel >= nivel)
                {
                    //Procedimentos
                   
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usário logado");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void eNTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_login f_login = new F_login(this);
            f_login.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_acess.Text = "0";
            lbl_usuario.Text = "---";
            pt_logado.Image = Properties.Resources.png_transparent_light_emitting_diode_computer_icons_light_camera_lens_light_led_thumbnail;
            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado==true)
            {
                if (Globais.nivel >= 3)
                {
                    //Procedimentos
                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usário logado");
            }
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fo_NovoUsuario novoUsuario = new Fo_NovoUsuario();
            abreform(2, novoUsuario);
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestao gestao = new Gestao();
            abreform(2, gestao);
        }

        private void pESSOASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novaPessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)
            {
                //procedimentos  
                
            }
            else
            {
                MessageBox.Show("É necessário ter um usário logado");
            }
        }

        private void sUPORTEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void horáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Horarios horarios = new F_Horarios();
            abreform(2, horarios);
        }

        private void gestãoDeTrabalhadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FG_Trabalhadores fG_Trabalhadores = new FG_Trabalhadores();
            abreform(2, fG_Trabalhadores);

        }

        private void áreasToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void areasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GAreas areas = new GAreas();

            abreform(2, areas);
        }

        private void noboToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
