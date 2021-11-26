using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameData : MonoBehaviour  //abstract classes cannot be instantiated as a c# object 
{
    public static int score = 0;

    public static float GetXMin()  //statics make an attribute/method class level.. no need of objects
    {
        float XMin = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
      //  Debug.Log("XMin: " + XMin.ToString());
        return XMin;
    }

    public static float GetXMax()
    {
        float XMax = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
      //  Debug.Log("XMax: " + XMax.ToString());
        return XMax;
    }


    public static float GetYMin()
    {
        float YMin = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
      //  Debug.Log("YMin: " + YMin.ToString());
        return YMin;
    }

    public static float GetYMax()
    {
        float YMax = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;
        //Debug.Log("YMax: " + YMax.ToString());
        return YMax;
    }


    public static Vector3 GetMousePos()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0f, 0f, 10f);
      //  Debug.Log(mousePos);
        return mousePos;
    }



}
