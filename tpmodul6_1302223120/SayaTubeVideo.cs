using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302223120
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            // Membuat angka random dari 9999 sampai 100001 menggunakan kelas random, lalu disimpan ke var. 'id'
            Random acak = new Random();
            id = acak.Next(9999, 100001);

            //  Precondition
            // Memastikan title tidak null & tidak lebih dari 100 karakter.
            Debug.Assert(title.Length <= 100 && title != null);
            this.title = title;

            // state awal playCount bernilai 0
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Contract.Requires(count > 0 && count <= 10000000, "Input penambahan play count (max. 10.000.000)");
            Contract.Ensures(playCount <= int.MaxValue - count, "Penambahan play count melebihi batas maksimal.");

            try
            {
                checked
                {
                    playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Penambahan play count melebihi batas maksimal.");
            }
        }

        // Print detail informasi dari Video
        public void PrintVideoDetails()
        {
            Console.WriteLine($"Video ID: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Play Count: {playCount}");
        }
    }
}

