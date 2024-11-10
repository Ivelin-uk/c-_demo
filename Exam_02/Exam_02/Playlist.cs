using System.Collections.Generic;
using System.Linq;
using System;

public class Playlist
{
    private string title;

    public string Title
    {
        get => title;
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 3 || value.Length > 50)
                throw new ArgumentException("Playlist title should be between 3 and 50 characters!");
            title = value;
        }
    }

    public List<Song> Songs { get; }

    public Playlist(string title)
    {
        Title = title;
        Songs = new List<Song>();
    }

    public void AddSong(Song song)
    {
        Songs.Add(song);
    }

    public double TotalDuration()
    {
        return Songs.Sum(s => s.Duration);
    }

    public List<Song> GetSongsByArtist(string artist)
    {
        return Songs.Where(s => s.Artist == artist).OrderBy(s => s.Title).ToList();
    }

    public List<Song> GetSongsByGenre(string genre)
    {
        return Songs.Where(s => s is AlbumSong albumSong && albumSong.AlbumName == genre).OrderBy(s => s.Title).ToList();
    }

    public List<Song> GetSongsAboveDuration(int duration)
    {
        return Songs.Where(s => s.Duration >= duration).OrderByDescending(s => s.Duration).ToList();
    }

    public override string ToString()
    {
        return $"Playlist: {Title}\nTotal Songs: {Songs.Count}";
    }
}