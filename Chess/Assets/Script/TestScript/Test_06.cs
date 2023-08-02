using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_06 : MonoBehaviour
{
    
    int total;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 1; i <= 9; i++)
        {
            for(int j = 1; j <=9; j++)
            {
                total = i * j;
                Debug.Log(total);
            }
        }
        
    }

}
