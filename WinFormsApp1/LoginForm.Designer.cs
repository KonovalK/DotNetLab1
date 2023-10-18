namespace WinFormsApp1
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            PasswordTextBox = new MaskedTextBox();
            LoginTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 308);
            button1.Name = "button1";
            button1.Size = new Size(348, 130);
            button1.TabIndex = 0;
            button1.Text = "ENTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(102, 170);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(258, 23);
            PasswordTextBox.TabIndex = 1;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(102, 106);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(258, 23);
            LoginTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 106);
            label1.Name = "label1";
            label1.Size = new Size(50, 17);
            label1.TabIndex = 3;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 170);
            label2.Name = "label2";
            label2.Size = new Size(84, 17);
            label2.TabIndex = 4;
            label2.Text = "PASSWORD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(102, 18);
            label3.Name = "label3";
            label3.Size = new Size(154, 25);
            label3.TabIndex = 5;
            label3.Text = "KOLYA`S BANK";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(12, 277);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(72, 17);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registrate";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 450);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LoginTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(button1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MaskedTextBox PasswordTextBox;
        private TextBox LoginTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
    }
}