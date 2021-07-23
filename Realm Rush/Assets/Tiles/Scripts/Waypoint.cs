using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] bool isPlaceable;
    [SerializeField] Tower towerPreFab;
    public bool IsPlaceable { get { return isPlaceable; } }

    void OnMouseDown()
    {
        if(isPlaceable)
        {
            bool isPlaced = towerPreFab.CreateTower(towerPreFab, transform.position);
            isPlaceable = !isPlaced;
        }
        
    }

}
