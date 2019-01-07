// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// Jamie Briggs
// Brandon Taylor
// 07/01/2019
// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

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
        public void TestGetAllJobs() => Assert.IsNotNull(m_presenter.GetAllJobs());

        [TestMethod]
        public void TestGetAllClients() => Assert.IsNotNull(m_presenter.GetAllClients());

        [TestMethod]
        public void TestGetAllMachines() => Assert.IsNotNull(m_presenter.GetAllMachines());

        [TestMethod]
        public void TestGetAllStaff() => Assert.IsNotNull(m_presenter.GetAllStaff());

        [TestMethod]
        public void TestGetAllClientMachines() => Assert.IsNotNull(m_presenter.GetAllClientSpecificMachines(2));

        [TestMethod]
        public void TestGetAllMachineNames() => Assert.IsNotNull(m_presenter.GetAllMachineNames());

        [TestMethod]
        public void TestGetClientID() => Assert.IsNotNull(m_presenter.GetClientID("Eddie & Co"));

        [TestMethod]
        public void TestGetClientNameThroughMachineID() => Assert.IsTrue(m_presenter.GetClientNameThroughMachineID(1) != "ERROR GETTING CLIENT NAME");

        [TestMethod]
        public void TestGetMachineNameThroughMachineID() => Assert.IsTrue(m_presenter.GetMachineNameThroughMachineID(1) != "ERROR GETTING MACHINE NAME");

        [TestMethod]
        public void TestGetStafInitials() => Assert.IsTrue(m_presenter.GetStaffInitials(1) != "Unassigned");

        [TestMethod]
        public void TestGetTechnicalManager() => Assert.IsNotNull(m_presenter.GetTechnicaManager());

        [TestMethod]
        public void TestIsTechnicalManager()
        {
            var manager = m_presenter.GetTechnicaManager();
            m_presenter.SetUser(manager.StaffID);
            bool isManager = m_presenter.IsTechnicalManager();
            Assert.IsTrue(isManager);
        }

        
    }
}
