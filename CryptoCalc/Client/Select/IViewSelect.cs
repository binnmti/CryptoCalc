﻿namespace CryptoCalc.Client.Select;

public interface IViewSelect
{
    public string Id { get; }
    public string Value { get; set; }
    public string Default { get; }
    public string Title { get; }
    public Dictionary<string, string> Items { get; }
}
