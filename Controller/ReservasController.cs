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
        public bool cadastrar(ReservasModelo reservas)
        {
            bool resultado = false;
            string sql = "INSERT INTO reservas(idh, idq, datainr, dataoutr, preçor, nhospedesr, statusr)" +
                         "VALUES (@idh, @idq, @datainr, @dataoutr, @preçor, @nhospedesr, @statusr)";

            MySqlConnection sqlCon = con.getConexao();
            sqlCon.Open();

            using (MySqlCommand cmd = new MySqlCommand(sql, sqlCon))
            {
                // Use parâmetros para as datas
                cmd.Parameters.AddWithValue("@idh", reservas.idh);
                cmd.Parameters.AddWithValue("@idq", reservas.idq);
                cmd.Parameters.AddWithValue("@datainr", reservas.datainr.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@dataoutr", reservas.dataoutr.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@preçor", reservas.preçor);
                cmd.Parameters.AddWithValue("@nhospedesr", reservas.nhospedesr);
                cmd.Parameters.AddWithValue("@statusr", reservas.statusr);

                using (var transaction = sqlCon.BeginTransaction())
                {
                    try
                    {
                        cmd.Transaction = transaction;

                        if (cmd.ExecuteNonQuery() >= 1)
                        {
                            transaction.Commit();
                            resultado = true;
                        }
                        else
                        {
                            transaction.Rollback();
                        }
                    }
                    catch (Exception ex)
                    {
                        // Trate a exceção, se necessário
                        Console.WriteLine(ex.Message);
                        transaction.Rollback();
                    }
                }
            }
            sqlCon.Close();
            return resultado;
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
            string sql = "UPDATE reservas set idh=@idh,idq=@idq,datainr=@datainr,dataoutr=@dataoutr,nhospedesr=@nhospedesr,statusr=@statusr,preçor=@preçor where idr=@idr ";
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
            string sql = "SELECT * from reservas where idr=@id";
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
        public bool ReservaExisteParaHospede(string idh)
        {
            string query = $"SELECT COUNT(*) FROM reservas WHERE idh = '{idh}'";
            DataTable dt = obterdados(query);

            return Convert.ToInt32(dt.Rows[0][0]) > 0;
        }
        public bool ReservaExistenteParaQuartoPeriodo(int idq, DateTime datainr, DateTime dataoutr)
        {
            string query = $"SELECT COUNT(*) FROM reservas WHERE idq = {idq} " +
                           $"AND ((datainr BETWEEN '{datainr.ToString("yyyy-MM-dd HH:mm:ss")}' AND '{dataoutr.ToString("yyyy-MM-dd HH:mm:ss")}') " +
                           $"OR (dataoutr BETWEEN '{datainr.ToString("yyyy-MM-dd HH:mm:ss")}' AND '{dataoutr.ToString("yyyy-MM-dd HH:mm:ss")}'))";
            DataTable dt = obterdados(query);

            return Convert.ToInt32(dt.Rows[0][0]) > 0;
        }
    }
}
