using System;
using System.Collections.Generic;
using System.Linq;

public class Controller
{
    private readonly Dictionary<string, User> users;

    public Controller()
    {
        users = new Dictionary<string, User>();
    }

    public string AddUser(List<string> args)
    {
        var username = args[0];
        var age = int.Parse(args[1]);

        var user = new User(username, age);
        users.Add(username, user);

        return $"Created User {username}!";
    }

    public string AddPlaylist(List<string> args)
    {
        var username = args[0];
        var playlistTitle = args[1];

        if (!users.ContainsKey(username))
            return "User does not exist!";

        var user = users[username];
        var playlist = new Playlist(playlistTitle);

        user.AddPlaylist(playlist);

        return $"Created Playlist {playlistTitle} for User {username}!";
    }

    public string AddSongToPlaylist(List<string> args)
    {
        var username = args[0];
        var playlistTitle = args[1];
        var songTitle = args[2];
        var duration = int.Parse(args[3]);
        var artist = args[4];
        var genre = args[5];
        var type = args[6].ToLower();
        Song song;

        if (type == "single")
        {
            var releaseDate = args[7];
            if (!DateTime.TryParseExact(releaseDate, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out var parsedDate))
            {
                throw new ArgumentException("Invalid date format. Use 'dd/MM/yyyy'.");
            }

            song = new Single(songTitle, duration, artist, releaseDate);
        }
        else if (type == "albumsong")
        {
            var albumName = args[7];
            song = new AlbumSong(songTitle, duration, artist, albumName);
        }
        else
        {
            throw new ArgumentException("Invalid song type!");
        }

        if (!users.ContainsKey(username))
            return "User does not exist!";

        var user = users[username];
        var playlist = user.Playlists.FirstOrDefault(p => p.Title == playlistTitle);

        if (playlist == null)
            return "Playlist does not exist!";

        playlist.AddSong(song);

        return $"Added song {songTitle} to Playlist {playlistTitle}!";
    }

    public string GetTotalDurationOfPlaylist(List<string> args)
    {
        var username = args[0];
        var playlistTitle = args[1];

        if (!users.ContainsKey(username))
            return "User does not exist!";

        var user = users[username];
        var playlist = user.Playlists.FirstOrDefault(p => p.Title == playlistTitle);

        if (playlist == null)
            return "Playlist does not exist!";

        var totalDuration = playlist.TotalDuration();

        return $"Total duration of {playlistTitle}: {totalDuration} seconds";
    }

    public string GetSongsByArtistFromPlaylist(List<string> args)
    {
        var username = args[0];
        var playlistTitle = args[1];
        var artist = args[2];

        if (!users.ContainsKey(username))
            return "User does not exist!";

        var user = users[username];
        var playlist = user.Playlists.FirstOrDefault(p => p.Title == playlistTitle);

        if (playlist == null)
            return "Playlist does not exist!";

        var songs = playlist.GetSongsByArtist(artist);

        if (!songs.Any())
            return $"No songs found for artist {artist}.";

        return string.Join(Environment.NewLine, songs);
    }

    public string GetSongsByGenreFromPlaylist(List<string> args)
    {
        var username = args[0];
        var playlistTitle = args[1];
        var genre = args[2];

        if (!users.ContainsKey(username))
            return "User does not exist!";

        var user = users[username];
        var playlist = user.Playlists.FirstOrDefault(p => p.Title == playlistTitle);

        if (playlist == null)
            return "Playlist does not exist!";

        var songs = playlist.GetSongsByGenre(genre);

        if (!songs.Any())
            return $"No songs found for genre {genre}.";

        return string.Join(Environment.NewLine, songs);
    }

    public string GetSongsAboveDurationFromPlaylist(List<string> args)
    {
        var username = args[0];
        var playlistTitle = args[1];
        var duration = int.Parse(args[2]);

        if (!users.ContainsKey(username))
            return "User does not exist!";

        var user = users[username];
        var playlist = user.Playlists.FirstOrDefault(p => p.Title == playlistTitle);

        if (playlist == null)
            return "Playlist does not exist!";

        var songs = playlist.GetSongsAboveDuration(duration);

        if (!songs.Any())
            return $"No songs found with duration above {duration} seconds.";

        return string.Join(Environment.NewLine, songs);
    }
}
