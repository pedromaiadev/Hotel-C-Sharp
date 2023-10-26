using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class QuartosController
    {
        //instanciei o objeto conexao
        Conexao con = new Conexao();
        //criando o metodo de cadastrar Quartos
        public bool cadastrar(QuartosModelo quartos)//passo o objeto quartos
        {//declaro a variavel da resposta da query
            bool resultado = false;
            string sql = "insert into quartos(nomeq,capacidadeq,preçoq,status_id,idq) " +
                "values('" + quartos.nomeq + "','" + quartos.capacidadeq + "'" +
                "," + quartos.preçoq + ",'" + quartos.status_id + "','" + quartos.idq + "')";
            //chamando minha conexao
            MySqlConnection sqlCon = con.getConexao();
            sqlCon.Open();//abrindo o banco
            MySqlCommand cmd = new MySqlCommand(sql, sqlCon);
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
            string sql = "DELETE FROM quartos where idq=" + codigo;
            //chamando minha conexao
            MySqlConnection sqlCon = con.getConexao();
            sqlCon.Open();//abrindo o banco
            MySqlCommand cmd = new MySqlCommand(sql, sqlCon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            if (cmd.ExecuteNonQuery() >= 1)//executar o seu sql
                resultado = true;
            sqlCon.Close();//fecho a conexao
            return resultado;//retorno o valor
        }
        public bool editar(QuartosModelo us)
        {
            bool resultado = false;
            //string sql = "select quartos.nomeq, quartos.capacidadeq, quartos.preçoq, quartos.status_id, quartos.idq from quartos inner join status on status.idstatus = quartos.status_id";
            string sql = "UPDATE quartos set nomeq=@nomeq,capacidadeq=@capacidadeq,preçoq=@preçoq,status_id=@status_id where idq=@idq ";
            MySqlConnection sqlcon = con.getConexao();
            sqlcon.Open();
            MySqlCommand command = new MySqlCommand(sql, sqlcon);
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = sql;
            // substituindo a variavel @___ pelo conteudo do objeto
            command.Parameters.AddWithValue("@nomeq", us.nomeq);
            command.Parameters.AddWithValue("@capacidadeq", us.capacidadeq);
            command.Parameters.AddWithValue("@preçoq", us.preçoq);
            command.Parameters.AddWithValue("@status_id", us.status_id);
            command.Parameters.AddWithValue("@idq", us.idq);
            if (command.ExecuteNonQuery() >= 1)
                resultado = true;
            sqlcon.Close();
            return resultado;
        }
        //metodo para carregar o usuario
        public QuartosModelo Carregaquartos(int codigo)
        {
            QuartosModelo us = new QuartosModelo();
            MySqlConnection sqlcon = con.getConexao();
            sqlcon.Open();
            string sql = "SELECT * from quartos where idq=@idq";
            MySqlCommand cmd = new MySqlCommand(sql, sqlcon);
            cmd.Parameters.AddWithValue("@idq", codigo);//substituo o valor do codigo
            MySqlDataReader registro = cmd.ExecuteReader();//leia os dados da consulta
            if (registro.HasRows)//existe linha de registro
            {
                registro.Read();//leia o registro
                //gravando as informações no modelo usuario
                us.nomeq = registro["nomeq"].ToString();
                us.capacidadeq = registro["capacidadeq"].ToString();
                us.preçoq = Convert.ToInt32(registro["preçoq"]);
                us.status_id = registro["status_id"].ToString();
                us.idq = Convert.ToInt32(registro["idq"]);
            }
            sqlcon.Close();
            return us;
        }
        //finaliza o metodo
    }
}
