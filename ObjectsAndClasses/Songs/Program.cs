namespace Songs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var songNumber = int.Parse(Console.ReadLine());
            var songs = new List<Song>();
            for (int i = 0; i < songNumber; i++)
            {
                var curSongArgs = Console.ReadLine().Split('_', StringSplitOptions.RemoveEmptyEntries);
                var typeList = curSongArgs[0];
                var songName = curSongArgs[1];
                var songDuraion = curSongArgs[2];
                var curSong = new Song(typeList, songName, songDuraion);
                songs.Add(curSong);
            }

            var outputCommand = Console.ReadLine();
            if (outputCommand.ToLower() == "all")
            {
                Console.WriteLine(String.Join(Environment.NewLine, songs));
            }
            else
            {
                var filteredSongs = songs.Where(x => x.TypeList.ToLower() == outputCommand.ToLower()).ToList();
                Console.WriteLine(String.Join(Environment.NewLine, filteredSongs));
            }
        }
    }
}
