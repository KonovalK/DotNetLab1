using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class RegistrateForm : Form
    {
        SampleDBContext db;
        public RegistrateForm()
        {
            InitializeComponent();
            db = new SampleDBContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Account newAccount = new Account();
                newAccount.Name = textBox1.Text;
                newAccount.Surname = textBox2.Text;
                newAccount.Email = textBox3.Text;
                newAccount.Password = textBox4.Text;
                db.Accounts.Add(newAccount);
                db.SaveChanges();
                MessageBox.Show("Data is Added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
