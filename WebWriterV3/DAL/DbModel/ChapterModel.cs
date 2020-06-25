using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebWriterV3.DAL.DbModel
{
    public class ChapterModel : BaseModel
    {
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
