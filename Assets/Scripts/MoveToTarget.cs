using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform nextPos; //miami
    public Transform curPos; //bogota
    public float speed = 5.0f; //speed
    public GameObject destroy; //virus one
    public Transform newPos; //mexicoCity
    public Transform newPos1;//mexico city
    public Rigidbody newVirus; //new virus
    Vector3 spawnPosition;
    Vector3 spawnPosition1;
    private bool stopSpawn = false; //only spawn 1 virus
   
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           MoveToTarget();
 
           DestroyObject();
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            NewVirus();
        }

    }
    private void MoveToTarget()
    {
        curPos.position = nextPos.position;
    }
    private void DestroyObject()
    {
        Destroy(destroy);
        Debug.Log("Virus Eliminated");
    }
    private void NewVirus()
    {
        spawnPosition = newPos.position;
        spawnPosition1 = newPos1.position;
        Instantiate(newVirus,spawnPosition,Quaternion.identity);
        Instantiate(newVirus,spawnPosition1,Quaternion.identity);
        stopSpawn = true;
    }
}
