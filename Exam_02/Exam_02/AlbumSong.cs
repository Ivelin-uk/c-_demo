using System;
using System.Collections.Generic;
using System.Linq;

public class AlbumSong : Song
{
    private string albumName;

    public string AlbumName
    {
        get => albumName;
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 3 || value.Length > 100)
                throw new ArgumentException("Album name should be between 3 and 100 characters!");
            albumName = value;
        }
    }

    public AlbumSong(string title, int duration, string artist, string albumName)
        : base(title, duration, artist)
    {
        AlbumName = albumName;
    }

    public override string ToString()
    {
        return base.ToString() + $"\nAlbum: {AlbumName}";
    }
}