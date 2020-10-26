using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace MyAssets.Patterns.SpatialPartition.Scripts
{
    public class MyGrid
    {
        private int cols;
        private int rows;
        private static int cellSize = 3;
        private static List<Cell> cells = new List<Cell>();

        public static Cell FindCellForUnit(Vector3 unitPosition)
        {
            var x = Mathf.FloorToInt(unitPosition.x / cellSize);
            var y = Mathf.FloorToInt(unitPosition.y / cellSize);
            
            var cell = cells.FirstOrDefault(c =>
                (c.X == x) && (c.Y == y));
            
            if (cell == null)
            {
                cell = new Cell(x, y);
                cells.Add(cell);
            }
            
            return cell;
        }

        public static List<Cell> GetCells()
        {
            return cells;
        }
    }
}