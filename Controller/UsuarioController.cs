using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Modelo;
using System.Data;
using System.Management;
using PdfSharp;//bliblioteca gera PDF
using PdfSharp.Drawing;//para desenho
using PdfSharp.Pdf;// conversao
using System.Diagnostics;
using System.Xml.Linq;

namespace Controller
{
    public class UsuarioController
    {//instanciei o objeto conexao
        Conexao con = new Conexao();
        //criando o metodo de cadastrar usuário
        public bool cadastrar( UsuarioModelo usuario)//passo o objeto usuario
        {//declaro a variavel da resposta da query
            bool resultado = false;
            string sql = "insert into usuario(nome,senha,idperfil,idusuario,email,fotousu)"+"values('"+usuario.nome+"','"+con.getMD5Hash(usuario.senha)+"','"+usuario.idperfil+"','"+usuario.idusuario+"','"+usuario.email+"','"+usuario.fotousu+"')";
            //chamando minha conexao
            MySqlConnection sqlCon = con.getConexao();
            sqlCon.Open();//abrindo o banco
            MySqlCommand cmd =new MySqlCommand(sql, sqlCon);
            if (cmd.ExecuteNonQuery() >= 1)//executar o seu sql
            resultado = true;
            sqlCon.Close();//fecho a conexao
            return resultado;//retorno o valor
        }
        public DataTable obterdados(string sql)
        {
            DataTable dt = new DataTable();
            MySqlConnection sqlCon = con.getConexao();
            sqlCon.Open();//abrindo o banco
            MySqlCommand cmd = new MySqlCommand(sql, sqlCon);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool excluir(int codigo)
        {
            bool resultado = false;
            string sql = "DELETE FROM usuario where idusuario=" +codigo;
            //chamando minha conexao
            MySqlConnection sqlCon = con.getConexao();
            sqlCon.Open();//abrindo o banco
            MySqlCommand cmd = new MySqlCommand(sql, sqlCon);
            cmd.CommandType =System.Data.CommandType.Text;
            cmd.CommandText = sql;
            if (cmd.ExecuteNonQuery() >= 1)//executar o seu sql
                resultado = true;
            sqlCon.Close();//fecho a conexao
            return resultado;//retorno o valor
        }
        public bool editar(UsuarioModelo us)
        {
            bool resultado = false;
            string sql = "update usuario set nome=@nome,senha=@senha,email=@email,idperfil=@idperfil,fotousu=@fotousu where idusuario=@id";
            MySqlConnection sqlcon=con.getConexao();
            sqlcon.Open();
            MySqlCommand command = new MySqlCommand(sql, sqlcon);   
            command.CommandType =System.Data.CommandType.Text;
            command.CommandText = sql;
            // substituindo a variavel @___ pelo conteudo do objeto
            command.Parameters.AddWithValue("@nome", us.nome);
            command.Parameters.AddWithValue("@senha", con.getMD5Hash(us.senha));
            command.Parameters.AddWithValue("@email", us.email);
            command.Parameters.AddWithValue("@idperfil", us.idperfil);
            command.Parameters.AddWithValue("@id", us.idusuario);
            command.Parameters.AddWithValue("@fotousu", us.fotousu);
            if ( command.ExecuteNonQuery()>=1)
                resultado=true;
           sqlcon.Close();
            return resultado;
        }
        //metodo para carregar o usuario
        public UsuarioModelo CarregaUsuario(int codigo)
        {
            UsuarioModelo us = new UsuarioModelo();
            MySqlConnection sqlcon = con.getConexao();
            sqlcon.Open();
            string sql = "SELECT * from usuario where idusuario=@id";
            MySqlCommand cmd = new MySqlCommand(sql, sqlcon);
            cmd.Parameters.AddWithValue("@id", codigo);//substituo o valor do codigo
            MySqlDataReader registro=cmd.ExecuteReader();//leia os dados da consulta
            if(registro.HasRows)//existe linha de registro
            {
                registro.Read();//leia o registro
                //gravando as informações no modelo usuario
                us.nome = registro["nome"].ToString();
                us.senha = registro["senha"].ToString();
                us.email = registro["email"].ToString();
                us.idusuario = Convert.ToInt32(registro["idusuario"]);
                us.idperfil = Convert.ToInt32(registro["idperfil"]);
            }
            sqlcon.Close();
            return us;
        }
        //finaliza o metodo
        public int logar(UsuarioModelo us)
        {//validar
            try
            {
               
                int registro=0;//retorna o numero de registro
                string sql = "SELECT idusuario from usuario where nome=@usuario and senha=@senha";
                MySqlConnection sqlcon = con.getConexao();
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(sql, sqlcon);
                cmd.Parameters.AddWithValue("@usuario", us.nome);
                cmd.Parameters.AddWithValue("@senha", us.senha);
                registro = Convert.ToInt32(cmd.ExecuteScalar());//retornar o valor
               
               return registro; //devolvo o ID do usuário
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void gerarPDF(string sql)
        {//chamo minha conexao mysql
            MySqlConnection SqlCon = con.getConexao();
            //preparo o comando sql
            MySqlCommand cmd = new MySqlCommand(sql, SqlCon);
            MySqlDataAdapter dados;//prepara os dados
            UsuarioModelo us = new UsuarioModelo();
            DataSet ds = new DataSet();
            try // teste de consulta
            {
                int i = 0;//registro
                int ypoint = 0;//espaco do conteudo
                SqlCon.Open();//abro a conexao
                dados = new MySqlDataAdapter(cmd);//recuperando sa informacoes
                dados.Fill(ds);//carrega as informacoes geradas
                PdfDocument pdf = new PdfDocument();
                //chamo a instancia do PDF
                pdf.Info.Title = "Listar Usuario";
                PdfPage page = pdf.AddPage();//gerar uma nova pagina
                XGraphics grafic = XGraphics.FromPdfPage(page);
                //defino a font e o tamanho
                XFont font = new XFont("arial", 12, XFontStyle.Regular);
                ypoint = ypoint + 75;
                grafic.DrawString(ds.Tables[0].Columns[0].ColumnName, font, XBrushes.Black, new XRect(20, ypoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                grafic.DrawString(ds.Tables[0].Columns[1].ColumnName, font, XBrushes.Black, new XRect(120, ypoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                grafic.DrawString(ds.Tables[0].Columns[3].ColumnName, font, XBrushes.Black, new XRect(220, ypoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                ypoint = ypoint + 75;//nova posiçao
                for (i= 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    //guarde no objeto nome p resultado da coluna
                    us.idusuario = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                    us.nome = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    us.idperfil = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[3].ToString());
                    grafic.DrawString(us.idusuario.ToString(), font, XBrushes.Black,new XRect(20, ypoint, page.Width.Point, page.Height.Point),XStringFormats.TopLeft);
                    grafic.DrawString(us.nome, font, XBrushes.Black, new XRect(120, ypoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    grafic.DrawString(us.idperfil.ToString(), font, XBrushes.Black, new XRect(220, ypoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    ypoint = ypoint + 30;
                }//defino o nome do arquivo pdf
                string pdffilename = "listarusuario.pdf";
                pdf.Save(pdffilename);//salvo o arquivo em pdf
                Process.Start(pdffilename);//abro o arquivo salvo
            }catch(Exception ex)
            {
                throw new ApplicationException(ex.ToString());
            }
        }
    }
    
}
