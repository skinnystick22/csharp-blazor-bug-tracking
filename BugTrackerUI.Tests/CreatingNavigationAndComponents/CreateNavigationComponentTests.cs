﻿using System.IO;
using Xunit;

namespace BugTrackerUI.Tests.CreatingNavigationAndComponents
{
    public class M201CreateNavigationComponentTests
    {
        [Fact(DisplayName = "Create the Navigation Component @create-navigation-component")]
        public void CreateNavigationComponentTest()
        {
            var filePath = TestHelpers.GetRootString() + "BugTrackerUI"
                                                       + Path.DirectorySeparatorChar + "Shared"
                                                       + Path.DirectorySeparatorChar + "LeftNav.razor";

            Assert.True(File.Exists(filePath), "`LeftNav.razor` should exist in the Shared folder.");
        }
    }
}