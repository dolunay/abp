[ABP Framework](https://abp.io/) and [ABP Commercial](https://commercial.abp.io/) 4.4 versions have been released today.

## What's New With 4.4?

Since all the new features are already explained in details with the 4.4 RC announcement posts, I will not repeat all the details again. See [the related blog post](https://blog.abp.io/abp/ABP-Platform-4-4-RC-Has-Been-Released) for all the features and enhancements.

## How to Upgrade an Existing Solution

### Install/Update the ABP CLI

First of all, install the ABP CLI or upgrade to the latest version.

If you haven't installed yet:

```bash
dotnet tool install -g Volo.Abp.Cli
```

To update an existing installation:

```bash
dotnet tool update -g Volo.Abp.Cli
```

### ABP UPDATE Command

[ABP CLI](https://docs.abp.io/en/abp/latest/CLI) provides a handy command to update all the ABP related NuGet and NPM packages in your solution with a single command:

```bash
abp update
```

Run this command in the root folder of your solution.

## The Road Map

The next feature version will be 5.0. It is planned to release the 5.0 RC (Release Candidate) in November 2021. See the updated road maps;

* [ABP Framework Road Map](https://docs.abp.io/en/abp/latest/Road-Map)
* [ABP Commercial Road Map](https://docs.abp.io/en/commercial/latest/road-map)