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
        public void DeadCellStaysDeadWithNoNeighbors(int numNeighbours)
        {
            Assert.IsFalse(LifeRules.CellSurvives(numNeighbours));
        }

        [Test]
        public void voidLiveCellDiesMoreThan3Neighbors()
        {
            int neighbours = 4;
            Assert.IsFalse(LifeRules.CellSurvives(neighbours));
        }

        [Test]
        public void CellAlwaysAliveWith3Neighbours()
        {
            int neighbours = 3;
            Assert.IsTrue(LifeRules.CellSurvives(neighbours));
        }
    }
}
