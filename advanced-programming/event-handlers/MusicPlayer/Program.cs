using MusicPlayerApp;

MusicPlayer player = new MusicPlayer();
Subscriber subscriber = new Subscriber();

player.SongPlayed += subscriber.PlaySong;
player.SongPaused += subscriber.PauseSong;
player.SongStopped += subscriber.StopSong;
player.SongSkipped += subscriber.SkipSong;

player.OnSongPlayed(EventArgs.Empty);
player.OnSongPaused(EventArgs.Empty);
player.OnSongSkipped(EventArgs.Empty);
player.OnSongStopped(EventArgs.Empty);
