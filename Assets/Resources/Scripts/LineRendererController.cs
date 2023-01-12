using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LineRendererController : MonoBehaviour
{
    
    LineRenderer lr;
    public Transform[] points;

    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
        SetUpLines(points);
    }

    

     void Update()
    {
        for (int i = 0; i < points.Length; i++)
        {
            lr.SetPosition(i, points[i].position);
        }
    }

    public void SetUpLines(Transform[] _points)
    {
        lr.positionCount = points.Length;
        this.points = _points;
    }
}
