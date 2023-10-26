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
    public class ReservasController
    {//instanciei o objeto conexao
        Conexao con = new Conexao();
        //criando o metodo de cadastrar reservas
        public bool cadastrar(ReservasModelo reservas)//passo o objeto reservas
        {//declaro a variavel da resposta da query
            bool resultado = false;
            string sql = "insert into reservas(idh,idq,datainr,dataoutr,preçor,nhospedesr,statusr)" + "values(" + reservas.idh + "," + reservas.idq + ",'" + reservas.datainr + "','" + reservas.dataoutr + "'," + reservas.preçor + "," + reservas.nhospedesr + ",'" + reservas.statusr + "')";
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
        public QuartosModelo obterdados(int quarto)
        {
            QuartosModelo quartos = new QuartosModelo();
            MySqlConnection sqlCon = con.getConexao();
            sqlCon.Open();//abrindo o banco
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM quartos where idq =" + quarto , sqlCon);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            MySqlDataReader registro = cmd.ExecuteReader();//leia os dados da consulta
            if (registro.HasRows)//existe linha de registro
            {
                registro.Read();//leia o registro
                //gravando as informações no modelo usuario
                quartos.nomeq = registro["nomeq"].ToString();
                quartos.capacidadeq = registro["capacidadeq"].ToString();
                quartos.preçoq = Convert.ToInt32(registro["preçoq"]);
                quartos.status_id = registro["status_id"].ToString();
                quartos.idq = Convert.ToInt32(registro["idq"]);
            }
            sqlCon.Close();
            return quartos;
        }
        public bool editar(ReservasModelo res)
        {
            bool resultado = false;
            string sql = "UPDATE reservas set idh=@idh,idq=@idq,datainr=@datainr,dataoutr=@dataoutr,nhospedes=@nhospedes,status=@status,preçor=@preçor where idr=@id ";
            MySqlConnection sqlcon = con.getConexao();
            sqlcon.Open();
            MySqlCommand command = new MySqlCommand(sql, sqlcon);
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = sql;
            // substituindo a variavel @___ pelo conteudo do objeto
            command.Parameters.AddWithValue("@idh", res.idh);
            command.Parameters.AddWithValue("@idq", res.idq);
            command.Parameters.AddWithValue("@datainr", res.datainr);
            command.Parameters.AddWithValue("@dataoutr", res.dataoutr);
            command.Parameters.AddWithValue("@nhospedesr", res.nhospedesr);
            command.Parameters.AddWithValue("@statusr", res.statusr);
            command.Parameters.AddWithValue("@preçor", res.preçor);
            command.Parameters.AddWithValue("@idr", res.idr);
            if (command.ExecuteNonQuery() >= 1)
                resultado = true;
            sqlcon.Close();
            return resultado;
        }
        public bool excluir(int codigo)
        {
            bool resultado = false;
            string sql = "DELETE FROM reservas where idr =" + codigo;
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
        //metodo para carregar o reservas
        public ReservasModelo Carregareservas(int codigo)
        {
            ReservasModelo res = new ReservasModelo();
            MySqlConnection sqlcon = con.getConexao();
            sqlcon.Open();
            string sql = "SELECT * from reserva where idr=@id";
            MySqlCommand cmd = new MySqlCommand(sql, sqlcon);
            cmd.Parameters.AddWithValue("@id", codigo);//substituo o valor do codigo
            MySqlDataReader registro = cmd.ExecuteReader();//leia os dados da consulta
            if (registro.HasRows)//existe linha de registro
            {
                registro.Read();//leia o registro
                //gravando as informações no modelo usuario
                res.idh = Convert.ToInt32(registro["idh"]);
                res.idq = Convert.ToInt32(registro["idq"]);
                res.datainr = Convert.ToDateTime(registro["datainr"]);
                res.dataoutr = Convert.ToDateTime(registro["dataoutr"]);
                res.nhospedesr = Convert.ToInt32(registro["nhospedesr"]);
                res.statusr = registro["statusr"].ToString();
                res.idr = Convert.ToInt32(registro["idr"]);
            }
            sqlcon.Close();
            return res;
        }
        //finaliza o metodo
    }
}
