// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// Jamie Briggs
// Brandon Taylor
// 07/01/2019
// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;

namespace Model.Tests
{
    [TestClass]
    public class UnitTest1
    {
        DatabaseController m_db;
        /// <summary>
        /// Dummy data.
        /// </summary>
        [TestInitialize]
        public void Init() => Assert.IsNotNull(m_db = new DatabaseController());

        /// <summary>
        /// Tests whether the clients are created correctly and not null.
        /// </summary>
        [TestMethod]
        public void RegisterClients()
        {
            Assert.IsNotNull(m_db.AddClient("Eddie & Co"));
            Assert.IsNotNull(m_db.AddClient("Rise Newcastle"));
            Assert.IsNotNull(m_db.AddClient("Pandon 24/7"));
            Assert.IsNotNull(m_db.AddClient("CIS Sucks INC"));
        }

        /// <summary>
        /// Tests whether the machines are created correctly and not null.
        /// </summary>
        [TestMethod]
        public void RegisterMachines()
        {
            Machine machine1 = new Machine
            {
                MachineDescription = "This is a machine.",
                MachineName = "MAC",
                SizeAndComplexity = 1,
                ClientID = 1,

            };

            Machine machine2 = new Machine
            {
                MachineDescription = "This is a machine.",
                MachineName = "MAC1",
                SizeAndComplexity = 1,
                ClientID = 1,

            };

            Machine machine3 = new Machine
            {
                MachineDescription = "This is a machine.",
                MachineName = "MAC2",
                SizeAndComplexity = 1,
                ClientID = 2,

            };

            Machine machine4 = new Machine
            {
                MachineDescription = "This is a machine.",
                MachineName = "MAC3",
                SizeAndComplexity = 1,
                ClientID = 3,

            };

            Machine machine5 = new Machine
            {
                MachineDescription = "This is a machine.",
                MachineName = "MAC4",
                SizeAndComplexity = 1,
                ClientID = 4,

            };

            Assert.IsNotNull(m_db.AddMachine(machine1));
            Assert.IsNotNull(m_db.AddMachine(machine2));
            Assert.IsNotNull(m_db.AddMachine(machine3));
            Assert.IsNotNull(m_db.AddMachine(machine4));
            Assert.IsNotNull(m_db.AddMachine(machine5));
        }

        /// <summary>
        ///  Tests whether or not jobs register and are not null.
        /// </summary>
        [TestMethod]
        public void RegisterJobs()
        {
            Job job1 = new Job
            {
                FaultDescription = "Machine has faulty network connections.",
                MachineID = 1,
                Urgency = 3,
            };

            Job job2 = new Job
            {
                FaultDescription = "It's missing a drive.",
                MachineID = 2,
                Urgency = 0,
            };

            Assert.IsNotNull(m_db.RegisterJob(job1));
            Assert.IsNotNull(m_db.RegisterJob(job2));
        }

        /// <summary>
        /// Tests if staff members register and are not null.
        /// </summary>
        [TestMethod]
        public void RegisterStaffMembers()
        {
            Staff staff1 = new Staff
            {
                Forename = "Brandon",
                Surname = "Taylor",
                Role = "Technical Manager",
            };

            Staff staff2 = new Staff
            {
                Forename = "Jamie",
                Surname = "Briggs",
                Role = "Technical Engineer",
            };

            Staff staff3 = new Staff
            {
                Forename = "Ryan",
                Surname = "Bervoets",
                Role = "Technical Engineer",
            };

            Staff staff4 = new Staff
            {
                Forename = "Elliot",
                Surname = "Anderson",
                Role = "Technical Engineer",
            };

            Staff staff5 = new Staff
            {
                Forename = "Matthew",
                Surname = "Peers",
                Role = "Technical Engineer",
            };

            Staff staff6 = new Staff
            {
                Forename = "Marcus",
                Surname = "Cubbage",
                Role = "Technical Engineer",
            };

            Staff staff7 = new Staff
            {
                Forename = "John",
                Surname = "Doe",
                Role = "Technical Engineer",
            };

            Staff staff8 = new Staff
            {
                Forename = "Jane",
                Surname = "Doe",
                Role = "Technical Engineer",
            };

            Staff staff9 = new Staff
            {
                Forename = "Newt",
                Surname = "Scamander",
                Role = "Technical Engineer",
            };

            Staff staff10 = new Staff
            {
                Forename = "Roy",
                Surname = "Trainer",
                Role = "Technical Engineer",
            };

            Staff staff11 = new Staff
            {
                Forename = "Michael",
                Surname = "Gardner",
                Role = "Technical Engineer",
            };

            Assert.IsNotNull(m_db.AddStaff(staff1));
            Assert.IsNotNull(m_db.AddStaff(staff2));
            Assert.IsNotNull(m_db.AddStaff(staff3));
            Assert.IsNotNull(m_db.AddStaff(staff4));
            Assert.IsNotNull(m_db.AddStaff(staff5));
            Assert.IsNotNull(m_db.AddStaff(staff6));
            Assert.IsNotNull(m_db.AddStaff(staff7));
            Assert.IsNotNull(m_db.AddStaff(staff8));
            Assert.IsNotNull(m_db.AddStaff(staff9));
            Assert.IsNotNull(m_db.AddStaff(staff10));
            Assert.IsNotNull(m_db.AddStaff(staff11));
        }
    }
}
