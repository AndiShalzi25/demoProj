
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Music
    {
    public string Artist { get; set; }

    public string TopSong { get; set; }

    public string Genre { get; set; }


    public string Title { get; set; }


    public string Description { get; set; }



    

public Music(string artist, string topSong, string genre, string title,string description)
{
    Artist = artist;
    TopSong = topSong;
    Genre = genre;
    Title = title;
    Description = description;

        
}
}