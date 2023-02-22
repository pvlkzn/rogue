using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackVseh : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            health.AdjustCurrentValue(-1);
        }
    }
}
