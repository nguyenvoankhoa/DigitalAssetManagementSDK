using DigitalAssetManagement;
using DigitalAssetManagement.Action;
using Microsoft.AspNetCore.Http.Internal;

string tenantId = "DC437619-4038-4FAE-84C0-5A5A5672FE0F";
string secretKey = "secret_key_1";
string apiKey = "api_key_1";

async Task testUploadImage()
{
    string baseDir = AppContext.BaseDirectory;
    string testDir = Path.Combine(baseDir, @"..\..\..\");
    string relativePath = Path.Combine(testDir, "Asset", "shoe.jpg");
    string localPath = Path.GetFullPath(relativePath);
    using var fileStream = new FileStream(localPath, FileMode.Open, FileAccess.Read);
    var file = new FormFile(fileStream, 0, fileStream.Length, "file", Path.GetFileName(localPath));

    Account acc = new Account();
    acc.SecretKey = secretKey;
    acc.ApiKey = apiKey;
    acc.TenantId = tenantId;
    Dam dam = new Dam(acc);
    var uploadParams = new ImageUploadParam()
    {
        File = file,
        Transformation = new Transformation().Width(200).Height(300).Quality(50)
    };

    ImageUploadResult result = await dam.UploadAsset(uploadParams);

    Console.WriteLine(result);
}

async Task testUploadVideo()
{
    string baseDir = AppContext.BaseDirectory;
    string testDir = Path.Combine(baseDir, @"..\..\..\");
    string relativePath = Path.Combine(testDir, "Asset", "shoe.jpg");
    string localPath = Path.GetFullPath(relativePath);
    using var fileStream = new FileStream(localPath, FileMode.Open, FileAccess.Read);
    var file = new FormFile(fileStream, 0, fileStream.Length, "file", Path.GetFileName(localPath));

    Account acc = new Account();
    acc.SecretKey = secretKey;
    acc.ApiKey = apiKey;
    acc.TenantId = tenantId;
    Dam dam = new(acc);
    var uploadParams = new ImageUploadParam()
    {
        File = file,
        Folder = "YPP3",
        Type = "mp4",
        Space = "9D00AA9D-CB79-4255-A706-DD8961A2BD87"
    };

    string result = await dam.UploadAsset(uploadParams);
}

async Task testGetByPublicId()
{
    Dam dam = new();
    string tenantId = string.Empty;
    string publicId = string.Empty;
    object result = await dam.GetAsset(tenantId, publicId);
}
