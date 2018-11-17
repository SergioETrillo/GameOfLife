using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GameOfLife.Test
{
    public class Test
    {
        [Test]
        public void DeadCellStaysDealWithNoNeighbors()
        {
            int numNeighbours = 0;
            Assert.IsFalse(LifeRules.CellSurvives(numNeighbours));
        }
    }
}
