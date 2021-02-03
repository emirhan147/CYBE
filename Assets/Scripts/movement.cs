using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    public bool go;
    public float sayac;
    public bool başla;
    void Start()
    {
        go = true;
        sayac = 0;
    }

    
    void Update()
    {
        if(sayac>0)
        {
            sayac -= Time.deltaTime;
        }
        if (sayac <= 0)
        {
            başla = true;
        }
        Touch touch = Input.GetTouch(0);
        if(touch.position.x <= Screen.width / 2 && go && başla)
        {
            transform.position = new Vector3(transform.position.x - 3, transform.position.y, transform.position.z);
            go = false;
        }

        if (touch.position.x > Screen.width / 2 && go && başla)
        {
            transform.position = new Vector3(transform.position.x + 3, transform.position.y, transform.position.z);
            go = false;
        }

        if(touch.phase == TouchPhase.Ended)
        {
            go = true;
        }
    }


    void gotrue()
    {
        go = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "düşman")
        {
            string scenename = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(scenename);
        }
    }
}
