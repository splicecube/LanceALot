using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorClass : MonoBehaviour
{

    Sprite currentFloor;
    BoxCollider2D bounds;

    // Start is called before the first frame update
    void Start()
    {
        bounds = gameObject.GetComponentInChildren<BoxCollider2D>();
        bounds.size.Set(bounds.size.x - 10,bounds.size.y - 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
