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
    public class WriterController : ControllerBase
    {
        public BookViewModel Load()
        {
            return new BookViewModel()
            {
                Name = "Smile 123",
                AuthorName = "Pol"
            };
        }


        [HttpPost]
        public bool Save(BookViewModel bookModel)
        {
            var a = bookModel.Name;
            return true;
        }
    }
}
