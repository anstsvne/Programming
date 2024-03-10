﻿using System;

class Time
{
    private int _hour;
    private int _minute;
    private int _second;
    public int Hour
    {
        get
        {
            return _hour;
        }
        set
        {
            if ((value < 0) || (value > 12))
                throw new ArgumentException("Hour cannot be empty or <  0  and cannot be >12");
            _hour = value;
        }
    }
    public int Minute
    {
        get
        {
            return _minute;
        }
        set
        {
            if ((value < 0) || (value > 59))
                throw new ArgumentException("Minutes cannot be empty or <  0 and cannot be >59");
            _minute = value;
        }
    }
    public int Second
    {
        get
        {
            return _second;
        }
        set
        {
            if ((value < 0) || (value > 59))
                throw new ArgumentException("Seconds cannot be empty or <  0 and cannot be >59");
            _second = value;
        }
    }
    public Time(int Hour, int Minute, int Second)
    {
        _hour = Hour;
        _minute = Minute;
        _second = Second;
    }
}