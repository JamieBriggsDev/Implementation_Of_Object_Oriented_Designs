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
        }


        [TestMethod]
        public void TestMethod1()
        {
            Job testJob = new Job
            {
                FaultDescription = "Testing the faulty stuff.",
                Open = true,
                Urgency = 5,
                Attachment = "www.google.com"
            };

            Assert.IsTrue(m_db.RegisterJob(testJob), "Failed to register new Job.");
        }
    }
}
