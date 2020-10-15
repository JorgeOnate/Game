using System;
using System.Linq;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Line : MonoBehaviour
{

    [SerializeField]public GameObject line;
    public GameObject currentLine;

    public LineRenderer lineRenderer;
    public EdgeCollider2D edgeCollider;
    public List<Vector2> fingerPositions;

    

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CreateLine();
        }

        if (Input.GetMouseButton(0))
        {
            Vector2 tempFingerPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Vector2.Distance(tempFingerPos,fingerPositions[fingerPositions.Count -1]) > .1f)
            {
                Updateline(tempFingerPos);
            }
        }
    }

    private void CreateLine()
    {
        currentLine = Instantiate(line, Vector3.zero, Quaternion.identity);
        lineRenderer = currentLine.GetComponent<LineRenderer>();
        edgeCollider = currentLine.GetComponent<EdgeCollider2D>();
        fingerPositions.Clear();
        fingerPositions.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        fingerPositions.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        lineRenderer.SetPosition(0,fingerPositions[0]);
        lineRenderer.SetPosition(1,fingerPositions[0]);
        edgeCollider.points = fingerPositions.ToArray();
    }

    void Updateline(Vector2 newFingerPos)
    {
        fingerPositions.Add(newFingerPos);
        lineRenderer.positionCount++;
        lineRenderer.SetPosition(lineRenderer.positionCount - 1, newFingerPos);
        edgeCollider.points = fingerPositions.ToArray();
    }
}