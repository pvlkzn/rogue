using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class triggerdoor : MonoBehaviour
{
    public GameObject DoorU;
    public GameObject DoorR;
    public GameObject DoorD;
    public GameObject DoorL;


    public void OnTriggerEnter(Collider other) 
    {
        
        if (other.tag == "Player")
        {

            if (!DoorD.activeInHierarchy) { DoorD.SetActive(true);  }
            if (!DoorU.activeInHierarchy) { DoorU.SetActive(true);  }
            if (!DoorL.activeInHierarchy) { DoorL.SetActive(true);  }
            if (!DoorR.activeInHierarchy) { DoorR.SetActive(true);  }
            
            Destroy(this.gameObject);


        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            
        }


    }
    public void OnTriggerExit(Collider other)
    {
        
        
        if (other.tag == "Player")
        {
            
        }

    }
}
