using System;

namespace FacadeDesignPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var musicPlayerFacade = new MusicPlayerFacade();
            musicPlayerFacade.Play("Song.mp3");
            Console.ReadKey();
        }
    }
}
