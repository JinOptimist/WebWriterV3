using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebWriterV3.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ReaderController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<ChapterViewModel> GetAll()
        {
            var models = new List<ChapterViewModel>();

            models.Add(new ChapterViewModel()
            {
                Title = "Глава 1. Спор",
                Body = "– Вот скажи, ты же, как программист.",
                Action = "Boom",
                Topics = new List<string>() { "One2", "Test2", "qwe2" }
            });

            models.Add(new ChapterViewModel()
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
