namespace SmartBlocks.Worlds
{
    public class WorldLoadException : Exception
    {
        public WorldLoadException() : base()
        {

        }

        public WorldLoadException(string message) : base(message)
        {

        }

        public WorldLoadException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
