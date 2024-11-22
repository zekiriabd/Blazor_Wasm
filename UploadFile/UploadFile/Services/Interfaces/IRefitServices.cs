using Refit;
public interface IRefitServices
{
    [Multipart]
    [Post("/WeatherForecast/UploadFile")]
    Task UploadFile([AliasAs("File")] StreamPart file);
}
