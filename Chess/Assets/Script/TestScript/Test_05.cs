using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Test_05 : MonoBehaviour
{

  protected string answer;
  
    private void Start()
    {
      switch(answer)
      {
        case "はい":
          Debug.Log("「はい」を選んでくれたんですね");
          break;

        case "いいえ":
          Debug.Log("「いいえ」を選んでくれたんですね");
          break;

        default:
          Debug.Log("「はい」か「いいえ」でこたえろよ");
          break;

      }
    }
}
