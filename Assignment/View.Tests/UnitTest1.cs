using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using View;

// Testing class to make sure the view project of the solution
//  works as it should
namespace View.Tests
{
    [TestClass]
    public class ViewTests
    {
        Presenter m_presenter;

        [TestInitialize]
        public void TestInitialize()
        {
            m_presenter = new Presenter();
        }

        [TestMethod]
        public void TestPresenterCreatedProperly()
        {
            Assert.IsNotNull(m_presenter, "Presenter failed to initialise.");
            Assert.IsTrue(m_presenter.ValidateDatabaseController(), "Database controller failed to initialise.");
        }

    }
}
