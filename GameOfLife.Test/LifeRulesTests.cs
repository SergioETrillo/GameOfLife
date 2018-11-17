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
        [Test]
        public void DeadCellStaysDeadWithNoNeighbors()
        {
            int numNeighbours = 0;
            Assert.IsFalse(LifeRules.CellSurvives(numNeighbours));
        }

        [Test]
        public void DeadCellStaysDeadWith2Neighbors()
        {
            int numNeighbours = 2;
            Assert.IsFalse(LifeRules.CellSurvives(numNeighbours));
        }

        [Test]
        public void DeadCellStaysDeadWith1Neighbors()
        {
            int numNeighbours = 1;
            Assert.IsFalse(LifeRules.CellSurvives(numNeighbours));
        }

    }
}
