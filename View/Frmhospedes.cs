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

namespace testando
{
    public partial class Frmhospedes : Form
    {
        int codigo;
        public Frmhospedes()
        {
            InitializeComponent();
        }
        private void Cadastroh_Load(object sender, EventArgs e)
        {
            HospedeController hcontroller = new HospedeController();
            dtHospede.DataSource = hcontroller.obterdados("select hospedes.nomeh,hospedes.emailh, hospedes.telefoneh, hospedes.cpfh, hospedes.fotoh, hospedes.idh from hospedes");
            /*cbotipo.DataSource = qcontroller.obterdados("select * from status");
            cbotipo.DisplayMember = "status";
            cbotipo.ValueMember = "idstatus";*/
        }
        // CRUD inicio
        private void btnConectar_Click(object sender, EventArgs e)
        {

        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            HospedeController hcontroller = new HospedeController();
            HospedeModelo hmodelo = new HospedeModelo();
            hmodelo.nomeh = txtnomeh.Text;
            hmodelo.emailh = txtemailh.Text;
            hmodelo.telefoneh = txttelefoneh.Text;
            hmodelo.cpfh = txtcpfh.Text;
            hmodelo.fotoh = ptbfoto.Text;
            if (hmodelo.nomeh != "" && hmodelo.emailh != "" && hmodelo.telefoneh.ToString() != "" || hmodelo.cpfh.ToString() != "" && hmodelo.fotoh != "")
            {
                if (hcontroller.cadastrar(hmodelo) == true)
                {
                    MessageBox.Show("cadastro com sucesso!");

                }
                else
                {
                    MessageBox.Show("Erro no cadastro do Quarto");
                }
            }
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            HospedeController hcontroller = new HospedeController();
            HospedeModelo hmodelo = new HospedeModelo();
            hmodelo.nomeh = txtnomeh.Text;
            hmodelo.emailh = txtemailh.Text;
            hmodelo.telefoneh = txttelefoneh.Text;
            hmodelo.cpfh = txtcpfh.Text;
            hmodelo.fotoh = ptbfoto.Text;

            if (hcontroller.editar(hmodelo) == true)
            {
                MessageBox.Show("Hospede atualizado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar Hospede");
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            HospedeController hcontroller = new HospedeController();
            if (hcontroller.excluir(codigo) == true)
            {
                MessageBox.Show("codigo do hospede " + codigo + " excluido com sucesso");
            }
            else
            {//falso erro ao excluir
                MessageBox.Show("Erro ao excluir o hospede");
            }
        }
        //FIM DO CRUD
        private void dtHospede_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnomeh.Text = dtHospede.Rows[e.RowIndex].Cells["nomeh"].Value.ToString();
            txttelefoneh.Text = dtHospede.Rows[e.RowIndex].Cells["telefoneh"].Value.ToString();
            txtemailh.Text = dtHospede.Rows[e.RowIndex].Cells["emailh"].Value.ToString();
            txtcpfh.Text = dtHospede.Rows[e.RowIndex].Cells["cpfh"].Value.ToString();
            ptbfoto.Text = dtHospede.Rows[e.RowIndex].Cells["fotoh"].Value.ToString();
            codigo = Convert.ToInt32(dtHospede.Rows[e.RowIndex].Cells["idh"].Value.ToString());  
        }
        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                //chamo a caixa de dialogo para foto
                OpenFileDialog fotoq = new OpenFileDialog();
                fotoq.Filter = "Image File(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
                //verifica se apertou no OK do dialog
                if (fotoq.ShowDialog() == DialogResult.OK)
                { //mostra o nome da foto
                    btnfotoh.Text = fotoq.FileName;
                    //caminho da imagem para ser exibida no form
                    Image arquivo = Image.FromFile(fotoq.FileName);
                    ptbfoto.Image = arquivo;//carrego a foto
                }
                else
                {
                    MessageBox.Show("Não escolheu a foto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        /*private void cbotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //variavel perfil convert para inteiro
            idstatus = Convert.ToInt32(((DataRowView)cbotipo.SelectedItem)["idstatus"]);
        }*/
    }
}
