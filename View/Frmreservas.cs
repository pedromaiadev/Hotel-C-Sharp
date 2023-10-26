using Controller;
using Google.Protobuf.WellKnownTypes;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace testando
{
    public partial class Frmreservas : Form
    {
        QuartosModelo quartosmodelo = new QuartosModelo();
        QuartosController qcontroller = new QuartosController();
        ReservasController rcontroller = new ReservasController();
        HospedeController hcontroller = new HospedeController();
        HospedeModelo hmodelo = new HospedeModelo();
        int idquartos;
        int nhospedes;
        public Frmreservas(int quarto)
        {
            idquartos = quarto;
            quartosmodelo = rcontroller.obterdados(quarto);

            InitializeComponent();
        }
        private void Frmreservas_Load(object sender, EventArgs e)
        {
            dtreservas.DataSource = rcontroller.obterdados("select reservas.idh, reservas.idq, date_format(reservas.datainr,'%d %m %y %T') as datainr, date_format(reservas.dataoutr,'%d %m %y %T') as dataoutr, reservas.preçor, reservas.statusr from reservas");
            
            cbostatus.DataSource = qcontroller.obterdados("select * from status");
            cbostatus.DisplayMember = "status";
            cbostatus.ValueMember = "idstatus";
            cboquartor.Text = quartosmodelo.idq.ToString();
            cboquartor.DataSource = qcontroller.obterdados("select * from quartos");
            cboquartor.DisplayMember = "nomeq";
            cboquartor.ValueMember = "idq";
            //cbonhospedesr.DataSource = qcontroller.obterdados("select * from quartos");
            //cbonhospedesr.DisplayMember = "capacidadeq";
            //cbonhospedesr.ValueMember = "capacidadeq";

        }
        private void btnreservar_Click(object sender, EventArgs e)
        {
            ReservasModelo reservasModelo = new ReservasModelo();
            reservasModelo.idh = hmodelo.idh;
            reservasModelo.idq = Convert.ToInt32(quartosmodelo.idq);
            reservasModelo.datainr = dTentrada.Value.Date;// ToString("yyyy-MM-dd hh:mm:ss"));
            reservasModelo.dataoutr = dTsaida.Value.Date;// ToString("yyyy-MM-dd hh:mm:ss");
            reservasModelo.preçor = txtpreco.Text;
            reservasModelo.nhospedesr = Convert.ToInt32(quartosmodelo.capacidadeq);
            reservasModelo.statusr = "Reservado";
            
            if (rcontroller.cadastrar(reservasModelo) == true)
            {
                MessageBox.Show("cadastro com sucesso!");

            }
            else
            {
                MessageBox.Show("Erro no cadastro do Quarto");
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnalterarstatus_Click(object sender, EventArgs e)
        {

        }

        private void dTentrada_ValueChanged(object sender, EventArgs e)
        {
            DateTime entrada = dTentrada.Value;
            DateTime saida = dTsaida.Value;
            TimeSpan timeSpan = saida - entrada;
            txtpreco.Text= Convert.ToString(timeSpan.Days * quartosmodelo.preçoq);
        }

        private void dTsaida_ValueChanged(object sender, EventArgs e)
        {
            DateTime entrada = dTentrada.Value;
            DateTime saida = dTsaida.Value;
            TimeSpan timeSpan = saida - entrada;
            txtpreco.Text = Convert.ToString(timeSpan.Days * quartosmodelo.preçoq);
        }
        private void cbonhospedesr_SelectedIndexChanged(object sender, EventArgs e)
        {

            quartosmodelo.capacidadeq = (string)cbonhospedesr.SelectedItem;
        }

        private void txtcpf_Leave(object sender, EventArgs e)
        {
            hmodelo = hcontroller.Carregarhospede(txtcpf.Text);
        }

        private void dtreservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcpf.Text = dtreservas.Rows[e.RowIndex].Cells["idh"].Value.ToString();
            cboquartor.Text = dtreservas.Rows[e.RowIndex].Cells["idq"].Value.ToString();
            dTentrada.Text = dtreservas.Rows[e.RowIndex].Cells["datainr"].Value.ToString();
            dTsaida.Text = dtreservas.Rows[e.RowIndex].Cells["dataoutr"].Value.ToString();
            txtpreco.Text = dtreservas.Rows[e.RowIndex].Cells["preçor"].Value.ToString();
            cbonhospedesr.Text = dtreservas.Rows[e.RowIndex].Cells["nhospedesr"].Value.ToString();
            cbostatus.Text = dtreservas.Rows[e.RowIndex].Cells["statusr"].Value.ToString();
        }

        private void cboquartor_SelectedIndexChanged(object sender, EventArgs e)
        {
            quartosmodelo.idq = Convert.ToInt32(((DataRowView)cboquartor.SelectedItem)["idq"]);
            quartosmodelo = qcontroller.Carregaquartos(quartosmodelo.idq);
            int contar ;
            cbonhospedesr.Items.Clear();
            for (contar = 1; contar <= Convert.ToInt32(quartosmodelo.capacidadeq); contar++)
            {
                cbonhospedesr.Items.Add(contar.ToString());
            }
        }
    }
}
