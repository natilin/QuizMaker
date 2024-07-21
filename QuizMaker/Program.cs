using System.ComponentModel.Design;
using System.Xml.Linq;

namespace QuizMaker
{
    public class Program
    {
        public static XMLService service = new XMLService("C:\\Users\\Owner\\source\\repos\\QuizMaker\\QuizMaker\\Data\\Quiz.xml");
        static void Main(string[] args)
        {
            Program.Menu();
        }
        public static void Menu()
        {
            Console.WriteLine(@"1. Create questions 
                                2. Answer Questions");
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    AddQnA();
                    break;
                case "2":
                    ReadQ();
                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
                    
        }
        public static void AddQnA()
        {
                Console.WriteLine("Write Question: ");
                string q = Console.ReadLine();
                Console.WriteLine("Write Answer: ");
                string a = Console.ReadLine();
                service.CreateNewQA(q, a);
        }
        public static void ReadQ()
        {
            List<XElement> elements = service.ReadAllQA();
            foreach (XElement element in elements)
            {
                Console.WriteLine("What's the answer?");
                Console.WriteLine(element.Element("Question").Value);
                string userAnswer = Console.ReadLine();
                if (userAnswer == element.Element("Answer").Value)
                {
                    Console.WriteLine("Yoy Right!!");
                }
                else { Console.WriteLine("wrong answer!"); }

            }
        }
    }
}