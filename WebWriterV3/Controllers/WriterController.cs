using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebWriterV3.DAL.DbModel;
using WebWriterV3.DAL.IRepository;
using WebWriterV3.DAL.Repostory;

namespace WebWriterV3.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WriterController : ControllerBase
    {
        private IBookRepository BookRepository;
        private IMapper Mapper;

        public WriterController(IBookRepository bookRepository, IMapper mapper)
        {
            BookRepository = bookRepository;
            Mapper = mapper;
        }

        public BookViewModel Load()
        {
            var bookModel = BookRepository.GetAll().FirstOrDefault();
            var viewModel = Mapper.Map<BookViewModel>(bookModel);
            return viewModel;
        }

        [HttpPost]
        public bool Save(BookViewModel bookViewModel)
        {
            var bookModel = Mapper.Map<BookModel>(bookViewModel);
            BookRepository.Save(bookModel);
            return true;
        }
    }
}
