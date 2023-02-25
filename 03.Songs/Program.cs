using System.Security.Cryptography.X509Certificates;

namespace _03.Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('_');

                string typeList = input[0];
                string songName = input[1];
                string duration = input[2];

                Song song = new Song();
                song.TypeList = typeList;
                song.Name = songName;
                song.Time= duration;

                songs.Add(song);
            }

            string searchForTypeList = Console.ReadLine();

            if (searchForTypeList == "all")
            {
                foreach(var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs)
                {
                    if(song.TypeList == searchForTypeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }

        public class Song
        {
            private string typeList;
            private string name;
            private string time;

            public string TypeList { get => typeList; set => typeList = value; }
            public string Name { get => name; set => name = value; }
            public string Time { get => time; set => time = value; }
        }
    }
}