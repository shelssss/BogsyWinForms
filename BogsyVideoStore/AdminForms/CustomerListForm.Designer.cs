namespace BogsyVideoStore
{
    partial class CustomerListForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            AddCustomerBtn = new Button();
            CustomerGridView = new DataGridView();
            panel2 = new Panel();
            nameLbl = new Label();
            searchBar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)CustomerGridView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
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
            AddCustomerBtn.TabIndex = 1;
            AddCustomerBtn.Text = "Add";
            AddCustomerBtn.UseVisualStyleBackColor = false;
            AddCustomerBtn.Click += AddCustomerBtn_Click;
            // 
            // CustomerGridView
            // 
            CustomerGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 46, 68);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CustomerGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            CustomerGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 46, 68);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            CustomerGridView.DefaultCellStyle = dataGridViewCellStyle2;
            CustomerGridView.Location = new Point(3, 3);
            CustomerGridView.Name = "CustomerGridView";
            CustomerGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            CustomerGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            CustomerGridView.Size = new Size(690, 433);
            CustomerGridView.TabIndex = 0;
            CustomerGridView.CellDoubleClick += CustomerGridView_CellDoubleClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(CustomerGridView);
            panel2.Location = new Point(80, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(693, 439);
            panel2.TabIndex = 0;
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLbl.ForeColor = Color.FromArgb(0, 46, 68);
            nameLbl.Location = new Point(80, 10);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(46, 15);
            nameLbl.TabIndex = 6;
            nameLbl.Text = "Name: ";
            // 
            // searchBar
            // 
            searchBar.Location = new Point(80, 28);
            searchBar.Name = "searchBar";
            searchBar.PlaceholderText = "Search...";
            searchBar.Size = new Size(165, 23);
            searchBar.TabIndex = 5;
            searchBar.TextChanged += searchBar_TextChanged;
            // 
            // CustomerListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 539);
            Controls.Add(nameLbl);
            Controls.Add(searchBar);
            Controls.Add(AddCustomerBtn);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerListForm";
            Text = "CustomerListForm";
            Load += CustomerListForm_Load;
            ((System.ComponentModel.ISupportInitialize)CustomerGridView).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button AddCustomerBtn;
        private DataGridView CustomerGridView;
        private Panel panel2;
        private Label nameLbl;
        private TextBox searchBar;
    }
}