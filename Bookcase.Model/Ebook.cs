using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookcase.Model
{
    public class Ebook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IList<Author> Authors { get; set; }
        public string EbookUrl { get; set; }
        public ImageData ImageData { get; set; }
    }
}
