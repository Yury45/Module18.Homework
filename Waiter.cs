namespace YouTubeDownloadApp
{
    internal class Waiter
    {
        private bool isEnded = true;

        internal async Task Wait()
        {
            while (isEnded)
            { 
                MyColoredText.Print(ApplicationStrings.wait);
            }
        }

        internal void StopCount()
        {
            isEnded = false;
        }
    }
}
