using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_07 : MonoBehaviour
{
    private void Start()
    {
    List<string> names = new List<string>();
    
        names.Add("きたがいとしょうまさん");
        names.Add("さかいふくもとさん");
        names.Add("はれおくん");

            names.Remove("はれおくん");
            names.RemoveAt(1);

        for (var i = 0; i < names.Count; i++) 
        {
        Debug.Log($"配列番号{i}中身 {names[i]}");
        }
    }
}