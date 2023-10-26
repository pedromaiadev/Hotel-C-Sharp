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

namespace testando
{
    public partial class Frmcadastros : Form
    {
        public Frmcadastros()
        {
            InitializeComponent();
        }
        private void usuario_Load(object sender, EventArgs e)
        {
            
        }
        private void btncquarto_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Cadastroq cadastrarq = new Cadastroq();
            cadastrarq.TopLevel = false;
            panel1.Controls.Add(cadastrarq);
            cadastrarq.Show();
        }
        private void btncusu_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Cadastrou cadastraru = new Cadastrou();
            cadastraru.TopLevel = false;
            panel1.Controls.Add(cadastraru);
            cadastraru.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Cadastrop cadastrarp = new Cadastrop();
            cadastrarp.TopLevel = false;
            panel1.Controls.Add(cadastrarp);
            cadastrarp.Show();
        }
    }
}
