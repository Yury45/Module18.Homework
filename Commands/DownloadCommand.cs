using YouTubeDownloadApp.Commands.Base;
using YoutubeExplode;
using YoutubeExplode.Converter;


namespace YouTubeDownloadApp.Commands
{
    internal class DownloadCommand : Command
    {
        Receiver receiver;

        public DownloadCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public override async void Run(string url, string localPath)
        {
            try
            {
                receiver.OperationStarted();

                var youtube = new YoutubeClient();
                var video = await youtube.Videos.GetAsync(url); 

                await youtube.Videos.DownloadAsync(url,
                    $"{ApplicationStrings.localPath}/{video.Title}{ApplicationStrings.aviFormat}",
                    builder => builder.SetPreset(ConversionPreset.UltraFast));


            }
            catch (Exception e)
            {
                receiver.OperationEnded();
                Thread.Sleep(1000);

                Console.WriteLine(ApplicationStrings.error + e.Message);
            }
            finally
            {
                receiver.OperationEnded();
                Thread.Sleep(1000);

                Console.WriteLine(ApplicationStrings.loadingEnded);
            }
        }
    }
}
