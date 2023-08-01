using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_02 : MonoBehaviour
{

    public int v = 500;
    public int w = 100;
    public int x = 30;
    public int y = 120;
    public int z = 250;

    // Start is called before the first frame update
    void Start()
    {
        int total = v + w + x + y + z;
        Debug.Log($"合計値は、{total}です");
    }
}
