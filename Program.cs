using YouTubeDownloadApp.Commands;

namespace YouTubeDownloadApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var sender = new Sender();
            var receiver = new Receiver();
            Waiter waiter = new Waiter();

            var downloadCommand = new DownloadCommand(receiver);

            receiver.onLoaded += waiter.StopCount;
            sender.SetCommand(downloadCommand);

            Console.WriteLine(ApplicationStrings.urlRequest);
            ApplicationStrings.url = Console.ReadLine();

            Console.WriteLine(ApplicationStrings.localPathRequest);
            ApplicationStrings.localPath = Console.ReadLine();

            sender.Run(ApplicationStrings.url, ApplicationStrings.localPath);
            
            //На время загрузки блокируем поток
            await waiter.Wait();
            
            Console.ReadKey();
        }
    }
}