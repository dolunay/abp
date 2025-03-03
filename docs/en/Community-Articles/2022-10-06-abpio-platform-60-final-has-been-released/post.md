[ABP Framework](https://abp.io/) and [ABP Commercial](https://commercial.abp.io/) 6.0 versions have been released today.

## What's new with ABP 6.0?

All the new features are explained in detail in the [6.0 RC Announcement Post](https://blog.abp.io/abp/ABP.IO-Platform-6.0-RC-Has-Been-Published). See the [RC Blog Post](https://blog.abp.io/abp/ABP.IO-Platform-6.0-RC-Has-Been-Published) for all the features and enhancements. This is the stable version of 6.0. You can safely upgrade your existing solution or create a new production-level solution.

## Getting started with 6.0

### Creating new solutions

You can create a new solution with the ABP Framework version 6.0 by either using the `abp new` command or using the **direct download** tab on the [get started page](https://abp.io/get-started).

> See the [getting started document](https://docs.abp.io/en/abp/latest/Getting-Started) for more.

### How to upgrade an existing solution

#### Install/Update the ABP CLI

Firstly, install the ABP CLI or upgrade to the latest version.

If you haven't installed it yet:

```bash
dotnet tool install -g Volo.Abp.Cli
```

To update an existing installation:

```bash
dotnet tool update -g Volo.Abp.Cli
```

#### Upgrading existing solutions with the ABP Update command

[ABP CLI](https://docs.abp.io/en/abp/latest/CLI) provides a handy command to update all the ABP-related NuGet and NPM packages in your solution with a single command:

```bash
abp update
```

Run this command in the root folder of your solution.

## Migration guides

Check the following migration guides for the applications with version 5.3 that are upgrading to version 6.0:

* [ABP Framework 5.3 to 6.0 Migration Guide](https://docs.abp.io/en/abp/6.0/Migration-Guides/Abp-6_0)
* [ABP Commercial 5.3 to 6.0 Migration Guide](https://docs.abp.io/en/commercial/6.0/migration-guides/v6_0)

## Community news

### New ABP community posts

Here are some of the recent posts added to the [ABP Community](https://community.abp.io/):

* [Halil Ibrahim Kalkan](https://twitter.com/hibrahimkalkan) has created two new community articles:
    * [Consuming gRPC Services from Blazor WebAssembly Application Using gRPC-Web](https://community.abp.io/posts/consuming-grpc-services-from-blazor-webassembly-application-using-grpcweb-dqjry3rv)
    * [Using gRPC with the ABP Framework](https://community.abp.io/posts/using-grpc-with-the-abp-framework-2dgaxzw3)
* [Malik Masis](https://twitter.com/malikmasis) also has created two new community articles:
    * [Consuming HTTP APIs from a .NET Client Using ABP's Client Proxy System](https://community.abp.io/posts/consuming-http-apis-from-a-.net-client-using-abps-client-proxy-system-xriqarrm)
    * [Using MassTransit via eShopOnAbp](https://community.abp.io/posts/using-masstransit-via-eshoponabp-8amok6h8)
* [Xeevis](https://community.abp.io/members/Xeevis) has created her/his first community article, that shows [Prerendering in Blazor WASM applications](https://community.abp.io/posts/prerendering-blazor-wasm-application-with-abp-6.x-2v8590g3).
* [Don Boutwell](https://community.abp.io/members/dboutwell) has created two new community articles: 
    * [Logging to Datadog from ABP framework](https://community.abp.io/posts/logging-to-datadog-from-abp-framework-fm4ozds4)
    * [Configuring Multiple DbContexts in an ABP Framework Project](https://community.abp.io/posts/configuring-multiple-dbcontexts-in-an-abp-framework-project-uoz5is3o)
* [Kirti Kulkarni](https://twitter.com/kirtimkulkarni) has created a new community article: [Deploying ABP angular application to Azure and App Insights integration](https://community.abp.io/posts/deploying-abp-angular-application-to-azure-and-app-insights-integration-4jrhtp01)

Thanks to the ABP Community for all the content they have published. You can also [post your ABP-related (text or video) content](https://community.abp.io/articles/submit) to the ABP Community.

## ABP by numbers
We have worked for 22 weeks on the 6.0 release. During this time, we closed 589 GitHub issues and merged 601 pull requests. For the new features and bug fixes, we made 3421 GitHub commits. We published 321 NuGet and 49 NPM packages. 50 contributors took part in this release, and 19 are first-time contributors. Thanks to everyone taking part in this version.

![image.png](048cddf521a29aaafbeb3a06cece21da.png)

## About the next version

The next feature version will be 7.0. It is planned to release the 7.0 RC (Release Candidate) on November 15 and the final version on December 13, 2022. You can follow the [release planning here](https://github.com/abpframework/abp/milestones).

Please [submit an issue](https://github.com/abpframework/abp/issues/new) if you have any problems with this version.