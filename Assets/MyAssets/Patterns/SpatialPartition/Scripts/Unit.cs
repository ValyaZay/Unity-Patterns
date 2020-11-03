using System;
using UnityEngine;

namespace MyAssets.Patterns.SpatialPartition.Scripts
{
    public class Unit : MonoBehaviour
    {
        private float currentUnitXPos;
        private float currentUnitYPos;
        
        public override string ToString()
        {
            return transform.name;
        }

        public void MoveUnit(float newXpos, float newYpos)
        {
            var position = transform.position;
            currentUnitXPos = position.x;
            currentUnitYPos = position.y;
           
            var currentCell = MyGrid.FindCellForUnit(new Vector3(currentUnitXPos, currentUnitYPos, 0));
            var newCell = MyGrid.FindCellForUnit(new Vector3(newXpos, newYpos, 0));

            currentUnitXPos = newXpos;
            currentUnitYPos = newYpos;

            if ((currentCell.X != newCell.X)
                && (currentCell.Y != newCell.Y))
            {
                currentCell.RemoveUnit(gameObject);
                newCell.AddUnit(gameObject);
            }
        }
    }
}