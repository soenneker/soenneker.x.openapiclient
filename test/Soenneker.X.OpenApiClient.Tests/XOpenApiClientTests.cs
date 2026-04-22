using Soenneker.Tests.HostedUnit;

namespace Soenneker.X.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class XOpenApiClientTests : HostedUnitTest
{
    public XOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
