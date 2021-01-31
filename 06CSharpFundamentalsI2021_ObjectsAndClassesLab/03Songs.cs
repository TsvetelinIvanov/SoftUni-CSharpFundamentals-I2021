using System;
using System.Linq;
using System.Collections.Generic;

namespace _03Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int songsCount = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < songsCount; i++)
            {
                string[] songData = Console.ReadLine().Split('_');
                string typeList = songData[0];
                string name = songData[1];
                string time = songData[2];
                Song song = new Song(typeList, name, time);
                songs.Add(song);
            }

            string songsTypeList = Console.ReadLine();
            if (songsTypeList == "all")
            {
                songs.ForEach(s => Console.WriteLine(s.Name));
            }
            else
            {
                songs.Where(s => s.TypeList == songsTypeList).ToList().ForEach(s => Console.WriteLine(s.Name));
            }            
        }
    }

    class Song
    {
        public Song(string typeList, string name, string time)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;
        }

        public string TypeList { get; }

        public string Name { get; }

        public string Time { get; }
    }
}
