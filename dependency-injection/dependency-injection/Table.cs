
namespace dependency_injection
{
    public class Table : IPlayable
    {
        private string _name = string.Empty;

        public Table(string name)
        {
            _name = name;
        }
        public string Play()
        {
            return $"You are playing console {_name} .";
        }
    }
}
