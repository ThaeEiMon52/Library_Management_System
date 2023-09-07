using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Entities.BookRental
{
    public class FilterBookRentalEntity
    {
        public int rental_id {  get; set; }

        public string status { get; set; }

        public decimal? fine_amount { get; set; }
        public string user_name { get; set; }

        public string nrc { get; set; }

        public string phone { get; set; }

        public string email { get; set; }

        public string address { get; set; }

        public string title { get; set; }

        public string author { get; set; }

        public DateTime issue_date { get; set; }

        public DateTime due_date { get; set; }

        public DateTime? return_date { get; set; }

        public string staff_issue_name { get; set; }

        public string staff_receive_name { get; set; } = "";
        

        public FilterBookRentalEntity()
        {
            InitializedObjectValue();
        }

        internal void InitializedObjectValue()
        {
            this.user_name = String.Empty;
            this.nrc = String.Empty;
            this.email = String.Empty;
            this.phone = String.Empty;
            this.address = String.Empty;
            this.title = String.Empty;
            this.author = String.Empty;
            this.staff_issue_name = String.Empty;
            this.staff_receive_name = String.Empty;
            this.issue_date = DateTime.Now;
            this.due_date = DateTime.Now;
            this.return_date = null;
            this.status = String.Empty;
            this.fine_amount = null;
            this.rental_id = 0;
        }
    }
}
