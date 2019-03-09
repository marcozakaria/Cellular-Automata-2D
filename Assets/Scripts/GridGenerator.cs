using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    public int gridSize = 25;
    public GameObject emptyCell;
    private GameObject[,] gameGrid;

    private void Awake()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        gameGrid = new GameObject[gridSize, gridSize];

        for (int x = 0; x < gridSize; x++)
        {
            for (int y = 0; y < gridSize; y++)
            {
                gameGrid[x, y] = Instantiate(emptyCell, new Vector3(x - gridSize / 2, y - gridSize / 2, 0), Quaternion.identity, this.transform);
            }
        }
    }
}
