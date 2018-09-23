using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshairs : MonoBehaviour {

    //crosshairs will light up when hovered over enemy.
    public LayerMask targetMask;
    public SpriteRenderer dot;
    public Color dotHighlightColor;
    Color originalDotColor;

    void Start()
    {
        originalDotColor = dot.color;
        Cursor.visible = false;
    }

    void Update () {
        //crosshair rotate effect
        transform.Rotate(Vector3.forward * -40 * Time.deltaTime);
	}
    public void Detect(Ray ray)
    {
        if (Physics.Raycast(ray, 100, targetMask))
        {
            dot.color = dotHighlightColor;
        }
        else
        {
            dot.color = originalDotColor;
        }
    }
}
