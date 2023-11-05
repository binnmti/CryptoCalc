using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CryptoCalc.Server.Data;
using CryptoCalc.Shared;

namespace CryptoCalc.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class CoinsController : ControllerBase
{
    private readonly CryptoCalcServerContext _context;

    public CoinsController(CryptoCalcServerContext context)
    {
        _context = context;
    }

    [Route("/coinMarkets")]
    public IEnumerable<CoinMarketView> CoinMarkets(int page, int count)
    {
        var skip = (Math.Max(page, 1) - 1) * count;
        var take = count == -1 ? int.MaxValue : count;
        return _context.CoinMarketView.OrderBy(x => x.MarketCapRank).Skip(skip).Take(take);
    }

    [Route("/coinMarketsCount")]
    public async Task<int> CoinMarketsCount()
        => await _context.CoinMarkets.Where(x => x.MarketCapRank != 0).CountAsync();
}
