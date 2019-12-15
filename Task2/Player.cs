using System;

namespace Task2
{
    class Player : IPlayable, IRecodable
    {

        public bool IsRecording { get; set; }
        public void Play()
        {
            IsRecording = false;
            Console.WriteLine("Play");
        }

        public void Record()
        {
            IsRecording = true;
            Console.WriteLine("Recording");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Pause audio");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Stop audio");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Pause recording");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Stop recording");
        }
    }
}
