using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skills : MonoBehaviour
{
     public float skillplace;
    public GameObject skill;
    public GameObject timeskill;
     
    void Start()
    {
 
    }

  
    void Update()
    {
        if (transform.position.x == skillplace)
        {
            Destroy(skill);
            timeskill.SetActive(true);

        }
    }
    

}
