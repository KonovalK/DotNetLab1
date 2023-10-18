using ClassLibrary;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        SampleDBContext db;
        public LoginForm()
        {
            InitializeComponent();
            db = new SampleDBContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var account=new Account();
                account = db.Accounts.FirstOrDefault(x => x.Email == LoginTextBox.Text && x.Password == PasswordTextBox.Text);
                if (account != null) {
                    if (account.Role == "ROLE_USER")
                    {
                        MainForm mainForm = new MainForm(account);
                        mainForm.Show();
                    }
                    else if (account.Role == "ROLE_ADMIN")
                    {
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid data!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrateForm registrateForm = new RegistrateForm();
            registrateForm.ShowDialog();
        }
    }
}