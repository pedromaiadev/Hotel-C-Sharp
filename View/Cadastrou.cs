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
    public partial class Cadastrou : Form
    {
        UsuarioController uscontroller = new UsuarioController();
        UsuarioModelo usmodelo = new UsuarioModelo();
        int codigo;
        int idperfil;//declaro o perfil publico
        public Cadastrou()
        {
            InitializeComponent();
        }
        private void usuario_Load(object sender, EventArgs e)
        {
            dtUsuario.DataSource = uscontroller.obterdados("select usuario.idusuario,usuario.nome,usuario.email,usuario.senha,usuario.fotousu,perfil.perfil from usuario inner join perfil on usuario.idperfil=perfil.id_perfil;");
            cboPerfil.DataSource = uscontroller.obterdados("select * from perfil");
            cboPerfil.DisplayMember = "perfil";
            cboPerfil.ValueMember = "id_perfil";
        }
        // CRUD inicio
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            usmodelo.nome = txtNome.Text;
            usmodelo.senha = txtSenha.Text;
            usmodelo.idperfil = idperfil;
            usmodelo.email = txtEmail.Text;
            usmodelo.fotousu = ptbusu.Text;
            if (usmodelo.nome != "" && usmodelo.senha != "")
            {
                if (uscontroller.cadastrar(usmodelo) == true)
                {
                    MessageBox.Show("cadastro com sucesso!");

                }
                else
                {
                    MessageBox.Show("Erro no cadastro d ousuário");
                }
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //chamo o metodo excluir do usuario controler se verdade
            if (uscontroller.excluir(codigo) == true)
            { //excluir o usuario
                MessageBox.Show("codigo do Usuário " + codigo + " excluido com sucesso");

            }
            else
            {//falso erro ao excluir
                MessageBox.Show("Erro ao excluir o usuário");
            }
            dtUsuario.Refresh();
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            usmodelo.nome = txtNome.Text;
            usmodelo.senha = txtSenha.Text;
            usmodelo.idperfil = idperfil;
            usmodelo.idusuario = codigo;
            usmodelo.email = txtEmail.Text;
            usmodelo.fotousu = ptbusu.Text;
            if (uscontroller.editar(usmodelo) == true)
            {
                MessageBox.Show("Usuario atualizado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar usuário");
            }
            dtUsuario.Refresh();
        }
        //FIM DO CRUD
        private void cboPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            //variavel perfil convert para inteiro
            idperfil = Convert.ToInt32(((DataRowView)cboPerfil.SelectedItem)["id_perfil"]);
        }
        private void dtUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = Convert.ToInt32(dtUsuario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            MessageBox.Show("Codigo " + codigo.ToString());
            txtNome.Text = dtUsuario.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtSenha.Text = dtUsuario.Rows[e.RowIndex].Cells["senha"].Value.ToString();
            txtEmail.Text = dtUsuario.Rows[e.RowIndex].Cells["email"].Value.ToString();
            cboPerfil.Text = dtUsuario.Rows[e.RowIndex].Cells["perfil"].Value.ToString();
        }
        private void btnfoto_Click(object sender, EventArgs e)
        {
            try
            {
                //chamo a caixa de dialogo para foto
                OpenFileDialog foto = new OpenFileDialog();
                foto.Filter = "Image File(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
                //verifica se apertou no OK do dialog
                if (foto.ShowDialog() == DialogResult.OK)
                { //mostra o nome da foto
                    btnfoto.Text = foto.FileName;
                    //caminho da imagem para ser exibida no form
                    Image arquivo = Image.FromFile(foto.FileName);
                    ptbusu.Image = arquivo;//carrego a foto
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
