using System;
using System.Collections.Generic;
using System.Linq;


public abstract class Song
{
    private string title;
    private int duration;
    private string artist;

    public string Title
    {
        get => title;
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 100)
                throw new ArgumentException("Title should be between 2 and 100 characters!");
            title = value;
        }
    }

    public int Duration
    {
        get => duration;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Duration should be positive!");
            duration = value;
        }
    }

    public string Artist
    {
        get => artist;
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 3 || value.Length > 50)
                throw new ArgumentException("Artist name should be between 3 and 50 characters!");
            artist = value;
        }
    }

    protected Song(string title, int duration, string artist)
    {
        Title = title;
        Duration = duration;
        Artist = artist;
    }

    public override string ToString()
    {
        return $"Title: {Title}\nDuration: {Duration} seconds\nArtist: {Artist}";
    }
}