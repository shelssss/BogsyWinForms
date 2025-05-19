namespace BogsyVideoStore
{
    partial class AddVideo
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
            TitleTxt = new TextBox();
            CurrentInTxt = new NumericUpDown();
            CategoryDropDown = new ComboBox();
            DescTxt = new TextBox();
            AddVidBtn = new Button();
            titleLbl = new Label();
            descLbl = new Label();
            catLbl = new Label();
            qtyLbl = new Label();
            uploadImgBtn = new Button();
            maxRentLbl = new Label();
            maxRentCmbx = new ComboBox();
            custInfoLlb = new Label();
            ((System.ComponentModel.ISupportInitialize)CurrentInTxt).BeginInit();
            SuspendLayout();
            // 
            // TitleTxt
            // 
            TitleTxt.Font = new Font("Segoe UI", 12F);
            TitleTxt.Location = new Point(86, 100);
            TitleTxt.Name = "TitleTxt";
            TitleTxt.PlaceholderText = "Title";
            TitleTxt.Size = new Size(231, 29);
            TitleTxt.TabIndex = 0;
            // 
            // CurrentInTxt
            // 
            CurrentInTxt.Location = new Point(86, 325);
            CurrentInTxt.Name = "CurrentInTxt";
            CurrentInTxt.Size = new Size(231, 23);
            CurrentInTxt.TabIndex = 1;
            // 
            // CategoryDropDown
            // 
            CategoryDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryDropDown.Font = new Font("Segoe UI", 12F);
            CategoryDropDown.ForeColor = SystemColors.WindowFrame;
            CategoryDropDown.FormattingEnabled = true;
            CategoryDropDown.Items.AddRange(new object[] { "DVD", "VCD" });
            CategoryDropDown.Location = new Point(86, 213);
            CategoryDropDown.Name = "CategoryDropDown";
            CategoryDropDown.Size = new Size(231, 29);
            CategoryDropDown.TabIndex = 2;
            // 
            // DescTxt
            // 
            DescTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescTxt.Location = new Point(86, 157);
            DescTxt.Name = "DescTxt";
            DescTxt.PlaceholderText = "Description";
            DescTxt.Size = new Size(231, 29);
            DescTxt.TabIndex = 3;
            // 
            // AddVidBtn
            // 
            AddVidBtn.BackColor = Color.FromArgb(0, 46, 68);
            AddVidBtn.FlatStyle = FlatStyle.Popup;
            AddVidBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AddVidBtn.ForeColor = Color.White;
            AddVidBtn.Location = new Point(86, 415);
            AddVidBtn.Name = "AddVidBtn";
            AddVidBtn.Size = new Size(231, 30);
            AddVidBtn.TabIndex = 4;
            AddVidBtn.Text = "Save";
            AddVidBtn.UseVisualStyleBackColor = false;
            AddVidBtn.Click += AddVidBtn_Click;
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            titleLbl.ForeColor = Color.FromArgb(0, 46, 68);
            titleLbl.Location = new Point(86, 82);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(35, 15);
            titleLbl.TabIndex = 5;
            titleLbl.Text = "Title:";
            // 
            // descLbl
            // 
            descLbl.AutoSize = true;
            descLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            descLbl.ForeColor = Color.FromArgb(0, 46, 68);
            descLbl.Location = new Point(86, 139);
            descLbl.Name = "descLbl";
            descLbl.Size = new Size(74, 15);
            descLbl.TabIndex = 6;
            descLbl.Text = "Description:";
            // 
            // catLbl
            // 
            catLbl.AutoSize = true;
            catLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            catLbl.ForeColor = Color.FromArgb(0, 46, 68);
            catLbl.Location = new Point(86, 195);
            catLbl.Name = "catLbl";
            catLbl.Size = new Size(60, 15);
            catLbl.TabIndex = 7;
            catLbl.Text = "Category:";
            // 
            // qtyLbl
            // 
            qtyLbl.AutoSize = true;
            qtyLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            qtyLbl.ForeColor = Color.FromArgb(0, 46, 68);
            qtyLbl.Location = new Point(86, 307);
            qtyLbl.Name = "qtyLbl";
            qtyLbl.Size = new Size(58, 15);
            qtyLbl.TabIndex = 8;
            qtyLbl.Text = "Quantity:";
            // 
            // uploadImgBtn
            // 
            uploadImgBtn.FlatStyle = FlatStyle.Popup;
            uploadImgBtn.Location = new Point(86, 364);
            uploadImgBtn.Name = "uploadImgBtn";
            uploadImgBtn.Size = new Size(231, 29);
            uploadImgBtn.TabIndex = 9;
            uploadImgBtn.Text = "Select Image";
            uploadImgBtn.UseVisualStyleBackColor = true;
            uploadImgBtn.Click += uploadImgBtn_Click;
            // 
            // maxRentLbl
            // 
            maxRentLbl.AutoSize = true;
            maxRentLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            maxRentLbl.ForeColor = Color.FromArgb(0, 46, 68);
            maxRentLbl.Location = new Point(86, 251);
            maxRentLbl.Name = "maxRentLbl";
            maxRentLbl.Size = new Size(64, 15);
            maxRentLbl.TabIndex = 11;
            maxRentLbl.Text = "Max Rent:";
            // 
            // maxRentCmbx
            // 
            maxRentCmbx.DropDownStyle = ComboBoxStyle.DropDownList;
            maxRentCmbx.Font = new Font("Segoe UI", 12F);
            maxRentCmbx.ForeColor = SystemColors.WindowFrame;
            maxRentCmbx.FormattingEnabled = true;
            maxRentCmbx.Items.AddRange(new object[] { "1", "2", "3" });
            maxRentCmbx.Location = new Point(86, 269);
            maxRentCmbx.Name = "maxRentCmbx";
            maxRentCmbx.Size = new Size(231, 29);
            maxRentCmbx.TabIndex = 10;
            // 
            // custInfoLlb
            // 
            custInfoLlb.AutoSize = true;
            custInfoLlb.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            custInfoLlb.ForeColor = Color.FromArgb(0, 46, 68);
            custInfoLlb.Location = new Point(104, 39);
            custInfoLlb.Name = "custInfoLlb";
            custInfoLlb.Size = new Size(195, 30);
            custInfoLlb.TabIndex = 12;
            custInfoLlb.Text = "Video Information";
            // 
            // AddVideo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 498);
            Controls.Add(custInfoLlb);
            Controls.Add(maxRentLbl);
            Controls.Add(maxRentCmbx);
            Controls.Add(uploadImgBtn);
            Controls.Add(qtyLbl);
            Controls.Add(catLbl);
            Controls.Add(descLbl);
            Controls.Add(titleLbl);
            Controls.Add(AddVidBtn);
            Controls.Add(DescTxt);
            Controls.Add(CategoryDropDown);
            Controls.Add(CurrentInTxt);
            Controls.Add(TitleTxt);
            Name = "AddVideo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddVideo";
            ((System.ComponentModel.ISupportInitialize)CurrentInTxt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TitleTxt;
        private NumericUpDown CurrentInTxt;
        private ComboBox CategoryDropDown;
        private TextBox DescTxt;
        private Button AddVidBtn;
        private Label titleLbl;
        private Label descLbl;
        private Label catLbl;
        private Label qtyLbl;
        private Button uploadImgBtn;
        private Label maxRentLbl;
        private ComboBox maxRentCmbx;
        private Label custInfoLlb;
    }
}