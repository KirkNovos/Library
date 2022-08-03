using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class AdminF : Form
    {
        Connect con = new Connect();

        public AdminF(string FIO)
        {
            InitializeComponent();
            string FIO_User = FIO;
            this.Text = "Здравствуйте " + FIO_User + "";
        }

        private void AdminF_Load(object sender, EventArgs e)
        {
            dataGridViewBooks.DataSource = con.CO("SELECT BookName AS 'Книга' , Year AS 'Год' , janr.NameJanr AS 'Жанр', Author AS 'Автор' FROM library.books, janr WHERE books.FkJnr = janr.idJanr;").Tables[0];
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            int vl = 1;
            AddF AF = new AddF(vl,null);
            AF.ShowDialog();
            dataGridViewBooks.DataSource = con.CO("SELECT BookName AS 'Книга' , Year AS 'Год' , janr.NameJanr AS 'Жанр', Author AS 'Автор' FROM library.books, janr WHERE books.FkJnr = janr.idJanr;").Tables[0];
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            int k = dataGridViewBooks.CurrentCell.RowIndex;
            string col = dataGridViewBooks[0, k].Value.ToString();
            con.SIDU("DELETE FROM books WHERE BookName = '" + col + "'");
            dataGridViewBooks.DataSource = con.CO("SELECT BookName AS 'Книга' , Year AS 'Год' , janr.NameJanr AS 'Жанр', Author AS 'Автор' FROM library.books, janr WHERE books.FkJnr = janr.idJanr;").Tables[0];
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            int k = dataGridViewBooks.CurrentCell.RowIndex;
            string BookName = dataGridViewBooks[0, k].Value.ToString();
            
            int vl = 2;
            AddF AF = new AddF(vl, BookName);
            AF.ShowDialog();
            dataGridViewBooks.DataSource = con.CO("SELECT BookName AS 'Книга' , Year AS 'Год' , janr.NameJanr AS 'Жанр', Author AS 'Автор' FROM library.books, janr WHERE books.FkJnr = janr.idJanr;").Tables[0];
        }
    }
}
