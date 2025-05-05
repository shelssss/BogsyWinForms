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
            ((System.ComponentModel.ISupportInitialize)RentedListGrid).BeginInit();
            SuspendLayout();
            // 
            // RentedListGrid
            // 
            RentedListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RentedListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RentedListGrid.Location = new Point(125, 49);
            RentedListGrid.Name = "RentedListGrid";
            RentedListGrid.ReadOnly = true;
            RentedListGrid.Size = new Size(652, 436);
            RentedListGrid.TabIndex = 0;
            // 
            // selectFilter
            // 
            selectFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            selectFilter.FormattingEnabled = true;
            selectFilter.Items.AddRange(new object[] { "All", "Rented", "Overdue", "Returned" });
            selectFilter.Location = new Point(125, 12);
            selectFilter.Name = "selectFilter";
            selectFilter.Size = new Size(136, 23);
            selectFilter.TabIndex = 1;
            selectFilter.SelectedIndexChanged += selectFilter_SelectedIndexChanged;
            // 
            // CustomerRentedList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 511);
            Controls.Add(selectFilter);
            Controls.Add(RentedListGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerRentedList";
            Text = "CustomerRentedList";
            ((System.ComponentModel.ISupportInitialize)RentedListGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView RentedListGrid;
        private ComboBox selectFilter;
    }
}