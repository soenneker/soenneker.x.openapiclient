using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.X.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class XOpenApiClientTests : FixturedUnitTest
{
    public XOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
