// See https://aka.ms/new-console-template for more information
using PuppeteerSharp;

Console.WriteLine("Hello, World!");
using var browserFetcher = new BrowserFetcher();
await browserFetcher.DownloadAsync();
await using var browser = await Puppeteer.LaunchAsync(
    new LaunchOptions { Headless = true });
await using var page = await browser.NewPageAsync();
await page.GoToAsync("http://www.google.com");
await page.ScreenshotAsync("./google.png");
