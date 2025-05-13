namespace BogsyVideoStore
{
    partial class CustomerRentedList
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
            RentedListGrid = new DataGridView();
            selectFilter = new ComboBox();
            searchBar = new TextBox();
            dateRented = new DateTimePicker();
            nameLbl = new Label();
            statusLbl = new Label();
            dateLbl = new Label();
            searchFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)RentedListGrid).BeginInit();
            SuspendLayout();
            // 
            // RentedListGrid
            // 
            RentedListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RentedListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RentedListGrid.Location = new Point(80, 66);
            RentedListGrid.Name = "RentedListGrid";
            RentedListGrid.ReadOnly = true;
            RentedListGrid.Size = new Size(690, 433);
            RentedListGrid.TabIndex = 0;
            RentedListGrid.CellDoubleClick += RentedListGrid_CellDoubleClick;
            // 
            // selectFilter
            // 
            selectFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            selectFilter.FormattingEnabled = true;
            selectFilter.Items.AddRange(new object[] { "All", "Rented", "Overdue", "Returned" });
            selectFilter.Location = new Point(251, 27);
            selectFilter.Name = "selectFilter";
            selectFilter.Size = new Size(136, 23);
            selectFilter.TabIndex = 1;
            selectFilter.SelectedIndexChanged += selectFilter_SelectedIndexChanged;
            // 
            // searchBar
            // 
            searchBar.Location = new Point(80, 28);
            searchBar.Name = "searchBar";
            searchBar.PlaceholderText = "Search...";
            searchBar.Size = new Size(165, 23);
            searchBar.TabIndex = 2;
            searchBar.TextChanged += searchBar_TextChanged;
            // 
            // dateRented
            // 
            dateRented.Location = new Point(396, 28);
            dateRented.Name = "dateRented";
            dateRented.Size = new Size(186, 23);
            dateRented.TabIndex = 3;
            dateRented.ValueChanged += dateRented_ValueChanged;
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLbl.ForeColor = Color.FromArgb(0, 46, 68);
            nameLbl.Location = new Point(80, 10);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(46, 15);
            nameLbl.TabIndex = 4;
            nameLbl.Text = "Name: ";
            // 
            // statusLbl
            // 
            statusLbl.AutoSize = true;
            statusLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusLbl.ForeColor = Color.FromArgb(0, 46, 68);
            statusLbl.Location = new Point(251, 9);
            statusLbl.Name = "statusLbl";
            statusLbl.Size = new Size(45, 15);
            statusLbl.TabIndex = 5;
            statusLbl.Text = "Status:";
            // 
            // dateLbl
            // 
            dateLbl.AutoSize = true;
            dateLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateLbl.ForeColor = Color.FromArgb(0, 46, 68);
            dateLbl.Location = new Point(396, 10);
            dateLbl.Name = "dateLbl";
            dateLbl.Size = new Size(84, 15);
            dateLbl.TabIndex = 6;
            dateLbl.Text = "Date Rented: ";
            // 
            // searchFilter
            // 
            searchFilter.BackColor = Color.FromArgb(0, 46, 68);
            searchFilter.FlatStyle = FlatStyle.Popup;
            searchFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            searchFilter.ForeColor = Color.White;
            searchFilter.Location = new Point(695, 26);
            searchFilter.Name = "searchFilter";
            searchFilter.Size = new Size(75, 23);
            searchFilter.TabIndex = 7;
            searchFilter.Text = "Search";
            searchFilter.UseVisualStyleBackColor = false;
            searchFilter.Click += searchFilter_Click;
            // 
            // CustomerRentedList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 539);
            Controls.Add(searchFilter);
            Controls.Add(dateLbl);
            Controls.Add(statusLbl);
            Controls.Add(nameLbl);
            Controls.Add(dateRented);
            Controls.Add(searchBar);
            Controls.Add(selectFilter);
            Controls.Add(RentedListGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerRentedList";
            Text = "CustomerRentedList";
            ((System.ComponentModel.ISupportInitialize)RentedListGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView RentedListGrid;
        private ComboBox selectFilter;
        private TextBox searchBar;
        private DateTimePicker dateRented;
        private Label nameLbl;
        private Label statusLbl;
        private Label dateLbl;
        private Button searchFilter;
    }
}