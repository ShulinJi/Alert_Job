namespace AlertJob.Api.Sources.Greenhouse;

public record GreenhouseJobInfo(
    long Id,
    string Title,
    GreenhouseJobLocation Location,
    string CompanyName,
    string AbsoluteUrl,
    string Language,
    DateTimeOffset UpdatedAt,
    DateTimeOffset FirstPublished,
    DateTimeOffset? ApplicationDeadline
);

public record GreenhouseJobLocation(
    string Name
);
public record GreenhouseJobResponse(
    List<GreenhouseJobInfo> Jobs
);