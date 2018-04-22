using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions_2
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }

    class Player : IPlayable, IRecordable
    {
        void IPlayable.Play()
        {
            Console.WriteLine("Playing...");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Playing is paused.");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Playing is stopped.");
        }

        void IRecordable.Record()
        {
            Console.WriteLine("Recording...");
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("Recording is paused.");
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("Recording is stopped.");
        }        

    }


    class Abstractions_2
    {
        static void Main(string[] args)
        {

            string playOrRecord;
            string pauseOrStop;
            Player player = new Player();
            
            do
            {
                Console.WriteLine("Do you want to play,record or exit? [p/r/e]");
                playOrRecord = Console.ReadLine();

                if (playOrRecord == "p")
                {
                    do
                    {
                       ((IPlayable)player).Play();

                        pauseOrStop = "";
                        while (pauseOrStop != "p" && pauseOrStop != "s")
                        {
                            Console.WriteLine("Pause/Stop? [p/s]");
                            pauseOrStop = Console.ReadLine();
                        }
                        if (pauseOrStop == "p")
                        {
                            ((IPlayable)player).Pause();

                            pauseOrStop = "";
                            while (pauseOrStop != "p" && pauseOrStop != "s")
                            {
                                Console.WriteLine("Play again or stop? [p/s]");
                                pauseOrStop = Console.ReadLine();
                            }
                        }
                    }
                    while (pauseOrStop == "p");
                    ((IPlayable)player).Stop();
                }

                else if (playOrRecord == "r")
                {
                    do
                    {
                        ((IRecordable)player).Record();

                        pauseOrStop = "";
                        while (pauseOrStop != "p" && pauseOrStop != "s")
                        {
                            Console.WriteLine("Pause/Stop? [p/s]");
                            pauseOrStop = Console.ReadLine();
                        }
                        if (pauseOrStop == "p")
                        {
                            ((IRecordable)player).Pause();

                            pauseOrStop = "";
                            while (pauseOrStop != "p" && pauseOrStop != "s")
                            {
                                Console.WriteLine("Record again or stop? [p/s]");
                                pauseOrStop = Console.ReadLine();
                            }
                        }
                    }
                    while (pauseOrStop == "p");
                    ((IRecordable)player).Stop(); 
                }
            }
            while (playOrRecord!="e");
        }
    }
}
