﻿using System.IO;
using System.Linq;
using HtmlAgilityPack;
using Xunit;

namespace BugTrackerUI.Tests.AddDataValidationToForm
{
    public class M504AddValidationSummaryComponentTests
    {
        [Fact(DisplayName = "Add the Validation Display Component @add-validation-display-component")]
        public void AddValidationSummaryComponentTest()
        {
            var filePath = TestHelpers.GetRootString() + "BugTrackerUI"
                                                       + Path.DirectorySeparatorChar + "Pages"
                                                       + Path.DirectorySeparatorChar + "NewBug.razor";

            Assert.True(File.Exists(filePath), "`NewBug.razor` should exist in the Pages folder.");

            var doc = new HtmlDocument();
            doc.Load(filePath);

            var validationSummary = doc.DocumentNode.Descendants("ValidationSummary")?.FirstOrDefault();

            Assert.True(validationSummary != null,
                "`NewBug.razor` should contain navigation `ValidationSummary` component.");
        }
    }
}