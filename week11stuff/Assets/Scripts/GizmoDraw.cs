using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoDraw : MonoBehaviour
{
    public GameObject wall;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 wallPos = wall.transform.position;
        transform.position = wallPos;
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(wallPos, 2);
    }
}
