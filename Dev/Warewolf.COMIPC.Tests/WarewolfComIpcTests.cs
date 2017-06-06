﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarewolfCOMIPC.Client;

// ReSharper disable InconsistentNaming

namespace WarewolfCOMIPC.Test
{
    [TestClass]
    public class WarewolfComIpcTests
    {
        [TestMethod]
        [Owner("Hagashen Naidu")]
        [TestCategory("WarewolfCOMIPCClient_Execute")]
        [Ignore]//Verfiy that the ID is actually registered
        public void WarewolfCOMIPCClient_Execute_GetType_ShouldReturnType()
        {
            //------------Setup for test--------------------------

            var clsid = new Guid("00000514-0000-0010-8000-00AA006D2EA4");
            //------------Execute Test---------------------------
           
            var execute = IpcClient.GetIPCExecutor().Invoke(clsid, "", Execute.GetType,  new ParameterInfoTO[] { });
            Assert.IsNotNull(execute);
            //------------Assert Results-------------------------
        }

        [TestMethod]
        [Owner("Nkosinathi Sangweni")]
        [Ignore]//Verfiy that the ID is actually registered
        public void GetMethods_GivenPersonLib_PersonController_ShouldReturnMethodList()
        {
            //---------------Set up test pack-------------------
            var classId = new Guid("2AC49130-C532-4154-B0DC-E930370D36EA");
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            {
                var execute = IpcClient.GetIPCExecutor().Invoke(classId, "", Execute.GetMethods,  new ParameterInfoTO[] { });
                var enumerable = execute as List<MethodInfoTO>;
                Assert.IsNotNull(enumerable);
                //---------------Test Result -----------------------
                Assert.AreNotEqual(10, enumerable.Count);
            }

        }

        [TestMethod]
        [Owner("Nkosinathi Sangweni")]
        [Ignore]//Test hangs
        public void GetMethods_GivenConnection_ShouldReturnMethodList()
        {
            //---------------Set up test pack-------------------
            var classId = new Guid("00000514-0000-0010-8000-00aa006d2ea4");
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            {
                var execute = IpcClient.GetIPCExecutor().Invoke(classId, "", Execute.GetMethods, new ParameterInfoTO[] { });
                var enumerable = execute as List<MethodInfoTO>;
                Assert.IsNotNull(enumerable);
                //---------------Test Result -----------------------
                Assert.AreNotEqual(30, enumerable.Count);
            }

        }

        [TestMethod]
        [Owner("Nkosinathi Sangweni")]
        [Ignore]//Test hangs
        public void GetMethods_GivenAcroPDF_ShouldReturnMethodList()
        {
            //---------------Set up test pack-------------------
            var classId = new Guid("CA8A9780-280D-11CF-A24D-444553540000");
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var execute = IpcClient.GetIPCExecutor().Invoke(classId, "", Execute.GetMethods, new ParameterInfoTO[] { });
            var enumerable = execute as List<MethodInfoTO>;
            Assert.IsNotNull(enumerable);
            //---------------Test Result -----------------------
            Assert.AreNotEqual(33, enumerable.Count);
        }
        
        [TestMethod]
        [Owner("Nkosinathi Sangweni")]
        [Ignore]//Test hangs
        public void ExecuteSpecifiedMethod_GivenConnection_ReturnSuccess()
        {
            //---------------Set up test pack-------------------
            var classId = new Guid("00000514-0000-0010-8000-00aa006d2ea4");
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var execute = IpcClient.GetIPCExecutor().Invoke(classId, "Open", Execute.ExecuteSpecifiedMethod, new ParameterInfoTO[] { });

            //---------------Test Result -----------------------
            var actual = execute as string;
            Assert.IsNotNull(actual);
        }
    }
}