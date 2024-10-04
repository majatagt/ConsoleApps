using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Album
{
    public string albumName { get; set; }
    public string artistName { get; set; }
    public int numOfTracks { get; set; }


    public void ReadAlbumName()
    {
        do
        {
            Console.WriteLine("Please enter the album name: ");
            this.albumName = Console.ReadLine();

        } while (string.IsNullOrEmpty(this.albumName));


        do
        {
            Console.WriteLine("Please enter the artist name: ");
            this.artistName = Console.ReadLine();

        }
        while (string.IsNullOrEmpty(this.artistName));


        int trackNumber;
        string? tracks;
        do
        {
            Console.WriteLine("How many tracks is on the track? ");
            tracks = Console.ReadLine();

        }
        while (!int.TryParse(tracks, out trackNumber));
        this.numOfTracks = trackNumber;
    }

    public void DisplayAlbumInfo()
    {
        Console.WriteLine($"Album: {albumName}");
    }

    public void DisplayArtistName()
    {
        Console.WriteLine($"Artist name: {artistName} ");
    }

    public void ReadTracks()
    {
        Console.WriteLine($"Num of tracks: {numOfTracks} ");
    }

}










