using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_08 : MonoBehaviour
{
    void Start()
    {
        int[] num = new int[]
        {
            1,2,3,4,5,6
        };

    foreach (var item in num)
        {
            Debug.Log(item);
        }    
    }
}
