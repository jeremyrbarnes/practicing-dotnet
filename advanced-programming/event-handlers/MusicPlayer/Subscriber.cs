namespace MusicPlayerApp
{
    public class Subscriber
    {
        public Subscriber() {}
    
        public void PlaySong(object? sender, EventArgs e)
        {
            System.Console.WriteLine("Playing song");
        }

        public void PauseSong(object? sender, EventArgs e)
        {
            System.Console.WriteLine("Pausing song");
        }

        public void StopSong(object? sender, EventArgs e)
        {
            System.Console.WriteLine("Stopping song");
        }

        public void SkipSong(object? sender, EventArgs e)
        {
            System.Console.WriteLine("Skipping song");
        }

    }
}
