using ApiDotNetCore.Model;
using MySqlConnector;
namespace PeopleAPI.Repository
{
    public class PeopleRepository : IPeopleRepository
    {
          //Variavel string conexão BD
        private readonly string _connectionString;
        //String de conexão no construtor da classe
        public PeopleRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        //Implementação do método imposto pela interface
        People IPeopleRepository.GetPeople(int PersonID)
        {
            using(MySqlConnection connection = new MySqlConnection(_connectionString))
            {          
                People people = null;   
                MySqlCommand query = new MySqlCommand();
                //Abrindo Conexão com banco
                connection.Open(); 
                //Atibuindo conexão aberta a query.Connection
                query.Connection = connection; 
                //Consulta
                query.CommandText = @"SELECT PersonID, FirstName, LastName, Age FROM People WHERE PersonID =@PersonID"; //Atribuindo consulta a query.CommandText
                //Boa prática para evitar SQL Injection
                query.Parameters.AddWithValue("@PersonID", PersonID); 
                //Executando a query
                MySqlDataReader reader = query.ExecuteReader(); 
                //Montando Objeto com resultado da consulta
                while(reader.Read())
                {
                    people = new People(
                    (int)reader["PersonID"], 
                    (string)reader["FirstName"],
                    (string)reader["LastName"],
                    (int)reader["Age"]
                    );
                }
                return people;               
            }
        }
    }
}