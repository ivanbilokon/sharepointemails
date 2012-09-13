﻿using SharePointEmails.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SharePointEmails.Core.Substitutions;
using Moq;
namespace SharePointEmails.Core.Tests
{
    
    
    /// <summary>
    ///This is a test class for FieldSubstitutionTest and is intended
    ///to contain all FieldSubstitutionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FieldSubstitutionTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for FieldSubstitution Constructor
        ///</summary>
        [TestMethod()]
        public void FieldSubstitutionConstructorTest()
        {
            FieldSubstitution target = new FieldSubstitution();
        }

        /// <summary>
        ///A test for Process
        ///</summary>
        [TestMethod()]
        public void ProcessTest_SomeText_Substituted()
        {
            FieldSubstitution target = new FieldSubstitution();
            var context = new Mock<ISubstitutionContext>();
            context.Setup(p => p.GetField("field1",new ModifiersCollection{Modifier.Old})).Returns("field1Oldtext");
            context.Setup(p => p.GetField("field1", new ModifiersCollection { Modifier.New })).Returns("field1Newtext");
            context.Setup(p => p.GetField("field2", new ModifiersCollection { Modifier.New })).Returns("field2Newtext");
            context.Setup(p => p.GetField("field1", new ModifiersCollection ())).Returns("field1Newtext");
            context.Setup(p => p.GetField("field3", new ModifiersCollection{Modifier.Old})).Returns("field3Oldtext");
            context.Setup(p => p.GetField("field3", new ModifiersCollection())).Returns("field3Oldtext");
            var text = "text1 [field1:O] text2 [field2:N] text3 [field1:N] text4 [field1] [field3]";
            var expected = "text1 field1Oldtext text2 field2Newtext text3 field1Newtext text4 field1Newtext field3Oldtext";
            var actual = target.Process(text, context.Object);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ProcessTest_NotExistedFields_Substituted()
        {
            FieldSubstitution target = new FieldSubstitution();
            var context = new Mock<ISubstitutionContext>();
            var text = "text1 [field1:O] text2 [field2:N] text3 [field1:N]";
            target.Process(text, context.Object);
        }

    }
}