using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebWriterV3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReaderController : ControllerBase
    {
        private readonly ILogger<ReaderController> _logger;

        public ReaderController(ILogger<ReaderController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("All")]
        public IEnumerable<ChapterModel> GetAll ()
        {
            var models = new List<ChapterModel>();

            models.Add(new ChapterModel()
            {
                Title = "Глава 1. Спор",
                Body = "– Вот скажи, ты же, как программист.",
                Action = "Boom",
                Topics = new List<string>() { "One2", "Test2", "qwe2" }
            });

            models.Add(new ChapterModel()
            {
                Title = "Глава 2. Последнее желание",
                Body = "Резкая вонь ударила в нос, но глаза открывать всё равно не хотелось.",
                Action = "Run",
                Topics = new List<string>() { "One", "Test", "qwe" }
            });

            return models;
        }
    }
}
