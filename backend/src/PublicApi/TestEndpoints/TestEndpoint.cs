using Ardalis.ApiEndpoints;

using Microsoft.AspNetCore.Mvc;

namespace LocalLibrary.PublicApi.TestEndpoints;

public class TestEndpoint : EndpointBaseAsync
    .WithoutRequest
    .WithResult<TestResponse>
{
    [HttpGet("api/[namespace]/")]
    public override Task<TestResponse> HandleAsync(CancellationToken cancellationToken = default)
    {
        var response = new TestResponse { message = "Sup my dudes" };
        return Task.FromResult<TestResponse>(response);
    }
}