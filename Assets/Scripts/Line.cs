using System;
using System.Linq;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Line : MonoBehaviour
{

    public Camera MainCamera;
    public GameObject line;
    public EdgeCollider2D edgeCol;

    LineRenderer lineRenderer;
    Vector2 lastPos;

    private void Update()
    {
        Draw();
    }

    void Draw()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            createLine();
        }

        if (Input.GetKey(KeyCode.Mouse0))
        {
            Vector2 mousePos = MainCamera.ScreenToWorldPoint(Input.mousePosition);
            if (mousePos != lastPos)
            {
                AddAPoint(mousePos);
                lastPos = mousePos;
            }
            
        }
        else
        {
            lineRenderer = null;
        }
    }

    void createLine()
    {
        GameObject lineInstance = Instantiate(line);
        lineRenderer = lineInstance.GetComponent<LineRenderer>();
        edgeCol = lineInstance.GetComponent<EdgeCollider2D>();
        
        Vector2 mousePos = MainCamera.ScreenToWorldPoint(Input.mousePosition);
        
        //edgeCol.points = lineRenderer.SetPosition(0, mousePos);
        
        lineRenderer.SetPosition(0,mousePos);
        lineRenderer.SetPosition(1,mousePos);
        
        
    }

    void AddAPoint(Vector2 pointPos)
    {
        lineRenderer.positionCount++;
        int positionIndex = lineRenderer.positionCount - 1;
        lineRenderer.SetPosition(positionIndex,pointPos);
    }

}