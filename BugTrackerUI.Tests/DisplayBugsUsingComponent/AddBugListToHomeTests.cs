using System.IO;
using System.Linq;
using HtmlAgilityPack;
using Xunit;

namespace BugTrackerUI.Tests.DisplayBugsUsingComponent
{
    public class M607AddBugListToHomeTests
    {
        [Fact(DisplayName = "Add the BugList component to Index @add-buglist-to-index")]
        public void AddNavigationToLayoutTest()
        {
            var filePath = TestHelpers.GetRootString() + "BugTrackerUI"
                                                       + Path.DirectorySeparatorChar + "Pages"
                                                       + Path.DirectorySeparatorChar + "Index.razor";

            Assert.True(File.Exists(filePath), "`Index.razor` should exist in the Shared folder.");

            var doc = new HtmlDocument();
            doc.Load(filePath);

            var leftNav = doc.DocumentNode.Descendants("BugList")?.FirstOrDefault();

            Assert.True(leftNav != null,
                "`Index.razor` should contain the `BugList` component.");
        }
    }
}