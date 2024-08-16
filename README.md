# Digital Asset Management C# SDK

This SDK allows developers to interact with a Digital Asset Management (DAM) system, providing functionalities to upload and retrieve digital assets such as images and videos. Below are examples and usage instructions.

## Table of Contents
- [Installation](#installation)
- [Usage](#usage)
  - [Configuration](#configuration)
  - [Uploading an Image](#uploading-an-image)
  - [Uploading a Video](#uploading-a-video)
  - [Retrieving an Asset by Public ID](#retrieving-an-asset-by-public-id)
- [License](#license)

## Installation

1. Clone the repository or download the SDK files.
2. Add the necessary references to your project.
3. Ensure you have access to the DAM system with valid `TenantId`, `SecretKey`, and `ApiKey`.

## Usage

### Configuration

Before using the SDK, ensure that you have your credentials (`TenantId`, `SecretKey`, and `ApiKey`) ready.

```csharp
string tenantId = "your-tenant-id";
string secretKey = "your-secret-key";
string apiKey = "your-api-key";
