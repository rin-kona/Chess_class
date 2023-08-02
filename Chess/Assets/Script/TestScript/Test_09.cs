using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teat_09 : MonoBehaviour
{
// 以下の値は編集可能です
    public int num1 = 100;
    public int num2 = 10;
    public int num3 = 20;

    void Start()
    {
        Sub(num1 , num2 , num3);   //subで引き算ができます
    }


    void Sub(int firstNum , int secondNum , int thirdNum)
    {
        int totalNum = firstNum - secondNum - thirdNum ;
        
        if (totalNum < 50 )  //追加したところ
        {
            Debug.Log("false");
        }
        else
        {
            Debug.Log("true");
        }

    }
}
