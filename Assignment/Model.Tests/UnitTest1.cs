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

            Job job1 = new Job
            {
                FaultDescription = "Accidentally disconnected the server cable.",
                Open = true,
                Urgency = 1,
                Location = "Your mums house.",
            };

            Job job2 = new Job
            {
                FaultDescription = "Don't have right software.",
                Open = true,
                Urgency = 2,
                Location = "Northumbria University.",
            };

            Job job3 = new Job
            {
                FaultDescription = "I damaged one of the drives.",
                Open = true,
                Urgency = 3,
                Location = "London.",
            };

            Job job4 = new Job
            {
                FaultDescription = "The server box is completely destroyed..",
                Open = true,
                Urgency = 4,
                Location = "Murica'",
            };

            Machine machine1 = new Machine
            {
                JobID = 0,
                MachineDescription = "This is a machine.",
                MachineName = "MAC" + job1.JobID.ToString(),
                SizeAndComplexity = 1,

            };

            Machine machine2 = new Machine
            {
                JobID = 1,
                MachineDescription = "This is a machine.",
                MachineName = "MAC" + job1.JobID.ToString(),
                SizeAndComplexity = 1,

            };

            Machine machine3 = new Machine
            {
                JobID = 2,
                MachineDescription = "This is a machine.",
                MachineName = "MAC" + job1.JobID.ToString(),
                SizeAndComplexity = 1,

            };

            Machine machine4 = new Machine
            {
                JobID = 3,
                MachineDescription = "This is a machine.",
                MachineName = "MAC" + job1.JobID.ToString(),
                SizeAndComplexity = 1,

            };

            Machine machine5 = new Machine
            {
                JobID = 4,
                MachineDescription = "This is a machine.",
                MachineName = "MAC" + job1.JobID.ToString(),
                SizeAndComplexity = 1,

            };


        }


        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(m_db.AddClient("Death INC"), "Failed to register new Job.");
        }
    }
}
