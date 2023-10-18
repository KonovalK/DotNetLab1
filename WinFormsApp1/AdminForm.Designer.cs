namespace WinFormsApp1
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            adressTextBox = new TextBox();
            nameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            createBankButton = new Button();
            groupBox2 = new GroupBox();
            changeBalanceNum2 = new NumericUpDown();
            label6 = new Label();
            label8 = new Label();
            bankComboBox2 = new ComboBox();
            addMachineButton = new Button();
            groupBox3 = new GroupBox();
            changeBalanceNum1 = new NumericUpDown();
            label5 = new Label();
            atmComboBox = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            bankComboBox1 = new ComboBox();
            changeMachineBalanceButton = new Button();
            label7 = new Label();
            adressTextBox2 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)changeBalanceNum2).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)changeBalanceNum1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(adressTextBox);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(createBankButton);
            groupBox1.Location = new Point(412, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(394, 363);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "CreateBank";
            // 
            // adressTextBox
            // 
            adressTextBox.Location = new Point(100, 97);
            adressTextBox.Name = "adressTextBox";
            adressTextBox.Size = new Size(288, 23);
            adressTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(100, 40);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(288, 23);
            nameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 97);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "ADRESS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 40);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "NAME";
            // 
            // createBankButton
            // 
            createBankButton.Location = new Point(248, 311);
            createBankButton.Name = "createBankButton";
            createBankButton.Size = new Size(140, 46);
            createBankButton.TabIndex = 0;
            createBankButton.Text = "CREATE";
            createBankButton.UseVisualStyleBackColor = true;
            createBankButton.Click += createBankButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(adressTextBox2);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(changeBalanceNum2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(bankComboBox2);
            groupBox2.Controls.Add(addMachineButton);
            groupBox2.Location = new Point(12, 191);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(394, 184);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Teller Machine";
            // 
            // changeBalanceNum2
            // 
            changeBalanceNum2.Location = new Point(201, 108);
            changeBalanceNum2.Name = "changeBalanceNum2";
            changeBalanceNum2.Size = new Size(162, 23);
            changeBalanceNum2.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 108);
            label6.Name = "label6";
            label6.Size = new Size(150, 15);
            label6.TabIndex = 14;
            label6.Text = "INPUT DEFAULT BALANCE";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 35);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 11;
            label8.Text = "SELECT BANK";
            // 
            // bankComboBox2
            // 
            bankComboBox2.FormattingEnabled = true;
            bankComboBox2.Location = new Point(128, 35);
            bankComboBox2.Name = "bankComboBox2";
            bankComboBox2.Size = new Size(235, 23);
            bankComboBox2.TabIndex = 10;
            bankComboBox2.SelectedIndexChanged += bankComboBox2_SelectedIndexChanged;
            // 
            // addMachineButton
            // 
            addMachineButton.Location = new Point(17, 137);
            addMachineButton.Name = "addMachineButton";
            addMachineButton.Size = new Size(113, 36);
            addMachineButton.TabIndex = 1;
            addMachineButton.Text = "CREATE";
            addMachineButton.UseVisualStyleBackColor = true;
            addMachineButton.Click += addMachineButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(changeBalanceNum1);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(atmComboBox);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(bankComboBox1);
            groupBox3.Controls.Add(changeMachineBalanceButton);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(394, 173);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Change ATM Balance";
            // 
            // changeBalanceNum1
            // 
            changeBalanceNum1.Location = new Point(128, 125);
            changeBalanceNum1.Name = "changeBalanceNum1";
            changeBalanceNum1.Size = new Size(105, 23);
            changeBalanceNum1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 127);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 7;
            label5.Text = "INPUT BALANCE";
            // 
            // atmComboBox
            // 
            atmComboBox.FormattingEnabled = true;
            atmComboBox.Location = new Point(128, 74);
            atmComboBox.Name = "atmComboBox";
            atmComboBox.Size = new Size(235, 23);
            atmComboBox.TabIndex = 6;
            atmComboBox.SelectedIndexChanged += atmComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 75);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 5;
            label3.Text = "SELECT ATM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 32);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 4;
            label4.Text = "SELECT BANK";
            // 
            // bankComboBox1
            // 
            bankComboBox1.FormattingEnabled = true;
            bankComboBox1.Location = new Point(128, 32);
            bankComboBox1.Name = "bankComboBox1";
            bankComboBox1.Size = new Size(235, 23);
            bankComboBox1.TabIndex = 2;
            bankComboBox1.SelectedIndexChanged += bankComboBox1_SelectedIndexChanged;
            // 
            // changeMachineBalanceButton
            // 
            changeMachineBalanceButton.Location = new Point(239, 125);
            changeMachineBalanceButton.Name = "changeMachineBalanceButton";
            changeMachineBalanceButton.Size = new Size(124, 42);
            changeMachineBalanceButton.TabIndex = 1;
            changeMachineBalanceButton.Text = "CHANGE";
            changeMachineBalanceButton.UseVisualStyleBackColor = true;
            changeMachineBalanceButton.Click += changeMachineBalanceButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 73);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 16;
            label7.Text = "INPUT ADRESS";
            // 
            // adressTextBox2
            // 
            adressTextBox2.Location = new Point(128, 70);
            adressTextBox2.Name = "adressTextBox2";
            adressTextBox2.Size = new Size(235, 23);
            adressTextBox2.TabIndex = 17;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 387);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)changeBalanceNum2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)changeBalanceNum1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button createBankButton;
        private Button addMachineButton;
        private GroupBox groupBox3;
        private Button changeMachineBalanceButton;
        private Label label2;
        private Label label1;
        private TextBox adressTextBox;
        private TextBox nameTextBox;
        private NumericUpDown changeBalanceNum2;
        private Label label6;
        private Label label8;
        private ComboBox bankComboBox2;
        private NumericUpDown changeBalanceNum1;
        private Label label5;
        private ComboBox atmComboBox;
        private Label label3;
        private Label label4;
        private ComboBox bankComboBox1;
        private TextBox adressTextBox2;
        private Label label7;
    }
}