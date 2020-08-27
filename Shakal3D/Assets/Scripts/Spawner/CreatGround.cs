using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatGround : MonoBehaviour
{
    [SerializeField] private GameObject cell;
    [SerializeField] private int x = 5;
    [SerializeField] private int z = 5;
    [SerializeField] private int y = 1;
    [SerializeField] private int distance = 1;
    void Start()
    {
        for (int PlaceForX = 0; PlaceForX < x; PlaceForX++)
            for (int PlaceForY = 0; PlaceForY < y; PlaceForY++)
                for (int PlaceForZ = 0; PlaceForZ < z; PlaceForZ++)
                    Instantiate(cell, new Vector3(PlaceForX * distance, PlaceForY * distance, PlaceForZ * distance), Quaternion.Euler(90,0,0));
    }

}
