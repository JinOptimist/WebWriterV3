using System.Collections.Generic;

namespace WebWriterV3
{
    public class ChapterViewModel : BaseViewModel
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Action { get; set; }
        public List<string> Topics { get; set; }
    }
}
