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
    public class HospedeController
    {
        
            //instanciei o objeto conexao
            Conexao con = new Conexao();
            HospedeModelo hos = new HospedeModelo();
            //criando o metodo de cadastrar reservas
            public bool cadastrar(HospedeModelo hospedes)//passo o objeto reservas
            {//declaro a variavel da resposta da query
                bool resultado = false;
                string sql = "insert into hospedes(nomeh,emailh,telefoneh,cpfh,fotoh)" + "values('" + hospedes.nomeh + "','" + hospedes.emailh + "','" + hospedes.telefoneh + "','" + hospedes.cpfh + "','" + hospedes.fotoh + "')";
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
                DataTable hos = new DataTable();
                MySqlConnection sqlCon = con.getConexao();
                sqlCon.Open();//abrindo o banco
                MySqlCommand cmd = new MySqlCommand(sql, sqlCon);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(hos);
                return hos;
            }
            public bool editar(HospedeModelo hos)
            {
                bool resultado = false;
                string sql = "UPDATE hospedes set nomeh=@nomeh,emailh=@emailh,telefoneh=@telefoneh,cpfh=@cpfh,fotoh=@fotoh where idh=@idh ";
                MySqlConnection sqlcon = con.getConexao();
                sqlcon.Open();
                MySqlCommand command = new MySqlCommand(sql, sqlcon);
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = sql;
                // substituindo a variavel @___ pelo conteudo do objeto
                command.Parameters.AddWithValue("@nomeh", hos.nomeh);
                command.Parameters.AddWithValue("@emailh", hos.emailh);
                command.Parameters.AddWithValue("@telefoneh", hos.telefoneh);
                command.Parameters.AddWithValue("@cpfh", hos.cpfh);
                command.Parameters.AddWithValue("@fotoh", hos.fotoh);
                command.Parameters.AddWithValue("@idh", hos.idh);
                if (command.ExecuteNonQuery() >= 1)
                    resultado = true;
                sqlcon.Close();
                return resultado;
            }
            public bool excluir(int codigo)
            {
                bool resultado = false;
                string sql = "DELETE FROM hospedes where idh =" + codigo;
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
            //metodo para carregar o hospedes
            public HospedeModelo Carregarhospede(string cpfh)
            {

                MySqlConnection sqlcon = con.getConexao();
                sqlcon.Open();
                string sql = "SELECT * from hospedes where cpfh=@cpf";
                MySqlCommand cmd = new MySqlCommand(sql, sqlcon);
                cmd.Parameters.AddWithValue("@cpf", cpfh);//substituo o valor do codigo
                MySqlDataReader registro = cmd.ExecuteReader();//leia os dados da consulta
                if (registro.HasRows)//existe linha de registro
                {
                    registro.Read();//leia o registro
                    //gravando as informações no modelo hospede
                    hos.nomeh = registro["nomeh"].ToString();
                    hos.emailh = registro["emailh"].ToString();
                    hos.telefoneh = registro["telefoneh"].ToString();
                    hos.cpfh = registro["cpfh"].ToString();
                    hos.fotoh = registro["fotoh"].ToString();
                    hos.idh = Convert.ToInt32(registro["idh"]);
                }
                sqlcon.Close();
                return hos;
            }
            //finaliza o metodo
    }
}

