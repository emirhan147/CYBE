using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubespawn : MonoBehaviour
{

    public int speed;
    public float startTime;
    public float repeatTime;
    float mainTime;
    public GameObject spawnPoint;
    public bool startspawn;
    public GameObject Cube;
    
    void Start()
    {
        mainTime = repeatTime;
    }

    
    void Update()
    {
        GetComponent<Animator>().SetFloat("fire", mainTime);
        if(startTime>0)
        {
            startTime -= Time.deltaTime;
        }
        if(startTime <= 0)
        {
            startspawn = true;
        }

        if(startspawn)
        {
            mainTime -= Time.deltaTime;
            if(mainTime <= 0)
            {
                GameObject spawnedCube = Instantiate(Cube, spawnPoint.transform.position, Quaternion.identity);                
                spawnedCube.GetComponent<cubeScript>().speed = speed;
                mainTime = repeatTime;
            }
        }
    }

}
