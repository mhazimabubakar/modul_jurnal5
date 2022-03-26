using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204092
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        private string Username;

        public SayaTubeUser(string username)
        {
            //generate kode random 5 digit
            Random random = new Random();
            this.id = random.Next(0, 10000);

            this.Username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int banyak = 0;
            foreach (SayaTubeVideo x in this.uploadedVideos)
            {
                banyak += x.getPlayCount();
            }
            return banyak;
        }

        public void AddVideo(SayaTubeVideo x)
        {
            this.uploadedVideos.Add(x);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User: " + this.Username);
            int i = 0;
            foreach(var video in this.uploadedVideos)
            {
                Console.WriteLine("Video " + (i + 1) + " judul: " + video.getTitle());
                i++;
            }

        }
    }
}
