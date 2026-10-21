using AlertJob.Api.Models;
using System.Text.Json;
namespace AlertJob.Api.Sources.Greenhouse;

public class GreenhouseJobSource : IJobSource
{
    private readonly HttpClient _http;
    public GreenhouseJobSource(HttpClient http)
    {
        _http = http;
    }
    private static readonly JsonSerializerOptions options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower
    };
    public async Task<List<JobInfo>> FetchJobsAsync(string companyToken)
    {
        var url = $"https://boards-api.greenhouse.io/v1/boards/{companyToken}/jobs";
        var reponse = await _http.GetFromJsonAsync<GreenhouseJobResponse>(url, options);
        if (reponse is null)
        {
            return [];
        }
        return [];
    }
}