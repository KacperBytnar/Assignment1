using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1_KacperBytnar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_KacperBytnar.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {

        [TestMethod()]
        public void AgeValidatorTest()
        {
            FootballPlayer errorAgePlayer = new FootballPlayer(1, "Dawid", 0, 9);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => errorAgePlayer.AgeValidator());
        }

        [TestMethod()]
        public void NameValidatorTest()
        {
            FootballPlayer errorNamePlayer = new FootballPlayer(2, "J", 1, 11);
            Assert.ThrowsException<ArgumentException>(() => errorNamePlayer.NameValidator());
        }

        [TestMethod()]
        public void ShirtNumberValidatorTest()
        {
        FootballPlayer errorShirtNumberPlayer = new FootballPlayer(3, "Paul", 21, 101);
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => errorShirtNumberPlayer.ShirtNumberValidator());
        }
    }
}