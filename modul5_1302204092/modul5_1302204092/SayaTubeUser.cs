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

            System.Diagnostics.Debug.Assert(username != null && username.Length <= 100, "Username tidak boleh null dan maksimal 100 karakter");
            this.Username = username;

            System.Diagnostics.Debug.Assert(uploadedVideos != null && uploadedVideos <= int.MaxValue, "Video tidak boleh null dan playCount kurang dari integer maksimum");
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
