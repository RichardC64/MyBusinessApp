using System.Diagnostics;
using Microsoft.Playwright;

using var playwright = await Playwright.CreateAsync();
await using var browser = await playwright.Chromium.LaunchAsync();

long total = 0;
for (var index = 0; index < 10; index++)
{
    var sw = Stopwatch.StartNew();
    var page = await browser.NewPageAsync();
    await page.GotoAsync(
        "https://devdevdev.net/tr02-2025-fluent-assertions-github-copilot-les-50-ans-de-ms-peeble-os-et-le-go/");

    var duree = sw.ElapsedMilliseconds;
    total += duree;

    Console.WriteLine($"It{index}= {duree}ms");

    sw.Restart();
}
Console.WriteLine("Moyenne: " + Math.Round(total / 10M, 2) + "ms");

Console.ReadLine();
//await page.ScreenshotAsync(new()
//{
//    Path = "screenshot.png"
//});