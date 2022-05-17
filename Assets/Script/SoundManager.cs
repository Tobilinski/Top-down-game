using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource _soundSource;
   
    // Start is called before the first frame update
    void Start()
    {
        _soundSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            _soundSource.Play();
        }
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            _soundSource.Play();
        }
    }
    
}
