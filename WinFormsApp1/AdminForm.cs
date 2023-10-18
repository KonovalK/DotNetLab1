using ClassLibrary;
using Microsoft.EntityFrameworkCore;
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
    public partial class AdminForm : Form
    {
        SampleDBContext db;
        List<AutomatedTellerMachine>? atmList;
        List<Bank>? bankList;
        Bank currentBank;
        AutomatedTellerMachine currentATM;
        public AdminForm()
        {
            InitializeComponent();
            db = new SampleDBContext();
            bankList = new List<Bank>();
            atmList = new List<AutomatedTellerMachine>();
            try
            {
                db.Banks.Include(x => x.Tellers).Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Reload_Data()
        {
            bankComboBox1.Items.Clear();
            bankComboBox2.Items.Clear();
            try
            {
                bankList = db.Banks.ToList();

                if (bankList != null && bankList.Count > 0)
                {
                    foreach (var bank in bankList)
                    {
                        var bankWrapper = new BankWrapper(bank);
                        bankComboBox1.Items.Add(bankWrapper);
                        bankComboBox2.Items.Add(bankWrapper);
                        bankComboBox1.SelectedIndex = 0;
                        bankComboBox2.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void createBankButton_Click(object sender, EventArgs e)
        {
            try
            {
                Bank newBank = new Bank();
                newBank.Name = nameTextBox.Text;
                newBank.Adress = adressTextBox.Text;
                db.Banks.Add(newBank);
                db.SaveChanges();
                MessageBox.Show("Data is Added!");
                Reload_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            changeBalanceNum1.Maximum = decimal.MaxValue;
            changeBalanceNum2.Maximum = decimal.MaxValue;
            Reload_Data();
        }

        private void bankComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedBankWrapper = (BankWrapper)bankComboBox1.SelectedItem;
                currentBank = selectedBankWrapper.Bank;
                List<AutomatedTellerMachine> atmList = currentBank.Tellers.ToList();
                atmComboBox.Items.Clear();
                if (atmList != null && atmList.Count > 0)
                {
                    foreach (var atm in atmList)
                    {
                        var atmWrapper = new AutomatedTellerMachineWrapper(atm,currentBank);
                        atmComboBox.Items.Add(atmWrapper);
                        atmComboBox.SelectedIndex = 0;
                    }
                }

                else
                {
                    MessageBox.Show("There are no ATMs in this bank");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void atmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedATMWrapper = (AutomatedTellerMachineWrapper)atmComboBox.SelectedItem;
            currentATM = selectedATMWrapper.ATM;
            changeBalanceNum1.Value = currentATM.Balance;
        }

        private void changeMachineBalanceButton_Click(object sender, EventArgs e)
        {
            try
            {
                var atmToUpdate = db.TellerMachines.FirstOrDefault(x => x.Id == currentATM.Id);

                if (atmToUpdate != null)
                {
                    atmToUpdate.Balance = (decimal)changeBalanceNum1.Value;
                    db.SaveChanges();

                    MessageBox.Show("Data is Updated!");
                    Reload_Data();
                }
                else
                {
                    MessageBox.Show("Please select ATM from list!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bankComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedBankWrapper = (BankWrapper)bankComboBox2.SelectedItem;
            currentBank = selectedBankWrapper.Bank;
        }

        private void addMachineButton_Click(object sender, EventArgs e)
        {
            try
            {
                AutomatedTellerMachine newMachine = new AutomatedTellerMachine();
                newMachine.Balance = changeBalanceNum2.Value;
                newMachine.Adress = adressTextBox2.Text;
                db.TellerMachines.Add(newMachine);
                currentBank.AddTellerMachine(newMachine);
                db.SaveChanges();
                MessageBox.Show("Data is Added!");
                Reload_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
