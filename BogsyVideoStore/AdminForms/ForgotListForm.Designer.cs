namespace BogsyVideoStore.AdminForms
{
    partial class ForgotListForm
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
            nameLbl = new Label();
            searchBar = new TextBox();
            AddCustomerBtn = new Button();
            ForgotListGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ForgotListGrid).BeginInit();
            SuspendLayout();
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLbl.ForeColor = Color.FromArgb(0, 46, 68);
            nameLbl.Location = new Point(80, 10);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(46, 15);
            nameLbl.TabIndex = 7;
            nameLbl.Text = "Name: ";
            // 
            // searchBar
            // 
            searchBar.Location = new Point(80, 28);
            searchBar.Name = "searchBar";
            searchBar.PlaceholderText = "Search...";
            searchBar.Size = new Size(165, 23);
            searchBar.TabIndex = 8;
            searchBar.TextChanged += searchBar_TextChanged;
            // 
            // AddCustomerBtn
            // 
            AddCustomerBtn.BackColor = Color.FromArgb(0, 46, 68);
            AddCustomerBtn.FlatStyle = FlatStyle.Popup;
            AddCustomerBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddCustomerBtn.ForeColor = SystemColors.ButtonHighlight;
            AddCustomerBtn.Location = new Point(698, 28);
            AddCustomerBtn.Name = "AddCustomerBtn";
            AddCustomerBtn.Size = new Size(75, 23);
            AddCustomerBtn.TabIndex = 9;
            AddCustomerBtn.Text = "Add";
            AddCustomerBtn.UseVisualStyleBackColor = false;
            // 
            // ForgotListGrid
            // 
            ForgotListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ForgotListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ForgotListGrid.Location = new Point(80, 57);
            ForgotListGrid.Name = "ForgotListGrid";
            ForgotListGrid.ReadOnly = true;
            ForgotListGrid.Size = new Size(693, 433);
            ForgotListGrid.TabIndex = 10;
            ForgotListGrid.CellContentClick += ForgotListGrid_CellContentClick;
            // 
            // ForgotListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 539);
            Controls.Add(ForgotListGrid);
            Controls.Add(AddCustomerBtn);
            Controls.Add(searchBar);
            Controls.Add(nameLbl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotListForm";
            Text = "ForgotListForm";
            ((System.ComponentModel.ISupportInitialize)ForgotListGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLbl;
        private TextBox searchBar;
        private Button AddCustomerBtn;
        private DataGridView ForgotListGrid;
    }
}