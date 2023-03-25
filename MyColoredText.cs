namespace YouTubeDownloadApp;

public static class MyColoredText
{
    private static  Random random = new Random();
    private static  readonly Dictionary<int, ConsoleColor> colors = new Dictionary<int, ConsoleColor>()
    {
        {0, ConsoleColor.Red},
        {1, ConsoleColor.Yellow},
        {2, ConsoleColor.Green},
        {3, ConsoleColor.Blue},
        {4, ConsoleColor.DarkBlue},
        {5, ConsoleColor.DarkMagenta},
        {6, ConsoleColor.Cyan},
        {7, ConsoleColor.DarkCyan},
        {8, ConsoleColor.White},
    };

    public static async Task Print(string text)
    {
        var temp = Console.ForegroundColor;
        foreach (var symbol in text)
        {
            Console.ForegroundColor = colors[random.Next(0, 8)];
            Console.Write(symbol);
            Thread.Sleep(100);
        }

        Console.CursorLeft = 0;
        Console.ForegroundColor = temp;
    }
}