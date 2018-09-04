using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sparrow.Framework;
using Sparrow.Framework.Interfaces;

namespace demomsptechday.Test
{
    [TestClass]
    public class UnitTest1
    {
        private INavigationBrowser _navigation;
        [TestMethod]
        public void TestMethod()
        {
            _navigation = new NavigationBrowser()
                .SetupTest("Chrome", "http://demomsptechday.azurewebsites.net/")
                .ExecutionTest()
                .GetElementByLinkText("Form Contact")
                .Click()
                .CloseBrowser();
        }
    }
}
