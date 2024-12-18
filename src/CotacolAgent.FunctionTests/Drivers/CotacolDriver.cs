using System.Threading.Tasks;

namespace CotacolAgent.FunctionTests.Drivers;

public class CotacolDriver
{
    public async Task<string> GeneratePostAsync(string cotacolId, string postType)
    {
        return $"{cotacolId} - {postType}";
    }
}