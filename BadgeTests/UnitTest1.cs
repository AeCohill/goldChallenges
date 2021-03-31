using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Badges;

namespace BadgeTests
{
    [TestClass]
    public class UnitTest1
    {
        public static BadgeRepo repo = new BadgeRepo();
        public static Badge badge = new Badge();

        [TestMethod]
        public void TestGetAllBadges()
        {
            // ASSERT the badges are not null or empty
            // Get a count?
            // Mehthods without signatures can be verified by directly accessing the dictionary in the test
        }

        [TestMethod]
        public void TestAddABadge()
        {
            // Add a badge and ASSERT the ID exists in dictionary
            // Get a count?
            // Mehthods without signatures can be verified by directly accessing the dictionary in the test
        }

        [TestMethod]
        public void TestUpdateABadge()
        {
            // ASSERT name entered == name in dictionary
            // Boolean
            // Verify ID is correct
            // Mehthods without signatures can be verified by directly accessing the dictionary in the test

        }
        [TestMethod]
        public void TestDeleteABadge()
        {
            // ASSERT item is removed
            // Boolean
            // Get a count?
            // Mehthods without signatures can be verified by directly accessing the dictionary in the test
        }
    }       
}
