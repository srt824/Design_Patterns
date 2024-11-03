namespace Bridge.Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFormat mp3Format = new MP3();
            MusicPlayer player = new DesktopPlayer(mp3Format);
            player.Play("song.mp3");

            IFormat wavFormat = new WAV();
            player = new DesktopPlayer(wavFormat);
            player.Play("song.wav");

        }
    }
}
