using System.IO;
using System.Linq;
using HtmlAgilityPack;
using Xunit;

namespace BugTrackerUI.Tests.CreatingNavigationAndComponents
{
    public class M202AddNavigationListTests
    {
        [Fact(DisplayName = "Add the Navigation List @add-navigation-list")]
        public void AddNavigationListTest()
        {
            var filePath = TestHelpers.GetRootString() + "BugTrackerUI"
                                                       + Path.DirectorySeparatorChar + "Shared"
                                                       + Path.DirectorySeparatorChar + "LeftNav.razor";

            Assert.True(File.Exists(filePath), "`LeftNav.razor` should exist in the Shared folder.");

            var doc = new HtmlDocument();
            doc.Load(filePath);

            var ulTag = doc.DocumentNode.Descendants("ul")?.FirstOrDefault();

            Assert.True(ulTag != null && ulTag.Descendants("li") != null && ulTag.Descendants("li").Count() == 2,
                "`LeftNav.razor` should contain a `ul` element with two child `li` elements.");
        }
    }
}