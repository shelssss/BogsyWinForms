namespace BogsyVideoStore
{
    partial class RentVideoForm
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
            videoFlowPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // videoFlowPanel
            // 
            videoFlowPanel.AutoScroll = true;
            videoFlowPanel.Dock = DockStyle.Fill;
            videoFlowPanel.Location = new Point(0, 0);
            videoFlowPanel.Name = "videoFlowPanel";
            videoFlowPanel.Size = new Size(800, 450);
            videoFlowPanel.TabIndex = 0;
            // 
            // RentVideoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(videoFlowPanel);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "RentVideoForm";
            Text = "RentVideoForm";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel videoFlowPanel;
    }
}