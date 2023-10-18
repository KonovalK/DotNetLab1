namespace WinFormsApp1
{
    partial class MainForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label9 = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            numericUpDown2 = new NumericUpDown();
            button2 = new Button();
            cardToComboBox = new ComboBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label3 = new Label();
            cardToTextBox = new TextBox();
            label2 = new Label();
            cardFromComboBox = new ComboBox();
            tabPage2 = new TabPage();
            selectAtmComboBox = new ComboBox();
            button1 = new Button();
            label11 = new Label();
            label12 = new Label();
            numericUpDown3 = new NumericUpDown();
            label13 = new Label();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            label10 = new Label();
            selectCardComboBox = new ComboBox();
            tabPage3 = new TabPage();
            groupBox1 = new GroupBox();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            bankComboBox = new ComboBox();
            createCardButton = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            tabPage4 = new TabPage();
            dataGridView2 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            tabPage3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(-3, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(461, 474);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(numericUpDown2);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(cardToComboBox);
            tabPage1.Controls.Add(radioButton2);
            tabPage1.Controls.Add(radioButton1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(cardToTextBox);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(cardFromComboBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(453, 446);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Transfer of funds";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.IndianRed;
            label9.Location = new Point(119, 160);
            label9.Name = "label9";
            label9.Size = new Size(123, 15);
            label9.TabIndex = 11;
            label9.Text = "There is no such card";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(12, 230);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(417, 154);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Information about the recipient";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(6, 78);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 1;
            label8.Text = "Surname";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(6, 31);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 0;
            label7.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(119, 187);
            label6.Name = "label6";
            label6.Size = new Size(173, 21);
            label6.TabIndex = 9;
            label6.Text = "ENTER THE AMOUND";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(309, 190);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 8;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(12, 390);
            button2.Name = "button2";
            button2.Size = new Size(417, 48);
            button2.TabIndex = 7;
            button2.Text = "Create Transfer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cardToComboBox
            // 
            cardToComboBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            cardToComboBox.FormattingEnabled = true;
            cardToComboBox.Location = new Point(119, 129);
            cardToComboBox.Name = "cardToComboBox";
            cardToComboBox.Size = new Size(310, 21);
            cardToComboBox.TabIndex = 6;
            cardToComboBox.SelectedIndexChanged += cardToComboBox_SelectedIndexChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(164, 83);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(122, 25);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "To your card";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(11, 83);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(147, 25);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "To another card";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(11, 126);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 3;
            label3.Text = "CARD TO";
            // 
            // cardToTextBox
            // 
            cardToTextBox.Location = new Point(119, 131);
            cardToTextBox.Name = "cardToTextBox";
            cardToTextBox.Size = new Size(310, 23);
            cardToTextBox.TabIndex = 2;
            cardToTextBox.TextChanged += cardToTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(11, 35);
            label2.Name = "label2";
            label2.Size = new Size(102, 21);
            label2.TabIndex = 1;
            label2.Text = "CARD FROM";
            // 
            // cardFromComboBox
            // 
            cardFromComboBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            cardFromComboBox.FormattingEnabled = true;
            cardFromComboBox.Location = new Point(119, 35);
            cardFromComboBox.Name = "cardFromComboBox";
            cardFromComboBox.Size = new Size(310, 21);
            cardFromComboBox.TabIndex = 0;
            cardFromComboBox.SelectedIndexChanged += cardFromComboBox_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(selectAtmComboBox);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(numericUpDown3);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(radioButton3);
            tabPage2.Controls.Add(radioButton4);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(selectCardComboBox);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(453, 446);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "ATM operations";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // selectAtmComboBox
            // 
            selectAtmComboBox.FormattingEnabled = true;
            selectAtmComboBox.Location = new Point(124, 117);
            selectAtmComboBox.Name = "selectAtmComboBox";
            selectAtmComboBox.Size = new Size(310, 23);
            selectAtmComboBox.TabIndex = 19;
            selectAtmComboBox.SelectedIndexChanged += selectAtmComboBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(17, 390);
            button1.Name = "button1";
            button1.Size = new Size(417, 48);
            button1.TabIndex = 18;
            button1.Text = "Create Transfer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Green;
            label11.Location = new Point(11, 148);
            label11.Name = "label11";
            label11.Size = new Size(374, 15);
            label11.TabIndex = 17;
            label11.Text = "You can choose an ATM only of the bank to which the card belongs";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(124, 178);
            label12.Name = "label12";
            label12.Size = new Size(173, 21);
            label12.TabIndex = 16;
            label12.Text = "ENTER THE AMOUND";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(314, 181);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 23);
            numericUpDown3.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(11, 117);
            label13.Name = "label13";
            label13.Size = new Size(102, 21);
            label13.TabIndex = 13;
            label13.Text = "SELECT ATM";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton3.Location = new Point(11, 72);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(146, 25);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "Top up the card";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton4.Location = new Point(163, 72);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(150, 25);
            radioButton4.TabIndex = 6;
            radioButton4.TabStop = true;
            radioButton4.Text = "Withdraw funds";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(11, 20);
            label10.Name = "label10";
            label10.Size = new Size(111, 21);
            label10.TabIndex = 2;
            label10.Text = "SELECT CARD";
            // 
            // selectCardComboBox
            // 
            selectCardComboBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            selectCardComboBox.FormattingEnabled = true;
            selectCardComboBox.Location = new Point(124, 20);
            selectCardComboBox.Name = "selectCardComboBox";
            selectCardComboBox.Size = new Size(310, 21);
            selectCardComboBox.TabIndex = 1;
            selectCardComboBox.SelectedIndexChanged += selectCardComboBox_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox1);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(dataGridView1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(453, 446);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Cards Operation";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(bankComboBox);
            groupBox1.Controls.Add(createCardButton);
            groupBox1.Location = new Point(11, 248);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(422, 190);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create New Card";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(16, 81);
            label5.Name = "label5";
            label5.Size = new Size(143, 17);
            label5.TabIndex = 6;
            label5.Text = "Select default balance";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(200, 81);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(186, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(16, 33);
            label4.Name = "label4";
            label4.Size = new Size(78, 17);
            label4.TabIndex = 4;
            label4.Text = "Select Bank";
            // 
            // bankComboBox
            // 
            bankComboBox.FormattingEnabled = true;
            bankComboBox.Location = new Point(145, 33);
            bankComboBox.Name = "bankComboBox";
            bankComboBox.Size = new Size(241, 23);
            bankComboBox.TabIndex = 3;
            bankComboBox.SelectedIndexChanged += bankComboBox_SelectedIndexChanged;
            // 
            // createCardButton
            // 
            createCardButton.Location = new Point(16, 131);
            createCardButton.Name = "createCardButton";
            createCardButton.Size = new Size(159, 53);
            createCardButton.TabIndex = 2;
            createCardButton.Text = "CREATE NEW CARD";
            createCardButton.UseVisualStyleBackColor = true;
            createCardButton.Click += createCardButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 30);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 1;
            label1.Text = "MY CARDS";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(422, 156);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridView2);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(453, 446);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Transactions";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(9, 12);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(436, 426);
            dataGridView2.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 473);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Main";
            Load += Main_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ComboBox cardFromComboBox;
        private Button createCardButton;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private ComboBox cardToComboBox;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label3;
        private TextBox cardToTextBox;
        private Button button2;
        private GroupBox groupBox1;
        private Label label4;
        private ComboBox bankComboBox;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private Label label6;
        private NumericUpDown numericUpDown2;
        private TabPage tabPage4;
        private Label label9;
        private Label label11;
        private Label label12;
        private NumericUpDown numericUpDown3;
        private ComboBox comboBox2;
        private Label label13;
        private TextBox textBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label10;
        private ComboBox selectCardComboBox;
        private Button button1;
        private ComboBox selectAtmComboBox;
        private DataGridView dataGridView2;
    }
}