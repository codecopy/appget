﻿using System.Linq;
using AppGet.InstalledPackages;
using AppGet.Manifests;
using FluentAssertions;
using NUnit.Framework;

namespace AppGet.Tests.InstalledPackages
{
    [TestFixture]
    public class WindowsInstallerInventoryManagerFixture : TestBase<WindowsInstallerInventoryManager>
    {
        [Test]
        public void should_get_uninstall_records()
        {
            var records = Subject.GetInstalledApplications();

            records.Should().NotBeEmpty();

            var nonMsi = records.Where(c => c.InstallMethod == InstallMethodType.Zip).ToList();
        }
    }
}