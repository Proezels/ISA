using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{
    Renderer render;
    private Color orig;

    void Start()
    {
        render = GetComponent<Renderer>();
        orig = render.material.GetColor("_color");
    }

    void OnMouseDown()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    void OnMouseOver()
    {
        render.material.SetColor("_color", Color.white);
    }

    void OnMouseExit()
    {
        render.material.SetColor("_color", orig);
    }

}
