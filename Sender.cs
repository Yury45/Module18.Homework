using YouTubeDownloadApp.Commands.Base;

namespace YouTubeDownloadApp
{
    internal class Sender
    {
        Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        public void Run(string url, string localPath)
        { 
            _command.Run(url, localPath );
        }
    }
}
