﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sibala_Hsinchu
{
    [TestClass]
    public class DiceTests
    {
        [TestMethod]
        public void CompareTest_1_Same_1_Same_should_be_0()
        {
            var diceA = new DiceDto(1, DiceDto.StatusEnum.SameColor);
            var diceB = new DiceDto(1, DiceDto.StatusEnum.SameColor);
            var expected = 0;
            CompareAreEqual(diceA, diceB, expected);
        }
        [TestMethod]
        public void CompareTest_1_Same_1_Point_should_be_1()
        {
            var diceA = new DiceDto(1, DiceDto.StatusEnum.SameColor);
            var diceB = new DiceDto(1, DiceDto.StatusEnum.Points);
            var expected = 1;
            CompareAreEqual(diceA, diceB, expected);
        }

        private static void CompareAreEqual(DiceDto diceA, DiceDto diceB, int expected)
        {
            var target = new Dice();
            var actual = target.Compare(diceA, diceB);
            Assert.AreEqual(expected, actual);
        }
    }
}