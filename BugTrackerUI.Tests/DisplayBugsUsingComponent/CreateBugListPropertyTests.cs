﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace BugTrackerUI.Tests.DisplayBugsUsingComponent
{
    public class M603CreateBugListPropertyTests
    {
        [Fact(DisplayName = "Create the Bugs property @create-bugs-property")]
        public void CreateBugListPropertyTest()
        {
            var filePath = TestHelpers.GetRootString() + "BugTrackerUI"
                                                       + Path.DirectorySeparatorChar + "Components"
                                                       + Path.DirectorySeparatorChar + "BugList.razor";

            Assert.True(File.Exists(filePath), "`BugList.razor` should exist in the Components folder.");

            var newBug = TestHelpers.GetClassType("BugTrackerUI.Components.BugList");

            var prop = newBug.GetProperty("Bugs");

            Assert.True(prop != null && prop.GetAccessors().FirstOrDefault(x => x.IsPublic) != null
                                     && newBug.GetProperty("Bugs").PropertyType.Name == typeof(List<Bug>).Name
                                     && newBug.GetProperty("Bugs").Name.Contains("Bugs"),
                "`BugList.razor` should contain a public property `Bugs` of type `List<Bug>`.");
            ;
        }
    }
}