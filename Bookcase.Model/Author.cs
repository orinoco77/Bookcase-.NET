using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookcase.Model
{
    public class Author
    {
        public int Id { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public IList<Ebook> Ebooks { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Forename, Surname);
        }
    }
}
