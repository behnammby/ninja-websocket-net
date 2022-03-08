namespace Ninja.WebSocketClient.Options
{
    public class Headers : Dictionary<string, string>
    {
        public Headers AddHeader(string key, string value)
        {
            this[key] = value;

            return this;
        }
    }
}
