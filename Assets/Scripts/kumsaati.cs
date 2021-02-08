using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skillkullaným : MonoBehaviour
{
    public void kumsaati()
    {
        Time.timeScale = 0.1f;
        Time.fixedDeltaTime = Time.deltaTime*0.01f;
    }


}
