using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BogsyVideoStore.Helpers;
using BogsyVideoStore.Models;


namespace BogsyVideoStore
{
    public partial class AddVideo : Form
    {
        private Video _videoToEdit;
        private string selectedImagePath = "";
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
            maxRentCmbx.Text = video.MaxRentDays.ToString();
            selectedImagePath = video.ImagePath;

        }

       

        private void AddVidBtn_Click(object sender, EventArgs e)
        {   
            string videoTitle = TitleTxt.Text;
            string description = DescTxt.Text;
            string category = CategoryDropDown.Text;
            int intCount = (int)CurrentInTxt.Value;
            int maxRentDays = int.Parse(maxRentCmbx.Text);
            string imgPath = selectedImagePath;

            if (!IsVideoInputValid())
            {
                MessageBox.Show(StringHelpers.supplyAllFields, StringHelpers.validationCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var context = new AppDbContext())
            {

                if (_videoToEdit != null)
                {
                    if (_videoToEdit != null)
                    {
                        bool sucessEdit = VideoCrudModule.EditVideo(context, _videoToEdit, videoTitle, description, category,
                            intCount, maxRentDays, imgPath);
                        if (sucessEdit)
                        {
                            this.Close();
                        }

                    }
                }
                else
                {
                    bool successInsert = VideoCrudModule.AddVideo(context, videoTitle, description, category, intCount,
                        maxRentDays, imgPath);

                    if (successInsert)
                    {
                        this.Close();
                    }
                }
            }
        }

        

        private bool IsVideoInputValid()
        {
            return !string.IsNullOrWhiteSpace(TitleTxt.Text)
                && !string.IsNullOrWhiteSpace(DescTxt.Text)
                && !string.IsNullOrWhiteSpace(CategoryDropDown.Text)
                && CurrentInTxt.Value > 0;
        }

        private void uploadImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = ofd.FileName;
                uploadImgBtn.Text = ofd.FileName;
            }
        }
    }
}
