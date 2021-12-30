using System.IO;
using System.Reflection;
using Xunit;

namespace BugTrackerUI.Tests.WorkingWithServicesAndData
{
    public class M403CreateFormSubmissionHandlerTests
    {
        [Fact(DisplayName = "Create the Form Handler @create-form-handler")]
        public void CreateFormSubmissionHandlerTest()
        {
            var filePath = TestHelpers.GetRootString() + "BugTrackerUI"
                                                       + Path.DirectorySeparatorChar + "Pages"
                                                       + Path.DirectorySeparatorChar + "NewBug.razor";

            Assert.True(File.Exists(filePath), "`NewBug.razor` should exist in the Pages folder.");

            var newBug = TestHelpers.GetClassType("BugTrackerUI.Pages.NewBug");

            var method = newBug.GetMethod(
                "HandleValidSubmit",
                BindingFlags.Instance | BindingFlags.NonPublic);

            Assert.True(method != null && method.IsFamily && method.ReturnType == typeof(void),
                "`NewBug.razor` should contain a `protected` method called `HandleValidSubmit` that returns a type of `Void`.");
        }
    }
}