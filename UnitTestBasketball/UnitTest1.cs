using Microsoft.VisualStudio.TestTools.UnitTesting;
using Basketball;

namespace UnitTestBasketball
{
    [TestClass]
    public class BasketballPlayerTests
    {
        [TestMethod]
        public void TestGetJerseyNumber()
        {
            BasketballPlayer player = new BasketballPlayer(23, "Forward", "LeBron", "James", 27.1);
            Assert.AreEqual(23, player[0]);
        }

        [TestMethod]
        public void TestUpdateLastName()
        {
            BasketballPlayer player = new BasketballPlayer(23, "Forward", "LeBron", "James", 27.1);
            player[3] = "Bryant";
            Assert.AreEqual("Bryant", player[3]);
        }

        [TestMethod]
        public void TestGetByAttributeName()
        {
            BasketballPlayer player = new BasketballPlayer(23, "Forward", "LeBron", "James", 27.1);
            Assert.AreEqual("Forward", player["position"]);
        }

        [TestMethod]
        public void TestUpdateByAttributeName()
        {
            BasketballPlayer player = new BasketballPlayer(23, "Forward", "LeBron", "James", 27.1);
            player["firstname"] = "Kobe";
            Assert.AreEqual("Kobe", player["firstname"]);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestInvalidIndexGet()
        {
            BasketballPlayer player = new BasketballPlayer(23, "Forward", "LeBron", "James", 27.1);
            var result = player[5];
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestInvalidIndexSet()
        {
            BasketballPlayer player = new BasketballPlayer(23, "Forward", "LeBron", "James", 27.1);
            player[5] = "Invalid";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidAttributeNameGet()
        {
            BasketballPlayer player = new BasketballPlayer(23, "Forward", "LeBron", "James", 27.1);
            var result = player["invalidattr"];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidAttributeNameSet()
        {
            BasketballPlayer player = new BasketballPlayer(23, "Forward", "LeBron", "James", 27.1);
            player["invalidattr"] = "Invalid";
        }
    }
}
