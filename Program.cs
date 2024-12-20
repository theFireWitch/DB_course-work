//using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Курсова_робота
{
    internal static class Program

    {
        /*
        private static IDriver _driver;

        // Підключення до бази даних Neo4j
        public Neo4jExample(string uri, string user, string password)
        {
            _driver = GraphDatabase.Driver(uri, AuthTokens.Basic(user, password));
        }

        // Закриття драйвера після виконання операцій
        public void Close()
        {
            _driver.Dispose();
        }
       
        // Створення вузлів і зв'язків між ними
        public void CreateNodesAndRelationships()
        {
            using (var session = _driver.AsyncSession())
            {
                // Створення 7 вузлів першого типу
                for (int i = 1; i <= 7; i++)
                {
                    session.RunAsync($"CREATE (a:FirstType {{name: 'Node1Type{i}'}})");
                }

                // Створення 5 вузлів другого типу
                for (int j = 1; j <= 5; j++)
                {
                    session.RunAsync($"CREATE (b:SecondType {{name: 'Node2Type{j}'}})");
                }

                // Створення зв'язків між ними
                session.RunAsync(@"
                    MATCH (a:FirstType), (b:SecondType)
                    WHERE a.name STARTS WITH 'Node1Type' AND b.name STARTS WITH 'Node2Type'
                    CREATE (a)-[:CONNECTED_TO]->(b)
                ");
            }
        }
         */


        public static void Main(string[] args)
        {
            /*
            var uri = "bolt://localhost:7687";
            var user = "neo4j";   // Введіть ваш логін
            var password = "neo4j4545";  // Введіть ваш пароль

            var example = new Neo4jExample(uri, user, password);

            try
            {
                // Створення вузлів і зв'язків
                //example.CreateNodesAndRelationships();
                //Console.WriteLine("Вузли та зв'язки створені успішно.");

                // Виведення всіх ланцюжків для вузлів типу FirstType
                //example.PrintChainsForNodeType("FirstType");

                // Для вузлів другого типу (можна розкоментувати)
                // example.PrintChainsForNodeType("SecondType");

            }
            finally
            {
                // Закриття драйвера після завершення
                example.Close();
            }
            */
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}