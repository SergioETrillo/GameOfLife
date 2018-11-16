using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GameOfLife.Test
{
    [TestFixture]
    class LifeRulesTests
    {
        [Test]
        public void AnyLifeCellWithFewerThanTwoLiveNeighboursDies()
        {
            //Arrange
            CellState currenCellState = CellState.Alive;
            int liveNeighbours = 1;

            //Act
            CellState resultCellState = LifeRules.GetNewState(currenCellState, liveNeighbours);

            //Assert
            Assert.AreEqual(CellState.Dead, resultCellState);
        }
    }
}
