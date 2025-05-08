namespace BogsyVideoStore
{
    partial class AddCustomer
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
            customerNameTxt = new TextBox();
            userNameTxt = new TextBox();
            BdayPicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            AddCustomerBtn = new Button();
            passLbl = new Label();
            passwordTxt = new TextBox();
            custInfoLlb = new Label();
            SuspendLayout();
            // 
            // customerNameTxt
            // 
            customerNameTxt.Font = new Font("Segoe UI", 12F);
            customerNameTxt.ForeColor = Color.FromArgb(0, 46, 68);
            customerNameTxt.Location = new Point(79, 122);
            customerNameTxt.Name = "customerNameTxt";
            customerNameTxt.PlaceholderText = "Customer Name";
            customerNameTxt.Size = new Size(252, 29);
            customerNameTxt.TabIndex = 1;
            // 
            // userNameTxt
            // 
            userNameTxt.Font = new Font("Segoe UI", 12F);
            userNameTxt.ForeColor = Color.FromArgb(0, 46, 68);
            userNameTxt.Location = new Point(79, 176);
            userNameTxt.Name = "userNameTxt";
            userNameTxt.PlaceholderText = "Username";
            userNameTxt.Size = new Size(252, 29);
            userNameTxt.TabIndex = 2;
            // 
            // BdayPicker
            // 
            BdayPicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BdayPicker.Location = new Point(79, 286);
            BdayPicker.Name = "BdayPicker";
            BdayPicker.Size = new Size(252, 29);
            BdayPicker.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 46, 68);
            label1.Location = new Point(79, 104);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 4;
            label1.Text = "Customer Name:";
          
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 46, 68);
            label2.Location = new Point(79, 158);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 5;
            label2.Text = "Customer Username:";
            
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 46, 68);
            label3.Location = new Point(79, 268);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 6;
            label3.Text = "Your Birthday:";
            // 
            // AddCustomerBtn
            // 
            AddCustomerBtn.BackColor = Color.FromArgb(0, 46, 68);
            AddCustomerBtn.FlatStyle = FlatStyle.Popup;
            AddCustomerBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AddCustomerBtn.ForeColor = Color.White;
            AddCustomerBtn.Location = new Point(131, 342);
            AddCustomerBtn.Name = "AddCustomerBtn";
            AddCustomerBtn.Size = new Size(134, 37);
            AddCustomerBtn.TabIndex = 7;
            AddCustomerBtn.Text = "Save";
            AddCustomerBtn.UseVisualStyleBackColor = false;
            AddCustomerBtn.Click += AddCustomerBtn_Click;
            // 
            // passLbl
            // 
            passLbl.AutoSize = true;
            passLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            passLbl.ForeColor = Color.FromArgb(0, 46, 68);
            passLbl.Location = new Point(79, 208);
            passLbl.Name = "passLbl";
            passLbl.Size = new Size(119, 15);
            passLbl.TabIndex = 9;
            passLbl.Text = "Customer Password:";
            // 
            // passwordTxt
            // 
            passwordTxt.Font = new Font("Segoe UI", 12F);
            passwordTxt.ForeColor = Color.FromArgb(0, 46, 68);
            passwordTxt.Location = new Point(79, 226);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PlaceholderText = "Password";
            passwordTxt.Size = new Size(252, 29);
            passwordTxt.TabIndex = 8;
            passwordTxt.UseSystemPasswordChar = true;
            // 
            // custInfoLlb
            // 
            custInfoLlb.AutoSize = true;
            custInfoLlb.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            custInfoLlb.ForeColor = Color.FromArgb(0, 46, 68);
            custInfoLlb.Location = new Point(89, 44);
            custInfoLlb.Name = "custInfoLlb";
            custInfoLlb.Size = new Size(232, 30);
            custInfoLlb.TabIndex = 10;
            custInfoLlb.Text = "Customer Information";
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 454);
            Controls.Add(custInfoLlb);
            Controls.Add(passLbl);
            Controls.Add(passwordTxt);
            Controls.Add(AddCustomerBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BdayPicker);
            Controls.Add(userNameTxt);
            Controls.Add(customerNameTxt);
            Name = "AddCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox customerNameTxt;
        private TextBox userNameTxt;
        private DateTimePicker BdayPicker;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button AddCustomerBtn;
        private Label passLbl;
        private TextBox passwordTxt;
        private Label custInfoLlb;
    }
}