namespace BogsyVideoStore
{
    partial class RentedVidForm
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
            RentedVidGrid = new DataGridView();
            ReturnBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)RentedVidGrid).BeginInit();
            SuspendLayout();
            // 
            // RentedVidGrid
            // 
            RentedVidGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RentedVidGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RentedVidGrid.Location = new Point(109, 37);
            RentedVidGrid.Name = "RentedVidGrid";
            RentedVidGrid.Size = new Size(626, 416);
            RentedVidGrid.TabIndex = 0;
            // 
            // ReturnBtn
            // 
            ReturnBtn.BackColor = Color.FromArgb(0, 46, 68);
            ReturnBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ReturnBtn.ForeColor = Color.White;
            ReturnBtn.Location = new Point(660, 8);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(75, 23);
            ReturnBtn.TabIndex = 1;
            ReturnBtn.Text = "Return";
            ReturnBtn.UseVisualStyleBackColor = false;
            ReturnBtn.Click += ReturnBtn_Click;
            // 
            // RentedVidForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 484);
            Controls.Add(ReturnBtn);
            Controls.Add(RentedVidGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RentedVidForm";
            Text = "RentedVidForm";
            ((System.ComponentModel.ISupportInitialize)RentedVidGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView RentedVidGrid;
        private Button ReturnBtn;
    }
}