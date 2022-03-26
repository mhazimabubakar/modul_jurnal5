using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204092
{
    internal class SayaTubeVideo
    {
        private int id { get; set; }
        private string title { get; set; }
        private int playCount { get; set; }

        public int getPlayCount()
        {
            return this.playCount;
        }

        public string getTitle()
        {
            return this.title;
        }

        public SayaTubeVideo(string title)
        {
            //generate kode random 5 digit
            Random random = new Random();
            this.id = random.Next(0, 10000);

            System.Diagnostics.Debug.Assert(title != null && title.Length <= 100, "Title tidak boleh null dan maksimal 100 karakter");
            this.title = title;

            this.playCount = 0;
        }

        public void IncreasePlayCount(int jumlah)
        {
            //prefetch pengkondisian
            //Debug.Assert(this.playCount <= int.MinValue);
            System.Diagnostics.Debug.Assert(jumlah <= 10000000, "Maksimal memasukkan 10.000.000 pemanggilan");

            //exception
            int hasil;
            try
            {
                hasil = checked(this.playCount + jumlah);
                Console.WriteLine("Berhasil menambahkan jumlah angka baru");
                this.playCount += jumlah;
            }
            catch (OverflowException e)
            {
                //Message untuk menampilkan masalah yang terjadi
                Console.WriteLine("Terjadi masalah saat melakukan penambahan jumlah angka: " + e.Message);
                //menerima jumlah angka
                this.playCount++;
            }
        }

        public void PrintVideoDetails()
        {
            //menampilkan output
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Judul: " + title);
            Console.WriteLine("Jumlah: " + playCount);
        }
    }
}
