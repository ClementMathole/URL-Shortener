using System;
using System.Collections.Generic;

namespace URL_Shortener.Services
{
    public class UrlService
    {
        private readonly Dictionary<string, string> _urlMap = new Dictionary<string, string>();
        private const string Chars =
            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private readonly Random _rnd = new Random();

        public string ShortenUrl(string originalUrl)
        {
            string shortUrl = GenerateShortUrl();
            _urlMap[shortUrl] = originalUrl;
            return shortUrl;
        }

        public string GetOriginalUrl(string shortUrl)
        {
            return _urlMap.TryGetValue(shortUrl, out var originalUrl) ? originalUrl : null;
        }

        private string GenerateShortUrl()
        {
            char[] stringChars = new char[6];
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = Chars[_rnd.Next(Chars.Length)];
            }
            return new string(stringChars);
        }
    }
}
