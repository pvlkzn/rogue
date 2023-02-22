using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigopen : MonoBehaviour
{

    public GameObject DoorU;
    public GameObject DoorR;
    public GameObject DoorD;
    public GameObject DoorL;


    public void OnTriggerEnter(Collider other)
    {

        if (other.tag != "Enemies")
        {

        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Enemies")
        {

        }


    }
    public void OnTriggerExit(Collider other)
    {

        if (other.tag == "Enemies")
        {
           
            if (!DoorD.activeInHierarchy) { DoorD.SetActive(false); }
            if (!DoorU.activeInHierarchy) { DoorU.SetActive(false); }
            if (!DoorL.activeInHierarchy) { DoorL.SetActive(false); }
            if (!DoorR.activeInHierarchy) { DoorR.SetActive(false); }
        }

    }
}


