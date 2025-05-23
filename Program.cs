using System;
using URL_Shortener.Models;
using URL_Shortener.Services;

namespace URL_Shortener
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //Name    : Main(string[] args)
            //Purpose : Main entry point of the program, takes user input for shortening or retrieving URLs.
            //Re-use  : None
            //Input Parameters : string[] args
            // - command line arguments
            //Output Type : None
            //
            var urlService = new UrlService();

            while (true)
            {
                Console.WriteLine("Enter a command (shorten, retrieve, exit):");
                var command = Console.ReadLine();

                if (command == "exit")
                {
                    break;
                }

                switch (command)
                {
                    case "shorten":
                        Console.WriteLine("Enter the original URL:");
                        var originalUrl = Console.ReadLine();
                        var shortUrl = urlService.ShortenUrl(originalUrl);
                        Console.WriteLine($"Shortened URL: {shortUrl}");
                        break;

                    case "retrieve":
                        Console.WriteLine("Enter the short URL:");
                        var shortUrlToRetrieve = Console.ReadLine();
                        var retrievedUrl = urlService.GetOriginalUrl(shortUrlToRetrieve);
                        if (retrievedUrl != null)
                        {
                            Console.WriteLine($"Original URL: {retrievedUrl}");
                        }
                        else
                        {
                            Console.WriteLine("URL not found.");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid command.");
                        break;
                }
            } //end while loop
        } //end Main
    } //end class Program
}
