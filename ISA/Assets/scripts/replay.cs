using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class replay : MonoBehaviour
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
       SceneManager.LoadScene(1);

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
