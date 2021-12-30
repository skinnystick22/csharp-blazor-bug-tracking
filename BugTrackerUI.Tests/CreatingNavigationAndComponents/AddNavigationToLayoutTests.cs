﻿using System.IO;
using System.Linq;
using HtmlAgilityPack;
using Xunit;

namespace BugTrackerUI.Tests.CreatingNavigationAndComponents
{
    public class M205AddNavigationToLayoutTests
    {
        [Fact(DisplayName = "Add the LeftNav Component to the MainLayout Component @add-leftnav-to-mainlayout")]
        public void AddNavigationToLayoutTest()
        {
            var filePath = TestHelpers.GetRootString() + "BugTrackerUI"
                                                       + Path.DirectorySeparatorChar + "Shared"
                                                       + Path.DirectorySeparatorChar + "MainLayout.razor";

            Assert.True(File.Exists(filePath), "`MainLayout.razor` should exist in the Shared folder.");

            var doc = new HtmlDocument();
            doc.Load(filePath);

            var leftNav = doc.DocumentNode.Descendants("LeftNav")?.FirstOrDefault();

            Assert.True(leftNav != null,
                "`MainLayout.razor` should contain the `LeftNav` component.");
        }
    }
}