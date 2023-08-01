using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_04_b : MonoBehaviour
{
    AudioSource source;
    public AudioClip[] clips;

    void Start(){
        if(source == null) source = gameObject.AddComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) && clips.Length > 0)
        {
            PlaySound(0);
        }
        else if(Input.GetKeyDown(KeyCode.A) && clips.Length > 1)
        {
            PlaySound(1);
        }
        else if(Input.GetKeyDown(KeyCode.S) && clips.Length > 2)
        {
            PlaySound(2);
        }
    }

    void PlaySound(int index)
    {
        if(index >= 0 && index < clips.Length){
            source.clip = clips[index];
            source.Play();
        }
    }
}
