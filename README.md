# URL Shortener
## Overview
A simple console based application written in C# that allows users to shorten URLs and retrieve the original URLs using a randomly generated short code.
## Features
- Shorten a given URL into a randomly generated short URL.
- Retrieve the original URL from the shortened version.
- Command-line interface for user interaction.
## Technologies Used
- C#
- .NET Core
## Installation
1. Clone the Repository
   ```bash
   git clone https://github.com/ClementMathole/URL-Shortener.git
   cd url_shortener
2. Open the Project in Visual Studio or VS Code
3. Run the Application
   ```bash
   dotnet run
## Usage Example
  ```csharp
  Enter a command (shorten, retrieve, exit): shorten
  Enter the original URL: https://example.com
  Shortened URL: abc123

  Enter a command (shorten, retrieve, exit): retrieve
  Enter the short URL: abc123
  Original URL: https://example.com
  ```
## Future Enhancements
- Persistent database for storing URLs.
- Web-based interface using ASP.NET Core.
- Algorithm for generating unique short URLs.
## License
This project is open-source and available under the **MIT License**.
