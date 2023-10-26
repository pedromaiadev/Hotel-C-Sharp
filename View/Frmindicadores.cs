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
    public partial class Frmindicadores : Form
    {
        public Frmindicadores()
        {
            InitializeComponent();
        }
        private void Frmindicadores_Load(object sender, EventArgs e)
        {
            Conexao con = new Conexao();
            //grafico.DataSource = con.obterdados("select count(*) as qtde, status_id from hopedes, where status_id = ativo");
        }
    }
}
