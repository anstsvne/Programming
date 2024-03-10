﻿using System;

class Song
{
    private string _songName;
    private string _artistName;
    private string _labelName;
    private int _durationSeconds;
    public string SongName
    {
        get
        {
            return _songName;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name of song cannot be empty or null");
            _songName = value;
        }
    }
    public string ArtistName
    {
        get
        {
            return _artistName;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Artist name cannot be empty or null");
            _artistName = value;
        }
    }
    public string LabelName
    {
        get
        {
            return _labelName;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Label name cannot be empty or null");
            _labelName = value;
        }
    }
    public int DurationSeconds
    {
        get
        {
            return _durationSeconds;
        }
        set
        {
            if ((value == null) || (value < 0))
                throw new ArgumentException("Duration cannot be empty or <  0");
            _durationSeconds = value;
        }
    }
    public Song(string SongName, string ArtistName, string LabelName, int DurationSeconds)
    {
        _songName = SongName;
        _artistName = ArtistName;
        _labelName = LabelName;
        _durationSeconds = DurationSeconds;
    }
}