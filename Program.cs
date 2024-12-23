using Neo4j.Driver;
using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Курсова_робота
{
    public class Neo4jExample
    {
        public static IDriver _driver;

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

        public async Task<List<string>> GetNodeLabelsById(int nodeId)
        {
            var nodeLabels = new List<string>();

            var query = @"
            MATCH (n)
            WHERE id(n) = $id
            RETURN labels(n) AS nodeLabels
        ";

            await using var session = _driver.AsyncSession();

            try
            {
                var result = await session.RunAsync(query, new { id = nodeId });

                await foreach (var record in result)
                {
                    var labels = record["nodeLabels"].As<List<string>>();
                    nodeLabels.AddRange(labels);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return nodeLabels;
        }
    }

    
    internal static class Program
    {
        public static void Main(string[] args)
        {
            
            //var uri = "bolt://localhost:7687";
            //var user = "neo4j";   // Введіть ваш логін
            //var password = "neo4j4545";  // Введіть ваш пароль

            //var example = new Neo4jExample(uri, user, password);

            
            
            ApplicationConfiguration.Initialize();
            Application.Run(new login());
        }
    }
}


/*
 public async Task GetNodeRelationships(int nodeId)
        {
            var query = $"MATCH (n)-[r]->(m) WHERE id(n) = {nodeId} RETURN n, r, m";

            // Відкриваємо сесію
            await using var session = _driver.AsyncSession();

            try
            {
                // Виконуємо запит
                var results = await session.RunAsync(query, new { id = nodeId });

                // Обробляємо результати
                Console.WriteLine($"Relationships for node with ID {nodeId}:");
                while (await results.FetchAsync())
                {
                    var node = results.Current["n"].As<INode>();
                    var relationship = results.Current["r"].As<IRelationship>();
                    var relatedNode = results.Current["m"].As<INode>();

                    Console.WriteLine($"Node: {node.Properties}");
                    Console.WriteLine($"Relationship: {relationship.Type}");
                    Console.WriteLine($"Related Node: {relatedNode.Properties}");
                    Console.WriteLine("-------------------");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

 */