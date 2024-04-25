﻿namespace DesignPatterns.Behavioral.State;

public class UpperCase : IWritingState
{
    public void Write(string words) => Console.WriteLine(words.ToUpper());
}
