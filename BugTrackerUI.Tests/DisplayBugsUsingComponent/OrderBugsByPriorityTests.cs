using System.IO;
using Xunit;

namespace BugTrackerUI.Tests.DisplayBugsUsingComponent
{
    public class M605OrderBugsByPriorityTests
    {
        [Fact(DisplayName = "Order the list of bugs by priority @order-buglist")]
        public void OrderBugsByPriorityTest()
        {
            var filePath = TestHelpers.GetRootString() + "BugTrackerUI"
                                                       + Path.DirectorySeparatorChar + "Components"
                                                       + Path.DirectorySeparatorChar + "BugList.razor";

            Assert.True(File.Exists(filePath), "`BugList.razor` should exist in the Pages folder.");

            string file;
            using (var streamReader = new StreamReader(filePath))
            {
                file = streamReader.ReadToEnd();
            }

            Assert.True(file.Contains("BugService.GetBugs().OrderBy(x => x.Priority).ToList()"),
                "`BugList.razor` did not contain a call to `OrderBy` on the list of Bugs.");
        }
    }
}