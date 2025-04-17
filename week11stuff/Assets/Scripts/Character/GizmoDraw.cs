using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoDraw : MonoBehaviour
{
    public GameObject wall;
    public GameObject arttargetaoe;
    public GameObject rollPath;
    public GameObject artilery;
    public float wallR;
    public float aoeR;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OnDrawGizmos();
             }

    private void OnDrawGizmos()
    {
        Vector3 wallPos = wall.transform.position;
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(wallPos, wallR);//gizmo for the aoe of the player/wall


        Vector3 artAOE = arttargetaoe.transform.position;//gizmo for the detect radius of the artilery
        Gizmos.color = Color.red;
        Gizmos.DrawSphere (artAOE, aoeR);

        Vector3 shellPos = rollPath.transform.position;
        Vector3 artSpawn = artilery.transform.position;
        Gizmos.color = Color.green;
        Gizmos.DrawLine (artSpawn, shellPos);

    }
}
