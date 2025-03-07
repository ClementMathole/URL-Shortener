namespace URL_Shortener.Models
{
    public class Url
    {////Name : Url(string originalUrl, string shortUrl)//
        public string OriginalUrl { get; set; }
        public string ShortUrl { get; set; }

        public Url(string originalUrl, string shortUrl)
        {
            OriginalUrl = originalUrl;
            ShortUrl = shortUrl;
        }
    }
}
