using Controller;
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
    public partial class FrmListarUsuario : Form
    {
        string sql;//variavel global
        //instancio o usuario controller
        UsuarioController uscontroller = new UsuarioController();

        public FrmListarUsuario()
        {
            InitializeComponent();
        }

        private void FrmListarUsuario_Load(object sender, EventArgs e)
        {
            sql = "SELECT * from usuario";
             dtUsuario.DataSource=uscontroller.obterdados(sql);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string sql;
            int valor;
            if (string.IsNullOrEmpty(txtPesquisar.Text))
            {
                sql = "SELECT * from usuario";
            }
            else
            {
                //receber um valor logico
                //verificar se o valor convert em inteiro
                bool teste=int.TryParse(txtPesquisar.Text, out valor);
                if (teste)
                {
                 sql = "SELECT * from usuario where idusuario=" + valor;
                }
                else
                {
                 sql = "SELECT * from usuario where nome" +
                        " like '%" + txtPesquisar.Text + "%'";

                }
            }
            dtUsuario.DataSource = uscontroller.obterdados(sql);

        }
    }
}
