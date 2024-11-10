using System;
using System.Collections.Generic;
using System.Linq;

public class Single : Song
{
    public DateTime ReleaseDate { get; }

    public Single(string title, int duration, string artist, string releaseDate)
        : base(title, duration, artist)
    {
        if (!DateTime.TryParseExact(releaseDate, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out var parsedDate))
            throw new ArgumentException("Invalid date format. Use 'dd/MM/yyyy'.");
        ReleaseDate = parsedDate;
    }

    public override string ToString()
    {
        return base.ToString() + $"\nRelease Date: {ReleaseDate:dd/MM/yyyy}";
    }
}