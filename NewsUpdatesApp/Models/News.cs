using System.Collections.ObjectModel;

namespace WorldNewsDM
{
    public class NewsObject
    {
        public string status { get; set; }
        public string totalResults { get; set; }
        public ObservableCollection<News> articles { get; set; }
    }
   public class News
    {
        string author;
        string title;
        string description;
        string content;
        string url;

        public string Author { get => author; set => author = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public string Content { get => content; set => content = value; }
        public string Url { get => url; set => url = value; }
    }
}
