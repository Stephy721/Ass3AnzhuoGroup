using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmarineManager : MonoBehaviour
{
    public GameObject submarine;
    public float value;
    public Vector3 sizeChange;

    public void MoveLeft()
    {
        value = value - 0.2f;
        submarine.transform.position = new Vector3(value, 0, 0);
    }
    public void RotateRight()
    {
        submarine.transform.Rotate(2f, 1f, 2f);
    }
    public void Grow()
    {
        submarine.transform.localScale = submarine.transform.localScale + sizeChange;
    }
    public void ResetSubmarine()
    {
        submarine.transform.position = new Vector3(0, 0, 0);
        submarine.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        submarine.transform.localScale = new Vector3(1, 1, 1);
    }
}
