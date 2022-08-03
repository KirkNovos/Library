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
    public partial class GuestF : Form
    {
        Connect con = new Connect();
        public GuestF(string FIO)
        {
            InitializeComponent();
            string FIO_User = FIO;
            this.Text = "Здравствуйте "+FIO_User+"";
        }

        private void GuestF_Load(object sender, EventArgs e)
        {
            dataGridViewBooks.DataSource = con.CO("SELECT BookName AS 'Книга' , Year AS 'Год' , janr.NameJanr AS 'Жанр', Author AS 'Автор' FROM library.books, janr WHERE books.FkJnr = janr.idJanr;").Tables[0]; 
        }
    }
}
