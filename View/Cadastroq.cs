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
    public partial class Cadastroq : Form
    {
        //instancio o objeto qcontroller
        QuartosController qcontroller = new QuartosController();
        QuartosModelo qmodelo = new QuartosModelo();
        int codigo;
        int idstatus;
        public Cadastroq()
        {
            InitializeComponent();
        }
        private void Cadastroq_Load(object sender, EventArgs e)
        {
            QuartosController qcontroller = new QuartosController();
            dtQuartos.DataSource = qcontroller.obterdados("select quartos.nomeq, quartos.capacidadeq, quartos.preçoq, quartos.status_id, quartos.idq from quartos inner join status on status.idstatus = quartos.status_id");
            cbostatusid.DataSource = qcontroller.obterdados("select * from status");
            cbostatusid.DisplayMember = "status";
            cbostatusid.ValueMember = "idstatus";
        }
        // CRUD inicio
        private void btnConectar_Click(object sender, EventArgs e)
        {

        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            qmodelo.nomeq = txtnquarto.Text;
            qmodelo.preçoq = Convert.ToSingle(txtpreçoq.Text);
            qmodelo.capacidadeq = txtcapacidadeq.Text;
            qmodelo.status_id = idstatus.ToString();
            if (qmodelo.nomeq != "" && qmodelo.capacidadeq != "" && qmodelo.preçoq.ToString() != "" && qmodelo.status_id != "")
            {
                if (qcontroller.cadastrar(qmodelo) == true)
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
            //populando o objeto qmodelo modelo
            qmodelo.nomeq = txtnquarto.Text;
            qmodelo.preçoq = Convert.ToSingle(txtpreçoq.Text);
            qmodelo.capacidadeq = txtcapacidadeq.Text;
            qmodelo.status_id = idstatus.ToString();
            if (qcontroller.editar(qmodelo) == true)
            {
                MessageBox.Show("Quarto atualizado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar quarto");
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            qcontroller.excluir(codigo);
            if (qcontroller.excluir(codigo) == true)
            {
                MessageBox.Show("codigo do quarto " + codigo + " excluido com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao excluir o quarto");
            }
        }
        //FIM DO CRUD
        private void dtQuartos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnquarto.Text = dtQuartos.Rows[e.RowIndex].Cells["nomeq"].Value.ToString();
            txtpreçoq.Text = dtQuartos.Rows[e.RowIndex].Cells["preçoq"].Value.ToString();
            txtcapacidadeq.Text = dtQuartos.Rows[e.RowIndex].Cells["capacidadeq"].Value.ToString();
            cbostatusid.Text = dtQuartos.Rows[e.RowIndex].Cells["status_id"].Value.ToString();
        }
        private void cbotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //variavel perfil convert para inteiro
            idstatus = Convert.ToInt32(((DataRowView)cbostatusid.SelectedItem)["idstatus"]);
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
                    btnFoto.Text = fotoq.FileName;
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

    }
}
