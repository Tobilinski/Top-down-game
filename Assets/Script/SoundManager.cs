using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource _soundSource;
    private AudioClip _Paintballsound;
   
    // Start is called before the first frame update
    void Start()
    {
        _soundSource = GetComponent<AudioSource>();
        _Paintballsound = Resources.Load("PaintballMarker") as AudioClip;
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.G))
         {

             PlayShot();
         }
         if (Input.GetKeyDown(KeyCode.RightControl))
         {
             PlayShot();
         }
        
        
    }
    void PlayShot()
    {
        _soundSource.PlayOneShot(_Paintballsound);
    }
    
}
