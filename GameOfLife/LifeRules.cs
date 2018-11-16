using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public enum CellState
    {
        Alive,
        Dead
    }
    public class LifeRules
    {

        public static CellState GetNewState(CellState currenCellState, int liveNeighbours)
        {
            return CellState.Alive;
        }
    }
}
