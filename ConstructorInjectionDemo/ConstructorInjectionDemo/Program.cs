using ConstructorInjectionDemo.Models;

namespace ConstructorInjectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookManager bookManager;
            bool replay = false;
            do
            {
                Console.WriteLine("Please select reading type (XML or JSON)");
                var input = Console.ReadLine();
                if (input.ToLower() == "xml")
                {
                    bookManager = new BookManager(new XMLBookReader());
                }
                else
                {
                    bookManager = new BookManager(new JSONBookReader());
                }
                bookManager.ReadBook();
                Console.WriteLine("Try again? (Y/N)");
                var tryAgain = Console.ReadLine();
                if (tryAgain.ToLower() == "y")
                    replay = true;
                else 
                    replay = false;
            } while (replay);
        }
    }
}
