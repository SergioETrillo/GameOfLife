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
    }
}
