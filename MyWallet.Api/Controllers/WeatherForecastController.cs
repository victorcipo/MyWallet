using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyWallet.Infrastructure.Data.MongoDb.Entities;
using MyWallet.Infrastructure.Data.MongoDb.Interfaces;
using System.Collections.Generic;

namespace MyWallet.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILancamentoQuery _lancamentoService;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ILancamentoQuery lancamentoService)
        {
            _logger = logger;
            _lancamentoService = lancamentoService;
        }

        [HttpGet]
        public IEnumerable<Lancamentos> Get()
        {
            return _lancamentoService.Get();
        }
    }
}
