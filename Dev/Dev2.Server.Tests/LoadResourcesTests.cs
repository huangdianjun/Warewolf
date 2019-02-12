﻿/*
*  Warewolf - Once bitten, there's no going back
*  Copyright 2018 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/

using Dev2.Common.Interfaces.Scheduler.Interfaces;
using Dev2.Common.Interfaces.Wrappers;
using Dev2.Runtime.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Reflection;

namespace Dev2.Server.Tests
{
    [TestClass]
    public class LoadResourcesTests
    {
        [TestMethod]
        [Owner("Siphamandla Dube")]
        [TestCategory(nameof(LoadResources))]
        public void LoadResources_CheckExampleResources_DirectoryExists_True()
        {
            //------------------Arrange---------------
            var mockWriter = new Mock<IWriter>();
            var mockDirectory = new Mock<IDirectory>();
            var mockResourceCatalog = new Mock<IResourceCatalog>();
            var mockResourceCatalogFactory = new Mock<IResourceCatalogFactory>();
            var mockDirectoryHelper = new Mock<IDirectoryHelper>();
            
            mockDirectory.Setup(o => o.Exists(It.IsAny<string>())).Returns(true);
            mockResourceCatalogFactory.Setup(o => o.New()).Returns(mockResourceCatalog.Object);
            mockResourceCatalog.Setup(o => o.LoadExamplesViaBuilder(It.IsAny<string>()))
                .Callback<string>((path) => Assert.IsTrue(path.EndsWith(@"\Resources - ServerTests")))
                .Returns(()=> null).Verifiable();
            //------------------Act-------------------
            var loadResources =  new LoadResources("Resources - ServerTests", mockWriter.Object, mockDirectory.Object,mockResourceCatalogFactory.Object, mockDirectoryHelper.Object);
            loadResources.CheckExampleResources();
            //------------------Assert----------------
            mockResourceCatalog.Verify();
        }

        [TestMethod]
        [Owner("Siphamandla Dube")]
        [TestCategory(nameof(LoadResources))]
        public void LoadResources_CheckExampleResources_DirectoryExists_False()
        {
            //------------------Arrange---------------
            var mockWriter = new Mock<IWriter>();
            var mockDirectory = new Mock<IDirectory>();
            var mockResourceCatalog = new Mock<IResourceCatalog>();
            var mockResourceCatalogFactory = new Mock<IResourceCatalogFactory>();
            var mockDirectoryHelper = new Mock<IDirectoryHelper>();

            mockDirectory.Setup(o => o.Exists(It.IsAny<string>())).Returns(false);
            mockResourceCatalogFactory.Setup(o => o.New()).Returns(mockResourceCatalog.Object);
            //------------------Act-------------------
            var loadResources = new LoadResources("Resources - ServerTests", mockWriter.Object, mockDirectory.Object, mockResourceCatalogFactory.Object, mockDirectoryHelper.Object);
            loadResources.CheckExampleResources();
            //------------------Assert----------------
            mockResourceCatalog.Verify(o => o.LoadExamplesViaBuilder(It.IsAny<string>()), Times.Never);
        }

        [TestMethod]
        [Owner("Siphamandla Dube")]
        [TestCategory(nameof(LoadResources))]
        public void LoadResources_MigrateOldResources_DirectoryExits_True()
        {
            //------------------Arrange---------------
            const string resourceDirectory = "Resources - ServerTests";

            var mockWriter = new Mock<IWriter>();
            var mockDirectory = new Mock<IDirectory>();
            var mockResourceCatalogFactory = new Mock<IResourceCatalogFactory>();
            var mockDirectoryHelper = new Mock<IDirectoryHelper>();
            
            mockDirectory.Setup(o => o.Exists(It.IsAny<string>())).Returns(true);
            //------------------Act-------------------
            var loadResources = new LoadResources(resourceDirectory, mockWriter.Object, mockDirectory.Object, mockResourceCatalogFactory.Object, mockDirectoryHelper.Object);
            loadResources.MigrateOldResources();
            //------------------Assert----------------
            mockDirectoryHelper.Verify(o => o.Copy(It.IsAny<string>(), It.IsAny<string>(), true), Times.Never);
            mockDirectoryHelper.Verify(o => o.CleanUp(It.IsAny<string>()), Times.Never);
        }

        [TestMethod]
        [Owner("Siphamandla Dube")]
        [TestCategory(nameof(LoadResources))]
        public void LoadResources_MigrateOldResources_DirectoryExits_False()
        {
            //------------------Arrange---------------
            const string resourceDirectory = "Resources - ServerTests";

            var mockWriter = new Mock<IWriter>();
            var mockDirectory = new Mock<IDirectory>();
            var mockResourceCatalogFactory = new Mock<IResourceCatalogFactory>();
            var mockDirectoryHelper = new Mock<IDirectoryHelper>();

            mockDirectory.Setup(o => o.Exists(It.IsAny<string>())).Returns(false);
            mockDirectoryHelper.Setup(o => o.Copy(It.IsAny<string>(), It.IsAny<string>(), true))
                .Verifiable();
            mockDirectoryHelper.Setup(o => o.CleanUp(It.IsAny<string>()))
                .Verifiable();
            //------------------Act-------------------
            var loadResources = new LoadResources(resourceDirectory, mockWriter.Object, mockDirectory.Object, mockResourceCatalogFactory.Object, mockDirectoryHelper.Object);
            loadResources.MigrateOldResources();
            //------------------Assert----------------
            mockDirectoryHelper.Verify();
        }

        [TestMethod]
        [Owner("Siphamandla Dube")]
        [TestCategory(nameof(LoadResources))]
        public void LoadResources_ValidateResourceFolder_Success()
        {
            //------------------Arrange---------------
            const string resourceDirectory = "Resources - ServerTests";

            var mockWriter = new Mock<IWriter>();
            var mockDirectory = new Mock<IDirectory>();
            var mockResourceCatalogFactory = new Mock<IResourceCatalogFactory>();
            var mockDirectoryHelper = new Mock<IDirectoryHelper>();

            mockDirectory.Setup(o => o.Exists(It.IsAny<string>())).Returns(false);
            mockDirectory.Setup(o => o.CreateDirectory(It.IsAny<string>())).Verifiable();
            //------------------Act-------------------
            var loadResources = new LoadResources(resourceDirectory, mockWriter.Object, mockDirectory.Object, mockResourceCatalogFactory.Object, mockDirectoryHelper.Object);
            loadResources.ValidateResourceFolder();
            //------------------Assert----------------
            mockDirectoryHelper.Verify();
        }

        [TestMethod]
        [Owner("Siphamandla Dube")]
        [TestCategory(nameof(LoadResources))]
        public void LoadResources_MethodsToBeDepricated_Success()
        {
            //------------------Arrange---------------
            const string resourceDirectory = "Resources - ServerTests";

            var mockWriter = new Mock<IWriter>();
            var mockDirectory = new Mock<IDirectory>();
            var mockResourceCatalog = new Mock<IResourceCatalog>();
            var mockResourceCatalogFactory = new Mock<IResourceCatalogFactory>();
            var mockDirectoryHelper = new Mock<IDirectoryHelper>();

            mockResourceCatalogFactory.Setup(o => o.New()).Returns(mockResourceCatalog.Object);
            mockResourceCatalog.Setup(o => o.CleanUpOldVersionControlStructure()).Verifiable();
            //------------------Act-------------------
            var loadResources = new LoadResources(resourceDirectory, mockWriter.Object, mockDirectory.Object, mockResourceCatalogFactory.Object, mockDirectoryHelper.Object);
            loadResources.MethodsToBeDepricated();
            //------------------Assert----------------
            mockResourceCatalog.Verify();
        }

        [TestMethod]
        [Owner("Siphamandla Dube")]
        [TestCategory(nameof(LoadResources))]
        public void LoadResources_LoadResourceCatalog_Success()
        {
            //------------------Arrange---------------
            const string resourceDirectory = "Resources - ServerTests";

            var mockWriter = new Mock<IWriter>();
            var mockDirectory = new Mock<IDirectory>();
            var mockResourceCatalog = new Mock<IResourceCatalog>();
            var mockResourceCatalogFactory = new Mock<IResourceCatalogFactory>();
            var mockDirectoryHelper = new Mock<IDirectoryHelper>();

            mockResourceCatalogFactory.Setup(o => o.New()).Returns(mockResourceCatalog.Object);
            mockResourceCatalog.Setup(o => o.CleanUpOldVersionControlStructure()).Verifiable();

            mockWriter.Setup(o => o.WriteLine("done.")).Verifiable();
            //------------------Act-------------------
            var loadResources = new LoadResources(resourceDirectory, mockWriter.Object, mockDirectory.Object, mockResourceCatalogFactory.Object, mockDirectoryHelper.Object);
            loadResources.LoadResourceCatalog();
            //------------------Assert----------------
            mockWriter.Verify();
        }


        [TestMethod]
        [Owner("Siphamandla Dube")]
        [TestCategory(nameof(LoadResources))]
        public void LoadResources_LoadActivityCache_Success()
        {
            //------------------Arrange---------------
            const string resourceDirectory = "Resources - ServerTests";

            var mockWriter = new Mock<IWriter>();
            var mockDirectory = new Mock<IDirectory>();
            var mockResourceCatalog = new Mock<IResourceCatalog>();
            var mockResourceCatalogFactory = new Mock<IResourceCatalogFactory>();
            var mockDirectoryHelper = new Mock<IDirectoryHelper>();
            var mockAssemblyLoader = new Mock<IAssemblyLoader>();

            mockResourceCatalogFactory.Setup(o => o.New()).Returns(mockResourceCatalog.Object);
            mockResourceCatalog.Setup(o => o.CleanUpOldVersionControlStructure()).Verifiable();
            mockResourceCatalog.Setup(o => o.LoadServerActivityCache()).Verifiable();
            
            mockWriter.Setup(o => o.Write("Loading resource activity cache...  ")).Verifiable();
            mockWriter.Setup(o => o.Write("Preloading assemblies...  ")).Verifiable();


            mockAssemblyLoader.Setup(o => o.AssemblyNames(It.IsAny<Assembly>())).Returns(new AssemblyName[] { new AssemblyName() { Name= "testAssemblyName" } });
            //------------------Act-------------------
            var loadResources = new LoadResources(resourceDirectory, mockWriter.Object, mockDirectory.Object, mockResourceCatalogFactory.Object, mockDirectoryHelper.Object);
            loadResources.LoadActivityCache(mockAssemblyLoader.Object);
            //------------------Assert----------------
            mockWriter.Verify(o => o.WriteLine("done."), Times.Exactly(2));
            mockWriter.Verify();
        }

        [TestMethod]
        [Owner("Siphamandla Dube")]
        [TestCategory(nameof(LoadResources))]
        public void LoadResources_LoadServerWorkspace_Success()
        {
            //------------------Arrange---------------
            const string resourceDirectory = "Resources - ServerTests";

            var mockWriter = new Mock<IWriter>();
            var mockDirectory = new Mock<IDirectory>();
            var mockResourceCatalog = new Mock<IResourceCatalog>();
            var mockResourceCatalogFactory = new Mock<IResourceCatalogFactory>();
            var mockDirectoryHelper = new Mock<IDirectoryHelper>();

            mockResourceCatalogFactory.Setup(o => o.New()).Returns(mockResourceCatalog.Object);

            mockWriter.Setup(o => o.Write("Loading server workspace...  ")).Verifiable();
            mockWriter.Setup(o => o.WriteLine("done.")).Verifiable();
            //------------------Act-------------------
            var loadResources = new LoadResources(resourceDirectory, mockWriter.Object, mockDirectory.Object, mockResourceCatalogFactory.Object, mockDirectoryHelper.Object);
            loadResources.LoadServerWorkspace();
            //------------------Assert----------------
            mockWriter.Verify();
        }

        [TestMethod]
        [Owner("Siphamandla Dube")]
        [TestCategory(nameof(LoadResources))]
        public void LoadResources_MigrateOldTests_DirecotoryExists_True()
        {
            //------------------Arrange---------------
            const string resourceDirectory = "Resources - ServerTests";

            var mockWriter = new Mock<IWriter>();
            var mockDirectory = new Mock<IDirectory>();
            var mockResourceCatalog = new Mock<IResourceCatalog>();
            var mockResourceCatalogFactory = new Mock<IResourceCatalogFactory>();
            var mockDirectoryHelper = new Mock<IDirectoryHelper>();

            mockDirectory.Setup(o => o.Exists(It.IsAny<string>())).Returns(true);
            mockResourceCatalogFactory.Setup(o => o.New()).Returns(mockResourceCatalog.Object);
            //------------------Act-------------------
            var loadResources = new LoadResources(resourceDirectory, mockWriter.Object, mockDirectory.Object, mockResourceCatalogFactory.Object, mockDirectoryHelper.Object);
            loadResources.MigrateOldTests();
            //------------------Assert----------------
            mockDirectoryHelper.Verify(o => o.Copy(It.IsAny<string>(), It.IsAny<string>(), true), Times.Never);
            mockDirectoryHelper.Verify(o => o.CleanUp(It.IsAny<string>()), Times.Never);
        }

        [TestMethod]
        [Owner("Siphamandla Dube")]
        [TestCategory(nameof(LoadResources))]
        public void LoadResources_MigrateOldTests_DirecotoryExists_False()
        {
            //------------------Arrange---------------
            const string resourceDirectory = "Resources - ServerTests";

            var mockWriter = new Mock<IWriter>();
            var mockDirectory = new Mock<IDirectory>();
            var mockResourceCatalog = new Mock<IResourceCatalog>();
            var mockResourceCatalogFactory = new Mock<IResourceCatalogFactory>();
            var mockDirectoryHelper = new Mock<IDirectoryHelper>();

            mockDirectory.Setup(o => o.Exists(It.IsAny<string>())).Returns(false);
            mockResourceCatalogFactory.Setup(o => o.New()).Returns(mockResourceCatalog.Object);
            //------------------Act-------------------
            var loadResources = new LoadResources(resourceDirectory, mockWriter.Object, mockDirectory.Object, mockResourceCatalogFactory.Object, mockDirectoryHelper.Object);
            loadResources.MigrateOldTests();
            //------------------Assert----------------
            mockDirectoryHelper.Verify(o => o.Copy(It.IsAny<string>(), It.IsAny<string>(), true), Times.Once);
            mockDirectoryHelper.Verify(o => o.CleanUp(It.IsAny<string>()), Times.Once);
        }
    }
}