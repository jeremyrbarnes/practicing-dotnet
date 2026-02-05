namespace MusicPlayerApp
{
    public class MusicPlayer
    {
        public MusicPlayer() {}

        public event EventHandler? SongPlayed;
        public event EventHandler? SongPaused;

        public event EventHandler? SongStopped;

        public event EventHandler? SongSkipped;

        public virtual void OnSongPlayed(EventArgs e)
        {
            SongPlayed?.Invoke(this, e);
        }

        public virtual void OnSongPaused(EventArgs e)
        {
            SongPaused?.Invoke(this, e);
        }

        public virtual void OnSongStopped(EventArgs e)
        {
            SongStopped?.Invoke(this, e);
        }

        public virtual void OnSongSkipped(EventArgs e)
        {
            SongSkipped?.Invoke(this, e);
        }
    }
}
