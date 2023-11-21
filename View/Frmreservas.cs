﻿using Controller;
using Google.Protobuf.WellKnownTypes;
using Modelo;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
        ReservasModelo reservasModelo = new ReservasModelo();
        HospedeController hcontroller = new HospedeController();
        HospedeModelo hmodelo = new HospedeModelo();
        int idquartos;
        int nhospedes;
        
        public Frmreservas(int roomNumber)
        {
            //idquartos = quarto;
            //quartosmodelo = rcontroller.obterdados(quarto);
            InitializeComponent();
        }
        public void AtualizarComboBoxQuarto(int roomNumber)
        {
            // Atualize o ComboBox com base no roomNumber
            if (cboquartor.Items.Cast<DataRowView>().Any(item => Convert.ToInt32(item.Row["idq"]) == roomNumber))
            {
                cboquartor.SelectedValue = roomNumber;
            }
            else
            {
                // Tratar o caso quando o roomNumber não está na lista (talvez exibir uma mensagem de erro)
                MessageBox.Show("O número do quarto não está na lista.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frmreservas_Load(object sender, EventArgs e)
        {
            dtreservas.DataSource = rcontroller.obterdados("select reservas.idh, reservas.idq, date_format(reservas.datainr,'%d %m %y %T') as datainr, date_format(reservas.dataoutr,'%d %m %y %T') as dataoutr, reservas.preçor, reservas.nhospedesr, reservas.statusr, reservas.idr from reservas");
            dtreservas.CellClick += dtreservas_CellClick;
            dtreservas.Columns[2].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:ss";
            dtreservas.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:ss";

            cbostatus.DataSource = qcontroller.obterdados("select * from status");
            cbostatus.DisplayMember = "status";
            cbostatus.ValueMember = "idstatus";
            
            cboquartor.Text = quartosmodelo.idq.ToString();
            cboquartor.DataSource = qcontroller.obterdados("select * from quartos");
            cboquartor.DisplayMember = "nomeq";
            cboquartor.ValueMember = "idq";

            dTentrada.MinDate = DateTime.Now;
            dTsaida.MinDate = dTentrada.Value.AddDays(1);
        }
        private void btnreservar_Click(object sender, EventArgs e)
        {
            if (rcontroller.ReservaExisteParaHospede(hmodelo.idh.ToString()))
            {
                MessageBox.Show("Hóspede já possue Reserva, Deseja realizar uma nova reserva?");
                return;
            }
            else
            {
                reservasModelo.idh = hmodelo.idh;
            }
            // Verifica se já existe reserva para o mesmo quarto no mesmo período
            DateTime datainr = dTentrada.Value;
            DateTime dataoutr = dTsaida.Value;
            if (rcontroller.ReservaExistenteParaQuartoPeriodo(quartosmodelo.idq, datainr, dataoutr))
            {
                MessageBox.Show("Quarto já possue Reserva para o periodo selecionado");
                return;    
            }
            else
            {
                reservasModelo.idq = Convert.ToInt32(quartosmodelo.idq);
            }
            reservasModelo.datainr = dTentrada.Value;// ToString("yyyy-MM-dd hh:mm:ss"));
            reservasModelo.dataoutr = dTsaida.Value;// ToString("yyyy-MM-dd hh:mm:ss");
            reservasModelo.preçor = txtpreco.Text;
            reservasModelo.nhospedesr = Convert.ToInt32(quartosmodelo.capacidadeq);
            reservasModelo.statusr = "Reservado";
            if (rcontroller.cadastrar(reservasModelo))
            {
                MessageBox.Show("Cadastro com sucesso!");

                // Atualiza o status do quarto para Reservado (status_id = 2)
                if (qcontroller.AtualizarStatusQuarto(quartosmodelo.idq, 2))
                {
                    MessageBox.Show("Status do quarto atualizado para Reservado!");
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar o status do quarto.");
                }

                // Atualiza a exibição das reservas no DataGridView
                AtualizarGridReservas();
            }
            else
            {
                MessageBox.Show("Erro no cadastro do Quarto");
            }  
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string termoBusca = txtbuscar.Text.Trim();

            // Evitar SQL Injection usando parâmetros
            string query = "SELECT reservas.idh, reservas.idq, date_format(reservas.datainr,'%d %m %y %T') as datainr, date_format(reservas.dataoutr,'%d %m %y %T') as dataoutr, reservas.preçor, reservas.nhospedesr, reservas.statusr, reservas.idr FROM reservas INNER JOIN hospedes ON reservas.idh = hospedes.idh WHERE hospedes.cpfh = @termo OR reservas.idq = @termo";

            // Criar comando com parâmetros
            using (MySqlCommand cmd = new MySqlCommand(query))
            {
                cmd.Parameters.AddWithValue("@termo", termoBusca);

                // Executar o comando e atualizar o DataGridView
                dtreservas.DataSource = rcontroller.obterdados(cmd.ToString());
            }
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            if (dtreservas.SelectedRows.Count > 0)
            {
                reservasModelo.idh = hmodelo.idh;
                reservasModelo.idq = Convert.ToInt32(txtIdq.Text);
                reservasModelo.datainr = dTentrada.Value;
                reservasModelo.dataoutr = dTsaida.Value;
                reservasModelo.preçor = txtpreco.Text;
                reservasModelo.nhospedesr = Convert.ToInt32(quartosmodelo.capacidadeq);
                reservasModelo.statusr = cbonhospedesr.Text;

                if (rcontroller.editar(reservasModelo) == true)
                {
                    MessageBox.Show("Reserva atualizada com sucesso");
                    AtualizarGridReservas();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar Reserva");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma reserva para alterar.");
            }
        }
        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            // Verifica se alguma reserva está selecionada
            if (dtreservas.SelectedRows.Count > 0)
            {
                // Obtém o ID da reserva selecionada
                int idReserva = Convert.ToInt32(dtreservas.SelectedRows[0].Cells["idr"].Value);

                // Confirmação com o usuário antes de cancelar a reserva
                DialogResult result = MessageBox.Show("Tem certeza que deseja cancelar a reserva?", "Cancelar Reserva", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Remove a reserva do banco de dados
                    if (rcontroller.excluir(idReserva))
                    {
                        MessageBox.Show("Reserva cancelada com sucesso!");
                        // Atualiza a exibição das reservas no DataGridView
                        AtualizarGridReservas();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cancelar a reserva.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma reserva para cancelar.");
            }
        }

        private void dTentrada_ValueChanged(object sender, EventArgs e)
        {
            DateTime entrada = dTentrada.Value;
            DateTime saida = dTsaida.Value;
            TimeSpan timeSpan = saida - entrada;
            txtpreco.Text= Convert.ToString(timeSpan.Days * quartosmodelo.preçoq);
            DateTime datainr = dTentrada.Value;
            DateTime dataoutr = dTsaida.Value;
            if (datainr > dataoutr)
            {
                MessageBox.Show("A data de entrada não pode ser posterior à data de saída.");
                dTsaida.MinDate = dTentrada.Value.AddDays(1);
                return;
            }
            else
            {
                dTsaida.MinDate = dTentrada.Value.AddDays(1);
            }

        }

        private void dTsaida_ValueChanged(object sender, EventArgs e)
        {
            DateTime entrada = dTentrada.Value;
            DateTime saida = dTsaida.Value;
            TimeSpan timeSpan = saida - entrada;
            txtpreco.Text = Convert.ToString(timeSpan.Days * quartosmodelo.preçoq);
            /*DateTime datainr = dTentrada.Value;
            DateTime dataoutr = dTsaida.Value;
            if (datainr > dataoutr)
            {
                MessageBox.Show("A data de entrada não pode ser posterior à data de saída.");
            }*/
        }
        private void cbonhospedesr_SelectedIndexChanged(object sender, EventArgs e)
        {
            quartosmodelo.capacidadeq = (string)cbonhospedesr.SelectedItem;
        }

        private void txtcpf_Leave(object sender, EventArgs e)
        {
            hmodelo = hcontroller.Carregarhospede(txtcpf.Text);
        }
        
        private void AtualizarDataComMinMaxValue(object dataValue, DateTimePicker dateTimePicker)
        {
            DateTime data = DateTime.MinValue;
            if (dataValue != null && dataValue != DBNull.Value)
            {
                data = Convert.ToDateTime(dataValue);

                // Garante que a data está dentro dos limites do DateTimePicker
                if (data < dateTimePicker.MinDate)
                {
                    data = dateTimePicker.MinDate;
                }
                else if (data > dateTimePicker.MaxDate)
                {
                    data = dateTimePicker.MaxDate;
                }
            }
            dateTimePicker.Value = data;
        }
        
        private void AtualizarCamposHospede(int idHospede)
        {
            HospedeModelo hospedeModelo = hcontroller.ObterHospedePorId(idHospede);

            if (hospedeModelo != null)
            {
                txtcpf.Text = hospedeModelo.cpfh;
                txtnomeh.Text = hospedeModelo.nomeh;
            }
            else
            {
                // Tratar o caso em que o hospedeModelo é nulo (talvez exibir uma mensagem de erro)
                MessageBox.Show("Não foi possível carregar os dados do hóspede.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtreservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtreservas.Rows[e.RowIndex];
                
                object idhValue = row.Cells["idh"].Value;
                string idh = idhValue != null ? idhValue.ToString() : string.Empty;
                AtualizarCamposHospede(Convert.ToInt32(idhValue));

                object idqValue = row.Cells["idq"].Value;
                string idq = idqValue != null ? idqValue.ToString() : string.Empty;
                txtIdq.Text = idq;

                AtualizarDataComMinMaxValue(row.Cells["datainr"].Value, dTentrada);
                AtualizarDataComMinMaxValue(row.Cells["dataoutr"].Value, dTsaida);

                object precoValue = row.Cells["preçor"].Value;
                txtpreco.Text = precoValue != null ? precoValue.ToString() : string.Empty;

                object nhospedesrValue = row.Cells["nhospedesr"].Value;
                cbonhospedesr.Text = nhospedesrValue != null ? nhospedesrValue.ToString() : string.Empty;

                object statusrValue = row.Cells["statusr"].Value;
                cbostatus.Text = statusrValue != null ? statusrValue.ToString() : string.Empty;
 
            }
        }

        // Método para atualizar o DataGridView com as reservas
        private void AtualizarGridReservas()
        {
            dtreservas.DataSource = rcontroller.obterdados("select reservas.idh, reservas.idq, date_format(reservas.datainr,'%d %m %y %T') as datainr, date_format(reservas.dataoutr,'%d %m %y %T') as dataoutr, reservas.preçor, reservas.nhospedesr, reservas.statusr, reservas.idr from reservas");
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
