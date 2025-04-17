using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public float speed = 5f;
    public GameObject shell;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = shell.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector3.left * speed  * Time.deltaTime, ForceMode.Impulse);
    }
}
