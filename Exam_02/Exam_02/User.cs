using System;
using System.Collections.Generic;
using System.Linq;


public class User
{
    private string username;
    private int age;

    public string Username
    {
        get => username;
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 3 || value.Length > 30)
                throw new ArgumentException("Username should be between 3 and 30 characters!");
            username = value;
        }
    }

    public int Age
    {
        get => age;
        set
        {
            if (value < 13)
                throw new ArgumentException("User must be at least 13 years old!");
            age = value;
        }
    }

    public List<Playlist> Playlists { get; }

    public User(string username, int age)
    {
        Username = username;
        Age = age;
        Playlists = new List<Playlist>();
    }

    public void AddPlaylist(Playlist playlist)
    {
        Playlists.Add(playlist);
    }

    public override string ToString()
    {
        return $"Username: {Username}\nAge: {Age}\nTotal Playlists: {Playlists.Count}";
    }
}