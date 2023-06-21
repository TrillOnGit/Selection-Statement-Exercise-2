using System.Linq.Expressions;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite of the following subjects? Math, Social Studies, Art, English, or Science?");
            var userSubject = Console.ReadLine();
            switch (userSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Neat! I actually enjoy math quite a bit too.");
                    break;
                case "social studies":
                    Console.WriteLine("Social studies? Bah! Never was a big fan, but I guess its important.");
                    break;
                case "art":
                    Console.WriteLine("Heck yeah! I'm not a hugely creative person myself, but I appreciate the artistically driven.");
                    break;
                case "english":
                    Console.WriteLine("English is surprisingly fun, right? Excellent choice.");
                    break;
                case "science":
                    Console.WriteLine("Maybe Science was too broad to say, but all the sciences are neat in their own way.");
                    break;
                default:
                    Console.WriteLine("Sorry, that's not a valid input.");
                    break;
            }
        }
    }
}