
namespace dependency_injection
{
    public class Player : IPlayable
    {
        /// <summary>
        /// Old solution 
        /// </summary>
        private Table? table;
        private PC? pc;

        /// <summary>
        /// New solution
        /// </summary>
        IPlayable? _playable;

        /// <summary>
        /// Old solution
        /// </summary>
        /// <param name="name"></param>
        public Player(string name)
        {
            table = new Table(name);
            pc = new PC(name);
        }

        /// <summary>
        /// New solution
        /// </summary>
        /// <param name="playable"></param>
        public Player(IPlayable playable)
        {
            _playable = playable;
        }

        public string Play()
        {
            // Old solution
            /*if (table != null)
                return table.Play();*/

            /*if (pc != null)
                return pc.Play();*/

            // New solution
            if (_playable != null)
                return _playable.Play();

            return "You are not a player";
        }
    }
}
