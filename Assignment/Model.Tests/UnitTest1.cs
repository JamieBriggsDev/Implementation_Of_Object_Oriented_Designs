using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;

namespace Model.Tests
{
    [TestClass]
    public class UnitTest1
    {
        DatabaseController m_db;
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
                Location = "Northumbria Univerity"
            };

            Job job2 = new Job
            {
                FaultDescription = "It's missing a drive.",
                MachineID = 2,
                Location = "I don't actually know.",
            };

            m_db.RegisterJob(job1);
            m_db.RegisterJob(job2);


        }


        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
