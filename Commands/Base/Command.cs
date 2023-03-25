namespace YouTubeDownloadApp.Commands.Base
{
    internal abstract class Command
    {
        public abstract void Run(string url, string localPath);
    }
}
