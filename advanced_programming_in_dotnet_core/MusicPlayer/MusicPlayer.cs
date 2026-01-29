namespace MusicPlayerApp;

public class MusicPlayer
{
    public MusicPlayer();

    public event EventHandler SongPlayed;
    public event EventHandler SongPaused;

    public event EventHandler SongStopped;

    public event EventHandler SongSkipped;
}