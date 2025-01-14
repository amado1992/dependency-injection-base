
namespace dependency_injection
{
    public class PC : IPlayable
    {
        private string _name = string.Empty;

        public PC(string name)
        {
            _name = name;
        }
        public string Play()
        {
            return $"You are playing pc {_name} .";
        }
    }
}
