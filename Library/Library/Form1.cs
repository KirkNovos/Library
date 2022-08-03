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
    public partial class AuthoF : Form
    {
        Connect con = new Connect();
        
        
        int role;
        string FIO_User;
        public AuthoF()
        {
            InitializeComponent();
        }

        private void AuthoBtn_Click(object sender, EventArgs e)
        {
            role = con.ExecuteScalarInt("SELECT FkRl FROM library.users WHERE `login` = '"+textBoxLog.Text+"' AND `password` = '"+textBoxPas.Text+"';");
            FIO_User = con.ExecuteScalar("SELECT FIO FROM users WHERE `login` = '" + textBoxLog.Text + "' AND `password` = '" + textBoxPas.Text + "'").ToString();
            if (role == 1)
            {
                GuestF GF = new GuestF(FIO_User);
                GF.ShowDialog();
                this.Close();
            }
            else if (role == 2)
            {
                AdminF AF = new AdminF(FIO_User);
                AF.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("ошибка неверный логин или пароль!!!");
            }
        }
    }
}
