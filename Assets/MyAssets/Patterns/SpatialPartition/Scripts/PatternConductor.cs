using System.Collections;
using System.Collections.Generic;
using MyAssets.Patterns.SpatialPartition.Scripts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PatternConductor : MonoBehaviour
{
    [SerializeField] private GameObject[] units;

    [SerializeField] private Text text;
    
    public void AddUnitsToCells()
    {
        foreach (var unit in units)
        {
            var cell = MyGrid.FindCellForUnit(unit.transform.position);
            cell.AddUnit(unit);
            var textComp = unit.GetComponentInChildren<TextMeshPro>();
            if (textComp != null)
            {
                textComp.text = unit.name;
            }
        }
    }

    public void ShowCellsAndUnits()
    {
        var cells = MyGrid.GetCells();
        var showInfo = string.Empty;
        foreach (var cell in cells)
        {
            var cellInfo = cell.ToString();
            showInfo += "\n" + cellInfo;
        }
        text.text = showInfo;
    }
}
