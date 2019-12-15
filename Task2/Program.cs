using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            player.Play();
            (player as IPlayable).Pause();
            (player as IPlayable).Stop();

            player.Record();
            (player as IRecodable).Pause();

            (player as IRecodable).Stop();


        }
    }
}
