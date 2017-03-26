namespace FacadeDesignPatternDemo
{
    public class MusicPlayerFacade : IMusicPlayerFacade
    {
        public void Play(string fileName)
        {
            var fileLoader = new FileLoader();
            var decoder = new Decoder();
            var player = new Player();

            fileLoader.LoadFile(fileName);
            decoder.DecodeFile();
            player.Init();
        }
    }
}
