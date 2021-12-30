using System.IO;
using Xunit;

namespace BugTrackerUI.Tests.WorkingWithServicesAndData
{
    public class M404PersistNewBugTests
    {
        [Fact(DisplayName = "Persist the new bug @persist-new-bug")]
        public void PersistNewBugTest()
        {
            var filePath = TestHelpers.GetRootString() + "BugTrackerUI"
                                                       + Path.DirectorySeparatorChar + "Pages"
                                                       + Path.DirectorySeparatorChar + "NewBug.razor";

            Assert.True(File.Exists(filePath), "`NewBug.razor` was not found.");

            string file;
            using (var streamReader = new StreamReader(filePath))
            {
                file = streamReader.ReadToEnd();
            }

            Assert.True(file.Contains("BugService.AddBug(AddBug)"),
                "`NewBug.razor` does not contain a call to `BugService.AddBug` with the parameter `AddBug`.");
        }
    }
}