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
    public partial class GAreas : Form
    {
        public GAreas()
        {
            InitializeComponent();
        }

        private void GAreas_Leave(object sender, EventArgs e)
        {
            
        }

        private void GAreas_Load(object sender, EventArgs e)
        {
            string vqueryDGV = @"
                SELECT
                       tba.id_areas as 'ID',
                       tba.desc_turma as 'Area',
                       tbh.desc_horario as 'Horario'
                From
                       areas as tba
                INNER JOIN
                       horarios as tbh on tbh.id_horario = tba.id_horario
";

            dtgv_areas.DataSource = Banco.dql(vqueryDGV);
            dtgv_areas.Columns[0].Width = 40;
            dtgv_areas.Columns[1].Width = 120;
            dtgv_areas.Columns[2].Width = 85;

        }
    }
}
