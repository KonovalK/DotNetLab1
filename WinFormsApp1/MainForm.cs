using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public delegate Task SendEmailAsyncDelegate(string fromEmail, string toEmail, string subject, string message);
        Account currentAccount;
        List<Card>? cardList;
        List<Transaction>? transactionsList;
        List<AutomatedTellerMachine>? atmList;
        List<Bank>? bankList;
        Bank currentBank;
        AutomatedTellerMachine currentATM;
        Card fromCard;
        Card toCard;
        SampleDBContext db;
        bool state;
        public MainForm(Account account)
        {
            InitializeComponent();
            currentAccount = account;
            db = new SampleDBContext();
            cardList = new List<Card>();
            transactionsList = new List<Transaction>();
            bankList = new List<Bank>();
            atmList = new List<AutomatedTellerMachine>();
            currentBank = new Bank();
            fromCard = new Card();
            toCard = new Card();
            currentATM = new AutomatedTellerMachine();
            state = true; //true-це поповнити картку false-зняти кошти

            try
            {
                currentAccount = db.Accounts.FirstOrDefault(a => a.Id == currentAccount.Id);
                db.Banks.Include(x => x.Tellers).Load();
                db.Banks.Include(x => x.Cards).Load();
                db.Accounts.Include(x => x.Cards).Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public async Task SendEmailAsync(string toEmail, string subject, string message)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("vt221_kmm@student.ztu.edu.ua", "944833"),
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network
            };
            await smtpClient.SendMailAsync("vt221_kmm@student.ztu.edu.ua", toEmail, subject, message);
        }
        private void Reload_Data()
        {
                button2.Enabled = false;
                cardList = currentAccount.Cards.ToList();
                var cardNumbers = cardList.Select(card => card.CardNumber.ToString()).ToList();
                transactionsList = db.Transactions.Where(t => cardNumbers.Contains(t.From) || cardNumbers.Contains(t.To)).ToList();
                dataGridView1.Columns.Clear();
                dataGridView2.Columns.Clear();
                cardFromComboBox.Items.Clear();
                cardToComboBox.Items.Clear();
                selectCardComboBox.Items.Clear();
                selectAtmComboBox.Items.Clear();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView2.AutoGenerateColumns = false;
                bankComboBox.Items.Clear();
                DataGridViewTextBoxColumn numberColumn = new DataGridViewTextBoxColumn();
                numberColumn.HeaderText = "CardNumber";
                numberColumn.DataPropertyName = "CardNumber";

                DataGridViewTextBoxColumn balanceColumn = new DataGridViewTextBoxColumn();
                balanceColumn.HeaderText = "Balance";
                balanceColumn.DataPropertyName = "Balance";

                DataGridViewTextBoxColumn bankColumn = new DataGridViewTextBoxColumn();
                bankColumn.HeaderText = "BankName";
                bankColumn.DataPropertyName = "Bank";

                DataGridViewTextBoxColumn fromColumn = new DataGridViewTextBoxColumn();
                fromColumn.HeaderText = "From";
                fromColumn.DataPropertyName = "From";

                DataGridViewTextBoxColumn toColumn = new DataGridViewTextBoxColumn();
                toColumn.HeaderText = "To";
                toColumn.DataPropertyName = "To";

                DataGridViewTextBoxColumn summaColumn = new DataGridViewTextBoxColumn();
                summaColumn.HeaderText = "Summa";
                summaColumn.DataPropertyName = "Summa";

                dataGridView1.Columns.Add(numberColumn);
                dataGridView1.Columns.Add(balanceColumn);
                dataGridView1.Columns.Add(bankColumn);

                dataGridView2.Columns.Add(fromColumn);
                dataGridView2.Columns.Add(toColumn);
                dataGridView2.Columns.Add(summaColumn);

                if (cardList != null && cardList.Count > 0)
                {
                    //Cards in datagrid
                    foreach (var card in cardList)
                    {
                        Bank cardBank = db.GetBankForCard(card);
                        var cardWrapper = new CardWrapper(card, cardBank);
                        cardFromComboBox.Items.Add(cardWrapper);
                        cardToComboBox.Items.Add(cardWrapper);
                        selectCardComboBox.Items.Add(cardWrapper);
                        dataGridView1.Rows.Add(cardWrapper.Card.CardNumber, cardWrapper.Card.Balance, cardWrapper.getBank());
                    }
                    cardFromComboBox.SelectedIndex = 0;
                    cardToComboBox.SelectedIndex = 0;
                    selectCardComboBox.SelectedIndex = 0;

                    //Transactions in datagrid
                    foreach (var transaction in transactionsList)
                    {
                        dataGridView2.Rows.Add(transaction.From, transaction.To, transaction.Summa);
                    }
                }

                else
                {
                    MessageBox.Show("Welcome to the KOLYA`S APP, if you are a new user, we recommend creating a card!");
                }

                bankList = db.Banks.ToList();

                if (bankList != null && bankList.Count > 0)
                {
                    foreach (var bank in bankList)
                    {
                        var bankWrapper = new BankWrapper(bank);
                        bankComboBox.Items.Add(bankWrapper);
                    }
                }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            label9.Visible = false;
            numericUpDown1.Maximum = decimal.MaxValue;
            radioButton3.Checked = true;
            Reload_Data();
        }

        private void createCardButton_Click(object sender, EventArgs e)
        {
            try
            {
                Card newCard = new Card();

                newCard.Balance = numericUpDown1.Value;
                db.Cards.Add(newCard);
                currentBank.Cards.Add(newCard);
                currentAccount.Cards.Add(newCard);

                db.SaveChanges();
                MessageBox.Show("Data is Added!");
                Reload_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bankComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedBankWrapper = (BankWrapper)bankComboBox.SelectedItem;
            currentBank = selectedBankWrapper.Bank;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                cardToComboBox.Visible = false;
                cardToTextBox.Visible = true;
                radioButton2.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                cardToComboBox.Visible = true;
                cardToTextBox.Visible = false;
                radioButton1.Checked = false;
            }
        }

        private void cardToTextBox_TextChanged(object sender, EventArgs e)
        {
            if (cardToTextBox.Text.Length == 8)
            {
                try
                {
                    int cardNumber = 0;

                    if (int.TryParse(cardToTextBox.Text, out cardNumber))
                    {
                        cardNumber = int.Parse(cardToTextBox.Text);
                        toCard = db.Cards.FirstOrDefault(x => x.CardNumber == cardNumber);
                    }
                    else
                    {
                        label9.Visible = true;
                    }
                    if (toCard != null)
                    {
                        Account accountWithCard = db.Accounts.FirstOrDefault(a => a.Cards.Any(card => card.CardNumber == toCard.CardNumber));
                        if (accountWithCard != null)
                        {
                            label7.Text = $"Name: {accountWithCard.Name}";
                            label8.Text = $"Surname: {accountWithCard.Surname}";
                            label9.Visible = false;
                            button2.Enabled = true;
                        }
                    }
                    else
                    {
                        label9.Visible = true;
                        button2.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cardToComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCardWrapper = (CardWrapper)cardToComboBox.SelectedItem;
            toCard = selectedCardWrapper.Card;
            button2.Enabled = true;
        }

        private void cardFromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCardWrapper = (CardWrapper)cardFromComboBox.SelectedItem;
            fromCard = selectedCardWrapper.Card;
            numericUpDown2.Maximum = fromCard.Balance;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            fromCard.Balance -= numericUpDown2.Value;
            toCard.Balance += numericUpDown2.Value;
            Transaction newTransaction = new Transaction();

            newTransaction.From = fromCard.CardNumber.ToString();
            newTransaction.To = toCard.CardNumber.ToString();
            newTransaction.Summa=numericUpDown2.Value;
            try
            {
                db.Transactions.Add(newTransaction);
                db.SaveChanges();
                var accountWithCardFrom = db.Accounts.FirstOrDefault(a => a.Cards.Any(c => c.CardNumber == fromCard.CardNumber));
                var accountWithCardTo = db.Accounts.FirstOrDefault(a => a.Cards.Any(c => c.CardNumber == toCard.CardNumber));
                await SendEmailAsync(accountWithCardFrom.Email, "Payment receipt from KOLYA`S bank app", $"You transferred ${numericUpDown2.Value}. Recipient: {accountWithCardTo.Name} {accountWithCardTo.Surname}");
                await SendEmailAsync(accountWithCardTo.Email, "Payment receipt from KOLYA`S bank app", $"You received funds in the amount of ${numericUpDown2.Value}. Sender: {accountWithCardFrom.Name} {accountWithCardFrom.Surname}");
                MessageBox.Show("Transfer is success!");
                Reload_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Transaction newTransaction = new Transaction();
            string ATMstring = $"ATM {currentATM.Id} adress {currentATM.Adress}";
            if (state == true) // Поповнюємо
            {
                fromCard.Balance += numericUpDown3.Value;
                currentATM.Balance += numericUpDown3.Value;
                newTransaction.From = ATMstring;
                newTransaction.To = fromCard.CardNumber.ToString();
                newTransaction.Summa = numericUpDown3.Value;
            }
            if (state == false) // Знімаємо
            {
                fromCard.Balance -= numericUpDown3.Value;
                currentATM.Balance -= numericUpDown3.Value;
                newTransaction.From = fromCard.CardNumber.ToString();
                newTransaction.To = ATMstring;
                newTransaction.Summa = numericUpDown3.Value;
            }

            try
            {
                db.Transactions.Add(newTransaction);
                db.SaveChanges();
                var accountWithCard = db.Accounts.FirstOrDefault(a => a.Cards.Any(c => c.CardNumber == fromCard.CardNumber));
                if (state == true)
                {
                    await SendEmailAsync(accountWithCard.Email, "Payment receipt from KOLYA`S bank app", $"Your card was withdrawn in the amount of ${numericUpDown3.Value} at the ATM at the address: {currentATM.Adress}");
                }
                if (state == false)
                {
                    await SendEmailAsync(accountWithCard.Email, "Payment receipt from KOLYA`S bank app", $"Your card has been credited with ${numericUpDown3.Value}");
                }
                MessageBox.Show("Transfer is success! Account");
                Reload_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectCardComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedCardWrapper = (CardWrapper)selectCardComboBox.SelectedItem;
                fromCard = selectedCardWrapper.Card;
                currentBank = selectedCardWrapper.Bank;
                List<AutomatedTellerMachine> atmList = currentBank.Tellers.ToList();
                selectAtmComboBox.Items.Clear();
                if (atmList != null && atmList.Count > 0)
                {
                    foreach (var atm in atmList)
                    {
                        var atmWrapper = new AutomatedTellerMachineWrapper(atm, currentBank);
                        selectAtmComboBox.Items.Add(atmWrapper);
                        selectAtmComboBox.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                radioButton4.Checked = false;
                numericUpDown3.Maximum = decimal.MaxValue;
                state = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                checkBalance();
                radioButton3.Checked = false;
                state = false;
            }
        }
        private void checkBalance()
        {
            if (currentATM.Balance < fromCard.Balance)
            {
                numericUpDown3.Maximum = currentATM.Balance;
            }
            else
            {
                numericUpDown3.Maximum = fromCard.Balance;
            }
        }
        private void selectAtmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedAtmWrapper = (AutomatedTellerMachineWrapper)selectAtmComboBox.SelectedItem;
            currentATM = selectedAtmWrapper.ATM;
            checkBalance();
        }
    }
}
