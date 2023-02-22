using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timedelete : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if(Time.deltaTime==1f)
        Destroy(gameObject);
    }
}
