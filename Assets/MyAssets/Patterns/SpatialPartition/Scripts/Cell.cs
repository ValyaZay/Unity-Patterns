using System;
using System.Collections.Generic;
using UnityEngine;

namespace MyAssets.Patterns.SpatialPartition.Scripts
{
    public class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
        private List<GameObject> units;
        
        public Cell(int x, int y)
        {
            X = x;
            Y = y;
            units = new List<GameObject>();
        }

        public void AddUnit(GameObject unit)
        {
            units.Add(unit);
        }

        public void RemoveUnit(GameObject unit)
        {
            units.Remove(unit);
        }

        public override string ToString()
        {
            var name = "Cell " + X + ", " + Y;
            var myUnits = "My units are: ";
            foreach (var unit in units)
            {
                var unitName = "/n " + unit.ToString();
                myUnits = myUnits + unitName + "; ";
            }

            return name + myUnits;
        }
    }
}