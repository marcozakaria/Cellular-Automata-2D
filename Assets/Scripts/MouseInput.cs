using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    private Camera mainCamera;
    public GameObject antPrefap;

    private void Start()
    {
        mainCamera = GetComponent<Camera>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {           
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D raycastHit2D = Physics2D.Raycast(ray.origin, ray.direction, 100);

            if (raycastHit2D.transform != null)
            {
                PlaceAntSimulator(Vector2Int.CeilToInt(raycastHit2D.point));
            }
        }
    }

    void PlaceAntSimulator(Vector2 position)
    {
        GameObject antObject = Instantiate(antPrefap, position, Quaternion.identity);

    }
}
