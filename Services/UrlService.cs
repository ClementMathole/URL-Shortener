using System;
using System.Collections.Generic;

namespace URL_Shortener.Services
{
    public class UrlService
    {
        private readonly Dictionary<string, string> _urlMap = new Dictionary<string, string>();
        private const string Chars =
            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private readonly Random _rnd = new Random(); // Random number generator

        public string ShortenUrl(string originalUrl)
        {
            //
            //Name    : ShortenUrl(string originalUrl)
            //Purpose : Shortens the given original URL and stores it in the map
            //Re-use  : GenerateShortUrl()
            //Input Parameters : string originalUrl
            // - The original URL to be shortened
            //Output Type : string
            // - The shortened URL
            //
            string shortUrl = GenerateShortUrl();
            _urlMap[shortUrl] = originalUrl;
            return shortUrl;
        } //end ShortenUrl

        public string GetOriginalUrl(string shortUrl)
        {
            //
            //Name    : GetOriginalUrl(string shortUrl)
            //Purpose : Retrieves the original URL for the given short URL
            //Re-use  : None
            //Input Parameters : string shortUrl
            // - The short URL to retrieve the original URL
            //Output Type : string
            // - The original URL if found, otherwise null
            //
            return _urlMap.TryGetValue(shortUrl, out var originalUrl) ? originalUrl : null;
        } //end GetOriginalUrl

        private string GenerateShortUrl()
        {
            //
            //Name : GenerateShortUrl()
            //Purpose : Generates a random short URL consisting of 6 characters
            //Re-use : None
            //Input Parameters : None
            //Output Type : string
            // - The generated short URL
            //
            char[] stringChars = new char[6];
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = Chars[_rnd.Next(Chars.Length)];
            }
            return new string(stringChars);
        } //end GenerateShortUrl
    } //end class UrlService
}
