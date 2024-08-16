using DigitalAssetManagement;
using DigitalAssetManagement.Action;
using Microsoft.AspNetCore.Http.Internal;

string tenantId = "DC437619-4038-4FAE-84C0-5A5A5672FE0F";
string secretKey = "secret_key_1";
string apiKey = "api_key_1";

async Task testUploadImage()
{
    string localFilePath = "D:\\.Net\\DigitalAssetManagement\\Test\\Asset\\shoe.jpg";
    using var fileStream = new FileStream(localFilePath, FileMode.Open, FileAccess.Read);
    var file = new FormFile(fileStream, 0, fileStream.Length, "file", Path.GetFileName(localFilePath));

    Account acc = new Account();
    acc.SecretKey = secretKey;
    acc.ApiKey = apiKey;
    acc.TenantId = tenantId;
    Dam dam = new(acc);
    var uploadParams = new ImageUploadParam()
    {
        File = file,
        Folder = "YPP3",
        Type = "jpg",
        Space = "9D00AA9D-CB79-4255-A706-DD8961A2BD87"
    };

    string result = await dam.UploadAsset(uploadParams);
}

testUploadImage();
async Task testUploadVideo()
{
    string localFilePath = "D:\\.Net\\DigitalAssetManagement\\Test\\Asset\\shoe.jpg";
    using var fileStream = new FileStream(localFilePath, FileMode.Open, FileAccess.Read);
    var file = new FormFile(fileStream, 0, fileStream.Length, "file", Path.GetFileName(localFilePath));

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

testUploadVideo();

async Task testGetByPath()
{
    Dam dam = new();
    string path = "shoe.jpg";
    object result = await dam.GetAsset(path);
}


async Task testGetByPublicId()
{
    Dam dam = new();
    string tenantId = string.Empty;
    string publicId = string.Empty;
    object result = await dam.GetAsset(tenantId, publicId);
}