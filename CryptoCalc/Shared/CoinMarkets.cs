﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CryptoCalc.Shared;

public record CoinMarkets
{
    public CoinMarkets() { }

    [SetsRequiredMembers]
    public CoinMarkets(string id, string symbol, string name, string image, float currentPrice)
    {
        Id = id;
        Symbol = symbol;
        Name = name;
        Image = image;
        CurrentPrice = currentPrice;
    }
    [Key]
    [MaxLength(100)]
    public required string Id { get; set; }
    [MaxLength(100)]
    public required string Symbol { get; set; }
    [MaxLength(100)]
    public required string Name { get; set; }
    public required string Image { get; set; }
    public float CurrentPrice { get; set; }
    public float MarketCap { get; set; }
    public int MarketCapRank { get; set; }
    public float FullyDilutedValuation { get; set; }
    public float TotalVolume { get; set; }
    public float High24h { get; set; }
    public float Low24h { get; set; }
    public float PriceChange24h { get; set; }
    public float PriceChangePercentage24h { get; set; }
    public float MarketCapChange24h { get; set; }
    public float MarketCapChangePercentage24h { get; set; }
    public float CirculatingSupply { get; set; }
    public float TotalSupply { get; set; }
    public float MaxSupply { get; set; }
    public float Ath { get; set; }
    public float AthChangePercentage { get; set; }
    public DateTime AthDate { get; set; }
    public float Atl { get; set; }
    public float AtlChangePercentage { get; set; }
    public DateTime AtlDate { get; set; }
    public DateTime LastUpdated { get; set; }
}
