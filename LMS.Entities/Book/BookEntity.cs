using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Entities.Book
{
    public class BookEntity
    {   
        public int bookId { get; set; }
        public string book { get; set; }

        public string author { get; set; }

        public string publisher { get; set; }

        public DateTime publishDate { get; set; }

        public int edition { get; set; }

        public int categoryId { get; set; }

        public int total { get; set; }

        public string language { get; set; }

    }
}
