using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using LMS.Entities.Book;
using LMS.Services.Book;

namespace LMS.APP.Views.Book
{
    public partial class UCBook : UserControl
    {   
        private BookService bookService= new BookService();
        public static int Id = 0;
        public UCBook()
        {
            InitializeComponent();
        }

        private void pnTitle_Paint(object sender, PaintEventArgs e)
        {

        }


        private void UCBook_Load(object sender, EventArgs e)
        {
            BindData();
        }
        private void BindData()
        {
            DataTable dataTable = bookService.GetAll1();
            cbo_category.ValueMember = "category_name";
            cbo_category.DataSource = dataTable;
            if (Id!=0)
            {
                DataTable dt = bookService.Get(Id);
                
                if (dt.Rows.Count > 0)
                {
                    txt_book.Text = dt.Rows[0]["title"].ToString();
                    txt_author.Text = dt.Rows[0]["author"].ToString();
                    txt_publisher.Text = dt.Rows[0]["publisher"].ToString();
                    dtp_date.Text = dt.Rows[0]["publication_date"].ToString();
                    txt_edition.Text = dt.Rows[0]["edition_number"].ToString();
                    DataTable dt2 = bookService.Get1(Convert.ToInt32(dt.Rows[0]["category_id"].ToString()));
                    if(dt2.Rows.Count > 0)
                    {
                        cbo_category.Text = dt2.Rows[0]["category_name"].ToString();
                    }
                    txt_total.Text = dt.Rows[0]["num_of_books"].ToString();
                    txt_language.Text = dt.Rows[0]["language"].ToString();

                }

            }


        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string pass = "^[0-9]*$";
            Regex re = new Regex(pass);
           if(txt_book.Text==string.Empty || txt_author.Text==string.Empty || txt_publisher.Text==string.Empty || txt_edition.Text == string.Empty || !re.IsMatch(txt_edition.Text) || txt_total.Text == string.Empty||!re.IsMatch(txt_total.Text) || txt_language.Text==string.Empty)
            {
                if (txt_book.Text == string.Empty)
                {
                    txt_book.Focus();
                    MessageBox.Show("Fill Book Name");
                    return;
                }
                if (txt_author.Text == string.Empty)
                {
                    txt_author.Focus();
                    MessageBox.Show("Fill Author ");
                    return;
                }
                if (txt_publisher.Text == string.Empty)
                {
                    txt_publisher.Focus();
                    MessageBox.Show("Fill Publisher ");
                    return;
                }
                if (txt_edition.Text == string.Empty || !re.IsMatch(txt_edition.Text))
                {
                    txt_edition.Focus();
                    MessageBox.Show("Fill valid edition ");
                    return;
                }
                if (txt_total.Text == string.Empty||!re.IsMatch(txt_total.Text))
                {
                    txt_total.Focus();
                    MessageBox.Show("Fill Total Book ");
                    return;
                }
                if (txt_language.Text == string.Empty)
                {
                    txt_language.Focus();
                    MessageBox.Show("Fill Language ");
                    return;
                }

            }
            else
            {
                AddorUpdate();
            }
             
        }
        private void AddorUpdate()
        {
            BookService bookService = new BookService();
            BookEntity bookEntity = CreateData();
            bool success = false;
            if(Id == 0)
            {
                success = bookService.Insert(bookEntity);
                if (success)
                {
                    MessageBox.Show("Save Success.", "Success", MessageBoxButtons.OK);

                }
            }
            else
            {
                success = bookService.Update(bookEntity);
                if (success)
                {
                    MessageBox.Show("Update Success.", "Success", MessageBoxButtons.OK);

                }
            }
            
            
        }
        private BookEntity CreateData()
        {
            string categoryId = String.Empty;
            DataTable dataTable = bookService.GetAll1();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (cbo_category.Text == dataTable.Rows[i]["category_name"].ToString())
                {
                    categoryId=dataTable.Rows[i]["category_id"].ToString();
                }
            }

            BookEntity bookEntity = new BookEntity();

            bookEntity.bookId = Id;
            bookEntity.book = txt_book.Text;
            bookEntity.author = txt_author.Text;
            bookEntity.publisher = txt_book.Text;
            bookEntity.publishDate = Convert.ToDateTime(dtp_date.Text);
            bookEntity.edition = Convert.ToInt32(txt_edition.Text);
            bookEntity.categoryId = Convert.ToInt32(categoryId);
            bookEntity.total = Convert.ToInt32(txt_total.Text);
            bookEntity.language = txt_language.Text;


            return bookEntity;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_book.Text = String.Empty;
            txt_author.Text = String.Empty;
            txt_publisher.Text = String.Empty;
            dtp_date.Text = String.Empty;
            txt_edition.Text = String.Empty;
            cbo_category.Text = String.Empty;
            txt_total.Text = String.Empty;
            txt_language.Text = String.Empty;
            MessageBox.Show("Data Cleared");
        }
    }
}
