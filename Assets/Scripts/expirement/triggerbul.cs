using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerbul : MonoBehaviour
{
   

    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemies") {
            healEnemy.AdjustCurrentValue(-1);
        }
            Destroy(gameObject);        
    }
    
}
