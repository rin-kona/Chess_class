using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_10 : MonoBehaviour
{
    public int x = 5;
    public int y = 5;

    void Start()
    {
        Debug.Log(ADD_FUNCTION(x , y) * 2);
    }

    public int ADD_FUNCTION(int firstNum ,int secondNum)
    {
        var result = firstNum - secondNum;
        return result;
    }
}