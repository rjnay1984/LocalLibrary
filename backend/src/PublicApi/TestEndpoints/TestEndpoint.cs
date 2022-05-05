using MinimalApi.Endpoint;

namespace LocalLibrary.PublicApi.TestEndpoints;

public class TestResponse
{
    public string message { get; set; }
}

public class TestEndpoint : IEndpoint<IResult>
{
    public void AddRoute(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/test", () => HandleAsync())
          .Produces<TestResponse>(StatusCodes.Status200OK);
    }

    public Task<IResult> HandleAsync()
    {
        var result = Results.Json(new TestResponse { message = "Sup my dudes"});
        return Task.FromResult(result);
    }
}