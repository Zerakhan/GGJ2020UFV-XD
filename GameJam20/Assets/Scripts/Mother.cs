using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mother : MonoBehaviour
{
    public Transform [] points;
    private int destPoint = 0;
    void Update()
    {
        if (Vector2.Distance(this.transform.position, points[destPoint].transform.position) < 0.5f)
            GotoNextPoint();
    }
    void GotoNextPoint()
    {
        if (points.Length == 0) return;
        this.transform.position = Vector2.Lerp(this.transform.position, points[destPoint].position, 2);
        destPoint = (destPoint + 1) % points.Length;
    }
}
