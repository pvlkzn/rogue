using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class healEnemy : MonoBehaviour
{
    public float maxValue = 5;   
    private static float healEn;
    void Start()
    {
        healEn = maxValue;             
    }
    public static float healEnValue
    {
        get { return healEn; }
    }
    void Update()
    {
        if (healEn < 0) healEn = 0;
        if (healEn > maxValue) healEn = maxValue;
        if (healEn == 0) { Destroy(gameObject); }
    }
    public static void AdjustCurrentValue(float adjust)
    {
        healEn += adjust;
    }
}