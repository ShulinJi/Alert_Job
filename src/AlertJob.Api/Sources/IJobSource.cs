using AlertJob.Api.Models;
namespace AlertJob.Api.Sources;

public interface IJobSource
{
    Task<List<JobInfo>> FetchJobsAsync(string companyToken);
}