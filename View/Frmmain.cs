using Controller;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testando;

namespace UI_UX_Dashboard_P1
{
    public partial class Frmmain : Form
    {
        bool sidebarexpand;
        int idUsu;//crio a variavel do id usuario local
        //passo  oID pelo paramentro do
        //declaro os objeto para instanciar o usuario
        UsuarioController usController = new UsuarioController();
        UsuarioModelo usmodelo = new UsuarioModelo();
        public Frmmain(int codigo)
        {
            idUsu = codigo;//atribui a variavel local
            MessageBox.Show("Seja bem vindo Id" + codigo);
            InitializeComponent();
        }              
        private void btnmenu_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //carrego no usuario as informações
            usmodelo = usController.CarregaUsuario(idUsu);
            lblnomeusuario.Text = usmodelo.nome;
            if (usmodelo.idperfil == 1)
            {
                //deixar o menu invisivel
                btncadastros.Visible = false;
            }
            else
                if (usmodelo.idperfil == 2)
            {
                btncadastros.Visible = true;
            }
        }
        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button8_Click(object sender, EventArgs e)
        {

        }
        public void AddChildForm(Form childForm)
        {
            panel4.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel4.Controls.Add(childForm);
            childForm.Show();
        }

        //Botoes
        public void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnhome_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            Frmhome home = new Frmhome();
            home.TopLevel = false;
            panel4.Controls.Add(home);
            home.Show();
        }
        private void btnindicadores_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            Frmindicadores indicadores = new Frmindicadores();
            indicadores.TopLevel = false;
            panel4.Controls.Add(indicadores);
            indicadores.Show();
        }
        //add mapa
        private void btnreservas_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            Frmreservas reservas = new Frmreservas(0);
            reservas.TopLevel = false;
            panel4.Controls.Add(reservas);
            reservas.Show();
        }
        private void btnhospedes_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            Frmhospedes hospedes = new Frmhospedes();
            hospedes.TopLevel = false;
            panel4.Controls.Add(hospedes);
            hospedes.Show();
        }
        private void btmin_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            Check_in checkin = new Check_in();
            checkin.TopLevel = false;
            panel4.Controls.Add(checkin);
            checkin.Show();            
        }
        private void btnout_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            Check_out checkout = new Check_out();
            checkout.TopLevel = false;
            panel4.Controls.Add(checkout);
            checkout.Show();
        }
        private void btncadastros_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            Frmcadastros cadastros = new Frmcadastros();
            cadastros.TopLevel = false;
            panel4.Controls.Add(cadastros);
            cadastros.Show();
        }
        private void btnlogout_Click(object sender, EventArgs e)
        {
            //result guarda a resposta do botao
            var result = MessageBox.Show("Deseja sair do sistema?", "Sair do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Application.ExitThread();
                //FrmLogn login = new FrmLogn();
                //login.ShowDialog();

            }
        }//Fim dos botoes
        private void sidebartimer_Tick(object sender, EventArgs e)
        {
            if(sidebarexpand)
            {
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarexpand = false;
                    sidebartimer.Stop();
                }               
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarexpand = true;
                    sidebartimer.Stop();
                }
            }
        }  
    }
}
