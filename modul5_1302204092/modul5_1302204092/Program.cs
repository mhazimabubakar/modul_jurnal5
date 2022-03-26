using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204092
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeUser objUser = new SayaTubeUser("mhazimabubakar");

            SayaTubeVideo objVideo1 = new SayaTubeVideo("Review Film Jojo Rabbit oleh mhazimabubakar");
            SayaTubeVideo objVideo2 = new SayaTubeVideo("Review Film The Shawshank Redemption oleh mhazimabubakar");
            SayaTubeVideo objVideo3 = new SayaTubeVideo("Review Film The Green Mile oleh mhazimabubakar");
            SayaTubeVideo objVideo4 = new SayaTubeVideo("Review Film Star Wars oleh mhazimabubakar");
            SayaTubeVideo objVideo5 = new SayaTubeVideo("Review Film Harry Potter oleh mhazimabubakar");
            SayaTubeVideo objVideo6 = new SayaTubeVideo("Review Film Begin Again oleh mhazimabubakar");
            SayaTubeVideo objVideo7 = new SayaTubeVideo("Review Film The Conjuring oleh mhazimabubakar");
            SayaTubeVideo objVideo8 = new SayaTubeVideo("Review Film The Batman oleh mhazimabubakar");
            SayaTubeVideo objVideo9 = new SayaTubeVideo("Review Film The Hobbit oleh mhazimabubakar");
            SayaTubeVideo objVideo10 = new SayaTubeVideo("Review Film Judas And The Black Messiah oleh mhazimabubakar");
            

            objUser.AddVideo(objVideo1);
            objUser.AddVideo(objVideo2);
            objUser.AddVideo(objVideo3);
            objUser.AddVideo(objVideo4);
            objUser.AddVideo(objVideo5);
            objUser.AddVideo(objVideo6);
            objUser.AddVideo(objVideo7);
            objUser.AddVideo(objVideo8);
            objUser.AddVideo(objVideo9);
            objUser.AddVideo(objVideo10);

            objUser.PrintAllVideoPlayCount();
        }
    }
}
