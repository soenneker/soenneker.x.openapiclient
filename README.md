[![](https://img.shields.io/nuget/v/soenneker.x.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.x.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.x.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.x.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.x.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.x.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.x.openapiclient/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.x.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.X.OpenApiClient

A Kiota-generated .NET client for the X API, including strongly typed request builders and response models.

## Installation

```shell
dotnet add package Soenneker.X.OpenApiClient
```

## Usage

The generated client requires a Kiota request adapter. This example uses an app bearer token to search for users:

```csharp
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.X.OpenApiClient;
using System.Net.Http.Headers;

using var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", bearerToken);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient);

var client = new XOpenApiClient(adapter);

var response = await client.Two.Users.Search.GetAsync(request =>
{
    request.QueryParameters.Query = "dotnet";
    request.QueryParameters.MaxResults = 25;
}, cancellationToken);

foreach (var user in response?.Data ?? [])
    Console.WriteLine($"{user.Name} (@{user.Username})");
```

X endpoints accept different authentication contexts. Use an app bearer token only for endpoints that support app-only authentication; user-context operations require the appropriate OAuth access token.

The generated surface follows the API path hierarchy. For example, `/2/users/search` is exposed as `client.Two.Users.Search`.
