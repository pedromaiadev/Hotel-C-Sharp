using Controller;
using Microsoft.Win32;
using Modelo;
using MySql.Data.MySqlClient;
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

        public Frmhome()
        {
            // Crie o painel e a label no construtor
            CreateRoomPanel();
            InitializeComponent();
        }
        private void Frmhome_Load(object sender, EventArgs e)
        {
            QuartosController quartoscontroller = new QuartosController();
            QuartosModelo quartosModelo = new QuartosModelo();
        }

        private void CreateRoomPanel()
        {
            //tabela de dados
            DataTable dt = new DataTable();
            //buscando e populando da datatable
            dt = com.obterdados("select * from quartos");
            DataTable res = new DataTable();
            res = com.obterdados("select * from reservas");
            DataTable hos = new DataTable();
            hos = com.obterdados("select * from hospedes");
            int registros;//ler a quantidade de dados
            int x = 10, y = 52;//posição da tela 
            //varrer os registros da table produto
            for (registros = 0; registros < dt.Rows.Count; registros++)
            {
                Panel roomPanel = new Panel();
                roomPanel.Size = new System.Drawing.Size(200, 50);
                roomPanel.Location = new System.Drawing.Point(x, y);
                Controls.Add(roomPanel);

                Label roomLabel = new Label();
                roomLabel.Text = dt.Rows[registros][0].ToString();
                roomLabel.Dock = DockStyle.Bottom;
                roomLabel.TextAlign = ContentAlignment.MiddleCenter;
                roomLabel.Size = new System.Drawing.Size(87, 23);
                roomLabel.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                roomPanel.Controls.Add(roomLabel);

                Panel borderPanel = new Panel();
                borderPanel.Size = new System.Drawing.Size(200, 180);
                borderPanel.Location = new System.Drawing.Point(x, y);
                borderPanel.BackColor = System.Drawing.Color.WhiteSmoke;
                borderPanel.BorderStyle = BorderStyle.FixedSingle;
                Controls.Add(borderPanel);

                Button btnreserva = new Button();
                btnreserva.Name = "btnreserva";
                btnreserva.Text = "Reservar";
                btnreserva.UseVisualStyleBackColor = false;
                btnreserva.Font = new Font("Arial", 8, FontStyle.Bold);
                //chamo o evento click do botao
                btnreserva.Click += new EventHandler((sender, e) => btnreservarClick(sender, e));
                btnreserva.Location = new Point(20, 150);
                
                Button btnmanutencao = new Button();
                btnmanutencao.Name = "btnmanutencao";
                btnmanutencao.Text = "Manutenção";
                btnmanutencao.UseVisualStyleBackColor = false;
                btnmanutencao.Font = new Font("Arial", 8, FontStyle.Bold);
                btnmanutencao.Location = new Point(20, 100);
                //btnmanutencao.Click += new EventHandler((sender, e) => btnreservarClick(sender, e));

                Button btncheckout = new Button();
                btncheckout.Name = "btncheckout";
                btncheckout.Text = "Checkout";
                btncheckout.UseVisualStyleBackColor = false;
                btncheckout.Font = new Font("Arial", 8, FontStyle.Bold);
                btncheckout.Location = new Point(20, 100);
                //btncheckout.Click += new EventHandler((sender, e) => btnreservarClick(sender, e));

                Button btnchamados = new Button();
                btnchamados.Name = "btnchamados";
                btnchamados.Text = "Chamados";
                btnchamados.UseVisualStyleBackColor = false;
                btnchamados.Font = new Font("Arial", 8, FontStyle.Bold);
                btnchamados.Location = new Point(20, 100);
                //btnchamados.Click += new EventHandler((sender, e) => btnchamadosClick(sender, e));

                Button btnliberar = new Button();
                btnliberar.Name = "btnliberar";
                btnliberar.Text = "Liberar";
                btnliberar.UseVisualStyleBackColor = false;
                btnliberar.Font = new Font("Arial", 8, FontStyle.Bold);
                btnliberar.Location = new Point(20, 100);
                //btnliberar.Click += new EventHandler((sender, e) => btnliberarrClick(sender, e));

                Label datain = new Label();
                datain.Text = res.Rows[registros][2].ToString();
                datain.Dock = DockStyle.Bottom;
                datain.TextAlign = ContentAlignment.MiddleCenter;
                datain.Size = new System.Drawing.Size(20, 150);
                datain.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);

                Label dataout = new Label();
                dataout.Text = res.Rows[registros][3].ToString();
                dataout.Dock = DockStyle.Bottom;
                dataout.TextAlign = ContentAlignment.MiddleCenter;
                dataout.Size = new System.Drawing.Size(110, 150);
                dataout.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);

                Label nomeh = new Label();
                nomeh.Text = hos.Rows[registros][0].ToString();
                nomeh.Dock = DockStyle.Bottom;
                nomeh.TextAlign = ContentAlignment.MiddleCenter;
                nomeh.Size = new System.Drawing.Size(64, 125);
                nomeh.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);

                switch (Convert.ToInt32(dt.Rows[registros][3]))
                {
                    case 1:
                        borderPanel.Controls.Add(btnreserva);
                        borderPanel.Controls.Add(btnmanutencao);
                        break;
                    case 2:
                        borderPanel.Controls.Add(nomeh);
                        borderPanel.Controls.Add(datain);
                        borderPanel.Controls.Add(dataout);
                        borderPanel.Controls.Add(btnmanutencao);
                        break;
                    case 3:
                        borderPanel.Controls.Add(nomeh);
                        borderPanel.Controls.Add(datain);
                        borderPanel.Controls.Add(dataout);
                        borderPanel.Controls.Add(btncheckout);
                        borderPanel.Controls.Add(btnchamados);
                        borderPanel.Controls.Add(btnmanutencao);
                        break;
                    case 4:
                        borderPanel.Controls.Add(nomeh);
                        borderPanel.Controls.Add(datain);
                        borderPanel.Controls.Add(dataout);
                        borderPanel.Controls.Add(btncheckout);
                        borderPanel.Controls.Add(btnchamados);
                        borderPanel.Controls.Add(btnmanutencao);
                        break;
                    case 5:
                        borderPanel.Controls.Add(nomeh);
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
                    panel.BackColor = System.Drawing.Color.Green;
                    break;
                case 2:
                    panel.BackColor = System.Drawing.Color.Yellow;
                    break;
                case 3:
                    panel.BackColor = System.Drawing.Color.Red;
                    break;
                case 4:
                    panel.BackColor = System.Drawing.Color.Blue;
                    break;
                case 5:
                    panel.BackColor = System.Drawing.Color.Gray;
                    break;
                default:
                    panel.BackColor = System.Drawing.Color.White;
                    break;
            }
        }
        private void btnreservarClick(object sender, EventArgs e)
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
        }
    }
}

