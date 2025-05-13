namespace BogsyVideoStore
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            panel1 = new Panel();
            bvsLbl = new Label();
            hamPic = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel4 = new Panel();
            videoBtn = new Button();
            panel3 = new Panel();
            RentVidBtn = new Button();
            panel7 = new Panel();
            panel6 = new Panel();
            logoutBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hamPic).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 46, 68);
            panel1.Controls.Add(bvsLbl);
            panel1.Controls.Add(hamPic);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(188, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(946, 45);
            panel1.TabIndex = 2;
            // 
            // bvsLbl
            // 
            bvsLbl.AutoSize = true;
            bvsLbl.BackColor = Color.FromArgb(0, 46, 68);
            bvsLbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            bvsLbl.ForeColor = Color.White;
            bvsLbl.Location = new Point(60, 9);
            bvsLbl.Name = "bvsLbl";
            bvsLbl.Size = new Size(185, 28);
            bvsLbl.TabIndex = 2;
            bvsLbl.Text = "Bogsy Video Store";
            bvsLbl.Click += bvsLbl_Click;
            // 
            // hamPic
            // 
            hamPic.Image = (Image)resources.GetObject("hamPic.Image");
            hamPic.Location = new Point(0, 1);
            hamPic.Name = "hamPic";
            hamPic.Size = new Size(54, 44);
            hamPic.SizeMode = PictureBoxSizeMode.CenterImage;
            hamPic.TabIndex = 1;
            hamPic.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(0, 46, 68);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel7);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 30, 0, 0);
            flowLayoutPanel1.Size = new Size(188, 681);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(videoBtn);
            panel4.Location = new Point(3, 33);
            panel4.Name = "panel4";
            panel4.Size = new Size(195, 57);
            panel4.TabIndex = 5;
            // 
            // videoBtn
            // 
            videoBtn.BackColor = Color.FromArgb(0, 46, 68);
            videoBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            videoBtn.ForeColor = Color.White;
            videoBtn.Image = (Image)resources.GetObject("videoBtn.Image");
            videoBtn.ImageAlign = ContentAlignment.MiddleLeft;
            videoBtn.Location = new Point(-12, -29);
            videoBtn.Name = "videoBtn";
            videoBtn.Padding = new Padding(25, 0, 0, 0);
            videoBtn.Size = new Size(239, 115);
            videoBtn.TabIndex = 2;
            videoBtn.Text = "Rent a Video";
            videoBtn.UseVisualStyleBackColor = false;
            videoBtn.Click += videoBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(RentVidBtn);
            panel3.Location = new Point(3, 96);
            panel3.Name = "panel3";
            panel3.Size = new Size(195, 57);
            panel3.TabIndex = 6;
            // 
            // RentVidBtn
            // 
            RentVidBtn.BackColor = Color.FromArgb(0, 46, 68);
            RentVidBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            RentVidBtn.ForeColor = Color.White;
            RentVidBtn.Image = (Image)resources.GetObject("RentVidBtn.Image");
            RentVidBtn.ImageAlign = ContentAlignment.MiddleLeft;
            RentVidBtn.Location = new Point(-13, -29);
            RentVidBtn.Name = "RentVidBtn";
            RentVidBtn.Padding = new Padding(25, 0, 0, 0);
            RentVidBtn.Size = new Size(239, 115);
            RentVidBtn.TabIndex = 3;
            RentVidBtn.Text = "Rented Videos";
            RentVidBtn.UseVisualStyleBackColor = false;
            RentVidBtn.Click += RentVidBtn_Click;
            // 
            // panel7
            // 
            panel7.Location = new Point(3, 159);
            panel7.Name = "panel7";
            panel7.Size = new Size(185, 445);
            panel7.TabIndex = 10;
            // 
            // panel6
            // 
            panel6.Controls.Add(logoutBtn);
            panel6.Location = new Point(3, 610);
            panel6.Name = "panel6";
            panel6.Size = new Size(195, 57);
            panel6.TabIndex = 9;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.FromArgb(0, 46, 68);
            logoutBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            logoutBtn.ForeColor = Color.White;
            logoutBtn.Image = (Image)resources.GetObject("logoutBtn.Image");
            logoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            logoutBtn.Location = new Point(-20, -29);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Padding = new Padding(25, 0, 0, 0);
            logoutBtn.Size = new Size(239, 115);
            logoutBtn.TabIndex = 3;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 681);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hamPic).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label bvsLbl;
        private PictureBox hamPic;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel4;
        private Button videoBtn;
        private Panel panel3;
        private Button RentVidBtn;
        private Panel panel7;
        private Panel panel6;
        private Button logoutBtn;
    }
}