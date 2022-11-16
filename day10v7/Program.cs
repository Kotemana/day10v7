var json = await GetNewsJson();
Console.WriteLine(json);


static async Task<string> GetNewsJson()
{
    var apikey = "1af83452c10b4aec85b15f2a92a003ed";
    var query = "tesla";
    var url = $"https://newsapi.org/v2/everything?q={query}&from=2022-10-16&sortBy=publishedAt&apiKey={apikey}";
    using var client = new HttpClient();
    var result = await client.GetAsync(url);
    return await result.Content.ReadAsStringAsync();
}


