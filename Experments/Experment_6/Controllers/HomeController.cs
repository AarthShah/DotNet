using System.Diagnostics;
using Experment_6.Data;
using Experment_6.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace Experment_6.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IMemoryCache _memoryCache;
    private readonly AppDbContext _dbContext;

    public HomeController(
        ILogger<HomeController> logger,
        IMemoryCache memoryCache,
        AppDbContext dbContext)
    {
        _logger = logger;
        _memoryCache = memoryCache;
        _dbContext = dbContext;
    }

    public IActionResult Index()
    {
        _logger.LogInformation("Home page opened at {Time}.", DateTime.Now);

        const string cacheKey = "home-page-data";

        if (!_memoryCache.TryGetValue(cacheKey, out HomePageViewModel? model))
        {
            model = new HomePageViewModel
            {
                CachedMessage = "This message is stored in memory for 30 seconds.",
                GeneratedAt = DateTime.Now,
                StudentCount = _dbContext.Students.Count()
            };

            var cacheOptions = new MemoryCacheEntryOptions()
                .SetAbsoluteExpiration(TimeSpan.FromSeconds(30));

            _memoryCache.Set(cacheKey, model, cacheOptions);
            _logger.LogInformation("Fresh home page data was added to cache.");
        }
        else
        {
            _logger.LogInformation("Home page data was served from cache.");
        }

        return View(model);
    }

    public IActionResult About()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
