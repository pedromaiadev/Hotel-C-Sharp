using Controller;
using Modelo;
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
        ReservasController rController = new ReservasController();
        QuartosController qController = new QuartosController();
        QuartosModelo qModelo= new QuartosModelo();
        public Check_in()
        {
            InitializeComponent();
        }

        private void Check_in_Load(object sender, EventArgs e)
        {

            dTReservasin.DataSource = rController.obterdados("select reservas.idh, reservas.idq, date_format(reservas.datainr,'%d %m %y %T') as datainr, date_format(reservas.dataoutr,'%d %m %y %T') as dataoutr, reservas.preçor, reservas.nhospedesr, reservas.statusr, reservas.idr from reservas");
        }

        private void btnfinin_Click(object sender, EventArgs e)
        {
            if (qController.AtualizarStatusQuarto(qModelo.idq, 3))
            {
                MessageBox.Show("Status do quarto atualizado para Reservado!");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar o status do quarto.");
            }
        }

        /*private void txtcpfhin_TextChanged(object sender, EventArgs e)
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
            if(0)
            {
                DataGridViewRow row = dtreservasin.Rows[];
                string valorpgin = row.Cells["preçor"].Value.ToString();
                txtcpfhin.Text = valorpgin;
            }
        }*/
    }
}
