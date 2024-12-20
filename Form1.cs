namespace Курсова_робота
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGreen;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var uri = "bolt://localhost:7687";
            var user = "neo4j";   // Введіть ваш логін
            var password = "neo4j4545";  // Введіть ваш пароль

            var example = new Neo4jExample(uri, user, password);
            try
            {
                // Створення вузлів і зв'язків
                example.CreateNodesAndRelationships();
                Console.WriteLine("Вузли та зв'язки створені успішно.");

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
        }
    }
}
