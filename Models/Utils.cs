﻿namespace EasyFortniteStats_ImageApi.Models;

public class ProgressBar
{
    public float Progress { get; set; }
    
    public string Percentage { get; set; }
    public string[] GradientColors { get; set; }
}

public class Drop
{
    public string Locale { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
}