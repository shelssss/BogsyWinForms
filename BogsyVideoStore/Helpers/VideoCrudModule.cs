using BogsyVideoStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogsyVideoStore.Helpers
{
    public class VideoCrudModule
    {
        public static bool EditVideo(AppDbContext context,Video videoToEdit,string videoTitle,string description,
                                    string category, int inCount, int maxRent, string imagePath)
        {
            var video = context.Video.FirstOrDefault(v => v.Id == videoToEdit.Id);
            if (video != null) 
            {
                video.Title = videoTitle;
                video.Description = description;
                video.Category = category;
                video.InCount = inCount;
                video.MaxRentDays = maxRent;
                video.ImagePath = imagePath;
                context.SaveChanges();
                MessageBox.Show("Video updated!");
                return true;
            }
            MessageBox.Show("Video not found.");
            return false;
        }

        public static bool AddVideo(AppDbContext context, string videoTitle, string description, string category, 
                                    int inCount, int maxRent, string imagePath)
        {
            var video = new Video
            {
                Id = Guid.NewGuid(),
                Title = videoTitle,
                Description = description,
                Category = category,
                InCount = inCount,
                OutCount = 0,
                MaxRentDays = maxRent,
                ImagePath = imagePath
            };
            context.Video.Add(video);

            context.SaveChanges();
            MessageBox.Show("Video added!");
            return true;
        }

        public static bool DeleteVideo(AppDbContext context, Guid videoId)
        {
            var videoToDelete = context.Video.FirstOrDefault(v => v.Id == videoId);

            if (videoToDelete == null)
            {
                MessageBox.Show("Video not found.");
                return false;
            }

            if (videoToDelete.OutCount > 0)
            {
                MessageBox.Show("Cannot delete this video because it is currently rented out.",
                                "Delete Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this Video?",
                                          "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                context.Video.Remove(videoToDelete);
                context.SaveChanges();
                MessageBox.Show("Video deleted!");
                return true;
            }

            return false;
        }
    }
}
