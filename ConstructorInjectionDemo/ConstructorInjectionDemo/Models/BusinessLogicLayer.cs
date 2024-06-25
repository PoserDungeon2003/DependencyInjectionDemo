using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInjectionDemo.Models
{
    public class BookManager
    {
        public IBookReader bookReader;
        public BookManager(IBookReader bookReader)
        {
            this.bookReader = bookReader;
        }
        public void ReadBook()
        {
            this.bookReader.ReadBook();
        }
    }
}
