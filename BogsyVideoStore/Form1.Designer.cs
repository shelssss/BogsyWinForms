namespace BogsyVideoStore
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            userNameTxt = new TextBox();
            loginBtn = new Button();
            passwordTxt = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(166, 161);
            label1.Name = "label1";
            label1.Size = new Size(316, 37);
            label1.TabIndex = 0;
            label1.Text = "BVS: Bogsy Video Store";
            label1.Click += label1_Click;
            // 
            // userNameTxt
            // 
            userNameTxt.Location = new Point(175, 225);
            userNameTxt.Name = "userNameTxt";
            userNameTxt.PlaceholderText = "Username";
            userNameTxt.Size = new Size(296, 23);
            userNameTxt.TabIndex = 1;
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            loginBtn.ForeColor = Color.FromArgb(0, 46, 68);
            loginBtn.Location = new Point(283, 292);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 3;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(175, 254);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PlaceholderText = "Password";
            passwordTxt.Size = new Size(296, 23);
            passwordTxt.TabIndex = 4;
            passwordTxt.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(215, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 46, 68);
            ClientSize = new Size(652, 382);
            Controls.Add(passwordTxt);
            Controls.Add(loginBtn);
            Controls.Add(userNameTxt);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userNameTxt;
        private Button loginBtn;
        private TextBox passwordTxt;
        private PictureBox pictureBox1;
    }
}
