namespace URL_Shortener.Models
{
    public class Url
    {
        public string OriginalUrl { get; set; }
        public string ShortUrl { get; set; }

        public Url(string originalUrl, string shortUrl)
        {
            //
            //Name    : Url(string originalUrl, string shortUrl)
            //Purpose : Constructor to initialize the original and short URL
            //Re-use  : None
            //Input Parameters : string originalUrl
            // - The original URL to be shortened
            //string shortUrl
            // - The shortened URL
            //Output Type : None
            //
            OriginalUrl = originalUrl;
            ShortUrl = shortUrl;
        } //end Url Constractor
    } //end Url Class
}
