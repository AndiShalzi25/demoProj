
    public class Music
    {
    public string Artist { get; set; }

    public string TopSong { get; set; }

    public string Genre { get; set; }

    public int Age { get; set; }

    public string Nationality { get; set; }

    public string Religion { get; set; }


    public Music(string artist, string topSong, string genre, int age, string nationality, string religion)
    {
        Artist = artist;
        TopSong = topSong;
        Genre = genre;
        Age = age;
        Nationality = nationality;
        Religion = religion;
    }
}