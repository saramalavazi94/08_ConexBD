using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ConexBD
{
    internal class ConexaoFlexivel
    {
        string host = "localhost";
        string banco = "008_lista_tarefas";
        string usuario = "root";
        string senha = "senac";

        MySqlConnection conexao;
       

        public ConexaoFlexivel()
        {

            string dadosConexao = $"Server={host};Database={banco};Uid={usuario};Pwd={senha};";
            conexao = new MySqlConnection(dadosConexao);

        }

        public void executaQuery( string query ) // Vai rodar comandos dentro do banco
        {
            conexao.Open();

            MySqlCommand comando = new MySqlCommand(query, conexao);

            MySqlDataReader dados = comando.ExecuteReader();

            while (dados.Read() == true)
            {
                Console.WriteLine("Tarefa:" + dados ["id"] + dados[1]);
            }
            Console.WriteLine("-------------------");
            if (dados.FieldCount == 0)
            {
                Console.WriteLine("Nenhum resultado encontrado D:");
            }
            conexao.Close();
        }

    }
}
