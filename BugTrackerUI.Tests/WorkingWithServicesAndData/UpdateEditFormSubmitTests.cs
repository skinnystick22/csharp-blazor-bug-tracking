﻿using System.IO;
using System.Linq;
using HtmlAgilityPack;
using Xunit;

namespace BugTrackerUI.Tests.WorkingWithServicesAndData
{
    public class M407UpdateEditFormSubmitTests
    {
        [Fact(DisplayName = "Update the EditForm Component submit @update-editform-submit")]
        public void M4_07_UpdateEditFormSubmitTest()
        {
            var filePath = TestHelpers.GetRootString() + "BugTrackerUI"
                                                       + Path.DirectorySeparatorChar + "Pages"
                                                       + Path.DirectorySeparatorChar + "NewBug.razor";

            Assert.True(File.Exists(filePath), "`NewBug.razor` should exist in the `Pages` folder.");

            var doc = new HtmlDocument();
            doc.Load(filePath);

            var editForm = doc.DocumentNode.Descendants("EditForm")?.FirstOrDefault();

            Assert.True(editForm != null && editForm.Attributes["OnValidSubmit"]?.Value == "HandleValidSubmit",
                @"The `NewBug` component element should contain an `EditForm` component with with a `OnValidSubmit` attribute set to `@HandleValidSubmit`.");
        }
    }
}