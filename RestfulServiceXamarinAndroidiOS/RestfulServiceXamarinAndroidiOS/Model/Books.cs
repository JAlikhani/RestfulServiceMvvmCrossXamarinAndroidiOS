using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestfulServiceXamarinAndroidiOS.Model
{
    public class Book
    {
        public string id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
    }

    public class Books
    {
        public List<Book> book { get; set; }
    }

}
