using BogsyVideoStore.Helpers;
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

        private void VideoGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = VideoGridView.Rows[e.RowIndex];
                var video = (Video)selectedRow.DataBoundItem;

                var editForm = new AddVideo(video);
                editForm.ShowDialog();
                LoadVideo();
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (VideoGridView.SelectedRows.Count > 0)
            {
                var selectedRow = VideoGridView.SelectedRows[0];
                var video = (Video)selectedRow.DataBoundItem;

                using (var context = new AppDbContext())
                {
                    bool deleted = VideoCrud.DeleteVideo(context, video.Id);
                    if (deleted)
                    {
                        LoadVideo();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a video to delete.");
            }
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            using (var context = new AppDbContext()) 
            {   
                string search = searchBar.Text.Trim();
                var searchTitle = FilterResults.SearchTitle(context, search);

                VideoGridView.DataSource = searchTitle;
            }
        }
    }
}
