using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardpers : MonoBehaviour
{

    public float speed = 7f;
    // Start is called before the first frame update
    void Update()
    {
        GetInput();
    }

    // Update is called once per frame
    void GetInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += -transform.right * speed * Time.deltaTime;            
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.forward * speed * Time.deltaTime;            
        }
       
       

}
}

