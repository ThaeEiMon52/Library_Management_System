using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Entities.BookRental
{
    public class InsertBookRentalEntity
    {
        public int userId { get; set; }

        public int bookId { get; set; }

        public int staffIssueId { get; set; }

        public DateTime issueDate { get; set; }

        public DateTime dueDate { get; set; }

        public InsertBookRentalEntity()
        {
            InitializedObjectValue();
        }

        internal void InitializedObjectValue()
        {
            this.userId = 0;
            this.bookId = 0;
            this.staffIssueId = 0;
            this.issueDate = DateTime.Now;
            this.dueDate = DateTime.Now;
        }
    }
}
