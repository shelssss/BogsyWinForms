namespace BogsyVideoStore
{
    partial class VideosForm
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
            VideoGridView = new DataGridView();
            AddViewBtn = new Button();
            delBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)VideoGridView).BeginInit();
            SuspendLayout();
            // 
            // VideoGridView
            // 
            VideoGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            VideoGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VideoGridView.Location = new Point(83, 57);
            VideoGridView.Name = "VideoGridView";
            VideoGridView.ReadOnly = true;
            VideoGridView.Size = new Size(690, 433);
            VideoGridView.TabIndex = 0;
            VideoGridView.CellDoubleClick += VideoGridView_CellDoubleClick;
            // 
            // AddViewBtn
            // 
            AddViewBtn.BackColor = Color.FromArgb(0, 46, 68);
            AddViewBtn.FlatStyle = FlatStyle.Popup;
            AddViewBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AddViewBtn.ForeColor = Color.White;
            AddViewBtn.Location = new Point(617, 28);
            AddViewBtn.Name = "AddViewBtn";
            AddViewBtn.Size = new Size(75, 23);
            AddViewBtn.TabIndex = 1;
            AddViewBtn.Text = "Add";
            AddViewBtn.UseVisualStyleBackColor = false;
            AddViewBtn.Click += AddViewBtn_Click;
            // 
            // delBtn
            // 
            delBtn.BackColor = Color.FromArgb(0, 46, 68);
            delBtn.FlatStyle = FlatStyle.Popup;
            delBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            delBtn.ForeColor = Color.White;
            delBtn.Location = new Point(698, 28);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(75, 23);
            delBtn.TabIndex = 3;
            delBtn.Text = "Delete";
            delBtn.UseVisualStyleBackColor = false;
            delBtn.Click += delBtn_Click;
            // 
            // VideosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 539);
            Controls.Add(delBtn);
            Controls.Add(AddViewBtn);
            Controls.Add(VideoGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VideosForm";
            Text = "VideosForm";
            Load += VideosForm_Load;
            ((System.ComponentModel.ISupportInitialize)VideoGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView VideoGridView;
        private Panel panel1;
        private Panel panel2;
        private Button AddViewBtn;
        private Button delBtn;
    }
}