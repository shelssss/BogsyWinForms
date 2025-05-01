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
        private string currentCustomerName;
        private RentedVideo RentedList;

        public RentVideoForm(string customerName)
        {
            InitializeComponent();
            currentCustomerName = customerName;
            LoadVideos();

        }
       
       
        private void LoadVideos()
        {
            videoFlowPanel.Controls.Clear();



            using (var context = new AppDbContext())
            {
                
                var videos = context.Video.Where(v => v.InCount > 0).ToList();
                
                foreach (var video in videos)
                {
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
                        pictureBox.Image = Image.FromFile(video.ImagePath); // Load the image
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
                        Text = $"Category: {video.Category}",
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

                  
                    int cost = video.Category == "DVD" ? 50 : 25;
                    Label costLabel = new Label
                    {
                        Text = $"Cost: ₱{cost}",
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
                        RentVideo(video, currentCustomerName);
                    };
                    card.Controls.Add(pictureBox);
                    card.Controls.Add(title);
                    card.Controls.Add(category);
                    card.Controls.Add(stock);
                    card.Controls.Add(costLabel);
                    card.Controls.Add(rentBtn);

                    videoFlowPanel.Controls.Add(card);
                }
            }
        }

        private void RentVideo(Video video, string customerName)
        {
            
            int cost = video.Category == "DVD" ? 50 : 25;

            
            var result = MessageBox.Show(
                $"You are about to rent '{video.Title}' ({video.Category}) for ₱{cost}.\n" +
                $"You can only keep the video for {video.MaxRentDays} day/s.\n" +
                "After that, ₱5 will be charged for each extra day.\n\n" +
                "Do you want to continue?",
                "Confirm Rental",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
            );

            if (result == DialogResult.No)
                return;

            using (var context = new AppDbContext())
            {
                var v = context.Video.FirstOrDefault(x => x.Id == video.Id);
                if (v != null)
                {
                    if (v.InCount > 0)
                    {
                        v.InCount -= 1;
                        v.OutCount += 1;

                        var rental = new CustomerRented
                        {
                            Id = Guid.NewGuid(),
                            CustomerName = customerName,
                            VideoRented = v.Title,
                            RentedDate = DateOnly.FromDateTime(DateTime.Today),
                            RentCost = cost,
                            status = "Rented",
                            VideoId = v.Id.ToString(),
                        };

                        context.CustomerRented.Add(rental);
                        context.SaveChanges();

                        MessageBox.Show($"'{v.Title}' rented successfully by {customerName}.");
                        LoadVideos();
                    }
                    else
                    {
                        MessageBox.Show("No copies left to rent.");
                    }
                }
            }
        }
    }
}
