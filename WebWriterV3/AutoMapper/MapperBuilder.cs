using AutoMapper;
using AutoMapper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebWriterV3.DAL.DbModel;

namespace WebWriterV3.AutoMapper
{
    public class MapperBuilder
    {
        public static IMapper GetMapper()
        {
            var configExpression = new MapperConfigurationExpression();
            configExpression.CreateMap<BookModel, BookViewModel>();
            configExpression.CreateMap<ChapterModel, ChapterViewModel>();
            
            configExpression.CreateMap<BookViewModel, BookModel>();
            configExpression.CreateMap<ChapterViewModel, ChapterModel>();

            var mapperConfiguration = new MapperConfiguration(configExpression);
            return new Mapper(mapperConfiguration);
        }
    }
}
