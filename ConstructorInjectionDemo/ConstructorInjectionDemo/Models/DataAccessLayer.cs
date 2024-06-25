using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInjectionDemo.Models
{
    public interface IBookReader
    {
        void ReadBook();
    }
    public class XMLBookReader : IBookReader
    {
        public void ReadBook()
        {
            Console.WriteLine("Reading book from XML");
        }
    }
    public class JSONBookReader : IBookReader
    {
        public void ReadBook()
        {
            Console.WriteLine("Reading book from JSON");
        }
    }
}
