namespace Composition
{
    public class Installer
    {
        private readonly Logger _Logger;
        public Installer(Logger logger)
        {
            _Logger = logger;
        }

        public void Install()
        {
            _Logger.Log("Installing");
        }
    }
}
