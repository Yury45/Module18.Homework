using static YouTubeDownloadApp.Commands.DownloadCommand;

namespace YouTubeDownloadApp
{
    internal class Receiver
    {
        internal delegate void Stopping();

        public event Stopping onLoaded;
        public void OperationStarted()
        {
            Console.WriteLine(ApplicationStrings.loadingStarted);
        }

        public void OperationEnded()
        {
            onLoaded();
        }
    }
}
