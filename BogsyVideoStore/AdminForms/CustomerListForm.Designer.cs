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
            panel2 = new Panel();
            CustomerGridView = new DataGridView();
            AddCustomerBtn = new Button();
            EditBtn = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerGridView).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(CustomerGridView);
            panel2.Location = new Point(114, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(674, 397);
            panel2.TabIndex = 0;
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
            CustomerGridView.Dock = DockStyle.Fill;
            CustomerGridView.Location = new Point(0, 0);
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
            CustomerGridView.Size = new Size(674, 397);
            CustomerGridView.TabIndex = 0;
            // 
            // AddCustomerBtn
            // 
            AddCustomerBtn.BackColor = Color.FromArgb(0, 46, 68);
            AddCustomerBtn.FlatStyle = FlatStyle.Popup;
            AddCustomerBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddCustomerBtn.ForeColor = SystemColors.ButtonHighlight;
            AddCustomerBtn.Location = new Point(623, 12);
            AddCustomerBtn.Name = "AddCustomerBtn";
            AddCustomerBtn.Size = new Size(75, 23);
            AddCustomerBtn.TabIndex = 1;
            AddCustomerBtn.Text = "Add";
            AddCustomerBtn.UseVisualStyleBackColor = false;
            AddCustomerBtn.Click += AddCustomerBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.FromArgb(0, 46, 68);
            EditBtn.FlatStyle = FlatStyle.Popup;
            EditBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditBtn.ForeColor = Color.White;
            EditBtn.Location = new Point(713, 12);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(75, 23);
            EditBtn.TabIndex = 2;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // CustomerListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 453);
            Controls.Add(EditBtn);
            Controls.Add(AddCustomerBtn);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerListForm";
            Text = "CustomerListForm";
            Load += CustomerListForm_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CustomerGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private DataGridView CustomerGridView;
        private Button AddCustomerBtn;
        private Button EditBtn;
    }
}