namespace BogsyVideoStore
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            panel1 = new Panel();
            bvsLbl = new Label();
            hamPic = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            dashboardBtn = new Button();
            panel3 = new Panel();
            customerBtn = new Button();
            panel4 = new Panel();
            videoBtn = new Button();
            panel5 = new Panel();
            AllRentsBtn = new Button();
            panel7 = new Panel();
            panel6 = new Panel();
            logoutBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hamPic).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 46, 68);
            panel1.Controls.Add(bvsLbl);
            panel1.Controls.Add(hamPic);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1038, 45);
            panel1.TabIndex = 0;
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
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel7);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 45);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 30, 0, 0);
            flowLayoutPanel1.Size = new Size(188, 533);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(dashboardBtn);
            panel2.Location = new Point(3, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(195, 57);
            panel2.TabIndex = 3;
            // 
            // dashboardBtn
            // 
            dashboardBtn.BackColor = Color.FromArgb(0, 46, 68);
            dashboardBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dashboardBtn.ForeColor = Color.White;
            dashboardBtn.Image = (Image)resources.GetObject("dashboardBtn.Image");
            dashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardBtn.Location = new Point(-12, -29);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Padding = new Padding(25, 0, 0, 0);
            dashboardBtn.Size = new Size(239, 115);
            dashboardBtn.TabIndex = 2;
            dashboardBtn.Text = "Dashboard";
            dashboardBtn.UseVisualStyleBackColor = false;
            dashboardBtn.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(customerBtn);
            panel3.Location = new Point(3, 96);
            panel3.Name = "panel3";
            panel3.Size = new Size(195, 57);
            panel3.TabIndex = 4;
            // 
            // customerBtn
            // 
            customerBtn.BackColor = Color.FromArgb(0, 46, 68);
            customerBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            customerBtn.ForeColor = Color.White;
            customerBtn.Image = (Image)resources.GetObject("customerBtn.Image");
            customerBtn.ImageAlign = ContentAlignment.MiddleLeft;
            customerBtn.Location = new Point(-13, -29);
            customerBtn.Name = "customerBtn";
            customerBtn.Padding = new Padding(25, 0, 0, 0);
            customerBtn.Size = new Size(239, 115);
            customerBtn.TabIndex = 2;
            customerBtn.Text = "Customer";
            customerBtn.UseVisualStyleBackColor = false;
            customerBtn.Click += customerBtn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(videoBtn);
            panel4.Location = new Point(3, 159);
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
            videoBtn.Text = "Videos";
            videoBtn.UseVisualStyleBackColor = false;
            videoBtn.Click += videoBtn_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(AllRentsBtn);
            panel5.Location = new Point(3, 222);
            panel5.Name = "panel5";
            panel5.Size = new Size(195, 57);
            panel5.TabIndex = 6;
            // 
            // AllRentsBtn
            // 
            AllRentsBtn.BackColor = Color.FromArgb(0, 46, 68);
            AllRentsBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            AllRentsBtn.ForeColor = Color.White;
            AllRentsBtn.Image = (Image)resources.GetObject("AllRentsBtn.Image");
            AllRentsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AllRentsBtn.Location = new Point(-13, -34);
            AllRentsBtn.Name = "AllRentsBtn";
            AllRentsBtn.Padding = new Padding(25, 0, 0, 0);
            AllRentsBtn.Size = new Size(239, 115);
            AllRentsBtn.TabIndex = 3;
            AllRentsBtn.Text = "All Rents";
            AllRentsBtn.UseVisualStyleBackColor = false;
            AllRentsBtn.Click += AllRentsBtn_Click;
            // 
            // panel7
            // 
            panel7.Location = new Point(3, 285);
            panel7.Name = "panel7";
            panel7.Size = new Size(195, 186);
            panel7.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.Controls.Add(logoutBtn);
            panel6.Location = new Point(3, 477);
            panel6.Name = "panel6";
            panel6.Size = new Size(195, 57);
            panel6.TabIndex = 7;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.FromArgb(0, 46, 68);
            logoutBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            logoutBtn.ForeColor = Color.White;
            logoutBtn.Image = (Image)resources.GetObject("logoutBtn.Image");
            logoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            logoutBtn.Location = new Point(-12, -36);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Padding = new Padding(25, 0, 0, 0);
            logoutBtn.Size = new Size(239, 115);
            logoutBtn.TabIndex = 3;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 578);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += DashboardForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hamPic).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label bvsLbl;
        private PictureBox hamPic;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Button dashboardBtn;
        private Panel panel3;
        private Button customerBtn;
        private Panel panel4;
        private Button videoBtn;
        private Button AllRentsBtn;
        private Panel panel5;
        private Panel panel7;
        private Panel panel6;
        private Button logoutBtn;
    }
}