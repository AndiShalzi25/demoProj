
    public class Music
    {
    public string Artist { get; set; }

    public string TopSong { get; set; }

    public string Genre { get; set; }

    

public Music(string artist, string topSong, string genre)
{
    Artist = artist;
    TopSong = topSong;
    Genre = genre;
}
}