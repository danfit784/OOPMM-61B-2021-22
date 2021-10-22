using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawner : MonoBehaviour
{
    GameObject circlePrefab, squarePrefab;
    void Start()
    {
        circlePrefab = Resources.Load("Circle") as GameObject;
        squarePrefab = Resources.Load("Square") as GameObject;
        GameObject mycircle = Instantiate(circlePrefab, new Vector3(0f, -2f, 0), Quaternion.identity);
        GameObject mysquare = Instantiate(squarePrefab, new Vector3(0f, 2f, 0), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
