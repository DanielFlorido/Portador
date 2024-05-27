namespace Portador.Model
{
    public class GeoCodeRequest
    {
        public string key = "pBwkcDkK1PnFrImeL6jMDJR0UksS1xedkET3AavuoxDq6a6iBvZg7sQgOb6WfVpW";
        public string Address { get; set; }
        public string region = "co";

        public GeoCodeRequest(string addess)
        {
            Address = addess;
        }
        public Dictionary<string, string> ToDictionary()
        {
            var paramsDict = new Dictionary<string, string>
            {
                {"key", key },
                {"address", Address},
                {"region",region}
            };
            return paramsDict;
        }
    }
}
