using Controller;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace testando
{
    public partial class Check_in : Form
    {
        ReservasController rcontroller = new ReservasController();
        public Check_in()
        {
            InitializeComponent();
        }

        private void Check_in_Load(object sender, EventArgs e)
        {
            
            dtreservasin.DataSource = rcontroller.obterdados("select reservas.idh, reservas.idq, date_format(reservas.datainr,'%d %m %y %T') as datainr, date_format(reservas.dataoutr,'%d %m %y %T') as dataoutr, reservas.preçor, reservas.statusr from reservas");
        }

        private void btnfinin_Click(object sender, EventArgs e)
        {

        }

        private void txtcpfhin_TextChanged(object sender, EventArgs e)
        {
            dtreservasin.ClearSelection();
            string pesquisar = txtcpfhin.Text.ToLower();
            foreach (DataGridViewRow row in dtreservasin.Rows)
            {
                if (row.Cells["idh"].Value != null)
                {
                    if (row.Cells["idh"].Value.ToString().ToLower().Equals(pesquisar))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dtreservasin.Rows[e.RowIndex];
                string valorpgin = row.Cells["preçor"].Value.ToString();
                txtcpfhin.Text = valorpgin;
            }
        }
    }
}
