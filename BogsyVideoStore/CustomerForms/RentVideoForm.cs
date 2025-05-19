using BogsyVideoStore.Helpers;
using BogsyVideoStore.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class RentVideoForm : Form
    {
        private Guid currentCustomerId;
        private string currentUsername;
        private RentedVideo RentedList;

        public RentVideoForm(Guid Id, string CustomerUsername)
        {
            InitializeComponent();
            currentCustomerId = Id;
            LoadVideos();
            currentUsername = CustomerUsername;
        }


        private void LoadVideos()
        {
            videoFlowPanel.Controls.Clear();
            using (var context = new AppDbContext())
            {
                
                var videos = context.Video.Where(v => v.InCount > 0).ToList();
                
                foreach (var video in videos)
                {
                    int cost = video.Category == "DVD" ? 50 : 25;

                    Panel card = new Panel
                    {
                        Width = 200,
                        Height = 300,
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(10)
                    };

                    PictureBox pictureBox = new PictureBox
                    {
                        Width = 180,
                        Height = 120, 
                        Top = 10,
                        Left = 10,
                        SizeMode = PictureBoxSizeMode.StretchImage 
                    };

                    if (!string.IsNullOrEmpty(video.ImagePath) && File.Exists(video.ImagePath))
                    {
                        pictureBox.Image = Image.FromFile(video.ImagePath); 
                    }

                   
                    Label title = new Label
                    {
                        Text = video.Title,
                        Font = new Font("Arial", 10, FontStyle.Bold),
                        AutoSize = false,
                        Width = 180,
                        Height = 30,
                        Top = 140, 
                        Left = 10
                    };

                   
                    Label category = new Label
                    {
                        Text = $"Category: {video.Category}-(₱{cost})",
                        AutoSize = false,
                        Width = 180,
                        Height = 20,
                        Top = 170, 
                        Left = 10
                    };

                    
                    Label stock = new Label
                    {
                        Text = $"Available: {video.InCount}",
                        AutoSize = false,
                        Width = 180,
                        Height = 20,
                        Top = 190, 
                        Left = 10
                    };

                  
            
                    Label maxRent = new Label
                    {
                        Text = $"Rent Days: {video.MaxRentDays}",
                        AutoSize = false,
                        Width = 180,
                        Height = 20,
                        Top = 210, 
                        Left = 10
                    };

                  
                    Button rentBtn = new Button
                    {
                        Text = "Rent",
                        Width = 100,
                        Height = 30,
                        Top = 240, 
                        Left = 50,
                        FlatStyle = FlatStyle.Popup,
                        BackColor = Color.FromArgb(0, 46, 68),
                        ForeColor = Color.White 
                    };

                   
                    rentBtn.Click += (s, e) =>
                    {
                        TransactionVideo.RentAVideo(video, currentCustomerId, currentUsername);
                        LoadVideos();
                    };
                    card.Controls.Add(pictureBox);
                    card.Controls.Add(title);
                    card.Controls.Add(category);
                    card.Controls.Add(stock);
                    card.Controls.Add(maxRent);
                    card.Controls.Add(rentBtn);

                    videoFlowPanel.Controls.Add(card);
                }
            }
        }
    }
}
