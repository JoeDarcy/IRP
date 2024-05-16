using System.Collections.Generic;
using UnityEngine;

public class GraphLineAnimatorDOTween : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public int numberOfPoints;
    public float animationDuration;

    private List<Vector3> points = new List<Vector3>();

    void Start()
    {
        lineRenderer.positionCount = numberOfPoints;

        for (int i = 0; i < numberOfPoints - 1; i++)
        {
            points[i] = lineRenderer.GetPosition(i);
        }

        foreach(Vector3 point in points)
        {
            Debug.Log(point);
        }

        AnimateGraphLine();
    }

    void AnimateGraphLine()
    {
        
    }
}
