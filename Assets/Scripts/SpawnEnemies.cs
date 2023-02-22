using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject[] obj;
    private GameObject priv_obj;
    private GameObject pol;
    public Vector3 vector;
    public Vector3 vector1;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            transform.position = transform.TransformPoint(vector);
            int randomEnim = Random.Range(3, 5);
            for (int i = 0; i < randomEnim; i++)
            {
                int random = Random.Range(0, 2); //Debug.Log(random);
                priv_obj = Instantiate(obj[random], obj[random].transform.position, Quaternion.identity) as GameObject;
                int randomx = Random.Range(-4, 4);
                int randomz = Random.Range(-4, 4);

                vector1 = new Vector3(transform.position.x + randomx, 1.5f, transform.position.z + randomz);
                priv_obj.transform.position = vector1;
            }
        }
    }
}



