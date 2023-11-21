using Controller;
using Microsoft.Win32;
using Modelo;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_UX_Dashboard_P1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace testando
{
    public partial class Frmhome : Form
    {
        Conexao com = new Conexao();
        QuartosController quartoscontroller = new QuartosController();
        QuartosModelo quartosModelo = new QuartosModelo();
        public Frmhome()
        {
            InitializeComponent();
            CreateFromReservas();
            CreateFromHospedes();
        }
        private List<Label> CreateFromHospedes()
        {
            int registros;
            List<Label> labels = new List<Label>();
            DataTable hos = new DataTable();
            hos = com.obterdados("SELECT h.nomeh FROM hospedes h INNER JOIN reservas r on h.idh = r.idh WHERE r.idh IS NOT NULL");
            for (registros = 0; registros < hos.Rows.Count; registros++)
            {
                Label nomeh = new Label();
                nomeh.Text = hos.Rows[registros][0].ToString();
                nomeh.Dock = DockStyle.Bottom;
                nomeh.TextAlign = ContentAlignment.MiddleCenter;
                nomeh.Location = new System.Drawing.Point(13, 63);
                nomeh.Size = new System.Drawing.Size(13, 63);
                nomeh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                labels.Add(nomeh);
            }
            return labels;
        }
        //Label dataout = new Label();
        //Label datain = new Label();
        private List<Label> CreateFromReservas()
        {
            List<Label> reservasLabels = new List<Label>();
            int registros;
            DataTable res = new DataTable();
            res = com.obterdados("select reservas.idh, reservas.idq, date_format(reservas.datainr,'%d %m %y %T') as datainr, date_format(reservas.dataoutr,'%d %m %y %T') as dataoutr, reservas.preçor, reservas.statusr from reservas");
            for (registros = 0; registros < res.Rows.Count; registros++)
            {
                Label datain = new Label();
                datain.Text = res.Rows[registros][2].ToString();
                datain.Dock = DockStyle.Bottom;
                datain.TextAlign = ContentAlignment.MiddleCenter;
                datain.Location = new System.Drawing.Point(35, 87);
                datain.Size = new System.Drawing.Size(20, 150);
                datain.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                reservasLabels.Add(datain);

                Label dataout = new Label();
                dataout.Text = res.Rows[registros][3].ToString();
                dataout.Dock = DockStyle.Bottom;
                dataout.TextAlign = ContentAlignment.MiddleCenter;
                dataout.Location = new System.Drawing.Point(35, 114);
                dataout.Size = new System.Drawing.Size(110, 150);
                dataout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                reservasLabels.Add(dataout);
            }
            return reservasLabels;
        }
        private void Frmhome_Load(object sender, EventArgs e)
        {
            //tabela de dados
            DataTable dt = new DataTable();
            //buscando e populando da datatable
            dt = com.obterdados("select * from quartos");
            int registros;//ler a quantidade de dados
            int x = 10, y = 52;//posição da tela 
            //varrer os registros da table produto
            for (registros = 0; registros < dt.Rows.Count; registros++)
            {
                Panel borderPanel = new Panel();
                borderPanel.Size = new System.Drawing.Size(200, 220);
                borderPanel.Location = new System.Drawing.Point(x, y);
                borderPanel.BackColor = System.Drawing.Color.WhiteSmoke;
                borderPanel.BorderStyle = BorderStyle.FixedSingle;

                //CreateRoomPanel(borderPanel);
                Panel roomPanel = new Panel();
                roomPanel.Size = new System.Drawing.Size(200, 50);
                roomPanel.Location = new System.Drawing.Point(0, 0);

                Label roomLabel = new Label();
                roomLabel.Text = dt.Rows[registros][0].ToString();
                roomLabel.Dock = DockStyle.Bottom;
                roomLabel.TextAlign = ContentAlignment.MiddleCenter;
                roomLabel.Size = new System.Drawing.Size(87, 23);
                roomLabel.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                roomLabel.ForeColor = Color.White;

                roomPanel.Controls.Add(roomLabel);
                borderPanel.Controls.Add(roomPanel);
                Controls.Add(borderPanel);
                
                Button btnreserva = new Button();
                btnreserva.Name = "btnreserva";
                btnreserva.Text = "Reservar";
                btnreserva.UseVisualStyleBackColor = false;
                btnreserva.Font = new Font("Arial", 8, FontStyle.Bold);
                //chamo o evento click do botao
                btnreserva.Click += btnreservarClick;
                btnreserva.Tag = dt.Rows[registros][4];
                //btnreserva.Click += new EventHandler((sender1, e1) => btnreservarClick(sender1, e1));
                btnreserva.Location = new Point(13, 63);

                Button btnmanutencao = new Button();
                btnmanutencao.Name = "btnmanutencao";
                btnmanutencao.Text = "Manutenção";
                btnmanutencao.UseVisualStyleBackColor = false;
                btnmanutencao.Font = new Font("Arial", 8, FontStyle.Bold);
                btnmanutencao.Location = new Point(48, 168);
                btnmanutencao.Click += new EventHandler((sender2, e2) => btnmanutencaoClick(sender, e));

                Button btncheckout = new Button();
                btncheckout.Name = "btncheckout";
                btncheckout.Text = "Checkout";
                btncheckout.UseVisualStyleBackColor = false;
                btncheckout.Font = new Font("Arial", 8, FontStyle.Bold);
                btncheckout.Location = new Point(48, 141);
                //btncheckout.Click += new EventHandler((sender, e) => btncheckoutClick(sender, e));

                Button btnchamados = new Button();
                btnchamados.Name = "btnchamados";
                btnchamados.Text = "Chamados";
                btnchamados.UseVisualStyleBackColor = false;
                btnchamados.Font = new Font("Arial", 8, FontStyle.Bold);
                btnchamados.Location = new Point(48, 195);
                //btnchamados.Click += new EventHandler((sender, e) => btnchamadosClick(sender, e));

                Button btnliberar = new Button();
                btnliberar.Name = "btnliberar";
                btnliberar.Text = "Liberar";
                btnliberar.UseVisualStyleBackColor = false;
                btnliberar.Font = new Font("Arial", 8, FontStyle.Bold);
                btnliberar.Location = new Point(48, 168);
                //btnliberar.Click += new EventHandler((sender, e) => btnliberarrClick(sender, e));

                panelquartos.Controls.Add(borderPanel);

                List<Label> hospedeLabels = CreateFromHospedes();
                List<Label> reservasLabels = CreateFromReservas();

                switch (Convert.ToInt32(dt.Rows[registros][3]))
                {
                    case 1:
                        borderPanel.Controls.Add(btnreserva);
                        borderPanel.Controls.Add(btnmanutencao);
                        break;
                    case 2:
                        foreach (Label label in hospedeLabels)
                        {
                            borderPanel.Controls.Add(label);//Nome hospede
                        }
                        foreach (Label label in reservasLabels)
                        {
                            borderPanel.Controls.Add(label);//Data de entrada data de saida
                        }
                        //borderPanel.Controls.Add(datain);
                        //borderPanel.Controls.Add(dataout);
                        borderPanel.Controls.Add(btnmanutencao);
                        break;
                    case 3:
                        foreach (Label label in hospedeLabels)
                        {
                            borderPanel.Controls.Add(label);//Nome hospede
                        }
                        foreach (Label label in reservasLabels)
                        {
                            borderPanel.Controls.Add(label);//Data de entrada data de saida
                        }
                        borderPanel.Controls.Add(btncheckout);
                        borderPanel.Controls.Add(btnchamados);
                        borderPanel.Controls.Add(btnmanutencao);
                        break;
                    case 4:
                        foreach (Label label in hospedeLabels)
                        {
                            borderPanel.Controls.Add(label);//Nome hospede
                        }
                        foreach (Label label in reservasLabels)
                        {
                            borderPanel.Controls.Add(label);//Data de entrada data de saida
                        }
                        borderPanel.Controls.Add(btncheckout);
                        borderPanel.Controls.Add(btnchamados);
                        borderPanel.Controls.Add(btnmanutencao);
                        break;
                    case 5:
                        borderPanel.Controls.Add(btnliberar);
                        borderPanel.Controls.Add(btnchamados);
                        break;
                }
                y += 0;
                x = 232;
                LoadStatusAndChangeColor(roomPanel, Convert.ToInt32(dt.Rows[registros][3]));
            }
        }
        private void LoadStatusAndChangeColor(Panel panel, int statusid)
        {
            // Define a cor do painel com base no status usando switch case
            switch (statusid)
            {
                case 1:
                    panel.BackColor = System.Drawing.Color.SeaGreen;
                    break;
                case 2:
                    panel.BackColor = System.Drawing.Color.FromArgb(192,192,0);
                    break;
                case 3:
                    panel.BackColor = System.Drawing.Color.Sienna;
                    break;
                case 4:
                    panel.BackColor = System.Drawing.Color.FromArgb(52,152,219);
                    break;
                case 5:
                    panel.BackColor = System.Drawing.SystemColors.ControlText;
                    break;
                default:
                    panel.BackColor = System.Drawing.Color.White;
                    break;
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void btnreservarClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn.Tag != null)
            {
                // Recupera o número do quarto da tag
                if (int.TryParse(btn.Tag.ToString(), out int roomNumber))
                {
                    // Verifica se o FormMain já está aberto
                    Frmmain formMain = Application.OpenForms.OfType<Frmmain>().FirstOrDefault();
                    if (formMain != null)
                    {
                        Frmreservas formReservas = new Frmreservas(roomNumber);
                        formMain.AddChildForm(formReservas);
                        formReservas.AtualizarComboBoxQuarto(roomNumber);
                    }
                }
            }
        }

        /*private void btnreservarClick(object sender, EventArgs e)
        {
            // Conexão com o banco de dados    
            Conexao con = new Conexao();
            MySqlConnection sqlcon = con.getConexao();
            sqlcon.Open();
            // Consulta SQL para obter o número do quarto desejado
            string sql = "SELECT idq FROM quartos";
            MySqlCommand cmd = new MySqlCommand(sql, sqlcon);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            
            int numeroQuarto = (int)cmd.ExecuteScalar();
            // Verifica se o FormMain já está aberto
            Frmmain formMain = Application.OpenForms.OfType<Frmmain>().FirstOrDefault();
            if (formMain != null)
            {
                Frmreservas formReservas = new Frmreservas(numeroQuarto);
                formMain.AddChildForm(formReservas);
            }
        }*/
        /*private void ScheduleRoomMaintenance(int roomNumber, int maintenanceDurationInDays)
        {
            // Verifica se o quarto já está em manutenção
            if (IsRoomUnderMaintenance(roomNumber))
            {
                MessageBox.Show("O quarto já está em manutenção.");
                return;
            }

            // Atualiza o status do quarto para "Manutenção"
            UpdateRoomStatus(roomNumber, RoomStatus.Maintenance);

            // Agenda uma tarefa para mudar o status de volta para "Disponível" após o período de manutenção
            var currentTime = DateTime.Now;
            var endOfMaintenance = currentTime.AddDays(maintenanceDurationInDays);

            Task.Delay(endOfMaintenance - currentTime).ContinueWith(task =>
            {
                // Verifica se o quarto ainda está em manutenção antes de mudar o status de volta para "Disponível"
                if (IsRoomUnderMaintenance(roomNumber))
                {
                    UpdateRoomStatus(roomNumber, RoomStatus.Available);
                }
            });
        }*/
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void btnmanutencaoClick(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Realmente deseja realizar uma Manutenção no Quarto?", "Realizar Manutenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                //int roomNumber = ExtractRoomNumberFromButton(sender);
                //ScheduleRoomMaintenance(roomNumber, 7);
                //Frmmanutençaõ manutençaõ = new Frmmanutençaõ();
                //manutençaõ.ShowDialog();
            }
        }
        /*private void btnmanutencaoClick(object sender, EventArgs e)
        {

            //e modifica o status do quarto para manutenção,
            
            var result = MessageBox.Show("Realmente deseja realizar uma Manutenção no Quarto?", "Realizar Manutenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                //Frmmanutençaõ manutençaõ = new Frmmanutençaõ();
                //manutençaõ.ShowDialog();
            }
        }*/
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void btncheckoutClick(object sender, EventArgs e)
        {
            //abre o frmcheckout do quarto
        }
        private void btnliberarClick(object sender, EventArgs e)
        {
            //libera o quarto modificando o status do quarto para disponivel
            //AtualizarStatusQuarto(numeroQuarto, StatusDisponivel);
        }
        // Método para extrair o número do quarto do botão clicado
        
    }
}