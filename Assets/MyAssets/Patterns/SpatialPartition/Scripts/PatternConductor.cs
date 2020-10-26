using System.Collections;
using System.Collections.Generic;
using MyAssets.Patterns.SpatialPartition.Scripts;
using UnityEngine;
using UnityEngine.UI;

public class PatternConductor : MonoBehaviour
{
    [SerializeField] private GameObject[] units;

    [SerializeField] private Text text;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddUnitsToCells()
    {
        var unitss = FindObjectsOfType<Unit>();
        foreach (var unit in units)
        {
            var cell = MyGrid.FindCellForUnit(unit.transform.position);
            
            cell.AddUnit(unit);
        }
    }

    public void ShowCellsAndUnits()
    {
        var cells = MyGrid.GetCells();
        
        foreach (var cell in cells)
        {
            var cellInfo = cell.ToString();
            text.text = cellInfo + "; ";
        }
    }
}
