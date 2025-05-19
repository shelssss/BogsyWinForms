namespace BogsyVideoStore.Modals
{
    partial class PasswordChange
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
            custInfoLlb = new Label();
            passLbl = new Label();
            passwordTxt = new TextBox();
            SavePassBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BdayPicker = new DateTimePicker();
            userNameTxt = new TextBox();
            customerNameTxt = new TextBox();
            SuspendLayout();
            // 
            // custInfoLlb
            // 
            custInfoLlb.AutoSize = true;
            custInfoLlb.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            custInfoLlb.ForeColor = Color.FromArgb(0, 46, 68);
            custInfoLlb.Location = new Point(111, 52);
            custInfoLlb.Name = "custInfoLlb";
            custInfoLlb.Size = new Size(185, 30);
            custInfoLlb.TabIndex = 20;
            custInfoLlb.Text = "Change Password";
            // 
            // passLbl
            // 
            passLbl.AutoSize = true;
            passLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            passLbl.ForeColor = Color.FromArgb(0, 46, 68);
            passLbl.Location = new Point(78, 216);
            passLbl.Name = "passLbl";
            passLbl.Size = new Size(119, 15);
            passLbl.TabIndex = 19;
            passLbl.Text = "Customer Password:";
            // 
            // passwordTxt
            // 
            passwordTxt.Font = new Font("Segoe UI", 12F);
            passwordTxt.ForeColor = Color.FromArgb(0, 46, 68);
            passwordTxt.Location = new Point(78, 234);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PlaceholderText = "Password";
            passwordTxt.Size = new Size(252, 29);
            passwordTxt.TabIndex = 18;
            passwordTxt.UseSystemPasswordChar = true;
            // 
            // SavePassBtn
            // 
            SavePassBtn.BackColor = Color.FromArgb(0, 46, 68);
            SavePassBtn.FlatStyle = FlatStyle.Popup;
            SavePassBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SavePassBtn.ForeColor = Color.White;
            SavePassBtn.Location = new Point(78, 350);
            SavePassBtn.Name = "SavePassBtn";
            SavePassBtn.Size = new Size(252, 31);
            SavePassBtn.TabIndex = 17;
            SavePassBtn.Text = "Save";
            SavePassBtn.UseVisualStyleBackColor = false;
            SavePassBtn.Click += SavePassBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 46, 68);
            label3.Location = new Point(78, 276);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 16;
            label3.Text = "Your Birthday:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 46, 68);
            label2.Location = new Point(78, 166);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 15;
            label2.Text = "Customer Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 46, 68);
            label1.Location = new Point(78, 112);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 14;
            label1.Text = "Customer Name:";
            // 
            // BdayPicker
            // 
            BdayPicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BdayPicker.Location = new Point(78, 294);
            BdayPicker.Name = "BdayPicker";
            BdayPicker.Size = new Size(252, 29);
            BdayPicker.TabIndex = 13;
            // 
            // userNameTxt
            // 
            userNameTxt.Font = new Font("Segoe UI", 12F);
            userNameTxt.ForeColor = Color.FromArgb(0, 46, 68);
            userNameTxt.Location = new Point(78, 184);
            userNameTxt.Name = "userNameTxt";
            userNameTxt.PlaceholderText = "Username";
            userNameTxt.Size = new Size(252, 29);
            userNameTxt.TabIndex = 12;
            // 
            // customerNameTxt
            // 
            customerNameTxt.Font = new Font("Segoe UI", 12F);
            customerNameTxt.ForeColor = Color.FromArgb(0, 46, 68);
            customerNameTxt.Location = new Point(78, 130);
            customerNameTxt.Name = "customerNameTxt";
            customerNameTxt.PlaceholderText = "Customer Name";
            customerNameTxt.Size = new Size(252, 29);
            customerNameTxt.TabIndex = 11;
            // 
            // PasswordChange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 454);
            Controls.Add(custInfoLlb);
            Controls.Add(passLbl);
            Controls.Add(passwordTxt);
            Controls.Add(SavePassBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BdayPicker);
            Controls.Add(userNameTxt);
            Controls.Add(customerNameTxt);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "PasswordChange";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PasswordChange";
            Load += PasswordChange_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label custInfoLlb;
        private Label passLbl;
        private TextBox passwordTxt;
        private Button SavePassBtn;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker BdayPicker;
        private TextBox userNameTxt;
        private TextBox customerNameTxt;
    }
}