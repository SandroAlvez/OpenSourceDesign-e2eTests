using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using sandroCodeflow.src.pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace sandroCodeflow.src.tests;

[TestClass]
public class HomePageTests : TestBase
{
    private string searchText = "Design";

    [TestMethod]
    //Temporary test to verify if methods in homePage.cs are working as expected
    public void FlowTest()
    {
        //Calls homePage.cs
        HomePage homePage = new HomePage(driver);

        //Go to website
        driver.Navigate().GoToUrl(homePage.homePageUrl);
        
        //Verify if home page is loaded
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