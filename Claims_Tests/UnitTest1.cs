using Claims_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Claims_Tests
{
    [TestClass]
    public class UnitTest1
    {
        private Claim testClaim = new Claim(1, "Car Accident on Highway 1", 40000, "6/05/18", "6/07/18", true);

        private Claim_Repo _testClaimsRepo;
        [TestMethod]
        public void TestMethod1()
        {
            _testClaimsRepo = new Claim_Repo();

            _testClaimsRepo.CreateNew(testClaim);

            Queue<Claim> queContent = _testClaimsRepo.();

            foreach (Claim Claim in queContent)
            {
                Assert.IsNotNull(Claim);
            }
        }
        public void GetQueueTest()
        {
            _testClaimsRepo = new Claim_Repo();

            _testClaimsRepo.CreateNew(testClaim);

            Queue<Claim> getTestQueues = _testClaimsRepo.GetQueue();

            foreach (Claim Claim in getTestQueues)
            {
                Assert.IsNotNull(Claim);
            }
        }
        public void CopyContentQueTest()
        {
            _testClaimsRepo = new Claim_Repo();

            Queue<Claim> testQueue = new Queue<Claim>();

            testQueue.Enqueue(testClaim);

            _testClaimsRepo.GetQueue(testQueue);

            Queue<Claim> getTestQueues = _testClaimsRepo.GetQueue();

            foreach (Claim Claim in getTestQueues)
            {
                Assert.IsNotNull(Claim);
            }
        }

    }
}
