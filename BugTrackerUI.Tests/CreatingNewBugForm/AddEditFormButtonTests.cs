using System.IO;
using System.Linq;
using HtmlAgilityPack;
using Xunit;

namespace BugTrackerUI.Tests.CreatingNewBugForm
{
    public class M305AddEditFormButtonTests
    {
        [Fact(DisplayName = "Add the Edit Form Button @add-editform-button")]
        public void AddEditFormButtonTest()
        {
            var filePath = TestHelpers.GetRootString() + "BugTrackerUI"
                                                       + Path.DirectorySeparatorChar + "Pages"
                                                       + Path.DirectorySeparatorChar + "NewBug.razor";

            Assert.True(File.Exists(filePath), "`NewBug.razor` should exist in the `Pages` folder.");

            var doc = new HtmlDocument();
            doc.Load(filePath);

            var editForm = doc.DocumentNode.Descendants("EditForm")?.FirstOrDefault();

            if (editForm != null)
            {
                var parsedInput = editForm.Descendants("button")
                    .FirstOrDefault(x => x.Attributes["type"]?.Value == $"submit");

                Assert.True(parsedInput != null && parsedInput.InnerText == "Add Bug",
                    $"The EditForm Component should contain a button with attributes `type=\"submit\"` and the text `\"Add Bug\"`.");
            }
            else
            {
                Assert.True(editForm != null,
                    @"The `NewBug` component element should contain an `EditForm` component with with a `Model` attribute set to `AddBug`.");
            }
        }
    }
}