using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour {

    private Vector3 offset;

    void OnMouseDown()
    {

        offset = gameObject.transform.position -
                 Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
    }
    
    void OnMouseDrag()
    {
        Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 96.0f);
        transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset; 
        /*     if (transform.position.x < 6.4 && transform.position.x > -6.4 && transform.position.y < 9.8 && transform.position.y > 6.5){
            Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 96.0f);
        transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset; 
        }

        if (transform.position.x > 6.4)
        {
            Vector3 newPosition = new Vector3(6.35f, Input.mousePosition.y, 96.0f);
            transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset; 
        }
        
        if (transform.position.x < -6.4)
        {
            Vector3 newPosition = new Vector3(-5f, Input.mousePosition.y, 96.0f);
            transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset; 
        }
        
        if (transform.position.y > 9.8)
        {
            Vector3 newPosition = new Vector3(Input.mousePosition.x, 9.75f, 96.0f);
            transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset; 
        }
        
        if (transform.position.y < 6.5)
        {
            Vector3 newPosition = new Vector3(Input.mousePosition.x, 6.45f, 96.0f);
            transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset; 
        }*/
    }
}
