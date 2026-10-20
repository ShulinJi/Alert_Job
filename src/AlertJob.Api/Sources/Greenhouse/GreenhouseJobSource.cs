using AlertJob.Api.Models;
namespace AlertJob.Api.Sources.Greenhouse;

public class GreenhouseJobSource : IJobSource
{
    private readonly HttpClient _http;
    public GreenhouseJobSource(HttpClient http)
    {
        _http = http;
    }
    public Task<List<JobInfo>> FetchJobsAsync(string companyToken)
    {
        throw new NotImplementedException();
    }
}