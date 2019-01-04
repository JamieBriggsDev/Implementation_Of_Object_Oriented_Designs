using Microsoft.VisualStudio.TestTools.UnitTesting;


// Testing class to make sure the view project of the solution
//  works as it should
namespace View.Tests
{
    [TestClass]
    public class ViewTests
    {
        Presenter m_presenter;

        [TestInitialize]
        public void TestInitialize() => m_presenter = new Presenter();

        [TestMethod]
        public void TestGetStaffInitials() => Assert.IsNotNull(m_presenter.GetStaffInitials(1));

        [TestMethod]
        public void TestGetMachineNameFromID() => Assert.IsNotNull(m_presenter.GetMachineNameThroughMachineID(1));

        [TestMethod]
        public void TestGetAllMachineNames() => Assert.IsNotNull(m_presenter.GetAllMachineNames());

        [TestMethod]
        public void TestGetAllClientMachines() => Assert.IsNotNull(m_presenter.GetAllClientSpecificMachines(2));

        [TestMethod]
        public void TestGetClientID() => Assert.IsNotNull(m_presenter.GetClientID("Eddie & Co"));

        [TestMethod]
        public void TestGetClientNameThroughMachineID() => Assert.IsNotNull(m_presenter.GetClientNameThroughMachineID(1));
    }
}
