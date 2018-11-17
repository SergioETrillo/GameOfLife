using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GameOfLife.Test
{
    [TestFixture]
    public class Test
    {
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void DeadCellStaysDeadWithLessThan3Neighbors(int numNeighbours)
        {
            Assert.IsFalse(LifeRules.CellSurvives(numNeighbours, false));
        }

        [TestCase(4)]
        public void LiveCellDiesMoreThan3Neighbors(int neighbours)
        {
            Assert.IsFalse(LifeRules.CellSurvives(neighbours, false));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void CellAlwaysAliveWith3Neighbours(bool state)
        {
            int neighbours = 3;
            Assert.IsTrue(LifeRules.CellSurvives(neighbours, state));
        }

        [Test]
        public void AliveCellWithTwoNeighboursLives()
        {
            int neighbours = 2;
            Assert.IsTrue(LifeRules.CellSurvives(neighbours, true));
        }
    }
}
