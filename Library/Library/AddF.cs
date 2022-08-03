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
    public partial class AddF : Form
    {
        DataTable dt1 = new DataTable();
        Connect con = new Connect();
        int IdJanr,id,vl1;
        string BookName1;
        public AddF(int vl,string BookName)
        {
            InitializeComponent();
            vl1 = vl;
            BookName1 = BookName;
            if (vl == 1)
            {
                this.Text = "Добавление книги";
            }
            else
            {
                this.Text = "Изменение книги";
            }
            
        }

        private void AddF_Load(object sender, EventArgs e)
        {
            string kab = "Select NameJanr from janr ";
            dt1 = con.ConDT(kab);
            foreach (DataRow dr in dt1.Rows)
            {
                comboBoxJanr.Items.Add(dr[0].ToString());
            }
            if (vl1 == 2)
            {
                int JanrInt = con.ExecuteScalarInt("SELECT FkJnr FROM books WHERE BookName = '" + BookName1 + "'");
                string Janr = con.ExecuteScalar("SELECT NameJanr FROM janr WHERE idJanr = '" + JanrInt + "'");
                string Year = con.ExecuteScalar("SELECT Year FROM books WHERE BookName = '" + BookName1 + "'");
                string Author = con.ExecuteScalar("SELECT Author FROM books WHERE BookName = '" + BookName1 + "'");
                id = con.ExecuteScalarInt("SELECT idBooks FROM books WHERE BookName = '" + BookName1 + "'");
                textBoxBook.Text = BookName1;
                maskedTextBoxDate.Text = Year;
                comboBoxJanr.Text = Janr;
                textBoxAuthor.Text = Author;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            IdJanr = con.ExecuteScalarInt("SELECT idJanr From janr WHERE NameJanr = '" + comboBoxJanr.SelectedItem + "'");
            if (vl1 == 1)
            {
                
                con.SIDU("INSERT INTO books (BookName,Year,FkJnr,Author) Values ('" + textBoxBook.Text + "','" + maskedTextBoxDate.Text + "','" + IdJanr + "','" + textBoxAuthor.Text + "')");
            }
            else if (vl1 == 2)
            {
                con.SIDU("UPDATE books set BookName = '" + textBoxBook.Text + "',Year ='" + maskedTextBoxDate.Text + "',FkJnr = '" + IdJanr + "',Author ='" + textBoxAuthor.Text + "'WHERE idBooks= '"+id+"'");
            }
            this.Close();
        }
    }
}
