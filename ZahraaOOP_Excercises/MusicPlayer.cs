using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZahraaOOP_Excercises
{
    //Exercise 16: Create a MusicPlayer class with methods play(song), pause(), and stop().
    internal class MusicPlayer
    {
        public string CurrentSong { get; protected set; }

        public void Play(string song)
        {
            CurrentSong = song;
            Console.WriteLine($"Playing: {CurrentSong}");
        }

        public void Pause()
        {
            Console.WriteLine($"Paused: {CurrentSong}");
        }

        public void Stop()
        {
            Console.WriteLine($"Stopped: {CurrentSong}");
            CurrentSong = null;
        }
    }
}
