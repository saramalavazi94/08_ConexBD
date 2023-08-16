using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ConexBD
{
    internal class ConexaoSimples
    {
        string host = "localhost";
        string banco = "008_lista_tarefas";
        string usuario = "root";
        string senha = "senac";
       

        public ConexaoSimples()
        {
            // Usa os dados do banco para se conectar
            string dadosConexao = $"Server={host};Database={banco};Uid={usuario};Pwd={senha};";
            // Cria a conexão com o banco usando os dados 
            // O banco não se ceneccta sozinho, ele apenas cria a conexão

            MySqlConnection conexao = new MySqlConnection( dadosConexao );
            // Abre a conexão com o banco 
            conexao.Open();
            // Linha de código do SQL 

            string query = "SELECT * FROM tarefas;";
            // Envia um comando para o banco
            MySqlCommand comando = new MySqlCommand(query, conexao);
            // Guarda os dados que vierem do banco dentro de "dados"
            // MySqlDateReader recebe os dados em formato de tabela 

            MySqlDataReader dados = comando.ExecuteReader();

            // Roda cada dado da tabela, até á última linha
            // A útilma linha vai ser FALSE e quebrar o loop
            while (dados.Read() == true)
            {
                Console.WriteLine("Descrição da tarefa:" + dados["descricao"] );
            }
            // Fecha a conexão com o banco
            conexao.Close();
        }

    }
}
