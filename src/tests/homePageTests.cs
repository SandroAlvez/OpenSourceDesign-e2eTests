using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OSDe2Tests.src.pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace OSDe2Tests.src.tests;

[TestClass]
public class HomePageTests : TestBase
{
    
    [TestMethod]
    //Temporary test to verify if methods in homePage.cs are working as expected
    public void FlowTest()
    {
        //Calls homePage.cs
        HomePage homePage = new HomePage(driver);

        //Calls httpHelper.cs
        HttpHelper http = new HttpHelper();

        //Sets the URL for the HTTP request
        http.url = homePage.homePageUrl;

        //Checks home page url
        http.checkUrl().Wait();

        //Verifies the test
        Assert.IsTrue(http.checkUrl().Result.Contains("OK"));
        
    }

    //Mock data for search test   
    //private string searchText = "Design";
    
    [TestMethod]
    [TestCategory("Smoke")]
    public void SearchText(string searchText)
    {
        //Calls homePage.cs
        HomePage homePage = new HomePage(driver);

        //Opens the page
        homePage.OpenHomePage();

        Assert.AreEqual("Open Source Design", homePage.PageTitle);

        //Make a search
        homePage.Search(searchText); 

        //Get the search results
        IReadOnlyCollection<IWebElement> searchResults = homePage.GetSearchResultsElements();

        //Verify if the text is found in the search results
        foreach (IWebElement result in searchResults)
        {
            Assert.IsTrue(result.Text.Contains(searchText, StringComparison.OrdinalIgnoreCase));
            
        }
    }



}