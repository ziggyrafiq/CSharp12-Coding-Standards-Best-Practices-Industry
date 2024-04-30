namespace ZiggyRafiq.CodeExample04.AsyncAwaitPattern;

public class Example
{
    public async Task<string> GetDataAsync()
    {
        HttpClient client = new HttpClient();
        return await client.GetStringAsync("https://api.ziggyrafiq.com/data");//please note this is a dead link only used for code example
    }

}
