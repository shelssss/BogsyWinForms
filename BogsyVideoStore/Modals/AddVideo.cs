using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BogsyVideoStore.Models;


namespace BogsyVideoStore
{
    public partial class AddVideo : Form
    {
        private Video _videoToEdit;
        public AddVideo()
        {
            InitializeComponent();
        }

        public AddVideo(Video video)
        {
            InitializeComponent();
            _videoToEdit = video;

            TitleTxt.Text = video.Title;
            DescTxt.Text = video.Description;
            CategoryDropDown.Text = video.Category;
            CurrentInTxt.Value = video.InCount;

        }

        private void AddVideo_Load(object sender, EventArgs e)
        {
           
        }

        private void AddVidBtn_Click(object sender, EventArgs e)
        {
            if (!IsVideoInputValid())
            {
                MessageBox.Show("Please fill in all fields properly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var context = new AppDbContext())
            {

                if (_videoToEdit != null)
                {
                    var video = context.Video.FirstOrDefault(v => v.Id == _videoToEdit.Id);
                    if (video != null)
                    {

                        video.Title = TitleTxt.Text;
                        video.Description = DescTxt.Text;
                        video.Category = CategoryDropDown.Text;
                        video.InCount = (int)CurrentInTxt.Value;
                    }
                }
                else
                {
                    var video = new Video
                    {
                        Id = new Guid(),
                        Title = TitleTxt.Text,
                        Description = DescTxt.Text,
                        Category = CategoryDropDown.Text,
                        InCount = (int)CurrentInTxt.Value,
                        OutCount = 0
                    };
                    context.Add(video);
                    
                }
                context.SaveChanges();
                MessageBox.Show("Video saved!");

            }
            this.Close();
        }

        private void TitleTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private bool IsVideoInputValid()
        {
            return !string.IsNullOrWhiteSpace(TitleTxt.Text)
                && !string.IsNullOrWhiteSpace(DescTxt.Text)
                && !string.IsNullOrWhiteSpace(CategoryDropDown.Text)
                && CurrentInTxt.Value > 0;
        }


    }
}
