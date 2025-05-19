namespace BogsyVideoStore.Modals
{
    partial class ForgotPassword
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
            passRestLbl = new Label();
            usernameLbl = new Label();
            usernameTxt = new TextBox();
            label1 = new Label();
            reasonTxt = new TextBox();
            RequestBtn = new Button();
            SuspendLayout();
            // 
            // passRestLbl
            // 
            passRestLbl.AutoSize = true;
            passRestLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passRestLbl.ForeColor = Color.FromArgb(0, 46, 68);
            passRestLbl.Location = new Point(43, 26);
            passRestLbl.Name = "passRestLbl";
            passRestLbl.Size = new Size(237, 30);
            passRestLbl.TabIndex = 13;
            passRestLbl.Text = "Forgot your Password?";
            // 
            // usernameLbl
            // 
            usernameLbl.AutoSize = true;
            usernameLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            usernameLbl.ForeColor = Color.FromArgb(0, 46, 68);
            usernameLbl.Location = new Point(28, 89);
            usernameLbl.Name = "usernameLbl";
            usernameLbl.Size = new Size(67, 15);
            usernameLbl.TabIndex = 16;
            usernameLbl.Text = "Username:";
            // 
            // usernameTxt
            // 
            usernameTxt.Font = new Font("Segoe UI", 12F);
            usernameTxt.ForeColor = Color.FromArgb(0, 46, 68);
            usernameTxt.Location = new Point(28, 107);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.PlaceholderText = "Username";
            usernameTxt.Size = new Size(252, 29);
            usernameTxt.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 46, 68);
            label1.Location = new Point(28, 150);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 18;
            label1.Text = "Reason:";
            // 
            // reasonTxt
            // 
            reasonTxt.Font = new Font("Segoe UI", 12F);
            reasonTxt.ForeColor = Color.FromArgb(0, 46, 68);
            reasonTxt.Location = new Point(28, 168);
            reasonTxt.Name = "reasonTxt";
            reasonTxt.PlaceholderText = "Reason";
            reasonTxt.Size = new Size(252, 29);
            reasonTxt.TabIndex = 17;
            // 
            // RequestBtn
            // 
            RequestBtn.BackColor = Color.FromArgb(0, 46, 68);
            RequestBtn.FlatStyle = FlatStyle.Popup;
            RequestBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RequestBtn.ForeColor = Color.White;
            RequestBtn.Location = new Point(28, 224);
            RequestBtn.Name = "RequestBtn";
            RequestBtn.Size = new Size(252, 30);
            RequestBtn.TabIndex = 19;
            RequestBtn.Text = "Request";
            RequestBtn.UseVisualStyleBackColor = false;
            RequestBtn.Click += RequestBtn_Click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 382);
            Controls.Add(RequestBtn);
            Controls.Add(label1);
            Controls.Add(reasonTxt);
            Controls.Add(usernameLbl);
            Controls.Add(usernameTxt);
            Controls.Add(passRestLbl);
            MinimizeBox = false;
            Name = "ForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label passRestLbl;
        private Label usernameLbl;
        private TextBox usernameTxt;
        private Label label1;
        private TextBox reasonTxt;
        private Button RequestBtn;
    }
}