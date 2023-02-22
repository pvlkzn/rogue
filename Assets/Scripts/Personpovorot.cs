using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
public class Personpovorot : MonoBehaviour
{
    private Vector3 mousePosition;
    public float moveSpeed = 2;
    //public Camera cam;

    //void Start() {

    //    cam = Camera.main;
    //}

    void Update()
    {
        RaycastHit hit;
        Ray ray = UnityEngine.Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            RayFromPlayer(hit.point);

            //rotate player
            Vector3 direction = (hit.point - transform.position).normalized;
            Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
            transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation,  moveSpeed);
            //Debug.Log("point for camera: " + hit.point);
            //Debug.DrawRay(ray.origin, hit.point, Color.green);
            transform.Rotate(transform.rotation.x, transform.rotation.y+90, transform.rotation.z); 
        }
    }
    void RayFromPlayer(Vector3 position)
    {
        //Debug.Log("point for player: " + position);
        //Debug.DrawRay(transform.position, position, Color.magenta);
    }
}


