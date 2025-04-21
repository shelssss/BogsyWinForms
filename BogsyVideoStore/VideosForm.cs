using BogsyVideoStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BogsyVideoStore
{
    public partial class VideosForm : Form
    {
        public VideosForm()
        {
            InitializeComponent();
        }

        private void VideosForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadVideo();
        }

        private void AddViewBtn_Click(object sender, EventArgs e)
        {
            var addVideoForm = new AddVideo();
            addVideoForm.ShowDialog();
            LoadVideo();

        }

        private void LoadVideo()
        {
            using (var context = new AppDbContext())
            {
                var videos = context.Video.OrderBy(v => v.Title).ToList();  
                VideoGridView.DataSource = videos;
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (VideoGridView.SelectedRows.Count > 0)
            {
                var selectedRow = VideoGridView.SelectedRows[0];
                var video = (Video)selectedRow.DataBoundItem;

                var editForm = new AddVideo(video);
                editForm.ShowDialog();
                LoadVideo();
            }
            else
            {
                MessageBox.Show("Please select a video to edit.");
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (VideoGridView.SelectedRows.Count > 0)
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this Video?",
                                              "Confirm Delete",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    var selectedRow = VideoGridView.SelectedRows[0];
                    var video = (Video)selectedRow.DataBoundItem;

                    using (var context = new AppDbContext())
                    {
                        var videoToDelete = context.Video.FirstOrDefault(c => c.Id == video.Id);
                        if (videoToDelete != null)
                        {
                            context.Video.Remove(videoToDelete);
                            context.SaveChanges();
                            MessageBox.Show("Video deleted!");
                            LoadVideo(); 
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a video to delete.");
            }
        }
    }
}
