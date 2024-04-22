namespace Indexers
{
    public class HttpCooKie
    {
        private readonly Dictionary<string, string> _dictionary;
        //or private Dictionary<string, string> _dictionary = new Dictionary<string, string>();

        public HttpCooKie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        //Declaring an indexer
        public string this[string key]
        {
            get
            {
                return _dictionary[key];
            }
            set { _dictionary[key] = value; }
        }

    }
}
