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
        public void Init()
        {
            m_db = new DatabaseController();

            m_db.AddClient("Eddie & Co");
            m_db.AddClient("Rise Newcastle");
            m_db.AddClient("Pandon 24/7");
            m_db.AddClient("CIS Sucks INC");

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

            m_db.AddMachine(machine1);
            m_db.AddMachine(machine2);
            m_db.AddMachine(machine3);
            m_db.AddMachine(machine4);
            m_db.AddMachine(machine5);

            Job job1 = new Job
            {
                FaultDescription = "It's fucked.",
                MachineID = 1,
                Location = "Northumbria Univerity",
                Urgency = 3,
            };

            Job job2 = new Job
            {
                FaultDescription = "It's missing a drive.",
                MachineID = 2,
                Location = "I don't actually know.",
                Urgency = 0,
            };

            m_db.RegisterJob(job1);
            m_db.RegisterJob(job2);

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
                Role = "L33t 420 Pr0gramm3r",
            };

            Staff staff3 = new Staff
            {
                Forename = "Ryan",
                Surname = "Bervoets",
                Role = "Technician",
            };

            Staff staff4 = new Staff
            {
                Forename = "Elliot",
                Surname = "Anderson",
                Role = "Drug Addict",
            };

            m_db.AddStaff(staff1);
            m_db.AddStaff(staff2);
            m_db.AddStaff(staff3);
            m_db.AddStaff(staff4);


        }


        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
