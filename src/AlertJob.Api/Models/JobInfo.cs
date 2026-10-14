namespace AlertJob.Api.Models;
public record JobInfo(
    string Id,
    string Title,
    string? Description,
    string Location,
    string CompanyName,
    string PostUrl,
    DateTimeOffset PostDate,
    DateTimeOffset? EndDate,
    string Source
);