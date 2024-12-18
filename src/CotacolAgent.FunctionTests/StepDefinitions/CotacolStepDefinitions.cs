using System.Threading.Tasks;
using CotacolAgent.FunctionTests.Drivers;
using Reqnroll;
using Xunit;

namespace CotacolAgent.FunctionTests.StepDefinitions;

[Binding]
public class CotacolStepDefinitions(CotacolTestContext cotacolTestContext, CotacolDriver cotacolDriver)
{
    [Given(@"the cotacol number is (.*)")]
    public void GivenTheCotacolNumberIs(int cotacolId)
    {
        cotacolTestContext.CotacolId = cotacolId.ToString();
    }

    [Given(@"the post type is (.*)")]
    public void GivenThePostTypeIsBluesky(string postType)
    {
        cotacolTestContext.PostType = postType;
    }

    [When(@"the post is created")]
    public async Task WhenThePostIsCreated()
    {
        cotacolTestContext.PostContent =
            await cotacolDriver.GeneratePostAsync(cotacolTestContext.CotacolId, cotacolTestContext.PostType);
    }

    [Then(@"the description should contain (.*)")]
    public void ThenTheDescriptionShouldContain(string expectedWord)
    {
        Assert.Contains(expectedWord, cotacolTestContext.PostContent);
    }
}