using Microsoft.EntityFrameworkCore;
using CryptoCalc.Shared;

namespace CryptoCalc.Server.Data;

public class CryptoCalcServerContext : DbContext
{
    public CryptoCalcServerContext (DbContextOptions<CryptoCalcServerContext> options)
        : base(options)
    {
    }

    public DbSet<Coin> Coin { get; set; } = default!;
    public DbSet<CoinMarkets> CoinMarkets { get; set; } = default!;
    public DbSet<CoinMarketView> CoinMarketView { get; set; } = default!;
    public DbSet<Price> Price { get; set; } = default!;
}
