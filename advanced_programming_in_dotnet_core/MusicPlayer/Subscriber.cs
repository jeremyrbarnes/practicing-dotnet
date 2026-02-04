namespace MusicPlayerApp
{
    public class Subscriber
    {
        protected MusicPlayer _player;

        public Subscriber()
        {
            _player = new MusicPlayer();
            _player.OnSongPlayed += this.PlaySong;
            _player.OnSongPaused += this.PauseSong;
            _player.OnSongSkipped += this.SkipSong;
            _player.OnSongStopped += this.StopSong;
        }

        public void PlaySong()
        {
            
        }

        public void PauseSong()
        {
            
        }

        public void StopSong()
        {
            
        }

        public void SkipSong()
        {
            
        }

    }
}
