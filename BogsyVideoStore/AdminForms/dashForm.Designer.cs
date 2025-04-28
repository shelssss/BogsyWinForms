namespace BogsyVideoStore
{
    partial class dashForm
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
            panel1 = new Panel();
            userNumLbl = new Label();
            userCountLbl = new Label();
            panel2 = new Panel();
            vcdNumLbl = new Label();
            vcdCountLbl = new Label();
            panel3 = new Panel();
            dvdNumLbl = new Label();
            dvdCountLbl = new Label();
            panel4 = new Panel();
            overNumLbl = new Label();
            overCountLbl = new Label();
            panel5 = new Panel();
            totalSalesLbl = new Label();
            saleLbl = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 46, 68);
            panel1.Controls.Add(userNumLbl);
            panel1.Controls.Add(userCountLbl);
            panel1.Location = new Point(100, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 255);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // userNumLbl
            // 
            userNumLbl.AutoSize = true;
            userNumLbl.BackColor = Color.FromArgb(0, 46, 68);
            userNumLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userNumLbl.ForeColor = SystemColors.ControlLightLight;
            userNumLbl.Location = new Point(88, 113);
            userNumLbl.Name = "userNumLbl";
            userNumLbl.Size = new Size(0, 37);
            userNumLbl.TabIndex = 1;
            // 
            // userCountLbl
            // 
            userCountLbl.AutoSize = true;
            userCountLbl.BackColor = Color.FromArgb(0, 46, 68);
            userCountLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userCountLbl.ForeColor = SystemColors.ControlLightLight;
            userCountLbl.Location = new Point(19, 180);
            userCountLbl.Name = "userCountLbl";
            userCountLbl.Size = new Size(159, 37);
            userCountLbl.TabIndex = 0;
            userCountLbl.Text = "User Count";
            userCountLbl.Click += userCountLbl_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 46, 68);
            panel2.Controls.Add(vcdNumLbl);
            panel2.Controls.Add(vcdCountLbl);
            panel2.Location = new Point(330, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(192, 255);
            panel2.TabIndex = 2;
            // 
            // vcdNumLbl
            // 
            vcdNumLbl.AutoSize = true;
            vcdNumLbl.BackColor = Color.FromArgb(0, 46, 68);
            vcdNumLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vcdNumLbl.ForeColor = SystemColors.ControlLightLight;
            vcdNumLbl.Location = new Point(85, 113);
            vcdNumLbl.Name = "vcdNumLbl";
            vcdNumLbl.Size = new Size(0, 37);
            vcdNumLbl.TabIndex = 1;
            // 
            // vcdCountLbl
            // 
            vcdCountLbl.AutoSize = true;
            vcdCountLbl.BackColor = Color.FromArgb(0, 46, 68);
            vcdCountLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vcdCountLbl.ForeColor = SystemColors.ControlLightLight;
            vcdCountLbl.Location = new Point(61, 180);
            vcdCountLbl.Name = "vcdCountLbl";
            vcdCountLbl.Size = new Size(71, 37);
            vcdCountLbl.TabIndex = 0;
            vcdCountLbl.Text = "VCD";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 46, 68);
            panel3.Controls.Add(dvdNumLbl);
            panel3.Controls.Add(dvdCountLbl);
            panel3.Location = new Point(549, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(192, 255);
            panel3.TabIndex = 3;
            // 
            // dvdNumLbl
            // 
            dvdNumLbl.AutoSize = true;
            dvdNumLbl.BackColor = Color.FromArgb(0, 46, 68);
            dvdNumLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dvdNumLbl.ForeColor = SystemColors.ControlLightLight;
            dvdNumLbl.Location = new Point(85, 113);
            dvdNumLbl.Name = "dvdNumLbl";
            dvdNumLbl.Size = new Size(0, 37);
            dvdNumLbl.TabIndex = 1;
            // 
            // dvdCountLbl
            // 
            dvdCountLbl.AutoSize = true;
            dvdCountLbl.BackColor = Color.FromArgb(0, 46, 68);
            dvdCountLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dvdCountLbl.ForeColor = SystemColors.ControlLightLight;
            dvdCountLbl.Location = new Point(61, 180);
            dvdCountLbl.Name = "dvdCountLbl";
            dvdCountLbl.Size = new Size(75, 37);
            dvdCountLbl.TabIndex = 0;
            dvdCountLbl.Text = "DVD";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 46, 68);
            panel4.Controls.Add(overNumLbl);
            panel4.Controls.Add(overCountLbl);
            panel4.Location = new Point(100, 275);
            panel4.Name = "panel4";
            panel4.Size = new Size(192, 167);
            panel4.TabIndex = 4;
            // 
            // overNumLbl
            // 
            overNumLbl.AutoSize = true;
            overNumLbl.BackColor = Color.FromArgb(0, 46, 68);
            overNumLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            overNumLbl.ForeColor = SystemColors.ControlLightLight;
            overNumLbl.Location = new Point(86, 49);
            overNumLbl.Name = "overNumLbl";
            overNumLbl.Size = new Size(0, 37);
            overNumLbl.TabIndex = 1;
            // 
            // overCountLbl
            // 
            overCountLbl.AutoSize = true;
            overCountLbl.BackColor = Color.FromArgb(0, 46, 68);
            overCountLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            overCountLbl.ForeColor = SystemColors.ControlLightLight;
            overCountLbl.Location = new Point(35, 98);
            overCountLbl.Name = "overCountLbl";
            overCountLbl.Size = new Size(126, 37);
            overCountLbl.TabIndex = 0;
            overCountLbl.Text = "Overdue";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 46, 68);
            panel5.Controls.Add(totalSalesLbl);
            panel5.Controls.Add(saleLbl);
            panel5.Location = new Point(330, 275);
            panel5.Name = "panel5";
            panel5.Size = new Size(192, 167);
            panel5.TabIndex = 5;
            // 
            // totalSalesLbl
            // 
            totalSalesLbl.AutoSize = true;
            totalSalesLbl.BackColor = Color.FromArgb(0, 46, 68);
            totalSalesLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalSalesLbl.ForeColor = SystemColors.ControlLightLight;
            totalSalesLbl.Location = new Point(35, 49);
            totalSalesLbl.Name = "totalSalesLbl";
            totalSalesLbl.Size = new Size(0, 37);
            totalSalesLbl.TabIndex = 1;
            // 
            // saleLbl
            // 
            saleLbl.AutoSize = true;
            saleLbl.BackColor = Color.FromArgb(0, 46, 68);
            saleLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saleLbl.ForeColor = SystemColors.ControlLightLight;
            saleLbl.Location = new Point(22, 98);
            saleLbl.Name = "saleLbl";
            saleLbl.Size = new Size(154, 37);
            saleLbl.TabIndex = 0;
            saleLbl.Text = "Total Sales";
            // 
            // dashForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(849, 551);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dashForm";
            Text = "dashForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label userCountLbl;
        private Label userNumLbl;
        private Panel panel2;
        private Label vcdNumLbl;
        private Label vcdCountLbl;
        private Panel panel3;
        private Label dvdNumLbl;
        private Label dvdCountLbl;
        private Panel panel4;
        private Label overNumLbl;
        private Label overCountLbl;
        private Panel panel5;
        private Label totalSalesLbl;
        private Label saleLbl;
    }
}