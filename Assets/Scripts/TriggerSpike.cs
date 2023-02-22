using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpike : MonoBehaviour
{
    private float time;
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player" || other.tag =="enemies")
        {
            health.AdjustCurrentValue(-1);//Debug.Log("AHHAHAH");
            //enemies.adheal(-1);
        }
    }
    public void OnTriggerStay(Collider other)
    {
        time = time + Time.deltaTime;
        if (other.tag == "Player" && time%2==0)
        {
            health.AdjustCurrentValue(-1);
        }


    }
   
}
